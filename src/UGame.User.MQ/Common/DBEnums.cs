using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xxyy.Common
{
    /// <summary>
    /// 用户登录模式
    /// s_user.UserMode
    /// </summary>
    public enum UserMode
    {
        Unknow = 0,
        /// <summary>
        /// 游客
        /// </summary>
        Visitor = 1,
        /// <summary>
        /// 注册用户
        /// </summary>
        Register = 2,
        /// <summary>
        /// 第三方运营商用户
        /// </summary>
        Operator = 3
    }

    /// <summary>
    /// 用户类型
    /// s_user.UserKind
    /// </summary>
    public enum UserKind
    {
        /// <summary>
        /// 未知
        /// </summary>
        Unknow = 0,
        /// <summary>
        /// 普通用户
        /// </summary>
        User = 1,
        /// <summary>
        /// 开发用户
        /// </summary>
        Dev = 2,
        /// <summary>
        /// 线上测试用户（调用第三方扣减）
        /// </summary>
        Tester = 3,
        /// <summary>
        /// 线上测试用户（不调用第三方扣减）
        /// </summary>
        LocalTester = 4,
        /// <summary>
        /// 仿真测试人员
        /// </summary>
        Staging = 5,
        /// <summary>
        /// 联调测试用户
        /// </summary>
        Debug = 6,
        /// <summary>
        /// 管理员
        /// </summary>
        Admin = 9
    }

    /// <summary>
    /// 用户状态
    /// s_user.status
    /// </summary>
    public enum UserStatus
    {
        Unknown = 0,
        Normal = 1,
        ExClose = 2,
        SysClose = 9
    }

    /// <summary>
    /// 用户来源
    /// </summary>
    public enum FromMode
    {
        /// <summary>
        /// 运营商
        /// </summary>
        Operator = 0,
        /// <summary>
        /// 推广员
        /// </summary>
        Promoter = 1,
        /// <summary>
        /// 渠道
        /// </summary>
        Channel = 2,
        /// <summary>
        /// 红包
        /// </summary>
        Pack = 3,
        Unknow = 99
    }

    /// <summary>
    /// 货币类型
    /// s_currency.type
    /// </summary>
    public enum CurrencyType
    {
        Unknow = 0,
        Coin = 1,
        Gold = 2,
        Point = 3,
        SWB = 4,
        Crypto = 8,//加密货币
        Cash = 9
    }

    /// <summary>
    /// 订单状态(通用)
    /// s_provider_order s_operator_order s_sms_order等
    /// </summary>
    public enum OrderStatus
    {
        Initial = 0,
        Processing = 1,
        Success = 2,
        Fail = 3,
        Rollback = 4,
        Exception = 5,
        ExcHandled = 6
    }

    /// <summary>
    /// 提供商请求行为
    /// </summary>
    public enum ProviderAction
    {
        Balance = 0,
        Bet = 1,
        Win = 2,
        BetWin = 3,
        Rollback = 4
    }
}
