using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiUo.Extensions.AutoMapper;
using UGame.User.Common; 
using Xxyy.Common;
using UGame.User.Repository;

namespace UGame.User.Service.Account
{
    public class LoginDto:IMapFrom<S_userEO>
    {
        public string UserId { get; set; }
        public string Nickname { get; set; }
        public UserMode UserMode { get; set; }
        /// <summary>
        /// 仅游客使用
        /// </summary>
        public string VisitorPassword { get; set; }
        public UserKind UserKind { get; set; }
        /// <summary>
        /// Jwt Token（xxyy平台和lobby共用）
        /// </summary>
        public string JwtToken { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public decimal Cash { get; set; }
        public long Coin { get; set; }
        public long Gold { get; set; }
        public long Point { get; set; }
        public int VIP { get; set; }
        public long SWB { get; set; }
        public decimal Bonus { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 运营平台支持的语言，null为全部
        /// </summary>
        public List<string> OperatorLangs { get; set; }
        public string PUserId1 { get; set; }
        public int FromMode { get; set; }
        public string FromId { get; set; }
        public DateTime RegistDate { get; set; }

        public bool SetPass { get; set; } = true;

        public void MapFrom(S_userEO source)
        {
            UserMode = source.UserMode.ToEnum(UserMode.Unknow);
            UserKind = source.UserKind.ToEnum(UserKind.Unknow);
        }
    }
}
