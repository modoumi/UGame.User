using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Common
{
    public static class CommonCodes
    {
        /// <summary>
        /// 短信验证码发送限制（频繁）
        /// </summary>
        public const string SMSLimited = "SMSLimited";
        public const string SMSSendError = "SMSSendError";
        /// <summary>
        /// 验证码错误
        /// </summary>
        public const string VerifyCodeError = "VerifyCodeError";


        /// <summary>
        /// Email不存在
        /// </summary>
        public const string EmailNotExist = "EmailNotExist";
        /// <summary>
        /// Mobile不存在
        /// </summary>
        public const string MobileNotExist = "MobileNotExist";
        /// <summary>
        /// Username不存在
        /// </summary>
        public const string UsernameNotExist = "UsernameNotExist";
        /// <summary>
        /// 运营商用户不存在
        /// </summary>
        public const string OperatorUserIdNotExist = "OperatorUserIdNotExist";
        public const string OAuthUserNotExist = "OAuthUserNotExist";

        /// <summary>
        /// 用户状态异常
        /// </summary>
        public const string UserStatusError = "UserStatusError";
        /// <summary>
        /// 用户并发操作
        /// </summary>
        public const string UserConcurrent = "UserConcurrent";

        /// <summary>
        /// 验证码错误
        /// </summary>
        public const string RS_VERIFYCODE_ERROR = "VerifyCodeError";
        /// <summary>
        /// 短信验证码发送限制（频繁）
        /// </summary>
        public const string RS_SMS_LIMITED = "RS_SMS_LIMITED";
        /// <summary>
        /// 短信发送错误
        /// </summary>
        public const string RS_SMS_FAILED = "RS_SMS_FAILED";


        #region 新标准返回异常码
        /// <summary>
        /// 成功
        /// </summary>
        public const string RS_OK = "RS_OK";
        /// <summary>
        /// 一般错误状态，适用于没有特殊错误代码的情况。
        /// </summary>
        public const string RS_UNKNOWN = "RS_UNKNOWN";
        /// <summary>
        /// 用户余额不足
        /// </summary>
        public const string RS_NOT_ENOUGH_MONEY = "RS_NOT_ENOUGH_MONEY";

        /// <summary>
        /// 收到的请求与预期的请求形式和语法不匹配
        /// </summary>
        public const string RS_WRONG_SYNTAX = "RS_WRONG_SYNTAX";
        /// <summary>
        /// 无效运营商
        /// </summary>
        public const string RS_INVALID_OPERATOR = "RS_INVALID_OPERATOR";
        /// <summary>
        /// 无效提供商
        /// </summary>
        public const string RS_INVALID_PROVIDER = "RS_INVALID_PROVIDER";
        /// <summary>
        /// 未知游戏
        /// </summary>
        public const string RS_INVALID_APP = "RS_INVALID_APP";
        /// <summary>
        /// 国家不同于用户的国家
        /// </summary>
        public const string RS_WRONG_COUNTRY = "RS_WRONG_COUNTRY";
        /// <summary>
        /// 交易货币不同于用户的钱包货币
        /// </summary>
        public const string RS_WRONG_CURRENCY = "RS_WRONG_CURRENCY";
        /// <summary>
        /// 用户不存在
        /// </summary>
        public const string RS_USER_NOT_EXISTS = "RS_USER_NOT_EXISTS";
        /// <summary>
        /// 用户被禁用/锁定并且无法下注
        /// </summary>
        public const string RS_USER_DISABLED = "RS_USER_DISABLED";
        /// <summary>
        /// 验证签名错误
        /// </summary>
        public const string RS_INVALID_SIGNATURE = "RS_INVALID_SIGNATURE";
        /// <summary>
        /// 未知的令牌（我方提供的token）
        /// </summary>
        public const string RS_INVALID_TOKEN = "RS_INVALID_TOKEN";
        /// <summary>
        /// 令牌过期(token)
        /// </summary>
        public const string RS_TOKEN_EXPIRED = "RS_TOKEN_EXPIRED";
        /// <summary>
        /// 传输失败
        /// </summary>
        public const string RS_TRANSFER_FAILED = "RS_TRANSFER_FAILED";
        #endregion
    }
}
