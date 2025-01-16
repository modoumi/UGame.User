using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Lobby.Notify;

public class NotifyEmailMsg
{
    public EmailMessage EmailMessages { get; set; }
    public object MQMeta { get; set; }
}

public class EmailMessage : BaseIPO
{
    /// <summary>
    /// 发件人
    /// </summary>
    public string SenderID { get; set; }

    /// <summary>
    /// 0系统消息1最新动态 2奖励邮件 3私信
    /// </summary>
    public int Type { get; set; }


    public List<MessageExtend> ExtendList { get; set; } = new List<MessageExtend>();

    ///// <summary>
    /// 奖励信息
    /// </summary>
    public MessageReward Reward { get; set; }
}

public class MessageExtend
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 语种
    /// </summary>
    public string LangID { get; set; }

    /// <summary>
    /// 广告图
    /// </summary>
    public string ImgURL { get; set; }
    /// <summary>
    /// 链接地址
    /// </summary>
    public string HyperLink { get; set; }

    /// <summary>
    /// 过期时间
    /// </summary>

    public DateTime? ExpireTime { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string Remark { get; set; }

}

public class BaseIPO
{
    /// <summary>
    /// 用户编码
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// 运营商编码
    /// </summary>
    public string OperatorId { get; set; }
    /// <summary>
    /// 国家编码
    /// </summary>
    public string CountryId { get; set; }
    /// <summary>
    /// 货币编码
    /// </summary>
    public string CurrencyId { get; set; }
}

public class MessageReward
{
    /// <summary>
    /// 奖励类型1bouns 2真金
    /// </summary>
    public int AmountType { get; set; }
    /// <summary>
    /// 奖励金额
    /// </summary>
    public decimal Amount { get; set; }
    /// <summary>
    /// 送赠金的最少充值金额
    /// </summary>
    public long LeastPayAmount { get; set; }
    /// <summary>
    /// 赠金提现所需要的流水倍数
    /// </summary>
    public float FlowMultip { get; set; }

    /// <summary>
    /// 0-缺省值
    /// 1-后台奖励bonus
    /// 2-非后台奖励bonus
    /// </summary>
    public int RewardType { get; set; }

    /// <summary>
    /// 活动编号
    /// </summary>
    public string ActivityID { get; set; }

    public int SourceType { get; set; }

    public string SourceTable { get; set; }

    public string SourceId { get; set; }

}
