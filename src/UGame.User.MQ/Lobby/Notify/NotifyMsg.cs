using AiUo.Extensions.RabbitMQ;

namespace UGame.User.MQ.Lobby.Notify
{
    public class NotifyMsg
    {
        /// <summary>
        /// 通知列表
        /// </summary>
        public List<Notify> Notifies { get; set; }

        /// <summary>
        /// 通知用户
        /// </summary>
        public List<NotifyUser> NotifyUsers { get; set; }

        /// <summary>
        /// 通知明细
        /// </summary>
        public List<NotifyDetail> NotifyDetails { get; set; }
    
        public object MQMeta { get; set; }
    }

    /// <summary>
    /// 通知规则
    /// </summary>
    public class Notify
    {
        /// <summary>
        /// 通知Id（GUID）
        /// </summary>
        public string NotifyId { get; set; }

        /// <summary>
        /// 应用编码
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 运营商编码
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 何时显示1-登录前2-注册后第一次登录3登录后
        /// </summary>
        public int ActionAt { get; set; }

        /// <summary>
        /// 显示页面FLAG值0-全部1-首页2-4-8
        /// </summary>
        public int ShowAt { get; set; }

        /// <summary>
        /// 用户范围0-全部用户1-指定具体用户
        /// </summary>
        public int UserScope { get; set; }

        /// <summary>
        /// 需要通知的用户人数
        /// </summary>
        public int NotifyUsersCount { get; set; } = 1;

        /// <summary>
        /// 已通知用户人数
        /// </summary>
        public int NotifyDetailsCount { get; set; } = 0;

        /// <summary>
        /// 显示位置1-顶部2-中部3-下部
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// 展示次数
        /// </summary>
        public int ShowTimes { get; set; }

        /// <summary>
        /// 展示间隔（分钟）
        /// </summary>
        public int ShowInterval { get; set; }

        /// <summary>
        /// 自动关闭间隔（秒）0-手动关闭
        /// </summary>
        public int CloseInterval { get; set; }

        /// <summary>
        /// 排序（从小到大）
        /// </summary>
        public int OrderNum { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// 截止日期
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 状态(0-无效1-有效)
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RecDate { get; set; } = DateTime.UtcNow;
    }


    public class NotifyUser
    {
        /// <summary>
        /// 通知Id
        /// </summary>
        public string NotifyId { get; set; }
        /// <summary>
        /// 要通知的用户编码
        /// </summary>
        public string UserId { get; set; }
    }


    public class NotifyDetail
    {
        /// <summary>
        /// 通知Id
        /// </summary>
        public string NotifyId { get; set; }
        /// <summary>
        /// 语言编码
        /// pt 葡语
        /// es 西语
        /// en 英语
        /// </summary>
        public string LangId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl { get; set; }
        /// <summary>
        /// 通知内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 链接类型1-email 2-url
        /// </summary>
        public int LinkKind { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        public string LinkUrl { get; set; }
    }
}
