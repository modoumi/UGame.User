/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:52
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
	/// 应用列表
	/// 【表 s_app 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_appEO : IRowMapper<S_appEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_appEO()
		{
			this.AppType = 0;
			this.PromoterType = 2;
			this.ServerType = 0;
			this.FlowRatio = 1f;
			this.Status = 0;
			this.HasJackpot = false;
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
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AppID", AppID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// App编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string AppID { get; set; }
		/// <summary>
		/// 应用提供商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 应用提供商的应用编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string ProviderAppId { get; set; }
		/// <summary>
		/// App名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string AppName { get; set; }
		/// <summary>
		/// App类型1-大厅2-游戏3-应用
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int AppType { get; set; }
		/// <summary>
		/// 推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int PromoterType { get; set; }
		/// <summary>
		/// app服务端类型0-未知1-api2-websocket
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int ServerType { get; set; }
		/// <summary>
		/// 应用服务端线上URL（仅api game需要配置）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string ServerUrl { get; set; }
		/// <summary>
		/// 应用服务端线上URL2（仅api game需要配置）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string ServerUrl2 { get; set; }
		/// <summary>
		/// 应用服务端线上URL3（仅api game需要配置）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 10)]
		public string ServerUrl3 { get; set; }
		/// <summary>
		/// 应用服务端仿真URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 11)]
		public string ServerUrlStaging { get; set; }
		/// <summary>
		/// 应用服务端联调URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 12)]
		public string ServerUrlDebug { get; set; }
		/// <summary>
		/// 流水bet计算比率
		/// 【字段 float】
		/// </summary>
		[DataMember(Order = 13)]
		public float FlowRatio { get; set; }
		/// <summary>
		/// App支持的语言。|分割
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 14)]
		public string Langs { get; set; }
		/// <summary>
		/// 备注信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 15)]
		public string Note { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int Status { get; set; }
		/// <summary>
		/// 是否有Jackpot
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 17)]
		public bool HasJackpot { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_appEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_appEO MapDataReader(IDataReader reader)
		{
		    S_appEO ret = new S_appEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.ProviderID = reader.ToString("ProviderID");
			ret.ProviderAppId = reader.ToString("ProviderAppId");
			ret.AppName = reader.ToString("AppName");
			ret.AppType = reader.ToInt32("AppType");
			ret.PromoterType = reader.ToInt32("PromoterType");
			ret.ServerType = reader.ToInt32("ServerType");
			ret.ServerUrl = reader.ToString("ServerUrl");
			ret.ServerUrl2 = reader.ToString("ServerUrl2");
			ret.ServerUrl3 = reader.ToString("ServerUrl3");
			ret.ServerUrlStaging = reader.ToString("ServerUrlStaging");
			ret.ServerUrlDebug = reader.ToString("ServerUrlDebug");
			ret.FlowRatio = reader.ToSingle("FlowRatio");
			ret.Langs = reader.ToString("Langs");
			ret.Note = reader.ToString("Note");
			ret.Status = reader.ToInt32("Status");
			ret.HasJackpot = reader.ToBoolean("HasJackpot");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 应用列表
	/// 【表 s_app 的操作类】
	/// </summary>
	[Obsolete]
	public class S_appMO : MySqlTableMO<S_appEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_app`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_appMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_appMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_appMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_appEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `ProviderID`, `ProviderAppId`, `AppName`, `AppType`, `PromoterType`, `ServerType`, `ServerUrl`, `ServerUrl2`, `ServerUrl3`, `ServerUrlStaging`, `ServerUrlDebug`, `FlowRatio`, `Langs`, `Note`, `Status`, `HasJackpot`) VALUE (@AppID, @ProviderID, @ProviderAppId, @AppName, @AppType, @PromoterType, @ServerType, @ServerUrl, @ServerUrl2, @ServerUrl3, @ServerUrlStaging, @ServerUrlDebug, @FlowRatio, @Langs, @Note, @Status, @HasJackpot);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderAppId", item.ProviderAppId != null ? item.ProviderAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppName", item.AppName != null ? item.AppName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppType", item.AppType, MySqlDbType.Int32),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@ServerType", item.ServerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ServerUrl", item.ServerUrl != null ? item.ServerUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrl2", item.ServerUrl2 != null ? item.ServerUrl2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrl3", item.ServerUrl3 != null ? item.ServerUrl3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrlStaging", item.ServerUrlStaging != null ? item.ServerUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrlDebug", item.ServerUrlDebug != null ? item.ServerUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FlowRatio", item.FlowRatio, MySqlDbType.Float),
				Database.CreateInParameter("@Langs", item.Langs != null ? item.Langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@HasJackpot", item.HasJackpot, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<S_appEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_appEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_appEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `ProviderID`, `ProviderAppId`, `AppName`, `AppType`, `PromoterType`, `ServerType`, `ServerUrl`, `ServerUrl2`, `ServerUrl3`, `ServerUrlStaging`, `ServerUrlDebug`, `FlowRatio`, `Langs`, `Note`, `Status`, `HasJackpot`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}','{item.ProviderID}','{item.ProviderAppId}','{item.AppName}',{item.AppType},{item.PromoterType},{item.ServerType},'{item.ServerUrl}','{item.ServerUrl2}','{item.ServerUrl3}','{item.ServerUrlStaging}','{item.ServerUrlDebug}',{item.FlowRatio},'{item.Langs}','{item.Note}',{item.Status},{item.HasJackpot}),");
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
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_appEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, tm_);
		}
		public async Task<int> RemoveAsync(S_appEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByProviderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderID(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderIDData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderIDData(string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderID
		#region RemoveByProviderAppId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderAppId(string providerAppId, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderAppIdData(providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderAppIdAsync(string providerAppId, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderAppIdData(providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderAppIdData(string providerAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerAppId != null ? "`ProviderAppId` = @ProviderAppId" : "`ProviderAppId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerAppId != null)
				paras_.Add(Database.CreateInParameter("@ProviderAppId", providerAppId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderAppId
		#region RemoveByAppName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appName">App名称</param>
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
		#region RemoveByAppType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppType(int appType, TransactionManager tm_ = null)
		{
			RepairRemoveByAppTypeData(appType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppTypeAsync(int appType, TransactionManager tm_ = null)
		{
			RepairRemoveByAppTypeData(appType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppTypeData(int appType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppType` = @AppType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32));
		}
		#endregion // RemoveByAppType
		#region RemoveByPromoterType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoterTypeData(promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPromoterTypeData(int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PromoterType` = @PromoterType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
		}
		#endregion // RemoveByPromoterType
		#region RemoveByServerType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerType(int serverType, TransactionManager tm_ = null)
		{
			RepairRemoveByServerTypeData(serverType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerTypeAsync(int serverType, TransactionManager tm_ = null)
		{
			RepairRemoveByServerTypeData(serverType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerTypeData(int serverType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ServerType` = @ServerType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32));
		}
		#endregion // RemoveByServerType
		#region RemoveByServerUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerUrl(string serverUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlData(serverUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerUrlAsync(string serverUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlData(serverUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerUrlData(string serverUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (serverUrl != null ? "`ServerUrl` = @ServerUrl" : "`ServerUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (serverUrl != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl", serverUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByServerUrl
		#region RemoveByServerUrl2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerUrl2(string serverUrl2, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrl2Data(serverUrl2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerUrl2Async(string serverUrl2, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrl2Data(serverUrl2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerUrl2Data(string serverUrl2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (serverUrl2 != null ? "`ServerUrl2` = @ServerUrl2" : "`ServerUrl2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (serverUrl2 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl2", serverUrl2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByServerUrl2
		#region RemoveByServerUrl3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerUrl3(string serverUrl3, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrl3Data(serverUrl3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerUrl3Async(string serverUrl3, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrl3Data(serverUrl3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerUrl3Data(string serverUrl3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (serverUrl3 != null ? "`ServerUrl3` = @ServerUrl3" : "`ServerUrl3` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (serverUrl3 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl3", serverUrl3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByServerUrl3
		#region RemoveByServerUrlStaging
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerUrlStaging(string serverUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlStagingData(serverUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerUrlStagingAsync(string serverUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlStagingData(serverUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerUrlStagingData(string serverUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (serverUrlStaging != null ? "`ServerUrlStaging` = @ServerUrlStaging" : "`ServerUrlStaging` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (serverUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging, MySqlDbType.VarChar));
		}
		#endregion // RemoveByServerUrlStaging
		#region RemoveByServerUrlDebug
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByServerUrlDebug(string serverUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlDebugData(serverUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByServerUrlDebugAsync(string serverUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByServerUrlDebugData(serverUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByServerUrlDebugData(string serverUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (serverUrlDebug != null ? "`ServerUrlDebug` = @ServerUrlDebug" : "`ServerUrlDebug` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (serverUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug, MySqlDbType.VarChar));
		}
		#endregion // RemoveByServerUrlDebug
		#region RemoveByFlowRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowRatio(float flowRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowRatioData(flowRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowRatioAsync(float flowRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowRatioData(flowRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowRatioData(float flowRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowRatio` = @FlowRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float));
		}
		#endregion // RemoveByFlowRatio
		#region RemoveByLangs
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangs(string langs, TransactionManager tm_ = null)
		{
			RepairRemoveByLangsData(langs, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangsAsync(string langs, TransactionManager tm_ = null)
		{
			RepairRemoveByLangsData(langs, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangsData(string langs, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (langs != null ? "`Langs` = @Langs" : "`Langs` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (langs != null)
				paras_.Add(Database.CreateInParameter("@Langs", langs, MySqlDbType.Text));
		}
		#endregion // RemoveByLangs
		#region RemoveByNote
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNote(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNoteAsync(string note, TransactionManager tm_ = null)
		{
			RepairRemoveByNoteData(note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNoteData(string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (note != null ? "`Note` = @Note" : "`Note` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
		}
		#endregion // RemoveByNote
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
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
		#region RemoveByHasJackpot
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHasJackpot(bool hasJackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByHasJackpotData(hasJackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHasJackpotAsync(bool hasJackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByHasJackpotData(hasJackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHasJackpotData(bool hasJackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HasJackpot` = @HasJackpot";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte));
		}
		#endregion // RemoveByHasJackpot
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#region RemoveByProviderIDAndProviderAppId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderIDAndProviderAppId(string providerID, string providerAppId, TransactionManager tm_ = null)
		{
			RepiarRemoveByProviderIDAndProviderAppIdData(providerID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderIDAndProviderAppIdAsync(string providerID, string providerAppId, TransactionManager tm_ = null)
		{
			RepiarRemoveByProviderIDAndProviderAppIdData(providerID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByProviderIDAndProviderAppIdData(string providerID, string providerAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ProviderID` = @ProviderID AND `ProviderAppId` = @ProviderAppId";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderAppId", providerAppId != null ? providerAppId : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		#endregion // RemoveByProviderIDAndProviderAppId
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
		public int Put(S_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_appEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `ProviderID` = @ProviderID, `ProviderAppId` = @ProviderAppId, `AppName` = @AppName, `AppType` = @AppType, `PromoterType` = @PromoterType, `ServerType` = @ServerType, `ServerUrl` = @ServerUrl, `ServerUrl2` = @ServerUrl2, `ServerUrl3` = @ServerUrl3, `ServerUrlStaging` = @ServerUrlStaging, `ServerUrlDebug` = @ServerUrlDebug, `FlowRatio` = @FlowRatio, `Langs` = @Langs, `Note` = @Note, `Status` = @Status, `HasJackpot` = @HasJackpot WHERE `AppID` = @AppID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderAppId", item.ProviderAppId != null ? item.ProviderAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppName", item.AppName != null ? item.AppName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppType", item.AppType, MySqlDbType.Int32),
				Database.CreateInParameter("@PromoterType", item.PromoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@ServerType", item.ServerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ServerUrl", item.ServerUrl != null ? item.ServerUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrl2", item.ServerUrl2 != null ? item.ServerUrl2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrl3", item.ServerUrl3 != null ? item.ServerUrl3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrlStaging", item.ServerUrlStaging != null ? item.ServerUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ServerUrlDebug", item.ServerUrlDebug != null ? item.ServerUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FlowRatio", item.FlowRatio, MySqlDbType.Float),
				Database.CreateInParameter("@Langs", item.Langs != null ? item.Langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@HasJackpot", item.HasJackpot, MySqlDbType.Byte),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_appEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_appEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "appID">App编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID", ConcatValues(values_, appID));
		}
		public async Task<int> PutByPKAsync(string appID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID", ConcatValues(values_, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID", tm_, ConcatValues(values_, appID));
		}
		public async Task<int> PutByPKAsync(string appID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID", tm_, ConcatValues(values_, appID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AppID` = @AppID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutProviderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderIDByPK(string appID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(appID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderIDByPKAsync(string appID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(appID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderIDByPKData(string appID, string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderID(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderIDAsync(string providerID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID";
			var parameter_ = Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderID
		#region PutProviderAppId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderAppIdByPK(string appID, string providerAppId, TransactionManager tm_ = null)
		{
			RepairPutProviderAppIdByPKData(appID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderAppIdByPKAsync(string appID, string providerAppId, TransactionManager tm_ = null)
		{
			RepairPutProviderAppIdByPKData(appID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderAppIdByPKData(string appID, string providerAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderAppId` = @ProviderAppId  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderAppId", providerAppId != null ? providerAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderAppId(string providerAppId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderAppId` = @ProviderAppId";
			var parameter_ = Database.CreateInParameter("@ProviderAppId", providerAppId != null ? providerAppId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderAppIdAsync(string providerAppId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderAppId` = @ProviderAppId";
			var parameter_ = Database.CreateInParameter("@ProviderAppId", providerAppId != null ? providerAppId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderAppId
		#region PutAppName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "appName">App名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppNameByPK(string appID, string appName, TransactionManager tm_ = null)
		{
			RepairPutAppNameByPKData(appID, appName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppNameByPKAsync(string appID, string appName, TransactionManager tm_ = null)
		{
			RepairPutAppNameByPKData(appID, appName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppNameByPKData(string appID, string appName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppName` = @AppName  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppName", appName != null ? appName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appName">App名称</param>
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
		#region PutAppType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppTypeByPK(string appID, int appType, TransactionManager tm_ = null)
		{
			RepairPutAppTypeByPKData(appID, appType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppTypeByPKAsync(string appID, int appType, TransactionManager tm_ = null)
		{
			RepairPutAppTypeByPKData(appID, appType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppTypeByPKData(string appID, int appType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppType` = @AppType  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppType(int appType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppType` = @AppType";
			var parameter_ = Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppTypeAsync(int appType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppType` = @AppType";
			var parameter_ = Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppType
		#region PutPromoterType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoterTypeByPK(string appID, int promoterType, TransactionManager tm_ = null)
		{
			RepairPutPromoterTypeByPKData(appID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPromoterTypeByPKAsync(string appID, int promoterType, TransactionManager tm_ = null)
		{
			RepairPutPromoterTypeByPKData(appID, promoterType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPromoterTypeByPKData(string appID, int promoterType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoterType(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPromoterTypeAsync(int promoterType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoterType` = @PromoterType";
			var parameter_ = Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPromoterType
		#region PutServerType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerTypeByPK(string appID, int serverType, TransactionManager tm_ = null)
		{
			RepairPutServerTypeByPKData(appID, serverType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerTypeByPKAsync(string appID, int serverType, TransactionManager tm_ = null)
		{
			RepairPutServerTypeByPKData(appID, serverType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerTypeByPKData(string appID, int serverType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerType` = @ServerType  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerType(int serverType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerType` = @ServerType";
			var parameter_ = Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerTypeAsync(int serverType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerType` = @ServerType";
			var parameter_ = Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerType
		#region PutServerUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrlByPK(string appID, string serverUrl, TransactionManager tm_ = null)
		{
			RepairPutServerUrlByPKData(appID, serverUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerUrlByPKAsync(string appID, string serverUrl, TransactionManager tm_ = null)
		{
			RepairPutServerUrlByPKData(appID, serverUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerUrlByPKData(string appID, string serverUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerUrl` = @ServerUrl  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerUrl", serverUrl != null ? serverUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrl(string serverUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl` = @ServerUrl";
			var parameter_ = Database.CreateInParameter("@ServerUrl", serverUrl != null ? serverUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerUrlAsync(string serverUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl` = @ServerUrl";
			var parameter_ = Database.CreateInParameter("@ServerUrl", serverUrl != null ? serverUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerUrl
		#region PutServerUrl2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrl2ByPK(string appID, string serverUrl2, TransactionManager tm_ = null)
		{
			RepairPutServerUrl2ByPKData(appID, serverUrl2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerUrl2ByPKAsync(string appID, string serverUrl2, TransactionManager tm_ = null)
		{
			RepairPutServerUrl2ByPKData(appID, serverUrl2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerUrl2ByPKData(string appID, string serverUrl2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerUrl2` = @ServerUrl2  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerUrl2", serverUrl2 != null ? serverUrl2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrl2(string serverUrl2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl2` = @ServerUrl2";
			var parameter_ = Database.CreateInParameter("@ServerUrl2", serverUrl2 != null ? serverUrl2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerUrl2Async(string serverUrl2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl2` = @ServerUrl2";
			var parameter_ = Database.CreateInParameter("@ServerUrl2", serverUrl2 != null ? serverUrl2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerUrl2
		#region PutServerUrl3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrl3ByPK(string appID, string serverUrl3, TransactionManager tm_ = null)
		{
			RepairPutServerUrl3ByPKData(appID, serverUrl3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerUrl3ByPKAsync(string appID, string serverUrl3, TransactionManager tm_ = null)
		{
			RepairPutServerUrl3ByPKData(appID, serverUrl3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerUrl3ByPKData(string appID, string serverUrl3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerUrl3` = @ServerUrl3  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerUrl3", serverUrl3 != null ? serverUrl3 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrl3(string serverUrl3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl3` = @ServerUrl3";
			var parameter_ = Database.CreateInParameter("@ServerUrl3", serverUrl3 != null ? serverUrl3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerUrl3Async(string serverUrl3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrl3` = @ServerUrl3";
			var parameter_ = Database.CreateInParameter("@ServerUrl3", serverUrl3 != null ? serverUrl3 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerUrl3
		#region PutServerUrlStaging
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrlStagingByPK(string appID, string serverUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutServerUrlStagingByPKData(appID, serverUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerUrlStagingByPKAsync(string appID, string serverUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutServerUrlStagingByPKData(appID, serverUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerUrlStagingByPKData(string appID, string serverUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerUrlStaging` = @ServerUrlStaging  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging != null ? serverUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrlStaging(string serverUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrlStaging` = @ServerUrlStaging";
			var parameter_ = Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging != null ? serverUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerUrlStagingAsync(string serverUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrlStaging` = @ServerUrlStaging";
			var parameter_ = Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging != null ? serverUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerUrlStaging
		#region PutServerUrlDebug
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrlDebugByPK(string appID, string serverUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutServerUrlDebugByPKData(appID, serverUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutServerUrlDebugByPKAsync(string appID, string serverUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutServerUrlDebugByPKData(appID, serverUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutServerUrlDebugByPKData(string appID, string serverUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ServerUrlDebug` = @ServerUrlDebug  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug != null ? serverUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutServerUrlDebug(string serverUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrlDebug` = @ServerUrlDebug";
			var parameter_ = Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug != null ? serverUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutServerUrlDebugAsync(string serverUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ServerUrlDebug` = @ServerUrlDebug";
			var parameter_ = Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug != null ? serverUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutServerUrlDebug
		#region PutFlowRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowRatioByPK(string appID, float flowRatio, TransactionManager tm_ = null)
		{
			RepairPutFlowRatioByPKData(appID, flowRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowRatioByPKAsync(string appID, float flowRatio, TransactionManager tm_ = null)
		{
			RepairPutFlowRatioByPKData(appID, flowRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowRatioByPKData(string appID, float flowRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowRatio` = @FlowRatio  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowRatio(float flowRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowRatio` = @FlowRatio";
			var parameter_ = Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowRatioAsync(float flowRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowRatio` = @FlowRatio";
			var parameter_ = Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowRatio
		#region PutLangs
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangsByPK(string appID, string langs, TransactionManager tm_ = null)
		{
			RepairPutLangsByPKData(appID, langs, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangsByPKAsync(string appID, string langs, TransactionManager tm_ = null)
		{
			RepairPutLangsByPKData(appID, langs, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangsByPKData(string appID, string langs, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Langs` = @Langs  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Langs", langs != null ? langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangs(string langs, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Langs` = @Langs";
			var parameter_ = Database.CreateInParameter("@Langs", langs != null ? langs : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangsAsync(string langs, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Langs` = @Langs";
			var parameter_ = Database.CreateInParameter("@Langs", langs != null ? langs : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangs
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string appID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(appID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string appID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(appID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string appID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNote(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNoteAsync(string note, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Note` = @Note";
			var parameter_ = Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNote
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string appID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(appID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string appID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(appID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string appID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
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
		#region PutHasJackpot
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasJackpotByPK(string appID, bool hasJackpot, TransactionManager tm_ = null)
		{
			RepairPutHasJackpotByPKData(appID, hasJackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHasJackpotByPKAsync(string appID, bool hasJackpot, TransactionManager tm_ = null)
		{
			RepairPutHasJackpotByPKData(appID, hasJackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHasJackpotByPKData(string appID, bool hasJackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HasJackpot` = @HasJackpot  WHERE `AppID` = @AppID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHasJackpot(bool hasJackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasJackpot` = @HasJackpot";
			var parameter_ = Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHasJackpotAsync(bool hasJackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HasJackpot` = @HasJackpot";
			var parameter_ = Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHasJackpot
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID) == null)
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
		public async Task<bool> SetAsync(S_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID) == null)
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
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_appEO GetByPK(string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<S_appEO> GetByPKAsync(string appID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		public S_appEO GetByAppID(string appID, TransactionManager tm_ = null)
		{
			RepairGetByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<S_appEO> GetByAppIDAsync(string appID, TransactionManager tm_ = null)
		{
			RepairGetByAppIDData(appID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		private void RepairGetByAppIDData(string appID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public S_appEO GetByProviderIDAndProviderAppId(string providerID, string providerAppId, TransactionManager tm_ = null)
		{
			RepairGetByProviderIDAndProviderAppIdData(providerID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<S_appEO> GetByProviderIDAndProviderAppIdAsync(string providerID, string providerAppId, TransactionManager tm_ = null)
		{
			RepairGetByProviderIDAndProviderAppIdData(providerID, providerAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		private void RepairGetByProviderIDAndProviderAppIdData(string providerID, string providerAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`ProviderID` = @ProviderID AND `ProviderAppId` = @ProviderAppId", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderAppId", providerAppId != null ? providerAppId : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderAppId（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderAppIdByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderAppId`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetProviderAppIdByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderAppId`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppName（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppNameByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppName`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetAppNameByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppName`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppType（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetAppTypeByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`AppType`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetAppTypeByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`AppType`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoterType（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPromoterTypeByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PromoterType`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetPromoterTypeByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PromoterType`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerType（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetServerTypeByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ServerType`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetServerTypeByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ServerType`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerUrl（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetServerUrlByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ServerUrl`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetServerUrlByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ServerUrl`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerUrl2（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetServerUrl2ByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ServerUrl2`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetServerUrl2ByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ServerUrl2`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerUrl3（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetServerUrl3ByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ServerUrl3`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetServerUrl3ByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ServerUrl3`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerUrlStaging（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetServerUrlStagingByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ServerUrlStaging`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetServerUrlStagingByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ServerUrlStaging`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ServerUrlDebug（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetServerUrlDebugByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ServerUrlDebug`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetServerUrlDebugByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ServerUrlDebug`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowRatio（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public float GetFlowRatioByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (float)GetScalar("`FlowRatio`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<float> GetFlowRatioByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (float)await GetScalarAsync("`FlowRatio`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Langs（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangsByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Langs`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetLangsByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Langs`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`AppID` = @AppID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HasJackpot（字段）
		/// </summary>
		/// /// <param name = "appID">App编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetHasJackpotByPK(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`HasJackpot`", "`AppID` = @AppID", paras_, tm_);
		}
		public async Task<bool> GetHasJackpotByPKAsync(string appID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`HasJackpot`", "`AppID` = @AppID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, int top_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, string sort_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByProviderAppId
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId)
		{
			return GetByProviderAppId(providerAppId, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId)
		{
			return await GetByProviderAppIdAsync(providerAppId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, TransactionManager tm_)
		{
			return GetByProviderAppId(providerAppId, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, TransactionManager tm_)
		{
			return await GetByProviderAppIdAsync(providerAppId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, int top_)
		{
			return GetByProviderAppId(providerAppId, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, int top_)
		{
			return await GetByProviderAppIdAsync(providerAppId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, int top_, TransactionManager tm_)
		{
			return GetByProviderAppId(providerAppId, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, int top_, TransactionManager tm_)
		{
			return await GetByProviderAppIdAsync(providerAppId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, string sort_)
		{
			return GetByProviderAppId(providerAppId, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, string sort_)
		{
			return await GetByProviderAppIdAsync(providerAppId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, string sort_, TransactionManager tm_)
		{
			return GetByProviderAppId(providerAppId, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, string sort_, TransactionManager tm_)
		{
			return await GetByProviderAppIdAsync(providerAppId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderAppId（字段） 查询
		/// </summary>
		/// /// <param name = "providerAppId">应用提供商的应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByProviderAppId(string providerAppId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerAppId != null ? "`ProviderAppId` = @ProviderAppId" : "`ProviderAppId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerAppId != null)
				paras_.Add(Database.CreateInParameter("@ProviderAppId", providerAppId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByProviderAppIdAsync(string providerAppId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerAppId != null ? "`ProviderAppId` = @ProviderAppId" : "`ProviderAppId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerAppId != null)
				paras_.Add(Database.CreateInParameter("@ProviderAppId", providerAppId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByProviderAppId
		#region GetByAppName
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName)
		{
			return GetByAppName(appName, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName)
		{
			return await GetByAppNameAsync(appName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, TransactionManager tm_)
		{
			return GetByAppName(appName, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, int top_)
		{
			return GetByAppName(appName, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, int top_)
		{
			return await GetByAppNameAsync(appName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, int top_, TransactionManager tm_)
		{
			return GetByAppName(appName, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, int top_, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, string sort_)
		{
			return GetByAppName(appName, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, string sort_)
		{
			return await GetByAppNameAsync(appName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, string sort_, TransactionManager tm_)
		{
			return GetByAppName(appName, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, string sort_, TransactionManager tm_)
		{
			return await GetByAppNameAsync(appName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppName（字段） 查询
		/// </summary>
		/// /// <param name = "appName">App名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppName(string appName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appName != null ? "`AppName` = @AppName" : "`AppName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appName != null)
				paras_.Add(Database.CreateInParameter("@AppName", appName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByAppNameAsync(string appName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appName != null ? "`AppName` = @AppName" : "`AppName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appName != null)
				paras_.Add(Database.CreateInParameter("@AppName", appName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByAppName
		#region GetByAppType
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType)
		{
			return GetByAppType(appType, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType)
		{
			return await GetByAppTypeAsync(appType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, TransactionManager tm_)
		{
			return GetByAppType(appType, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, TransactionManager tm_)
		{
			return await GetByAppTypeAsync(appType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, int top_)
		{
			return GetByAppType(appType, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, int top_)
		{
			return await GetByAppTypeAsync(appType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, int top_, TransactionManager tm_)
		{
			return GetByAppType(appType, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, int top_, TransactionManager tm_)
		{
			return await GetByAppTypeAsync(appType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, string sort_)
		{
			return GetByAppType(appType, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, string sort_)
		{
			return await GetByAppTypeAsync(appType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, string sort_, TransactionManager tm_)
		{
			return GetByAppType(appType, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, string sort_, TransactionManager tm_)
		{
			return await GetByAppTypeAsync(appType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppType（字段） 查询
		/// </summary>
		/// /// <param name = "appType">App类型1-大厅2-游戏3-应用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByAppType(int appType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppType` = @AppType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByAppTypeAsync(int appType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppType` = @AppType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppType", appType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByAppType
		#region GetByPromoterType
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, int top_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, int top_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, int top_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, int top_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, string sort_)
		{
			return GetByPromoterType(promoterType, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, string sort_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, string sort_, TransactionManager tm_)
		{
			return GetByPromoterType(promoterType, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, string sort_, TransactionManager tm_)
		{
			return await GetByPromoterTypeAsync(promoterType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromoterType（字段） 查询
		/// </summary>
		/// /// <param name = "promoterType">推广类型1-棋牌2-电子3-捕鱼4-真人5-彩票6-体育</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByPromoterType(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByPromoterTypeAsync(int promoterType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoterType` = @PromoterType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoterType", promoterType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByPromoterType
		#region GetByServerType
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType)
		{
			return GetByServerType(serverType, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType)
		{
			return await GetByServerTypeAsync(serverType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, TransactionManager tm_)
		{
			return GetByServerType(serverType, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, TransactionManager tm_)
		{
			return await GetByServerTypeAsync(serverType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, int top_)
		{
			return GetByServerType(serverType, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, int top_)
		{
			return await GetByServerTypeAsync(serverType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, int top_, TransactionManager tm_)
		{
			return GetByServerType(serverType, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, int top_, TransactionManager tm_)
		{
			return await GetByServerTypeAsync(serverType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, string sort_)
		{
			return GetByServerType(serverType, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, string sort_)
		{
			return await GetByServerTypeAsync(serverType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, string sort_, TransactionManager tm_)
		{
			return GetByServerType(serverType, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, string sort_, TransactionManager tm_)
		{
			return await GetByServerTypeAsync(serverType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerType（字段） 查询
		/// </summary>
		/// /// <param name = "serverType">app服务端类型0-未知1-api2-websocket</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerType(int serverType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ServerType` = @ServerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerTypeAsync(int serverType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ServerType` = @ServerType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ServerType", serverType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerType
		#region GetByServerUrl
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl)
		{
			return GetByServerUrl(serverUrl, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl)
		{
			return await GetByServerUrlAsync(serverUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, TransactionManager tm_)
		{
			return GetByServerUrl(serverUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, TransactionManager tm_)
		{
			return await GetByServerUrlAsync(serverUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, int top_)
		{
			return GetByServerUrl(serverUrl, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, int top_)
		{
			return await GetByServerUrlAsync(serverUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, int top_, TransactionManager tm_)
		{
			return GetByServerUrl(serverUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, int top_, TransactionManager tm_)
		{
			return await GetByServerUrlAsync(serverUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, string sort_)
		{
			return GetByServerUrl(serverUrl, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, string sort_)
		{
			return await GetByServerUrlAsync(serverUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, string sort_, TransactionManager tm_)
		{
			return GetByServerUrl(serverUrl, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, string sort_, TransactionManager tm_)
		{
			return await GetByServerUrlAsync(serverUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl">应用服务端线上URL（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl(string serverUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl != null ? "`ServerUrl` = @ServerUrl" : "`ServerUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl", serverUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerUrlAsync(string serverUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl != null ? "`ServerUrl` = @ServerUrl" : "`ServerUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl", serverUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerUrl
		#region GetByServerUrl2
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2)
		{
			return GetByServerUrl2(serverUrl2, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2)
		{
			return await GetByServerUrl2Async(serverUrl2, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, TransactionManager tm_)
		{
			return GetByServerUrl2(serverUrl2, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, TransactionManager tm_)
		{
			return await GetByServerUrl2Async(serverUrl2, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, int top_)
		{
			return GetByServerUrl2(serverUrl2, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, int top_)
		{
			return await GetByServerUrl2Async(serverUrl2, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, int top_, TransactionManager tm_)
		{
			return GetByServerUrl2(serverUrl2, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, int top_, TransactionManager tm_)
		{
			return await GetByServerUrl2Async(serverUrl2, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, string sort_)
		{
			return GetByServerUrl2(serverUrl2, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, string sort_)
		{
			return await GetByServerUrl2Async(serverUrl2, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, string sort_, TransactionManager tm_)
		{
			return GetByServerUrl2(serverUrl2, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, string sort_, TransactionManager tm_)
		{
			return await GetByServerUrl2Async(serverUrl2, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl2（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl2">应用服务端线上URL2（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl2(string serverUrl2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl2 != null ? "`ServerUrl2` = @ServerUrl2" : "`ServerUrl2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl2 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl2", serverUrl2, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerUrl2Async(string serverUrl2, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl2 != null ? "`ServerUrl2` = @ServerUrl2" : "`ServerUrl2` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl2 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl2", serverUrl2, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerUrl2
		#region GetByServerUrl3
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3)
		{
			return GetByServerUrl3(serverUrl3, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3)
		{
			return await GetByServerUrl3Async(serverUrl3, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, TransactionManager tm_)
		{
			return GetByServerUrl3(serverUrl3, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, TransactionManager tm_)
		{
			return await GetByServerUrl3Async(serverUrl3, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, int top_)
		{
			return GetByServerUrl3(serverUrl3, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, int top_)
		{
			return await GetByServerUrl3Async(serverUrl3, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, int top_, TransactionManager tm_)
		{
			return GetByServerUrl3(serverUrl3, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, int top_, TransactionManager tm_)
		{
			return await GetByServerUrl3Async(serverUrl3, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, string sort_)
		{
			return GetByServerUrl3(serverUrl3, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, string sort_)
		{
			return await GetByServerUrl3Async(serverUrl3, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, string sort_, TransactionManager tm_)
		{
			return GetByServerUrl3(serverUrl3, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, string sort_, TransactionManager tm_)
		{
			return await GetByServerUrl3Async(serverUrl3, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrl3（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrl3">应用服务端线上URL3（仅api game需要配置）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrl3(string serverUrl3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl3 != null ? "`ServerUrl3` = @ServerUrl3" : "`ServerUrl3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl3 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl3", serverUrl3, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerUrl3Async(string serverUrl3, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrl3 != null ? "`ServerUrl3` = @ServerUrl3" : "`ServerUrl3` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrl3 != null)
				paras_.Add(Database.CreateInParameter("@ServerUrl3", serverUrl3, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerUrl3
		#region GetByServerUrlStaging
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging)
		{
			return GetByServerUrlStaging(serverUrlStaging, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, TransactionManager tm_)
		{
			return GetByServerUrlStaging(serverUrlStaging, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, TransactionManager tm_)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, int top_)
		{
			return GetByServerUrlStaging(serverUrlStaging, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, int top_)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByServerUrlStaging(serverUrlStaging, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, int top_, TransactionManager tm_)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, string sort_)
		{
			return GetByServerUrlStaging(serverUrlStaging, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, string sort_)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByServerUrlStaging(serverUrlStaging, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, string sort_, TransactionManager tm_)
		{
			return await GetByServerUrlStagingAsync(serverUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlStaging">应用服务端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlStaging(string serverUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrlStaging != null ? "`ServerUrlStaging` = @ServerUrlStaging" : "`ServerUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerUrlStagingAsync(string serverUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrlStaging != null ? "`ServerUrlStaging` = @ServerUrlStaging" : "`ServerUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlStaging", serverUrlStaging, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerUrlStaging
		#region GetByServerUrlDebug
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug)
		{
			return GetByServerUrlDebug(serverUrlDebug, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, TransactionManager tm_)
		{
			return GetByServerUrlDebug(serverUrlDebug, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, TransactionManager tm_)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, int top_)
		{
			return GetByServerUrlDebug(serverUrlDebug, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, int top_)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByServerUrlDebug(serverUrlDebug, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, int top_, TransactionManager tm_)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, string sort_)
		{
			return GetByServerUrlDebug(serverUrlDebug, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, string sort_)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByServerUrlDebug(serverUrlDebug, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, string sort_, TransactionManager tm_)
		{
			return await GetByServerUrlDebugAsync(serverUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ServerUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "serverUrlDebug">应用服务端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByServerUrlDebug(string serverUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrlDebug != null ? "`ServerUrlDebug` = @ServerUrlDebug" : "`ServerUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByServerUrlDebugAsync(string serverUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(serverUrlDebug != null ? "`ServerUrlDebug` = @ServerUrlDebug" : "`ServerUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (serverUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ServerUrlDebug", serverUrlDebug, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByServerUrlDebug
		#region GetByFlowRatio
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio)
		{
			return GetByFlowRatio(flowRatio, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio)
		{
			return await GetByFlowRatioAsync(flowRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, TransactionManager tm_)
		{
			return GetByFlowRatio(flowRatio, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, TransactionManager tm_)
		{
			return await GetByFlowRatioAsync(flowRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, int top_)
		{
			return GetByFlowRatio(flowRatio, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, int top_)
		{
			return await GetByFlowRatioAsync(flowRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, int top_, TransactionManager tm_)
		{
			return GetByFlowRatio(flowRatio, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, int top_, TransactionManager tm_)
		{
			return await GetByFlowRatioAsync(flowRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, string sort_)
		{
			return GetByFlowRatio(flowRatio, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, string sort_)
		{
			return await GetByFlowRatioAsync(flowRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, string sort_, TransactionManager tm_)
		{
			return GetByFlowRatio(flowRatio, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, string sort_, TransactionManager tm_)
		{
			return await GetByFlowRatioAsync(flowRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowRatio（字段） 查询
		/// </summary>
		/// /// <param name = "flowRatio">流水bet计算比率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByFlowRatio(float flowRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowRatio` = @FlowRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByFlowRatioAsync(float flowRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowRatio` = @FlowRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowRatio", flowRatio, MySqlDbType.Float));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByFlowRatio
		#region GetByLangs
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs)
		{
			return GetByLangs(langs, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs)
		{
			return await GetByLangsAsync(langs, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, int top_)
		{
			return GetByLangs(langs, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, int top_)
		{
			return await GetByLangsAsync(langs, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, int top_, TransactionManager tm_)
		{
			return GetByLangs(langs, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, int top_, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, string sort_)
		{
			return GetByLangs(langs, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, string sort_)
		{
			return await GetByLangsAsync(langs, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, string sort_, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, string sort_, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">App支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByLangs(string langs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langs != null ? "`Langs` = @Langs" : "`Langs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langs != null)
				paras_.Add(Database.CreateInParameter("@Langs", langs, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByLangsAsync(string langs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langs != null ? "`Langs` = @Langs" : "`Langs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langs != null)
				paras_.Add(Database.CreateInParameter("@Langs", langs, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByLangs
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, int top_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, string sort_)
		{
			return await GetByNoteAsync(note, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByHasJackpot
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot)
		{
			return GetByHasJackpot(hasJackpot, 0, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot)
		{
			return await GetByHasJackpotAsync(hasJackpot, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, TransactionManager tm_)
		{
			return GetByHasJackpot(hasJackpot, 0, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, TransactionManager tm_)
		{
			return await GetByHasJackpotAsync(hasJackpot, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, int top_)
		{
			return GetByHasJackpot(hasJackpot, top_, string.Empty, null);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, int top_)
		{
			return await GetByHasJackpotAsync(hasJackpot, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, int top_, TransactionManager tm_)
		{
			return GetByHasJackpot(hasJackpot, top_, string.Empty, tm_);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, int top_, TransactionManager tm_)
		{
			return await GetByHasJackpotAsync(hasJackpot, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, string sort_)
		{
			return GetByHasJackpot(hasJackpot, 0, sort_, null);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, string sort_)
		{
			return await GetByHasJackpotAsync(hasJackpot, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, string sort_, TransactionManager tm_)
		{
			return GetByHasJackpot(hasJackpot, 0, sort_, tm_);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, string sort_, TransactionManager tm_)
		{
			return await GetByHasJackpotAsync(hasJackpot, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HasJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "hasJackpot">是否有Jackpot</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_appEO> GetByHasJackpot(bool hasJackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasJackpot` = @HasJackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		public async Task<List<S_appEO>> GetByHasJackpotAsync(bool hasJackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HasJackpot` = @HasJackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HasJackpot", hasJackpot, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_appEO.MapDataReader);
		}
		#endregion // GetByHasJackpot
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
