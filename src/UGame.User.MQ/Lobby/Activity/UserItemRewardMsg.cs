using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Lobby.Activity;

/// <summary>
/// 用户领奖通知
/// </summary>
public class UserItemRewardMsg
{
    /// <summary>
    /// 用户ID
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// 活动或任务ID
    /// </summary>
    public int ItemId { get; set; }
    /// <summary>
    /// 奖励日期
    /// </summary>
    public DateTime? DayId { get; set; }
    /// <summary>
    /// 应用ID
    /// </summary>
    public string AppId { get; set; }
    /// <summary>
    /// 运营商ID
    /// </summary>
    public string OperatorId { get; set; }
    /// <summary>
    /// 等级，有的活动或是任务，是有等级的
    /// </summary>
    public int Level { get; set; }
    /// <summary>
    /// 奖励明细ID，必须有值，这个奖励的唯一区分ID
    /// </summary>
    public string DetailId { get; set; }
    /// <summary>
    /// 国家ID
    /// </summary>
    public string CountryId { get; set; }
    /// <summary>
    /// 币种ID
    /// </summary>
    public string CurrencyId { get; set; }
    /// <summary>
    /// 延迟奖励是否是Bonus
    /// </summary>
    public bool IsBonus { get; set; }
    /// <summary>
    /// 延迟奖励金额，乘以10000后的金额
    /// </summary>
    public long DelayRewardAmount { get; set; }
    /// <summary>
    /// 延迟奖励发放天数，从明天开始算起，明天为第一天
    /// </summary>
    public int DelayDays { get; set; }
    /// <summary>
    /// 流水倍数
    /// </summary>
    public float FlowMultip { get; set; }
    /// <summary>
    /// 奖励原因，通常是活动奖励的描述，如：返水活动100010奖励
    /// </summary>
    public string Reason { get; set; }
    /// <summary>
    /// 扩展数据
    /// </summary>
    public object Meta { get; set; }

    public object MQMeta { get; set; }
}
