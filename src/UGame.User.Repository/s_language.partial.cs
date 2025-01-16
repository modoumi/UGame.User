using System;
using System.Linq;
using System.Text;
using SqlSugar;
using AiUo.Data.SqlSugar;

namespace UGame.User.Repository
{
    public partial class S_languagePO
    {
        #region AiUo
        public static implicit operator S_languageEO(S_languagePO value)
        {
            if (value==null) return null;
            return new S_languageEO
            {
		        LangID = value.LangID,
		        LangID3 = value.LangID3,
		        Name = value.Name,
		        EnName = value.EnName,
		        LangName = value.LangName,
		        Status = value.Status,
            };
        }
        public static implicit operator S_languagePO(S_languageEO value)
        {
            if (value==null) return null;
            return new S_languagePO
            {
		        LangID = value.LangID,
		        LangID3 = value.LangID3,
		        Name = value.Name,
		        EnName = value.EnName,
		        LangName = value.LangName,
		        Status = value.Status,
            };
        }
        #endregion
    }
}