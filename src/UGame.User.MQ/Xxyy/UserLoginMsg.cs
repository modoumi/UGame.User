using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo;
using AiUo.Extensions.RabbitMQ;
using AiUo.Net;

namespace UGame.User.MQ.Xxyy
{
    /// <summary>
    /// 用户登录消息
    /// </summary>
    public class UserLoginMsg
    {
        public object MQMeta { get; set; }
        public RegLoginType RegLoginType { get; set; }
        /// <summary>
        /// 1-游客
        /// </summary>
        public int LoginMode { get; set; }
        public int UserMode { get; set; }
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public string UserId { get; set; }
        public int UserKind { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Nickname { get; set; }
        public int FromMode { get; set; }
        public string FromId { get; set; }
        public string IMEI { get; set; }
        public string GAID { get; set; }
        public DateTime LoginDate { get; set; }
        public string UserIp { get; set; }

        public string VersionId { get; set; }
        public string Language { get; set; }
        public OperatingSystemType OS { get; set; }
        public bool IsMobile { get; set; }
        public BrowserType Browser { get; set; }

        /// <summary>
        /// 是否当天第一次登录
        /// </summary>
        public bool IsFirstLoginOfDay { get; set; }
        /// <summary>
        /// 用户连续登录天数(包含当天)
        /// </summary>
        public int LoginDays { get; set; }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime LastLoginTime { get; set; }

    }
    public enum RegLoginType
    {
        Unknow = 0,
        /// <summary>
        /// 新游客
        /// </summary>
        NewVisitor = 1,
        /// <summary>
        /// 游客注册
        /// </summary>
        VisitorReg = 2,
        /// <summary>
        /// 直接注册
        /// </summary>
        DirectReg = 3,
        /// <summary>
        /// 游客登录
        /// </summary>
        VisitorLogin = 4,
        /// <summary>
        /// 注册用户账号密码登录
        /// </summary>
        AccountLogin = 5,
        /// <summary>
        /// 注册用户jwt登录
        /// </summary>
        JwtLogin = 6,
        /// <summary>
        /// 合作方用户自动注册
        /// </summary>
        PartnerReg = 7
    }
}
