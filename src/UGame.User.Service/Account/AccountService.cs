using EasyNetQ;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AiUo;
using AiUo.AspNet;
using AiUo.Caching;
using AiUo.Collections;
using AiUo.Configuration;
using AiUo.Extensions.AutoMapper;
using AiUo.Extensions.RabbitMQ;
using AiUo.Net;
using AiUo.OAuth;
using AiUo.Security;
using AiUo.ShortId;
using AiUo.Text;
using UGame.User.Service.Common;
using UGame.User.Service.InitApp;
using UGame.User.Common;
using UGame.User.Common.Caching; 
using UGame.User.Repository;
using Xxyy.Common;
using UGame.User.MQ.Xxyy;

namespace UGame.User.Service.Account
{
    /// <summary>
    /// 新用户注册服务
    /// </summary>
    public class AccountService
    {
        private static LimitedCharFilter _charFilter;
        private VerifyCodeService _vcodeSvc = new();
        private AppSectionBase _section;
        static AccountService()
        {
            // 6-30长度
            // 数字字母和.
            // 不能.开头
            // 不能连续.
            // 可以 邮件格式
            _charFilter = new LimitedCharFilter(true, StringUtil.NumberLetterChars);
            _charFilter.AddChar('.');
        }
        private static bool IsValidUsername(string username)
        {
            return (_charFilter.IsValid(username) && !username.StartsWith('.') && username.IndexOf("..") < 0)
                || IsEmail(username);
        }

        
        public static bool IsEmail(string email) // "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
        {
            if (string.IsNullOrEmpty(email))
                return false;
            var ret = Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return ret;
        }

