using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UGame.User.Common;

namespace UGame.User.Service.InitApp
{
    public interface IBothKeyIpo
    {
        string AppId { get; set; }
        string Uuid { get; set; }
        long Timestamp { get; set; }
        string AUS { get; set; }

        string ClientUrl { get; set; }
        string OperatorId { get; set; }
    }
    public class InitOperatorAppIpo : IBothKeyIpo
    {
        public string AppId { get; set; }
        public string Uuid { get; set; }
        public long Timestamp { get; set; }
        public string AUS { get; set; }
        public string ClientUrl { get; set; }
        public string OperatorId { get; set; }
    }
    public class InitOperatorAppDto
    {
        public string OperatorId { get; set; }
        public string ProviderId { get; set; }
        public string CountryId { get; set; }
        public string CurrencyId { get; set; }
        public List<string> OperatorLangs { get; set; }
        /// <summary>
        /// 服务端地址
        /// </summary>
        public string ServerUrl { get; set; }
        public string ServerUrl2 { get; set; }
        public string ServerUrl3 { get; set; }
        public string AccessKey { get; set; }
        public int OperatorVersion { get; set; }
        public OperatorThemes Themes { get; set; } 
        public bool IsShowBonus { get; set; }
        public string AppId { get; set; }
    }
    public class OperatorThemes
    {
        /// <summary>
        /// 显示样式
        /// </summary>
        public int Theme { get; set; }
    }
}
