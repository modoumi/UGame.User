using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Lobby.Notify;

public class UserNotifyMsg
{
    /// <summary>
    /// 通知ID
    /// </summary>
    public string NofityId { get; set; }
    /// <summary>
    /// 接收人ID
    /// </summary>
    public string UserId { get; set; }
    /// <summary>
    /// 通知模板ID
    /// </summary>
    public string TemplateId { get; set; }
    /// <summary>
    /// 通知标题，有模板时，此栏位不需要传值
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// 通知内容，有模板时，此栏位不需要传值
    /// </summary>
    public string Content { get; set; }
    /// <summary>
    /// 自定义起始时间UTC格式
    /// </summary>
    public DateTime? BeginDateUtc { get; set; }
    /// <summary>
    /// 自定义结束时间UTC格式
    /// </summary>
    public DateTime? EndDateUtc { get; set; }
    public object MQMeta { get; set; }
}