        public AccountService()
        {
            _section = ConfigUtil.GetSection<AppSectionBase>();
        }
        /// <summary>
        /// 三方系统注册登录
        /// </summary>
        /// <param name="registerAuthIpo"></param>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public async Task<LoginDto> OAuthRegisterLogin(OAuthLoginIpo oatAuthLoginIpo, OAuthUserDto userInfo)
        {
            //根据三方信息获取本系统用户id
            string userId = await LoginCacheUtil.GetUserIdByOAuth(oatAuthLoginIpo.OperatorId, (int)oatAuthLoginIpo.OAuthUserIpo.OAuthProvider, userInfo?.OAuthId);
            //判断系统userid是否已经在系统中存在
            if (!string.IsNullOrEmpty(userId))
            {
                //登录
                return await Relogin(new ReloginIpo() { AppId = oatAuthLoginIpo.AppId, OperatorId = oatAuthLoginIpo.OperatorId, UserId = userId });
            }
            else
            {
                //注册
                RegisterIpo registerIpo = oatAuthLoginIpo.Map<RegisterIpo>();
                registerIpo.OAuthID = userInfo.OAuthId;
                registerIpo.Username = userInfo.UserName;
                registerIpo.Email = userInfo.Email;
                registerIpo.Nickname = userInfo.NickName;
                registerIpo.OAuthType = (int)oatAuthLoginIpo.OAuthUserIpo.OAuthProvider;
                //registerIpo.Password = Guid.NewGuid().ToString().Replace("-", "");
                //registerIpo.RepeatPassword = registerIpo.Password;
                return await Register(registerIpo);
            }
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<RegisterDto> Register(RegisterIpo ipo)
        {
            // 验证
            var oper = DbCacheUtil.GetOperator(ipo.OperatorId);
            if (!oper.AllowVisitor && ipo.LoginMode == LoginMode.Visitor)
                throw new Exception($"平台不允许游客注册");
            var app = DbCacheUtil.GetApp(ipo.AppId);
            var countryEo = DbCacheUtil.GetCountry(oper.CountryID);
            if (!string.IsNullOrEmpty(ipo.Mobile) && !ipo.Mobile.StartsWith(countryEo.CallingCode))
                throw new Exception($"手机号码错误。mobile:{ipo.Mobile} countryId:{countryEo.CountryID} callingCode:{countryEo.CallingCode}");
            if (!string.IsNullOrEmpty(ipo.Username))
            {
                if (ipo.Username.Length < 6 || ipo.Username.Length > 30)
                    throw new CustomException(XxyyCodes.UsernameInvalid, "username长度6-30");
                if (!IsValidUsername(ipo.Username))
                    throw new CustomException(XxyyCodes.UsernameInvalid, "username仅允许字母，数字和.，且.不能开头和连续");
            }
            if (!string.IsNullOrEmpty(ipo.Email) && !IsEmail(ipo.Email))
                throw new Exception("email格式不正确");
            if (!string.IsNullOrEmpty(ipo.FromId) && (ipo.FromMode == 1 || ipo.FromMode == 3))
            {
                var puser = await DbSink.BuildUserMo(ipo.FromId).GetByPKAsync(ipo.FromId);
                if (puser == null)
                {
                    //throw new CustomException(XxyyCodes.RS_PUSER_NOT_EXISTS, $"推广用户不存在:{ipo.FromId}");
                    ipo.FromMode = 0;
                    ipo.FromId = ipo.OperatorId;
                }
            }

            RegLoginType regType = RegLoginType.Unknow;
            ipo.Nickname = string.IsNullOrEmpty(ipo.Nickname) ? $"G-{ObjectId.NewId()}" : ipo.Nickname;

            S_userEO user;
            var currUtcNow = DateTime.UtcNow;
            var lastLoginTime = currUtcNow;
            var userIp = AspNetUtil.GetRemoteIpString();
            if (string.IsNullOrEmpty(ipo.UserId))
            {
                // 1-新游客 3-直接注册
                regType = ipo.LoginMode == LoginMode.Visitor
                    ? RegLoginType.NewVisitor : RegLoginType.DirectReg;
                user = new S_userEO()
                {
                    UserID = ObjectId.NewId(),
                    UserMode = ipo.LoginMode == LoginMode.Visitor ? (int)UserMode.Visitor : (int)UserMode.Register,
                    Nickname = ipo.Nickname,
                    FromMode = ipo.FromMode,
                    FromId = ipo.FromMode == 0 ? ipo.OperatorId : ipo.FromId,
                    OperatorID = ipo.OperatorId,
                    OperatorUserId = null, // 
                    CountryID = oper.CountryID,
                    CurrencyID = oper.CurrencyID,
                    UserKind = (int)ipo.UserKind,
                    Status = (int)UserStatus.Normal, //
                    Mobile = ipo.Mobile,
                    Email = ipo.Email,
                    Username = ipo.Username,
                    RecDate = currUtcNow,
                    IMEI = ipo.IMEI,
                    GAID = ipo.GAID,
                    UserIp = userIp,
                    ClientUrl = ipo.ClientUrl,
                    OAuthID = "",
                    OAuthType = 0
                };
                if (!string.IsNullOrEmpty(ipo.ClientUrl))
                {
                    user.DomainID = GetDomain(ipo.ClientUrl);
                }
            }
            else
            {
                regType = RegLoginType.VisitorReg; //2-游客注册

                user = await DbSink.BuildUserMo(ipo.UserId).GetByPKAsync(ipo.UserId);

                if (user == null)
                    throw new Exception($"游客变更为注册用户时用户已不存在。userId:{ipo.UserId}");
                if (user.UserMode != (int)UserMode.Visitor)
                    throw new CustomException(XxyyCodes.RS_USER_REGISTED, $"游客变更为注册用户时提供的UserId不是游客。userId:{ipo.UserId}");
                if (user.OperatorID != ipo.OperatorId)
                    throw new Exception($"游客变更为注册用户时OperatorId不同。ipo:{ipo.OperatorId} user:{user.OperatorID}");
                if (string.IsNullOrWhiteSpace(user.Mobile) && !string.IsNullOrWhiteSpace(ipo.Mobile))
                    user.Mobile = ipo.Mobile;
                if (string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(ipo.Email))
                    user.Email = ipo.Email;
                if (string.IsNullOrEmpty(user.Username) && !string.IsNullOrEmpty(ipo.Username))
                    user.Username = ipo.Username;

                user.UserMode = (int)UserMode.Register;
                user.RegistDate = currUtcNow;
                if (!string.IsNullOrEmpty(ipo.IMEI))
                    user.IMEI = ipo.IMEI;
                if (!string.IsNullOrEmpty(ipo.GAID))
                    user.GAID = ipo.GAID;
                lastLoginTime = user.LastLoginDate;
            }
            user.LastLoginDate = currUtcNow;
            // !!游客注册!!
            if (ipo.LoginMode == LoginMode.Visitor)
            {
                user.Bonus = 0;
                user.Gold = 0; // 游客可能赠送
                user.Coin = 0;
                user.Point = 0;
                user.Password = RandomString.Next(CharsScope.NumbersAndUpperLetters, 8);
            }
            else
            {
                if (ipo.LoginMode != LoginMode.OAuth)
                {
                    // 必须有Password
                    if (string.IsNullOrEmpty(ipo.Password))
                        throw new Exception("注册时密码不能空！");
                    if (string.IsNullOrEmpty(ipo.RepeatPassword))
                        throw new Exception("注册时二次密码不能空！");
                    if (ipo.Password != ipo.RepeatPassword)
                        throw new CustomException(XxyyCodes.PasswordDifferent, "注册时密码不一致");
                    user.PasswordSalt = SecurityUtil.GetPasswordSalt();
                    user.Password = SecurityUtil.EncryptPassword(ipo.Password, user.PasswordSalt);
                }

                user.RegistDate = currUtcNow;
                // 验证
                switch (ipo.LoginMode)
                {
                    case LoginMode.MobileAndPassword:
                        if (string.IsNullOrEmpty(ipo.Mobile))
                            throw new Exception("注册时登录手机号码不能为空");
                        if (!_vcodeSvc.VerifySecurityCode(ipo.SecurityCode, ipo.Mobile, ipo.VerifyCode))
                            throw new CustomException(XxyyCodes.SecurityCodeErr, $"注册时安全码异常");
                        if ((await LoginCacheUtil.GetUserIdByMobile(ipo.OperatorId, ipo.Mobile)) != null)
                            throw new CustomException(XxyyCodes.MobileExist, $"注册时登录Mobile已存在");
                        break;
                    case LoginMode.UsernameAndPassword:
                        if (string.IsNullOrEmpty(ipo.Username))
                            throw new Exception("注册时用户名不能为空");
                        if ((await LoginCacheUtil.GetUserIdByUsername(ipo.OperatorId, ipo.Username)) != null)
                            throw new CustomException(XxyyCodes.UsernameExist, $"注册时登录Username已存在");
                        break;
                    case LoginMode.EmailAndPassword:
                        if (string.IsNullOrEmpty(ipo.Email))
                            throw new Exception("注册时Email不能为空");
                        if ((await LoginCacheUtil.GetUserIdByEmail(ipo.OperatorId, ipo.Email)) != null)
                            throw new CustomException(XxyyCodes.EmailExist, $"注册时登录Email已存在");
                        break;
                    case LoginMode.OAuth:
                        if (string.IsNullOrEmpty(ipo.OAuthID))
                            throw new Exception("注册时OAuthID不能为空");
                        if ((await LoginCacheUtil.GetUserIdByOAuth(ipo.OperatorId, (int)ipo.OAuthType, ipo.OAuthID)) != null)
                            throw new CustomException(XxyyCodes.OAuthExist, $"该第三方已经绑定过其他用户");
                        break;
                    default:
                        throw new Exception($"Register注册时未知的方式：{ipo.LoginMode}");
                }
            }
            if (regType == RegLoginType.DirectReg || regType == RegLoginType.VisitorReg)
            {
                await SetPromoter(user);
            }

            user.OAuthID = ipo.OAuthID;
            user.OAuthType = string.IsNullOrEmpty(ipo.OAuthID) ? 0 : (int)ipo.OAuthType;
            if (!string.IsNullOrEmpty(ipo.OAuthID))
            {
                user.Nickname = ipo.Nickname;
            }

            // 注册完相即等同于登录完毕，直接返回LoginDto
            var ret = await BuildLoginDto(user, oper, app);

            // 保存
            if (string.IsNullOrEmpty(ipo.UserId))
            {
                await DbSink.BuildUserMo(user.UserID).AddAsync(user);
                await DbSink.BuildUserExMo(user.UserID).AddAsync(new S_user_exEO
                {
                    UserID = user.UserID,
                    UserKind = user.UserKind,
                    OperatorID = user.OperatorID,
                    CountryID = user.CountryID,
                    CurrencyID = user.CurrencyID,
                }, null, true);
            }
            else
            {

                await DbSink.BuildUserMo(user.UserID).PutAsync(user);
            }

            // 发送MQ
            if (regType == RegLoginType.NewVisitor || regType == RegLoginType.DirectReg)
            {
                await MQUtil.PublishAsync(new NewUserMsg
                {
                    RegLoginType = regType,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CountryId = user.CountryID,
                    CurrencyId = user.CurrencyID,
                    UserId = user.UserID,
                    Nickname = user.Nickname,
                    UserKind = user.UserKind,
                    FromMode = user.FromMode,
                    FromId = user.FromId,
                    IMEI = user.IMEI,
                    GAID = user.GAID,
                    UserIp = userIp,
                    RecDate = user.RecDate
                });
            }
            if (regType == RegLoginType.VisitorReg || regType == RegLoginType.DirectReg)
            {
                await MQUtil.PublishAsync(new UserRegisterMsg
                {
                    RegLoginType = regType,
                    AppId = ipo.AppId,
                    OperatorId = ipo.OperatorId,
                    CountryId = user.CountryID,
                    CurrencyId = user.CurrencyID,
                    RegisterMode = (int)ipo.LoginMode,
                    UserId = user.UserID,
                    Username = user.Username,
                    Email = user.Email,
                    Mobile = user.Mobile,
                    UserKind = user.UserKind,
                    Nickname = user.Nickname,
                    FromMode = user.FromMode,
                    FromId = user.FromId,
                    IMEI = user.IMEI,
                    GAID = user.GAID,
                    UserIp = userIp,
                    RegisterDate = user.RegistDate!.Value
                });
            }

            var userDCache = new GlobalUserDCache(user.UserID);
            await userDCache.SetLoginDaysAsync(1);
            await userDCache.SetLastLoginDateAsync(currUtcNow);
            await userDCache.SetIClientInfo(ipo);

            await MQUtil.PublishAsync(new UserLoginMsg
            {
                RegLoginType = regType,
                LoginMode = (int)ipo.LoginMode,
                UserMode = user.UserMode,
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                CountryId = user.CountryID,
                CurrencyId = user.CurrencyID,
                UserId = user.UserID,
                UserKind = user.UserKind,
                Username = user.Username,
                Email = user.Email,
                Mobile = user.Mobile,
                Nickname = user.Nickname,
                FromMode = user.FromMode,
                FromId = user.FromId,
                IMEI = user.IMEI,
                GAID = user.GAID,
                LoginDate = currUtcNow,
                UserIp = userIp,

                IsFirstLoginOfDay = true,
                LoginDays = 1,
                LastLoginTime = lastLoginTime
            });
            return ret.Map<RegisterDto>();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<LoginDto> Login(LoginIpo ipo)
        {
            // check
            var oper = DbCacheUtil.GetOperator(ipo.OperatorId);
            if (!oper.AllowVisitor && ipo.LoginMode == LoginMode.Visitor)
                throw new Exception($"不允许游客登录。OperatorId: {ipo.OperatorId}");
            var app = DbCacheUtil.GetApp(ipo.AppId);
            var userIp = AspNetUtil.GetRemoteIpString();

            var user = await GetUser(ipo);
            if (user.OperatorID != ipo.OperatorId)
                throw new CustomException(CommonCodes.UsernameNotExist, $"禁止跨operateId登录");
            // 保存GlobalUserDCache
            var userDCache = new GlobalUserDCache(user.UserID);
            await userDCache.SetBaseValues(user);
            if (!await userDCache.CheckAllowLoginAsync())
                throw new CustomException(XxyyCodes.LoginErrorLimit, "登录错误次数过多，等待30分钟");
            if (user.CountryID != oper.CountryID)
                throw new CustomException(CommonCodes.RS_USER_NOT_EXISTS, "禁止跨国访问");

            var currUtcNow = DateTime.UtcNow;
            RegLoginType loginType = RegLoginType.Unknow;
            switch (ipo.LoginMode)
            {
                case LoginMode.Visitor:
                    if (user.UserMode != (int)UserMode.Visitor)
                        throw new Exception($"以游客方式登录时，账户必须是游客类型。UserId: {user.UserID} userMode:{user.UserMode}");
                    if (string.IsNullOrEmpty(ipo.Password))
                        throw new Exception("以游客方式登录时，密码不能为空");
                    if (ipo.Password != user.Password)
                        throw new CustomException(XxyyCodes.UserPasswordError, "以游客方式登录时，密码错误，游客密码保存在客户端");
                    loginType = RegLoginType.VisitorLogin;
                    break;
                case LoginMode.MobileAndPassword:
                    if (string.IsNullOrEmpty(ipo.Mobile) || string.IsNullOrEmpty(ipo.Password))
                        throw new Exception("登录时Mobile和密码不能为空");
                    if (!SecurityUtil.ValidatePassword(ipo.Password, user.Password, user.PasswordSalt))
                        throw new CustomException(XxyyCodes.UserPasswordError, "密码错误");
                    loginType = RegLoginType.AccountLogin;
                    break;
                case LoginMode.UsernameAndPassword:
                    if (string.IsNullOrEmpty(ipo.Username) || string.IsNullOrEmpty(ipo.Password))
                        throw new Exception("登录时Username和密码不能为空");
                    if (ipo.Username.Length < 6 || ipo.Username.Length > 30)
                        throw new CustomException(XxyyCodes.UsernameInvalid, "username长度6-30");
                    if (!SecurityUtil.ValidatePassword(ipo.Password, user.Password, user.PasswordSalt))
                        throw new CustomException(XxyyCodes.UserPasswordError, "密码错误");
                    loginType = RegLoginType.AccountLogin;
                    break;
                default:
                    throw new Exception($"不支持此登录方式：{ipo.LoginMode}");
            }
            await userDCache.LoginSuccessAsync();
            var lastDate = await userDCache.GetLastLoginDateAsync();//上一次登录时间
            await userDCache.SetLastLoginDateAsync(currUtcNow);
            user.LastLoginDate = currUtcNow;
            await DbSink.BuildUserMo(user.UserID).PutLastLoginDateByPKAsync(user.UserID, currUtcNow);
            var ret = await BuildLoginDto(user, oper, app);

            // 是否连续登录
            var intervalDays = (currUtcNow.Date - lastDate.Date).Days;
            var loginDays = intervalDays == 1 ? await userDCache.GetLoginDaysAsync() + 1 : 1;
            await userDCache.SetLoginDaysAsync(loginDays);
            await userDCache.SetIClientInfo(ipo);
            await MQUtil.PublishAsync(new UserLoginMsg
            {
                RegLoginType = loginType,
                LoginMode = (int)ipo.LoginMode,
                UserMode = user.UserMode,
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                CountryId = user.CountryID,
                CurrencyId = user.CurrencyID,
                UserId = user.UserID,
                Username = user.Username,
                Email = user.Email,
                Mobile = user.Mobile,
                UserKind = user.UserKind,
                Nickname = user.Nickname,
                FromMode = user.FromMode,
                FromId = user.FromId,
                IMEI = user.IMEI,
                GAID = user.GAID,
                LoginDate = currUtcNow,
                VersionId = ipo.VersionId,
                Language = ipo.Language,
                OS = ipo.OS,
                IsMobile = ipo.IsMobile,
                Browser = ipo.Browser,
                UserIp = userIp,

                IsFirstLoginOfDay = intervalDays != 0,
                LoginDays = loginDays,
                LastLoginTime = lastDate
            });
            return ret;
        }
        public async Task<ReloginDto> Relogin(ReloginIpo ipo)
        {
            var user = await GetUser(ipo.UserId);
            if (user.OperatorID != ipo.OperatorId)
                throw new CustomException(CommonCodes.UsernameNotExist, $"禁止跨operateId登录");
            var app = DbCacheUtil.GetApp(ipo.AppId);
            var oper = DbCacheUtil.GetOperator(ipo.OperatorId);
            var userIp = AspNetUtil.GetRemoteIpString();

            var currUtcNow = DateTime.UtcNow;
            RegLoginType loginType = RegLoginType.JwtLogin;
            var userDCache = new GlobalUserDCache(user.UserID);
            var lastDate = await userDCache.GetLastLoginDateAsync();//上一次登录时间
            await userDCache.SetLastLoginDateAsync(currUtcNow);
            user.LastLoginDate = currUtcNow;
            await DbSink.BuildUserMo(ipo.UserId).PutLastLoginDateByPKAsync(user.UserID, DateTime.UtcNow);
            var ret = await BuildLoginDto(user, oper, app);

            // 是否连续登录
            var intervalDays = (currUtcNow.Date - lastDate.Date).Days;
            var loginDays = intervalDays == 1 ? await userDCache.GetLoginDaysAsync() + 1 : 1;
            await userDCache.SetLoginDaysAsync(loginDays);
            await MQUtil.PublishAsync(new UserLoginMsg
            {
                RegLoginType = loginType,
                LoginMode = (int)LoginMode.JwtToken,
                UserMode = user.UserMode,
                AppId = ipo.AppId,
                OperatorId = ipo.OperatorId,
                CountryId = user.CountryID,
                CurrencyId = user.CurrencyID,
                UserId = user.UserID,
                Username = user.Username,
                Email = user.Email,
                Mobile = user.Mobile,
                UserKind = user.UserKind,
                Nickname = user.Nickname,
                FromMode = user.FromMode,
                FromId = user.FromId,
                IMEI = user.IMEI,
                GAID = user.GAID,
                LoginDate = DateTime.UtcNow,
                UserIp = userIp,

                IsFirstLoginOfDay = intervalDays != 0,
                LoginDays = loginDays,
                LastLoginTime = lastDate
            });
            return ret.Map<ReloginDto>();
        }

        #region Utils
        private async Task<LoginDto> BuildLoginDto(S_userEO user, V_s_operatorEO oper, S_appEO app)
        {
            var ret = new LoginDto()
            {
                UserId = user.UserID,
                Nickname = user.Nickname,
                UserMode = (UserMode)user.UserMode,
                UserKind = (UserKind)user.UserKind,
                CountryId = user.CountryID,
                CurrencyId = user.CurrencyID,
                Cash = user.Cash.AToM(user.CurrencyID),
                Coin = user.Coin,
                Gold = user.Gold,
                Point = user.Point,
                SetPass = !string.IsNullOrEmpty(user.Password) && !string.IsNullOrEmpty(user.PasswordSalt),
                Bonus = user.Bonus.AToM(user.CurrencyID),
                SWB = user.SWB,
                Username = user.Username,
                Email = user.Email,
                Mobile = user.Mobile,
                VIP = user.VIP,
                FromMode = user.FromMode,
                FromId = user.FromId,
                PUserId1 = user.PUserID1,
                RegistDate = user.RegistDate.HasValue ? user.RegistDate.Value : DateTime.MinValue
            };

            // 1) 设置jwt
            var userIp = AspNetUtil.GetRemoteIpString();
            ret.JwtToken = JwtUtil.CreateJwtToken(user.UserID, user.UserKind.ToString(), userIp);

            // 2) Cookie登录
            await HttpContextEx.SignInUseCookie(user.UserID, true);

            // 3) 游客密码（游客登陆需密码）
            if (user.UserMode == (int)UserMode.Visitor)
                ret.VisitorPassword = user.Password;

            // 4) 运营商支持的语言
            if (!string.IsNullOrEmpty(oper.Langs))
                ret.OperatorLangs = oper.Langs.Split('|').ToList();

            // 5)保存GlobalUserDCache
            var userDCache = new GlobalUserDCache(user.UserID);
            await userDCache.SetBaseValues(user);
            return ret;
        }

        private async Task<S_userEO> GetUser(string userId)
        {
            var ret = await DbSink.BuildUserMo(userId).GetByPKAsync(userId);
            if (ret == null)
                throw new Exception($"用户不存在。userId:{userId}");
            // 异常用户
            if (ret.Status != (int)UserStatus.Normal)
                throw new CustomException(XxyyCodes.RS_USER_DISABLED, $"用户状态异常.userId:{ret.UserID} status:{ret.Status}");
            return ret;
        }
        private async Task<S_userEO> GetUser(LoginIpo ipo)
        {
            string userId;
            switch (ipo.LoginMode)
            {
                case LoginMode.Visitor:
                    if (string.IsNullOrEmpty(ipo.UserId))
                        throw new Exception("游客登录userId不能为空");
                    userId = ipo.UserId;
                    break;
                case LoginMode.UsernameAndPassword:
                    userId = await LoginCacheUtil.GetUserIdByUsername(ipo.OperatorId, ipo.Username);
                    if (string.IsNullOrEmpty(userId))
                        throw new CustomException(CommonCodes.UsernameNotExist, $"Username不存在。Username:{ipo.Username}");
                    break;
                case LoginMode.EmailAndPassword:
                    userId = await LoginCacheUtil.GetUserIdByEmail(ipo.OperatorId, ipo.Email);
                    if (string.IsNullOrEmpty(userId))
                        throw new CustomException(CommonCodes.EmailNotExist, $"Email不存在。Email:{ipo.Email}");
                    break;
                /*
            case LoginMode.MobileAndSMSCode:
                */
                case LoginMode.MobileAndPassword:
                    userId = await LoginCacheUtil.GetUserIdByMobile(ipo.OperatorId, ipo.Mobile);
                    if (string.IsNullOrEmpty(userId))
                        throw new CustomException(CommonCodes.MobileNotExist, $"Mobile不存在。Mobile:{ipo.Mobile}");
                    break;
                default:
                    throw new Exception("不支持此种登录方式");
            }

            var ret = await DbSink.BuildUserMo(userId).GetByPKAsync(userId);
            if (ret == null)
                throw new Exception($"用户不存在。userId:{userId}");
            // 异常用户
            if (ret.Status != (int)UserStatus.Normal)
                throw new CustomException(XxyyCodes.RS_USER_DISABLED, $"用户状态异常.userId:{ret.UserID} status:{ret.Status}");
            return ret;
        }
        #endregion

        public async Task<string> RefreshJwtToken(RefreshJwtTokenIpo ipo)
        {
            if (string.IsNullOrEmpty(ipo.JwtToken))
                new Exception("JwtToken不能为空");
            if (string.IsNullOrEmpty(ipo.UserId))
                new Exception("UserId不能为空");

            var userIp = AspNetUtil.GetRemoteIpString();
            var jwt = JwtUtil.ReadJwtToken(ipo.JwtToken, userIp);
            if (jwt.Status == JwtTokenStatus.Invalid || jwt.UserId != ipo.UserId)
                throw new CustomException(GResponseCodes.G_JWT_TOKEN_INVALID, "无效的token");
            if (jwt.Status == JwtTokenStatus.Expired)
                throw new CustomException(GResponseCodes.G_JWT_TOKEN_EXPIRED, "过期的token");
            var status = await (await GlobalUserDCache.Create(ipo.UserId)).GetUserStatusAsync();
            if (status != UserStatus.Normal)
                throw new CustomException(XxyyCodes.RS_USER_DISABLED, $"用户状态异常.userId:{ipo.UserId} status:{status}");
            return JwtUtil.CreateJwtToken(ipo.UserId, jwt.RoleString, userIp);
        }

        public async Task Loginout()
        {
            await HttpContextEx.SignOutUseCookie();
        }

        private async Task SetPromoter(S_userEO user)
        {
            if (!string.IsNullOrEmpty(user.FromId) && (user.FromMode == 1 || user.FromMode == 3))
            {

                var puserId = user.FromId;
                var iuserId = user.UserID;
                var utcNow = DateTime.UtcNow;
                await DbSink.BuildUserPromoterMo(puserId).AddAsync(new S_user_promoterEO
                {
                    PUserID = puserId,
                    IUserID = iuserId,
                    PromoteTime = utcNow,
                    UserKind = user.UserKind,
                    OperatorID = user.OperatorID,
                    FromMode = user.FromMode,
                    FromId = user.FromId,
                    CountryID = user.CountryID,
                    CurrencyID = user.CurrencyID,
                    CurrencyType = (int)DbCacheUtil.GetCurrencyType(user.CurrencyID),
                }, null, true);

                var puserId2 = await DbSink.BuildUserMo(puserId).GetPUserID1ByPKAsync(puserId);
                user.PUserID1 = puserId;
                user.PUserID2 = puserId2;
            }
        }
        private string GetDomain(string url)
        {
            if (string.IsNullOrEmpty(url))
                return null;
            url = url.Trim().ToLower();
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                return null;
            string ret = null;
            try {
                var uri = new Uri(url);
                ret = uri.Host;
            }
            catch { }
            return ret;
        }
    }
}
