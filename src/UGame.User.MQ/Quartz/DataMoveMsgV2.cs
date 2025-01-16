namespace UGame.User.MQ.Quartz
{
    public class DataMoveMsgV2
    {
        public string DatabaseId { get; set; }

        public string TableName { get; set; }
        public object MQMeta { get; set; }
    }
}
