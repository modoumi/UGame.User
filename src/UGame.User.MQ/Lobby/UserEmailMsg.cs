using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Email;

/// <summary>
/// 发送用户邮件消息
/// </summary>
public class UserEmailMsg
{
    /// <summary>
    /// 接收人ID
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// 显示类别，0-系统邮件 1-最新动态 2-奖励邮件 3-私信
    /// </summary>
    public int DisplayTag { get; set; }
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
    /// <summary>
    /// 应用编码
    /// </summary>
    public string AppId { get; set; }
    /// <summary>
    /// 领取奖金，乘以10000之后的数值
    /// </summary>
    public long RewardAmount { get; set; }
    /// <summary>
    /// 是否bouns
    /// </summary>
    public bool IsBouns { get; set; }
    /// <summary>
    /// 赠金提现所需要的流水倍数
    /// </summary>
    public float FlowMultip { get; set; }
    /// <summary>
    /// 来源类型，如果是活动，就是活动ID，如：100009，100010等
    /// </summary>
    public int SourceType { get; set; }
    /// <summary>
    /// 活动详情表名
    /// </summary>
    public string SourceTable { get; set; }
    /// <summary>
    /// 活动详情表Id
    /// </summary>
    public string SourceId { get; set; }
    /// <summary>
    /// 生效时间，UTC格式，时间未到当前系统时间，前端捞取不到此邮件
    /// </summary>
    public DateTime? BeginDateUtc { get; set; }
    /// <summary>
    /// 失效时间，UTC格式，时间小于当前系统时间，前端捞取不到此邮件
    /// </summary>
    public DateTime? EndDateUtc { get; set; }
    /// <summary>
    /// 发送人ID
    /// </summary>
    public string SenderId { get; set; }
    /// <summary>
    /// 发送邮件模板ID
    /// </summary>
    public string TemplateId { get; set; }
    /// <summary>
    /// 模板key，如果使用此字段，不用赋值TemplateId，会根据规则
    /// </summary>
    public string TemplateKey { get; set; }
    /// <summary>
    /// 标题，发送自定义邮件需要设置，模板邮件无需设置
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 邮件内容，发送自定义邮件时此栏位值是邮件的内容，模板邮件时，此栏位值是内容中参数变量的对象json
    /// 如：{"rewardAmount":50}
    /// </summary>
    public string Content { get; set; }

    public object MQMeta { get; set; }
}
