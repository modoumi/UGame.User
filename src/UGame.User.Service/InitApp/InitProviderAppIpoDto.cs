using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using UGame.User.Common;

namespace UGame.User.Service.InitApp
{
    public class InitProviderAppIpo: IBothKeyIpo
    {
        public string AppId { get; set; }
        public string Uuid { get; set; }
        public long Timestamp { get; set; }
        public string AUS { get; set; }
        public string ClientUrl { get; set; }
        public string OperatorId { get; set; }
    }

    public class InitProviderAppDto
    {
        public string AppServerUrl { get; set; }
        public string AccessKey { get; set; }
        public ChannelThemes Themes { get; set; } = new();
    }
}
