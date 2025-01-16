using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;

namespace UGame.User.Service.Account
{
    public class ReloginIpo
    {
        public string AppId { get; set; }
        public string OperatorId { get; set; }
        public dynamic Meta { get; set; }

        [JsonIgnore]
        public string UserId { get; set; }
    }

    public class ReloginDto : LoginDto, IMapFrom<LoginDto>
    {
        public void MapFrom(LoginDto source)
        {
        }
    }
}
