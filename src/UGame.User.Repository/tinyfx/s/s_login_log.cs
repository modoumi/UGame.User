/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:43
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
	/// 原始用户登录日志
	/// 登录登出时都插入数据
	/// 【表 s_login_log 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_login_logEO : IRowMapper<S_login_logEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_login_logEO()
		{
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalLogID;
		/// <summary>
		/// 【数据库中的原始主键 LogID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLogID
		{
			get { return _originalLogID; }
			set { HasOriginal = true; _originalLogID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "LogID", LogID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 日志编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string LogID { get; set; }
		/// <summary>
		/// 用户编码
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppID { get; set; }
		/// <summary>
		/// 登录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 5)]
		public DateTime? LoginDate { get; set; }
		/// <summary>
		/// 退出时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime? LogoutDate { get; set; }
		/// <summary>
		/// App版本号
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 7)]
		public string VersionID { get; set; }
		/// <summary>
		/// 语言
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 8)]
		public string LangID { get; set; }
		/// <summary>
		/// 是否移动端
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 9)]
		public bool? IsMobile { get; set; }
		/// <summary>
		/// 系统
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 10)]
		public string OS { get; set; }
		/// <summary>
		/// 浏览器
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 11)]
		public string Browser { get; set; }
		/// <summary>
		/// 状态(0-失败1-成功)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int Status { get; set; }
		/// <summary>
		/// 信息描述（错误原因）
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 13)]
		public string Message { get; set; }
		/// <summary>
		/// 用户IP
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 14)]
		public string UserIp { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 15)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_login_logEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_login_logEO MapDataReader(IDataReader reader)
		{
		    S_login_logEO ret = new S_login_logEO();
			ret.LogID = reader.ToString("LogID");
			ret.OriginalLogID = ret.LogID;
			ret.UserID = reader.ToString("UserID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.AppID = reader.ToString("AppID");
			ret.LoginDate = reader.ToDateTimeN("LoginDate");
			ret.LogoutDate = reader.ToDateTimeN("LogoutDate");
			ret.VersionID = reader.ToString("VersionID");
			ret.LangID = reader.ToString("LangID");
			ret.IsMobile = reader.ToBooleanN("IsMobile");
			ret.OS = reader.ToString("OS");
			ret.Browser = reader.ToString("Browser");
			ret.Status = reader.ToInt32("Status");
			ret.Message = reader.ToString("Message");
			ret.UserIp = reader.ToString("UserIp");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 原始用户登录日志
	/// 登录登出时都插入数据
	/// 【表 s_login_log 的操作类】
	/// </summary>
	[Obsolete]
	public class S_login_logMO : MySqlTableMO<S_login_logEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_login_log`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_login_logMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_login_logMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_login_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_login_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_login_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_login_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LogID`, `UserID`, `OperatorID`, `AppID`, `LoginDate`, `LogoutDate`, `VersionID`, `LangID`, `IsMobile`, `OS`, `Browser`, `Status`, `Message`, `UserIp`, `RecDate`) VALUE (@LogID, @UserID, @OperatorID, @AppID, @LoginDate, @LogoutDate, @VersionID, @LangID, @IsMobile, @OS, @Browser, @Status, @Message, @UserIp, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LoginDate", item.LoginDate.HasValue ? item.LoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@LogoutDate", item.LogoutDate.HasValue ? item.LogoutDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@VersionID", item.VersionID != null ? item.VersionID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsMobile", item.IsMobile.HasValue ? item.IsMobile.Value : (object)DBNull.Value, MySqlDbType.Byte),
				Database.CreateInParameter("@OS", item.OS != null ? item.OS : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Browser", item.Browser != null ? item.Browser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Message", item.Message != null ? item.Message : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<S_login_logEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_login_logEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_login_logEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LogID`, `UserID`, `OperatorID`, `AppID`, `LoginDate`, `LogoutDate`, `VersionID`, `LangID`, `IsMobile`, `OS`, `Browser`, `Status`, `Message`, `UserIp`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.LogID}','{item.UserID}','{item.OperatorID}','{item.AppID}','{item.LoginDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.LogoutDate?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.VersionID}','{item.LangID}',{item.IsMobile?.ToString()??null},'{item.OS}','{item.Browser}',{item.Status},'{item.Message}','{item.UserIp}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string logID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(logID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string logID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(logID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string logID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_login_logEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.LogID, tm_);
		}
		public async Task<int> RemoveAsync(S_login_logEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.LogID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAppID
		#region RemoveByLoginDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLoginDate(DateTime? loginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDateData(loginDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLoginDateAsync(DateTime? loginDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLoginDateData(loginDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLoginDateData(DateTime? loginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (loginDate.HasValue ? "`LoginDate` = @LoginDate" : "`LoginDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (loginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LoginDate", loginDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLoginDate
		#region RemoveByLogoutDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLogoutDate(DateTime? logoutDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLogoutDateData(logoutDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLogoutDateAsync(DateTime? logoutDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLogoutDateData(logoutDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLogoutDateData(DateTime? logoutDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (logoutDate.HasValue ? "`LogoutDate` = @LogoutDate" : "`LogoutDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (logoutDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LogoutDate", logoutDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLogoutDate
		#region RemoveByVersionID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByVersionID(string versionID, TransactionManager tm_ = null)
		{
			RepairRemoveByVersionIDData(versionID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByVersionIDAsync(string versionID, TransactionManager tm_ = null)
		{
			RepairRemoveByVersionIDData(versionID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByVersionIDData(string versionID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (versionID != null ? "`VersionID` = @VersionID" : "`VersionID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (versionID != null)
				paras_.Add(Database.CreateInParameter("@VersionID", versionID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByVersionID
		#region RemoveByLangID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID">语言</param>
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
			sql_ = $"DELETE FROM {TableName} WHERE " + (langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID
		#region RemoveByIsMobile
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsMobile(bool? isMobile, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMobileData(isMobile.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsMobileAsync(bool? isMobile, TransactionManager tm_ = null)
		{
			RepairRemoveByIsMobileData(isMobile.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsMobileData(bool? isMobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (isMobile.HasValue ? "`IsMobile` = @IsMobile" : "`IsMobile` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (isMobile.HasValue)
				paras_.Add(Database.CreateInParameter("@IsMobile", isMobile.Value, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsMobile
		#region RemoveByOS
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOS(string oS, TransactionManager tm_ = null)
		{
			RepairRemoveByOSData(oS, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOSAsync(string oS, TransactionManager tm_ = null)
		{
			RepairRemoveByOSData(oS, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOSData(string oS, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (oS != null ? "`OS` = @OS" : "`OS` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (oS != null)
				paras_.Add(Database.CreateInParameter("@OS", oS, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOS
		#region RemoveByBrowser
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBrowser(string browser, TransactionManager tm_ = null)
		{
			RepairRemoveByBrowserData(browser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBrowserAsync(string browser, TransactionManager tm_ = null)
		{
			RepairRemoveByBrowserData(browser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBrowserData(string browser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (browser != null ? "`Browser` = @Browser" : "`Browser` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (browser != null)
				paras_.Add(Database.CreateInParameter("@Browser", browser, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBrowser
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
		#region RemoveByMessage
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMessage(string message, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageData(message, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMessageAsync(string message, TransactionManager tm_ = null)
		{
			RepairRemoveByMessageData(message, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMessageData(string message, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (message != null ? "`Message` = @Message" : "`Message` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (message != null)
				paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
		}
		#endregion // RemoveByMessage
		#region RemoveByUserIp
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserIp(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIpData(userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIpData(string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserIp
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
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
		public int Put(S_login_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_login_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_login_logEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LogID` = @LogID, `UserID` = @UserID, `OperatorID` = @OperatorID, `AppID` = @AppID, `LoginDate` = @LoginDate, `LogoutDate` = @LogoutDate, `VersionID` = @VersionID, `LangID` = @LangID, `IsMobile` = @IsMobile, `OS` = @OS, `Browser` = @Browser, `Status` = @Status, `Message` = @Message, `UserIp` = @UserIp WHERE `LogID` = @LogID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", item.LogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", item.UserID != null ? item.UserID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", item.AppID != null ? item.AppID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LoginDate", item.LoginDate.HasValue ? item.LoginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@LogoutDate", item.LogoutDate.HasValue ? item.LogoutDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@VersionID", item.VersionID != null ? item.VersionID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", item.LangID != null ? item.LangID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsMobile", item.IsMobile.HasValue ? item.IsMobile.Value : (object)DBNull.Value, MySqlDbType.Byte),
				Database.CreateInParameter("@OS", item.OS != null ? item.OS : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Browser", item.Browser != null ? item.Browser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@Message", item.Message != null ? item.Message : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@UserIp", item.UserIp != null ? item.UserIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID_Original", item.HasOriginal ? item.OriginalLogID : item.LogID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_login_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_login_logEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string logID, string set_, params object[] values_)
		{
			return Put(set_, "`LogID` = @LogID", ConcatValues(values_, logID));
		}
		public async Task<int> PutByPKAsync(string logID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`LogID` = @LogID", ConcatValues(values_, logID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string logID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`LogID` = @LogID", tm_, ConcatValues(values_, logID));
		}
		public async Task<int> PutByPKAsync(string logID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`LogID` = @LogID", tm_, ConcatValues(values_, logID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string logID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`LogID` = @LogID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string logID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`LogID` = @LogID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string logID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(logID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string logID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(logID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string logID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID != null ? userID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string logID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(logID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string logID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(logID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string logID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutAppID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppIDByPK(string logID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(logID, appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppIDByPKAsync(string logID, string appID, TransactionManager tm_ = null)
		{
			RepairPutAppIDByPKData(logID, appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppIDByPKData(string logID, string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppID(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppID` = @AppID";
			var parameter_ = Database.CreateInParameter("@AppID", appID != null ? appID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppID
		#region PutLoginDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDateByPK(string logID, DateTime? loginDate, TransactionManager tm_ = null)
		{
			RepairPutLoginDateByPKData(logID, loginDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLoginDateByPKAsync(string logID, DateTime? loginDate, TransactionManager tm_ = null)
		{
			RepairPutLoginDateByPKData(logID, loginDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLoginDateByPKData(string logID, DateTime? loginDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LoginDate` = @LoginDate  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LoginDate", loginDate.HasValue ? loginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLoginDate(DateTime? loginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDate` = @LoginDate";
			var parameter_ = Database.CreateInParameter("@LoginDate", loginDate.HasValue ? loginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLoginDateAsync(DateTime? loginDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LoginDate` = @LoginDate";
			var parameter_ = Database.CreateInParameter("@LoginDate", loginDate.HasValue ? loginDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLoginDate
		#region PutLogoutDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLogoutDateByPK(string logID, DateTime? logoutDate, TransactionManager tm_ = null)
		{
			RepairPutLogoutDateByPKData(logID, logoutDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLogoutDateByPKAsync(string logID, DateTime? logoutDate, TransactionManager tm_ = null)
		{
			RepairPutLogoutDateByPKData(logID, logoutDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLogoutDateByPKData(string logID, DateTime? logoutDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LogoutDate` = @LogoutDate  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogoutDate", logoutDate.HasValue ? logoutDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLogoutDate(DateTime? logoutDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LogoutDate` = @LogoutDate";
			var parameter_ = Database.CreateInParameter("@LogoutDate", logoutDate.HasValue ? logoutDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLogoutDateAsync(DateTime? logoutDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LogoutDate` = @LogoutDate";
			var parameter_ = Database.CreateInParameter("@LogoutDate", logoutDate.HasValue ? logoutDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLogoutDate
		#region PutVersionID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVersionIDByPK(string logID, string versionID, TransactionManager tm_ = null)
		{
			RepairPutVersionIDByPKData(logID, versionID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutVersionIDByPKAsync(string logID, string versionID, TransactionManager tm_ = null)
		{
			RepairPutVersionIDByPKData(logID, versionID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutVersionIDByPKData(string logID, string versionID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `VersionID` = @VersionID  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@VersionID", versionID != null ? versionID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutVersionID(string versionID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VersionID` = @VersionID";
			var parameter_ = Database.CreateInParameter("@VersionID", versionID != null ? versionID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutVersionIDAsync(string versionID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `VersionID` = @VersionID";
			var parameter_ = Database.CreateInParameter("@VersionID", versionID != null ? versionID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutVersionID
		#region PutLangID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangIDByPK(string logID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(logID, langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangIDByPKAsync(string logID, string langID, TransactionManager tm_ = null)
		{
			RepairPutLangIDByPKData(logID, langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangIDByPKData(string logID, string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangIDAsync(string langID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID` = @LangID";
			var parameter_ = Database.CreateInParameter("@LangID", langID != null ? langID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID
		#region PutIsMobile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMobileByPK(string logID, bool? isMobile, TransactionManager tm_ = null)
		{
			RepairPutIsMobileByPKData(logID, isMobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsMobileByPKAsync(string logID, bool? isMobile, TransactionManager tm_ = null)
		{
			RepairPutIsMobileByPKData(logID, isMobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsMobileByPKData(string logID, bool? isMobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsMobile` = @IsMobile  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsMobile", isMobile.HasValue ? isMobile.Value : (object)DBNull.Value, MySqlDbType.Byte),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsMobile(bool? isMobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMobile` = @IsMobile";
			var parameter_ = Database.CreateInParameter("@IsMobile", isMobile.HasValue ? isMobile.Value : (object)DBNull.Value, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsMobileAsync(bool? isMobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsMobile` = @IsMobile";
			var parameter_ = Database.CreateInParameter("@IsMobile", isMobile.HasValue ? isMobile.Value : (object)DBNull.Value, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsMobile
		#region PutOS
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "oS">系统</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOSByPK(string logID, string oS, TransactionManager tm_ = null)
		{
			RepairPutOSByPKData(logID, oS, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOSByPKAsync(string logID, string oS, TransactionManager tm_ = null)
		{
			RepairPutOSByPKData(logID, oS, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOSByPKData(string logID, string oS, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OS` = @OS  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OS", oS != null ? oS : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOS(string oS, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OS` = @OS";
			var parameter_ = Database.CreateInParameter("@OS", oS != null ? oS : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOSAsync(string oS, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OS` = @OS";
			var parameter_ = Database.CreateInParameter("@OS", oS != null ? oS : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOS
		#region PutBrowser
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "browser">浏览器</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBrowserByPK(string logID, string browser, TransactionManager tm_ = null)
		{
			RepairPutBrowserByPKData(logID, browser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBrowserByPKAsync(string logID, string browser, TransactionManager tm_ = null)
		{
			RepairPutBrowserByPKData(logID, browser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBrowserByPKData(string logID, string browser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Browser` = @Browser  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Browser", browser != null ? browser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBrowser(string browser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Browser` = @Browser";
			var parameter_ = Database.CreateInParameter("@Browser", browser != null ? browser : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBrowserAsync(string browser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Browser` = @Browser";
			var parameter_ = Database.CreateInParameter("@Browser", browser != null ? browser : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBrowser
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string logID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(logID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string logID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(logID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string logID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutMessage
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessageByPK(string logID, string message, TransactionManager tm_ = null)
		{
			RepairPutMessageByPKData(logID, message, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMessageByPKAsync(string logID, string message, TransactionManager tm_ = null)
		{
			RepairPutMessageByPKData(logID, message, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMessageByPKData(string logID, string message, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Message` = @Message  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMessage(string message, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Message` = @Message";
			var parameter_ = Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMessageAsync(string message, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Message` = @Message";
			var parameter_ = Database.CreateInParameter("@Message", message != null ? message : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMessage
		#region PutUserIp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIpByPK(string logID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(logID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIpByPKAsync(string logID, string userIp, TransactionManager tm_ = null)
		{
			RepairPutUserIpByPKData(logID, userIp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIpByPKData(string logID, string userIp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIp(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIpAsync(string userIp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserIp` = @UserIp";
			var parameter_ = Database.CreateInParameter("@UserIp", userIp != null ? userIp : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserIp
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string logID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(logID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string logID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(logID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string logID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `LogID` = @LogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_login_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LogID) == null)
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
		public async Task<bool> SetAsync(S_login_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LogID) == null)
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
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_login_logEO GetByPK(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<S_login_logEO> GetByPKAsync(string logID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(logID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		private void RepairGetByPKData(string logID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`LogID` = @LogID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LoginDate（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLoginDateByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LoginDate`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<DateTime?> GetLoginDateByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LoginDate`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LogoutDate（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLogoutDateByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LogoutDate`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<DateTime?> GetLogoutDateByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LogoutDate`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 VersionID（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetVersionIDByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`VersionID`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetVersionIDByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`VersionID`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangID（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangIDByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetLangIDByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsMobile（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool? GetIsMobileByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (bool?)GetScalar("`IsMobile`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<bool?> GetIsMobileByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (bool?)await GetScalarAsync("`IsMobile`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OS（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOSByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OS`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetOSByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OS`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Browser（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBrowserByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Browser`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetBrowserByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Browser`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Message（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMessageByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Message`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetMessageByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Message`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserIp（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIpByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserIp`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<string> GetUserIpByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserIp`", "`LogID` = @LogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "logID">日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`LogID` = @LogID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string logID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LogID", logID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`LogID` = @LogID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userID != null ? "`UserID` = @UserID" : "`UserID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userID != null)
				paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<S_login_logEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<S_login_logEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<S_login_logEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appID != null ? "`AppID` = @AppID" : "`AppID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appID != null)
				paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByLoginDate
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate)
		{
			return GetByLoginDate(loginDate, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate)
		{
			return await GetByLoginDateAsync(loginDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, TransactionManager tm_)
		{
			return GetByLoginDate(loginDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, TransactionManager tm_)
		{
			return await GetByLoginDateAsync(loginDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, int top_)
		{
			return GetByLoginDate(loginDate, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, int top_)
		{
			return await GetByLoginDateAsync(loginDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, int top_, TransactionManager tm_)
		{
			return GetByLoginDate(loginDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, int top_, TransactionManager tm_)
		{
			return await GetByLoginDateAsync(loginDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, string sort_)
		{
			return GetByLoginDate(loginDate, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, string sort_)
		{
			return await GetByLoginDateAsync(loginDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, string sort_, TransactionManager tm_)
		{
			return GetByLoginDate(loginDate, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, string sort_, TransactionManager tm_)
		{
			return await GetByLoginDateAsync(loginDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LoginDate（字段） 查询
		/// </summary>
		/// /// <param name = "loginDate">登录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLoginDate(DateTime? loginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(loginDate.HasValue ? "`LoginDate` = @LoginDate" : "`LoginDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (loginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LoginDate", loginDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByLoginDateAsync(DateTime? loginDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(loginDate.HasValue ? "`LoginDate` = @LoginDate" : "`LoginDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (loginDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LoginDate", loginDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByLoginDate
		#region GetByLogoutDate
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate)
		{
			return GetByLogoutDate(logoutDate, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate)
		{
			return await GetByLogoutDateAsync(logoutDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, TransactionManager tm_)
		{
			return GetByLogoutDate(logoutDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, TransactionManager tm_)
		{
			return await GetByLogoutDateAsync(logoutDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, int top_)
		{
			return GetByLogoutDate(logoutDate, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, int top_)
		{
			return await GetByLogoutDateAsync(logoutDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, int top_, TransactionManager tm_)
		{
			return GetByLogoutDate(logoutDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, int top_, TransactionManager tm_)
		{
			return await GetByLogoutDateAsync(logoutDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, string sort_)
		{
			return GetByLogoutDate(logoutDate, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, string sort_)
		{
			return await GetByLogoutDateAsync(logoutDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, string sort_, TransactionManager tm_)
		{
			return GetByLogoutDate(logoutDate, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, string sort_, TransactionManager tm_)
		{
			return await GetByLogoutDateAsync(logoutDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LogoutDate（字段） 查询
		/// </summary>
		/// /// <param name = "logoutDate">退出时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLogoutDate(DateTime? logoutDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(logoutDate.HasValue ? "`LogoutDate` = @LogoutDate" : "`LogoutDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (logoutDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LogoutDate", logoutDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByLogoutDateAsync(DateTime? logoutDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(logoutDate.HasValue ? "`LogoutDate` = @LogoutDate" : "`LogoutDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (logoutDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LogoutDate", logoutDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByLogoutDate
		#region GetByVersionID
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID)
		{
			return GetByVersionID(versionID, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID)
		{
			return await GetByVersionIDAsync(versionID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, TransactionManager tm_)
		{
			return GetByVersionID(versionID, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, TransactionManager tm_)
		{
			return await GetByVersionIDAsync(versionID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, int top_)
		{
			return GetByVersionID(versionID, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, int top_)
		{
			return await GetByVersionIDAsync(versionID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, int top_, TransactionManager tm_)
		{
			return GetByVersionID(versionID, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, int top_, TransactionManager tm_)
		{
			return await GetByVersionIDAsync(versionID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, string sort_)
		{
			return GetByVersionID(versionID, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, string sort_)
		{
			return await GetByVersionIDAsync(versionID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, string sort_, TransactionManager tm_)
		{
			return GetByVersionID(versionID, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, string sort_, TransactionManager tm_)
		{
			return await GetByVersionIDAsync(versionID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 VersionID（字段） 查询
		/// </summary>
		/// /// <param name = "versionID">App版本号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByVersionID(string versionID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(versionID != null ? "`VersionID` = @VersionID" : "`VersionID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (versionID != null)
				paras_.Add(Database.CreateInParameter("@VersionID", versionID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByVersionIDAsync(string versionID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(versionID != null ? "`VersionID` = @VersionID" : "`VersionID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (versionID != null)
				paras_.Add(Database.CreateInParameter("@VersionID", versionID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByVersionID
		#region GetByLangID
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID)
		{
			return GetByLangID(langID, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, int top_)
		{
			return GetByLangID(langID, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, int top_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, int top_, TransactionManager tm_)
		{
			return GetByLangID(langID, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, int top_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, string sort_)
		{
			return GetByLangID(langID, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, string sort_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, string sort_, TransactionManager tm_)
		{
			return GetByLangID(langID, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, string sort_, TransactionManager tm_)
		{
			return await GetByLangIDAsync(langID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangID（字段） 查询
		/// </summary>
		/// /// <param name = "langID">语言</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByLangID(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByLangIDAsync(string langID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langID != null ? "`LangID` = @LangID" : "`LangID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langID != null)
				paras_.Add(Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByLangID
		#region GetByIsMobile
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile)
		{
			return GetByIsMobile(isMobile, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile)
		{
			return await GetByIsMobileAsync(isMobile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, TransactionManager tm_)
		{
			return GetByIsMobile(isMobile, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, TransactionManager tm_)
		{
			return await GetByIsMobileAsync(isMobile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, int top_)
		{
			return GetByIsMobile(isMobile, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, int top_)
		{
			return await GetByIsMobileAsync(isMobile, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, int top_, TransactionManager tm_)
		{
			return GetByIsMobile(isMobile, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, int top_, TransactionManager tm_)
		{
			return await GetByIsMobileAsync(isMobile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, string sort_)
		{
			return GetByIsMobile(isMobile, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, string sort_)
		{
			return await GetByIsMobileAsync(isMobile, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, string sort_, TransactionManager tm_)
		{
			return GetByIsMobile(isMobile, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, string sort_, TransactionManager tm_)
		{
			return await GetByIsMobileAsync(isMobile, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsMobile（字段） 查询
		/// </summary>
		/// /// <param name = "isMobile">是否移动端</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByIsMobile(bool? isMobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(isMobile.HasValue ? "`IsMobile` = @IsMobile" : "`IsMobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (isMobile.HasValue)
				paras_.Add(Database.CreateInParameter("@IsMobile", isMobile.Value, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByIsMobileAsync(bool? isMobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(isMobile.HasValue ? "`IsMobile` = @IsMobile" : "`IsMobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (isMobile.HasValue)
				paras_.Add(Database.CreateInParameter("@IsMobile", isMobile.Value, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByIsMobile
		#region GetByOS
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS)
		{
			return GetByOS(oS, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS)
		{
			return await GetByOSAsync(oS, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, TransactionManager tm_)
		{
			return GetByOS(oS, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, TransactionManager tm_)
		{
			return await GetByOSAsync(oS, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, int top_)
		{
			return GetByOS(oS, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, int top_)
		{
			return await GetByOSAsync(oS, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, int top_, TransactionManager tm_)
		{
			return GetByOS(oS, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, int top_, TransactionManager tm_)
		{
			return await GetByOSAsync(oS, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, string sort_)
		{
			return GetByOS(oS, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, string sort_)
		{
			return await GetByOSAsync(oS, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, string sort_, TransactionManager tm_)
		{
			return GetByOS(oS, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, string sort_, TransactionManager tm_)
		{
			return await GetByOSAsync(oS, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OS（字段） 查询
		/// </summary>
		/// /// <param name = "oS">系统</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByOS(string oS, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(oS != null ? "`OS` = @OS" : "`OS` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (oS != null)
				paras_.Add(Database.CreateInParameter("@OS", oS, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByOSAsync(string oS, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(oS != null ? "`OS` = @OS" : "`OS` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (oS != null)
				paras_.Add(Database.CreateInParameter("@OS", oS, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByOS
		#region GetByBrowser
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser)
		{
			return GetByBrowser(browser, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser)
		{
			return await GetByBrowserAsync(browser, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, TransactionManager tm_)
		{
			return GetByBrowser(browser, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, TransactionManager tm_)
		{
			return await GetByBrowserAsync(browser, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, int top_)
		{
			return GetByBrowser(browser, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, int top_)
		{
			return await GetByBrowserAsync(browser, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, int top_, TransactionManager tm_)
		{
			return GetByBrowser(browser, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, int top_, TransactionManager tm_)
		{
			return await GetByBrowserAsync(browser, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, string sort_)
		{
			return GetByBrowser(browser, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, string sort_)
		{
			return await GetByBrowserAsync(browser, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, string sort_, TransactionManager tm_)
		{
			return GetByBrowser(browser, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, string sort_, TransactionManager tm_)
		{
			return await GetByBrowserAsync(browser, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Browser（字段） 查询
		/// </summary>
		/// /// <param name = "browser">浏览器</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByBrowser(string browser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(browser != null ? "`Browser` = @Browser" : "`Browser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (browser != null)
				paras_.Add(Database.CreateInParameter("@Browser", browser, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByBrowserAsync(string browser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(browser != null ? "`Browser` = @Browser" : "`Browser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (browser != null)
				paras_.Add(Database.CreateInParameter("@Browser", browser, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByBrowser
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-失败1-成功)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByMessage
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message)
		{
			return GetByMessage(message, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message)
		{
			return await GetByMessageAsync(message, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, TransactionManager tm_)
		{
			return GetByMessage(message, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, TransactionManager tm_)
		{
			return await GetByMessageAsync(message, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, int top_)
		{
			return GetByMessage(message, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, int top_)
		{
			return await GetByMessageAsync(message, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, int top_, TransactionManager tm_)
		{
			return GetByMessage(message, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, int top_, TransactionManager tm_)
		{
			return await GetByMessageAsync(message, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, string sort_)
		{
			return GetByMessage(message, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, string sort_)
		{
			return await GetByMessageAsync(message, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, string sort_, TransactionManager tm_)
		{
			return GetByMessage(message, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, string sort_, TransactionManager tm_)
		{
			return await GetByMessageAsync(message, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Message（字段） 查询
		/// </summary>
		/// /// <param name = "message">信息描述（错误原因）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByMessage(string message, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(message != null ? "`Message` = @Message" : "`Message` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (message != null)
				paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByMessageAsync(string message, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(message != null ? "`Message` = @Message" : "`Message` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (message != null)
				paras_.Add(Database.CreateInParameter("@Message", message, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByMessage
		#region GetByUserIp
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp)
		{
			return GetByUserIp(userIp, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, int top_)
		{
			return GetByUserIp(userIp, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, int top_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, int top_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, int top_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, string sort_)
		{
			return GetByUserIp(userIp, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, string sort_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, string sort_, TransactionManager tm_)
		{
			return GetByUserIp(userIp, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, string sort_, TransactionManager tm_)
		{
			return await GetByUserIpAsync(userIp, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserIp（字段） 查询
		/// </summary>
		/// /// <param name = "userIp">用户IP</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByUserIp(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByUserIpAsync(string userIp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(userIp != null ? "`UserIp` = @UserIp" : "`UserIp` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (userIp != null)
				paras_.Add(Database.CreateInParameter("@UserIp", userIp, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByUserIp
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_login_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		public async Task<List<S_login_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_login_logEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
