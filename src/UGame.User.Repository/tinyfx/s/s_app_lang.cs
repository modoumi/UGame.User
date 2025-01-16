/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:40
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
	/// app多语言定义
	/// 【表 s_app_lang 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_app_langEO : IRowMapper<S_app_langEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_app_langEO()
		{
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalAppID;
		/// <summary>
		/// 【数据库中的原始主键 AppID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalAppID
		{
			get { return _originalAppID; }
			set { HasOriginal = true; _originalAppID = value; }
		}
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "LangID", LangID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 应用编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AppID { get; set; }
		/// <summary>
		/// 语言(空字符串表示默认)
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID { get; set; }
		/// <summary>
		/// 是否支持
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 3)]
		public bool IsSupport { get; set; }
		/// <summary>
		/// 应用名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppName { get; set; }
		/// <summary>
		/// 应用详细描述
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 5)]
		public string AppDesc { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_app_langEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_app_langEO MapDataReader(IDataReader reader)
		{
		    S_app_langEO ret = new S_app_langEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.IsSupport = reader.ToBoolean("IsSupport");
			ret.AppName = reader.ToString("AppName");
			ret.AppDesc = reader.ToString("AppDesc");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// app多语言定义
	/// 【表 s_app_lang 的操作类】
	/// </summary>
	[Obsolete]
	public class S_app_langMO : MySqlTableMO<S_app_langEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_app_lang`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_app_langMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_app_langMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_app_langMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_app_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_app_langEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_app_langEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `LangID`, `IsSupport`, `AppName`, `AppDesc`) VALUE (@AppID, @LangID, @IsSupport, @AppName, @AppDesc);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsSupport", item.IsSupport, MySqlDbType.Byte),
				Database.CreateInParameter("@AppName", item.AppName != null ? item.AppName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppDesc", item.AppDesc != null ? item.AppDesc : (object)DBNull.Value, MySqlDbType.Text),
			};
		}
		public int AddByBatch(IEnumerable<S_app_langEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_app_langEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_app_langEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `LangID`, `IsSupport`, `AppName`, `AppDesc`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}','{item.LangID}',{item.IsSupport},'{item.AppName}','{item.AppDesc}'),");
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_app_langEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.LangID, tm_);
		}
		public async Task<int> RemoveAsync(S_app_langEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.LangID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByAppID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairRemoveByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangID(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			RepairRemoveByLangIDData(langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangIDData(string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByIsSupport
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsSupport(bool isSupport, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSupportData(isSupport, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsSupportAsync(bool isSupport, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSupportData(isSupport, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsSupportData(bool isSupport, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsSupport` = @IsSupport";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsSupport
		#region RemoveByAppName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppName(string appName, TransactionManager tm_ = null)
		{
			RepairRemoveByAppNameData(appName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppNameAsync(string appName, TransactionManager tm_ = null)
		{
			RepairRemoveByAppNameData(appName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppNameData(string appName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appName != null ? "`AppName` = @AppName" : "`AppName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appName != null)
				paras_.Add(Database.CreateInParameter("@AppName", appName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppName
		#region RemoveByAppDesc
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppDesc(string appDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByAppDescData(appDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppDescAsync(string appDesc, TransactionManager tm_ = null)
		{
			RepairRemoveByAppDescData(appDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppDescData(string appDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appDesc != null ? "`AppDesc` = @AppDesc" : "`AppDesc` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appDesc != null)
				paras_.Add(Database.CreateInParameter("@AppDesc", appDesc, MySqlDbType.Text));
		}
		#endregion // RemoveByAppDesc
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
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
		public int Put(S_app_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_app_langEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_app_langEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `LangID` = @LangID, `IsSupport` = @IsSupport, `AppName` = @AppName, `AppDesc` = @AppDesc WHERE `AppID` = @AppID_Original AND `LangID` = @LangID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsSupport", item.IsSupport, MySqlDbType.Byte),
				Database.CreateInParameter("@AppName", item.AppName != null ? item.AppName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppDesc", item.AppDesc != null ? item.AppDesc : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_app_langEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_app_langEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string langID, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `LangID` = @LangID", ConcatValues(values_, appID, langID));
		}
		public async Task<int> PutByPKAsync(string appID, string langID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `LangID` = @LangID", ConcatValues(values_, appID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `LangID` = @LangID", tm_, ConcatValues(values_, appID, langID));
		}
		public async Task<int> PutByPKAsync(string appID, string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `LangID` = @LangID", tm_, ConcatValues(values_, appID, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AppID` = @AppID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutAppID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutLangID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID
		#region PutIsSupport
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSupportByPK(string appID, string langID, bool isSupport, TransactionManager tm_ = null)
		{
			RepairPutIsSupportByPKData(appID, langID, isSupport, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsSupportByPKAsync(string appID, string langID, bool isSupport, TransactionManager tm_ = null)
		{
			RepairPutIsSupportByPKData(appID, langID, isSupport, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsSupportByPKData(string appID, string langID, bool isSupport, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsSupport` = @IsSupport  WHERE `AppID` = @AppID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSupport(bool isSupport, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSupport` = @IsSupport";
			var parameter_ = Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsSupportAsync(bool isSupport, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSupport` = @IsSupport";
			var parameter_ = Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsSupport
		#region PutAppName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// /// <param name = "appName">应用名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppNameByPK(string appID, string langID, string appName, TransactionManager tm_ = null)
		{
			RepairPutAppNameByPKData(appID, langID, appName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppNameByPKAsync(string appID, string langID, string appName, TransactionManager tm_ = null)
		{
			RepairPutAppNameByPKData(appID, langID, appName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppNameByPKData(string appID, string langID, string appName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppName` = @AppName  WHERE `AppID` = @AppID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppName", appName != null ? appName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppName(string appName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppName` = @AppName";
			var parameter_ = Database.CreateInParameter("@AppName", appName != null ? appName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppNameAsync(string appName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppName` = @AppName";
			var parameter_ = Database.CreateInParameter("@AppName", appName != null ? appName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppName
		#region PutAppDesc
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppDescByPK(string appID, string langID, string appDesc, TransactionManager tm_ = null)
		{
			RepairPutAppDescByPKData(appID, langID, appDesc, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppDescByPKAsync(string appID, string langID, string appDesc, TransactionManager tm_ = null)
		{
			RepairPutAppDescByPKData(appID, langID, appDesc, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppDescByPKData(string appID, string langID, string appDesc, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppDesc` = @AppDesc  WHERE `AppID` = @AppID AND `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppDesc", appDesc != null ? appDesc : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppDesc(string appDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppDesc` = @AppDesc";
			var parameter_ = Database.CreateInParameter("@AppDesc", appDesc != null ? appDesc : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppDescAsync(string appDesc, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppDesc` = @AppDesc";
			var parameter_ = Database.CreateInParameter("@AppDesc", appDesc != null ? appDesc : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppDesc
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_app_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.LangID) == null)
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
		public async Task<bool> SetAsync(S_app_langEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.LangID) == null)
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
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_app_langEO GetByPK(string appID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<S_app_langEO> GetByPKAsync(string appID, string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, string langID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `LangID` = @LangID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsSupport（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsSupportByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsSupport`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<bool> GetIsSupportByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsSupport`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppName（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppNameByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppName`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetAppNameByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppName`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppDesc（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppDescByPK(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppDesc`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetAppDescByPKAsync(string appID, string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppDesc`", "`AppID` = @AppID AND `LangID` = @LangID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, int top_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, string sort_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<List<S_app_langEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言(空字符串表示默认)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<List<S_app_langEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LangID` = @LangID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByIsSupport
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport)
		{
			return GetByIsSupport(isSupport, 0, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport)
		{
			return await GetByIsSupportAsync(isSupport, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, TransactionManager tm_)
		{
			return GetByIsSupport(isSupport, 0, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, TransactionManager tm_)
		{
			return await GetByIsSupportAsync(isSupport, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, int top_)
		{
			return GetByIsSupport(isSupport, top_, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, int top_)
		{
			return await GetByIsSupportAsync(isSupport, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, int top_, TransactionManager tm_)
		{
			return GetByIsSupport(isSupport, top_, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, int top_, TransactionManager tm_)
		{
			return await GetByIsSupportAsync(isSupport, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, string sort_)
		{
			return GetByIsSupport(isSupport, 0, sort_, null);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, string sort_)
		{
			return await GetByIsSupportAsync(isSupport, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, string sort_, TransactionManager tm_)
		{
			return GetByIsSupport(isSupport, 0, sort_, tm_);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, string sort_, TransactionManager tm_)
		{
			return await GetByIsSupportAsync(isSupport, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsSupport（字段） 查询
		/// </summary>
		/// /// <param name = "isSupport">是否支持</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByIsSupport(bool isSupport, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSupport` = @IsSupport", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<List<S_app_langEO>> GetByIsSupportAsync(bool isSupport, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSupport` = @IsSupport", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSupport", isSupport, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		#endregion // GetByIsSupport
		#region GetByAppName
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName)
		{
			return GetByAppName(appName, 0, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName)
		{
			return await GetByAppNameAsync(appName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, TransactionManager tm_)
		{
			return GetByAppName(appName, 0, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, int top_)
		{
			return GetByAppName(appName, top_, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, int top_)
		{
			return await GetByAppNameAsync(appName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, int top_, TransactionManager tm_)
		{
			return GetByAppName(appName, top_, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, int top_, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, string sort_)
		{
			return GetByAppName(appName, 0, sort_, null);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, string sort_)
		{
			return await GetByAppNameAsync(appName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, string sort_, TransactionManager tm_)
		{
			return GetByAppName(appName, 0, sort_, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, string sort_, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">应用名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppName(string appName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appName != null ? "`AppName` = @AppName" : "`AppName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appName != null)
				paras_.Add(Database.CreateInParameter("@AppName", appName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<List<S_app_langEO>> GetByAppNameAsync(string appName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appName != null ? "`AppName` = @AppName" : "`AppName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appName != null)
				paras_.Add(Database.CreateInParameter("@AppName", appName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		#endregion // GetByAppName
		#region GetByAppDesc
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc)
		{
			return GetByAppDesc(appDesc, 0, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc)
		{
			return await GetByAppDescAsync(appDesc, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, TransactionManager tm_)
		{
			return GetByAppDesc(appDesc, 0, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, TransactionManager tm_)
		{
			return await GetByAppDescAsync(appDesc, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, int top_)
		{
			return GetByAppDesc(appDesc, top_, string.Empty, null);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, int top_)
		{
			return await GetByAppDescAsync(appDesc, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, int top_, TransactionManager tm_)
		{
			return GetByAppDesc(appDesc, top_, string.Empty, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, int top_, TransactionManager tm_)
		{
			return await GetByAppDescAsync(appDesc, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, string sort_)
		{
			return GetByAppDesc(appDesc, 0, sort_, null);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, string sort_)
		{
			return await GetByAppDescAsync(appDesc, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, string sort_, TransactionManager tm_)
		{
			return GetByAppDesc(appDesc, 0, sort_, tm_);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, string sort_, TransactionManager tm_)
		{
			return await GetByAppDescAsync(appDesc, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppDesc（字段） 查询
		/// </summary>
		/// /// <param name = "appDesc">应用详细描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_app_langEO> GetByAppDesc(string appDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appDesc != null ? "`AppDesc` = @AppDesc" : "`AppDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appDesc != null)
				paras_.Add(Database.CreateInParameter("@AppDesc", appDesc, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		public async Task<List<S_app_langEO>> GetByAppDescAsync(string appDesc, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appDesc != null ? "`AppDesc` = @AppDesc" : "`AppDesc` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appDesc != null)
				paras_.Add(Database.CreateInParameter("@AppDesc", appDesc, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_app_langEO.MapDataReader);
		}
		#endregion // GetByAppDesc
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
