using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.User.Common
{
    /// <summary>
    /// 应用类型
    /// s_app.AppType
    /// </summary>
    public enum AppType
    {
        Unknown = 0,
        Lobby = 1,
        Game = 2,
        App = 3,
        Activity = 4
    }

    /// <summary>
    /// 用户游戏状态
    /// s_user_app.UserAppStatus
    /// </summary>
    public enum UserAppStatus
    {
        Unknown = 0,
        Ok = 1,
        Error = 2
    }
    public enum ProviderType
    {
        /// <summary>
        /// 我方自有游戏提供商
        /// </summary>
        Own = 0,
        /// <summary>
        /// 第三方游戏提供商接我方标准接口
        /// </summary>
        Standard = 1,
        /// <summary>
        /// 第三方游戏提供商提供定制接口
        /// </summary>
        Custom = 2
    }
    public enum OperatorType
    {
        /// <summary>
        /// 我方自有平台运营商
        /// </summary>
        Own = 0,
        /// <summary>
        /// 第三方平台运营商接我方标准接口
        /// </summary>
        Standard = 1,
        /// <summary>
        /// 第三方平台运营商提供定制接口
        /// </summary>
        Custom = 2
    }
}
