/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:47
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using AiUo;
using AiUo.Data;
using MySql.Data.MySqlClient;
using System.Text;
using AiUo.Data.MySql;

namespace UGame.User.Repository
{
	#region EO
	/// <summary>
	/// 渠道+域名前端主题
	/// 【表 s_channel_themes 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_channel_themesEO : IRowMapper<S_channel_themesEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_channel_themesEO()
		{
			this.FlagType = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalThemesID;
		/// <summary>
		/// 【数据库中的原始主键 ThemesID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalThemesID
		{
			get { return _originalThemesID; }
			set { HasOriginal = true; _originalThemesID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ThemesID", ThemesID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 样式编码
		/// 【主键 varchar(36)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ThemesID { get; set; }
		/// <summary>
		/// 标识类型1-channelId 2-domain
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int FlagType { get; set; }
		/// <summary>
		/// 标识内容
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string FlagValue { get; set; }
		/// <summary>
		/// Logo路径
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string LogoUrl { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_channel_themesEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_channel_themesEO MapDataReader(IDataReader reader)
		{
		    S_channel_themesEO ret = new S_channel_themesEO();
			ret.ThemesID = reader.ToString("ThemesID");
			ret.OriginalThemesID = ret.ThemesID;
			ret.FlagType = reader.ToInt32("FlagType");
			ret.FlagValue = reader.ToString("FlagValue");
			ret.LogoUrl = reader.ToString("LogoUrl");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 渠道+域名前端主题
	/// 【表 s_channel_themes 的操作类】
	/// </summary>
	[Obsolete]
	public class S_channel_themesMO : MySqlTableMO<S_channel_themesEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_channel_themes`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_channel_themesMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_channel_themesMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_channel_themesMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_channel_themesEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_channel_themesEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_channel_themesEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ThemesID`, `FlagType`, `FlagValue`, `LogoUrl`) VALUE (@ThemesID, @FlagType, @FlagValue, @LogoUrl);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", item.ThemesID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FlagType", item.FlagType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlagValue", item.FlagValue, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogoUrl", item.LogoUrl != null ? item.LogoUrl : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<S_channel_themesEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_channel_themesEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_channel_themesEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ThemesID`, `FlagType`, `FlagValue`, `LogoUrl`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ThemesID}',{item.FlagType},'{item.FlagValue}','{item.LogoUrl}'),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string themesID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(themesID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string themesID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(themesID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string themesID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ThemesID` = @ThemesID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_channel_themesEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ThemesID, tm_);
		}
		public async Task<int> RemoveAsync(S_channel_themesEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ThemesID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByFlagType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlagType(int flagType, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagTypeData(flagType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagTypeAsync(int flagType, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagTypeData(flagType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlagTypeData(int flagType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlagType` = @FlagType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlagType
		#region RemoveByFlagValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlagValue(string flagValue, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagValueData(flagValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagValueAsync(string flagValue, TransactionManager tm_ = null)
		{
			RepairRemoveByFlagValueData(flagValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlagValueData(string flagValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlagValue` = @FlagValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFlagValue
		#region RemoveByLogoUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLogoUrl(string logoUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLogoUrlData(logoUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLogoUrlAsync(string logoUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLogoUrlData(logoUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLogoUrlData(string logoUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (logoUrl != null ? "`LogoUrl` = @LogoUrl" : "`LogoUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (logoUrl != null)
				paras_.Add(Database.CreateInParameter("@LogoUrl", logoUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLogoUrl
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#region RemoveByFlagTypeAndFlagValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlagTypeAndFlagValue(int flagType, string flagValue, TransactionManager tm_ = null)
		{
			RepiarRemoveByFlagTypeAndFlagValueData(flagType, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlagTypeAndFlagValueAsync(int flagType, string flagValue, TransactionManager tm_ = null)
		{
			RepiarRemoveByFlagTypeAndFlagValueData(flagType, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByFlagTypeAndFlagValueData(int flagType, string flagValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlagType` = @FlagType AND `FlagValue` = @FlagValue";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar),
			};
		}
		#endregion // RemoveByFlagTypeAndFlagValue
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(S_channel_themesEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_channel_themesEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_channel_themesEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ThemesID` = @ThemesID, `FlagType` = @FlagType, `FlagValue` = @FlagValue, `LogoUrl` = @LogoUrl WHERE `ThemesID` = @ThemesID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", item.ThemesID, MySqlDbType.VarChar),
				Database.CreateInParameter("@FlagType", item.FlagType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlagValue", item.FlagValue, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogoUrl", item.LogoUrl != null ? item.LogoUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ThemesID_Original", item.HasOriginal ? item.OriginalThemesID : item.ThemesID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_channel_themesEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_channel_themesEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string themesID, string set_, params object[] values_)
		{
			return Put(set_, "`ThemesID` = @ThemesID", ConcatValues(values_, themesID));
		}
		public async Task<int> PutByPKAsync(string themesID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ThemesID` = @ThemesID", ConcatValues(values_, themesID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string themesID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ThemesID` = @ThemesID", tm_, ConcatValues(values_, themesID));
		}
		public async Task<int> PutByPKAsync(string themesID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ThemesID` = @ThemesID", tm_, ConcatValues(values_, themesID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string themesID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ThemesID` = @ThemesID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string themesID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ThemesID` = @ThemesID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutFlagType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagTypeByPK(string themesID, int flagType, TransactionManager tm_ = null)
		{
			RepairPutFlagTypeByPKData(themesID, flagType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagTypeByPKAsync(string themesID, int flagType, TransactionManager tm_ = null)
		{
			RepairPutFlagTypeByPKData(themesID, flagType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagTypeByPKData(string themesID, int flagType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlagType` = @FlagType  WHERE `ThemesID` = @ThemesID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32),
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagType(int flagType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlagType` = @FlagType";
			var parameter_ = Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlagTypeAsync(int flagType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlagType` = @FlagType";
			var parameter_ = Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlagType
		#region PutFlagValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagValueByPK(string themesID, string flagValue, TransactionManager tm_ = null)
		{
			RepairPutFlagValueByPKData(themesID, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlagValueByPKAsync(string themesID, string flagValue, TransactionManager tm_ = null)
		{
			RepairPutFlagValueByPKData(themesID, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlagValueByPKData(string themesID, string flagValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlagValue` = @FlagValue  WHERE `ThemesID` = @ThemesID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar),
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlagValue(string flagValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlagValue` = @FlagValue";
			var parameter_ = Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlagValueAsync(string flagValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlagValue` = @FlagValue";
			var parameter_ = Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlagValue
		#region PutLogoUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLogoUrlByPK(string themesID, string logoUrl, TransactionManager tm_ = null)
		{
			RepairPutLogoUrlByPKData(themesID, logoUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLogoUrlByPKAsync(string themesID, string logoUrl, TransactionManager tm_ = null)
		{
			RepairPutLogoUrlByPKData(themesID, logoUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLogoUrlByPKData(string themesID, string logoUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LogoUrl` = @LogoUrl  WHERE `ThemesID` = @ThemesID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogoUrl", logoUrl != null ? logoUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLogoUrl(string logoUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LogoUrl` = @LogoUrl";
			var parameter_ = Database.CreateInParameter("@LogoUrl", logoUrl != null ? logoUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLogoUrlAsync(string logoUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LogoUrl` = @LogoUrl";
			var parameter_ = Database.CreateInParameter("@LogoUrl", logoUrl != null ? logoUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLogoUrl
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_channel_themesEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ThemesID) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(S_channel_themesEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ThemesID) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_channel_themesEO GetByPK(string themesID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(themesID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		public async Task<S_channel_themesEO> GetByPKAsync(string themesID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(themesID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		private void RepairGetByPKData(string themesID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ThemesID` = @ThemesID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		public S_channel_themesEO GetByFlagTypeAndFlagValue(int flagType, string flagValue, TransactionManager tm_ = null)
		{
			RepairGetByFlagTypeAndFlagValueData(flagType, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		public async Task<S_channel_themesEO> GetByFlagTypeAndFlagValueAsync(int flagType, string flagValue, TransactionManager tm_ = null)
		{
			RepairGetByFlagTypeAndFlagValueData(flagType, flagValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		private void RepairGetByFlagTypeAndFlagValueData(int flagType, string flagValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`FlagType` = @FlagType AND `FlagValue` = @FlagValue", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32),
				Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 FlagType（字段）
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlagTypeByPK(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FlagType`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		public async Task<int> GetFlagTypeByPKAsync(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FlagType`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlagValue（字段）
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFlagValueByPK(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FlagValue`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		public async Task<string> GetFlagValueByPKAsync(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FlagValue`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LogoUrl（字段）
		/// </summary>
		/// /// <param name = "themesID">样式编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLogoUrlByPK(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LogoUrl`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		public async Task<string> GetLogoUrlByPKAsync(string themesID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThemesID", themesID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LogoUrl`", "`ThemesID` = @ThemesID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByFlagType
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType)
		{
			return GetByFlagType(flagType, 0, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType)
		{
			return await GetByFlagTypeAsync(flagType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, TransactionManager tm_)
		{
			return GetByFlagType(flagType, 0, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, TransactionManager tm_)
		{
			return await GetByFlagTypeAsync(flagType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, int top_)
		{
			return GetByFlagType(flagType, top_, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, int top_)
		{
			return await GetByFlagTypeAsync(flagType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, int top_, TransactionManager tm_)
		{
			return GetByFlagType(flagType, top_, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, int top_, TransactionManager tm_)
		{
			return await GetByFlagTypeAsync(flagType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, string sort_)
		{
			return GetByFlagType(flagType, 0, sort_, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, string sort_)
		{
			return await GetByFlagTypeAsync(flagType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, string sort_, TransactionManager tm_)
		{
			return GetByFlagType(flagType, 0, sort_, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, string sort_, TransactionManager tm_)
		{
			return await GetByFlagTypeAsync(flagType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlagType（字段） 查询
		/// </summary>
		/// /// <param name = "flagType">标识类型1-channelId 2-domain</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagType(int flagType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlagType` = @FlagType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagTypeAsync(int flagType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlagType` = @FlagType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagType", flagType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		#endregion // GetByFlagType
		#region GetByFlagValue
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue)
		{
			return GetByFlagValue(flagValue, 0, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue)
		{
			return await GetByFlagValueAsync(flagValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, TransactionManager tm_)
		{
			return GetByFlagValue(flagValue, 0, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, TransactionManager tm_)
		{
			return await GetByFlagValueAsync(flagValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, int top_)
		{
			return GetByFlagValue(flagValue, top_, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, int top_)
		{
			return await GetByFlagValueAsync(flagValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, int top_, TransactionManager tm_)
		{
			return GetByFlagValue(flagValue, top_, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, int top_, TransactionManager tm_)
		{
			return await GetByFlagValueAsync(flagValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, string sort_)
		{
			return GetByFlagValue(flagValue, 0, sort_, null);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, string sort_)
		{
			return await GetByFlagValueAsync(flagValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, string sort_, TransactionManager tm_)
		{
			return GetByFlagValue(flagValue, 0, sort_, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, string sort_, TransactionManager tm_)
		{
			return await GetByFlagValueAsync(flagValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlagValue（字段） 查询
		/// </summary>
		/// /// <param name = "flagValue">标识内容</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByFlagValue(string flagValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlagValue` = @FlagValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		public async Task<List<S_channel_themesEO>> GetByFlagValueAsync(string flagValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlagValue` = @FlagValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlagValue", flagValue, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		#endregion // GetByFlagValue
		#region GetByLogoUrl
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl)
		{
			return GetByLogoUrl(logoUrl, 0, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl)
		{
			return await GetByLogoUrlAsync(logoUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, TransactionManager tm_)
		{
			return GetByLogoUrl(logoUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, TransactionManager tm_)
		{
			return await GetByLogoUrlAsync(logoUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, int top_)
		{
			return GetByLogoUrl(logoUrl, top_, string.Empty, null);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, int top_)
		{
			return await GetByLogoUrlAsync(logoUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, int top_, TransactionManager tm_)
		{
			return GetByLogoUrl(logoUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, int top_, TransactionManager tm_)
		{
			return await GetByLogoUrlAsync(logoUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, string sort_)
		{
			return GetByLogoUrl(logoUrl, 0, sort_, null);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, string sort_)
		{
			return await GetByLogoUrlAsync(logoUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, string sort_, TransactionManager tm_)
		{
			return GetByLogoUrl(logoUrl, 0, sort_, tm_);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLogoUrlAsync(logoUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LogoUrl（字段） 查询
		/// </summary>
		/// /// <param name = "logoUrl">Logo路径</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_channel_themesEO> GetByLogoUrl(string logoUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(logoUrl != null ? "`LogoUrl` = @LogoUrl" : "`LogoUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (logoUrl != null)
				paras_.Add(Database.CreateInParameter("@LogoUrl", logoUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		public async Task<List<S_channel_themesEO>> GetByLogoUrlAsync(string logoUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(logoUrl != null ? "`LogoUrl` = @LogoUrl" : "`LogoUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (logoUrl != null)
				paras_.Add(Database.CreateInParameter("@LogoUrl", logoUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_channel_themesEO.MapDataReader);
		}
		#endregion // GetByLogoUrl
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
