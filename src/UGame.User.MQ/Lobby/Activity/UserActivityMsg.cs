using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Lobby.Activity;

public class UserActivityMsg
{
    /// <summary>
    /// 用户编码
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// 活动编码
    /// </summary>
    public int ActivityType { get; set; }

    /// <summary>
    /// 活动是否已完成
    /// </summary>
    public bool IsEnd { get; set; }

    public object MQMeta { get; set; }
}
