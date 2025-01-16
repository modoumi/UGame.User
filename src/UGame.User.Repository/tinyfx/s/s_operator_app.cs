/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:57
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
	/// 
	/// 【表 s_operator_app 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_operator_appEO : IRowMapper<S_operator_appEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_operator_appEO()
		{
			this.UseBonus = false;
			this.CashLimit = 0;
			this.PayLimit = 0;
			this.Status = 0;
			this.EffectStatus = 0;
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
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "AppID", AppID },  { "OperatorID", OperatorID }, };
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
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 对应的运营商应用编码
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorAppId { get; set; }
		/// <summary>
		/// 是否使用bonus
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 4)]
		public bool UseBonus { get; set; }
		/// <summary>
		/// 进入游戏cash最小数量限制0-不限制
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int CashLimit { get; set; }
		/// <summary>
		/// 进入游戏充值最小数量限制0-不限制
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int PayLimit { get; set; }
		/// <summary>
		/// 支持的活动ID集合，|分割，如: 100001|100002
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 7)]
		public string ActivityIds { get; set; }
		/// <summary>
		/// 应用客户端线上URL
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string AppUrl { get; set; }
		/// <summary>
		/// 应用客户端仿真URL
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 9)]
		public string AppUrlStaging { get; set; }
		/// <summary>
		/// 应用客户端联调URL
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 10)]
		public string AppUrlDebug { get; set; }
		/// <summary>
		/// 状态0-无效1-在线2-维护中3-测试中
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Status { get; set; }
		/// <summary>
		/// 游戏入口效果标识Flag值 
		/// 0-无 
		/// 1-Hot
		/// 2-New
		/// 4-UseBonus
		/// 8-闪光效果
		/// 可用值0、1、2、4、8、9、10、12，其他值为非法值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int EffectStatus { get; set; }
		/// <summary>
		/// 
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 13)]
		public string OperatorThumb { get; set; }
		/// <summary>
		/// 游戏背景图url
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 14)]
		public string OperatorBg { get; set; }
		/// <summary>
		/// 游戏回合url
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 15)]
		public string OperatorRoundUrl { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_operator_appEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_operator_appEO MapDataReader(IDataReader reader)
		{
		    S_operator_appEO ret = new S_operator_appEO();
			ret.AppID = reader.ToString("AppID");
			ret.OriginalAppID = ret.AppID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.OperatorAppId = reader.ToString("OperatorAppId");
			ret.UseBonus = reader.ToBoolean("UseBonus");
			ret.CashLimit = reader.ToInt32("CashLimit");
			ret.PayLimit = reader.ToInt32("PayLimit");
			ret.ActivityIds = reader.ToString("ActivityIds");
			ret.AppUrl = reader.ToString("AppUrl");
			ret.AppUrlStaging = reader.ToString("AppUrlStaging");
			ret.AppUrlDebug = reader.ToString("AppUrlDebug");
			ret.Status = reader.ToInt32("Status");
			ret.EffectStatus = reader.ToInt32("EffectStatus");
			ret.OperatorThumb = reader.ToString("OperatorThumb");
			ret.OperatorBg = reader.ToString("OperatorBg");
			ret.OperatorRoundUrl = reader.ToString("OperatorRoundUrl");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 s_operator_app 的操作类】
	/// </summary>
	[Obsolete]
	public class S_operator_appMO : MySqlTableMO<S_operator_appEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_operator_app`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_operator_appMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_operator_appMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_operator_appMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_operator_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_operator_appEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_operator_appEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`AppID`, `OperatorID`, `OperatorAppId`, `UseBonus`, `CashLimit`, `PayLimit`, `ActivityIds`, `AppUrl`, `AppUrlStaging`, `AppUrlDebug`, `Status`, `EffectStatus`, `OperatorThumb`, `OperatorBg`, `OperatorRoundUrl`) VALUE (@AppID, @OperatorID, @OperatorAppId, @UseBonus, @CashLimit, @PayLimit, @ActivityIds, @AppUrl, @AppUrlStaging, @AppUrlDebug, @Status, @EffectStatus, @OperatorThumb, @OperatorBg, @OperatorRoundUrl);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorAppId", item.OperatorAppId != null ? item.OperatorAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UseBonus", item.UseBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@CashLimit", item.CashLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@PayLimit", item.PayLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityIds", item.ActivityIds != null ? item.ActivityIds : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrl", item.AppUrl != null ? item.AppUrl : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrlStaging", item.AppUrlStaging != null ? item.AppUrlStaging : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrlDebug", item.AppUrlDebug != null ? item.AppUrlDebug : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@EffectStatus", item.EffectStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorThumb", item.OperatorThumb != null ? item.OperatorThumb : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBg", item.OperatorBg != null ? item.OperatorBg : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorRoundUrl", item.OperatorRoundUrl != null ? item.OperatorRoundUrl : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<S_operator_appEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_operator_appEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_operator_appEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`AppID`, `OperatorID`, `OperatorAppId`, `UseBonus`, `CashLimit`, `PayLimit`, `ActivityIds`, `AppUrl`, `AppUrlStaging`, `AppUrlDebug`, `Status`, `EffectStatus`, `OperatorThumb`, `OperatorBg`, `OperatorRoundUrl`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.AppID}','{item.OperatorID}','{item.OperatorAppId}',{item.UseBonus},{item.CashLimit},{item.PayLimit},'{item.ActivityIds}','{item.AppUrl}','{item.AppUrlStaging}','{item.AppUrlDebug}',{item.Status},{item.EffectStatus},'{item.OperatorThumb}','{item.OperatorBg}','{item.OperatorRoundUrl}'),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(appID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string appID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_operator_appEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.AppID, item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(S_operator_appEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.AppID, item.OperatorID, tm_);
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
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByOperatorAppId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorAppId(string operatorAppId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorAppIdData(operatorAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorAppIdAsync(string operatorAppId, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorAppIdData(operatorAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorAppIdData(string operatorAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorAppId != null ? "`OperatorAppId` = @OperatorAppId" : "`OperatorAppId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorAppId != null)
				paras_.Add(Database.CreateInParameter("@OperatorAppId", operatorAppId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorAppId
		#region RemoveByUseBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUseBonus(bool useBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByUseBonusData(useBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUseBonusAsync(bool useBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByUseBonusData(useBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUseBonusData(bool useBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UseBonus` = @UseBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte));
		}
		#endregion // RemoveByUseBonus
		#region RemoveByCashLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashLimit(int cashLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByCashLimitData(cashLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashLimitAsync(int cashLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByCashLimitData(cashLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashLimitData(int cashLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashLimit` = @CashLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashLimit
		#region RemoveByPayLimit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayLimit(int payLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByPayLimitData(payLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayLimitAsync(int payLimit, TransactionManager tm_ = null)
		{
			RepairRemoveByPayLimitData(payLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayLimitData(int payLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayLimit` = @PayLimit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32));
		}
		#endregion // RemoveByPayLimit
		#region RemoveByActivityIds
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByActivityIds(string activityIds, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIdsData(activityIds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByActivityIdsAsync(string activityIds, TransactionManager tm_ = null)
		{
			RepairRemoveByActivityIdsData(activityIds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByActivityIdsData(string activityIds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (activityIds != null ? "`ActivityIds` = @ActivityIds" : "`ActivityIds` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (activityIds != null)
				paras_.Add(Database.CreateInParameter("@ActivityIds", activityIds, MySqlDbType.Text));
		}
		#endregion // RemoveByActivityIds
		#region RemoveByAppUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppUrl(string appUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlData(appUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppUrlAsync(string appUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlData(appUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppUrlData(string appUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appUrl != null ? "`AppUrl` = @AppUrl" : "`AppUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appUrl != null)
				paras_.Add(Database.CreateInParameter("@AppUrl", appUrl, MySqlDbType.Text));
		}
		#endregion // RemoveByAppUrl
		#region RemoveByAppUrlStaging
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppUrlStaging(string appUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlStagingData(appUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppUrlStagingAsync(string appUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlStagingData(appUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppUrlStagingData(string appUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appUrlStaging != null ? "`AppUrlStaging` = @AppUrlStaging" : "`AppUrlStaging` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@AppUrlStaging", appUrlStaging, MySqlDbType.Text));
		}
		#endregion // RemoveByAppUrlStaging
		#region RemoveByAppUrlDebug
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAppUrlDebug(string appUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlDebugData(appUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAppUrlDebugAsync(string appUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByAppUrlDebugData(appUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAppUrlDebugData(string appUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (appUrlDebug != null ? "`AppUrlDebug` = @AppUrlDebug" : "`AppUrlDebug` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (appUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@AppUrlDebug", appUrlDebug, MySqlDbType.Text));
		}
		#endregion // RemoveByAppUrlDebug
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
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
		#region RemoveByEffectStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEffectStatus(int effectStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByEffectStatusData(effectStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEffectStatusAsync(int effectStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByEffectStatusData(effectStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEffectStatusData(int effectStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EffectStatus` = @EffectStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByEffectStatus
		#region RemoveByOperatorThumb
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorThumb(string operatorThumb, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorThumbData(operatorThumb, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorThumbAsync(string operatorThumb, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorThumbData(operatorThumb, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorThumbData(string operatorThumb, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorThumb != null ? "`OperatorThumb` = @OperatorThumb" : "`OperatorThumb` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorThumb != null)
				paras_.Add(Database.CreateInParameter("@OperatorThumb", operatorThumb, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorThumb
		#region RemoveByOperatorBg
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorBg(string operatorBg, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorBgData(operatorBg, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorBgAsync(string operatorBg, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorBgData(operatorBg, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorBgData(string operatorBg, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorBg != null ? "`OperatorBg` = @OperatorBg" : "`OperatorBg` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorBg != null)
				paras_.Add(Database.CreateInParameter("@OperatorBg", operatorBg, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorBg
		#region RemoveByOperatorRoundUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorRoundUrl(string operatorRoundUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorRoundUrlData(operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorRoundUrlAsync(string operatorRoundUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorRoundUrlData(operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorRoundUrlData(string operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorRoundUrl != null ? "`OperatorRoundUrl` = @OperatorRoundUrl" : "`OperatorRoundUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorRoundUrl != null)
				paras_.Add(Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorRoundUrl
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
		public int Put(S_operator_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_operator_appEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_operator_appEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppID` = @AppID, `OperatorID` = @OperatorID, `OperatorAppId` = @OperatorAppId, `UseBonus` = @UseBonus, `CashLimit` = @CashLimit, `PayLimit` = @PayLimit, `ActivityIds` = @ActivityIds, `AppUrl` = @AppUrl, `AppUrlStaging` = @AppUrlStaging, `AppUrlDebug` = @AppUrlDebug, `Status` = @Status, `EffectStatus` = @EffectStatus, `OperatorThumb` = @OperatorThumb, `OperatorBg` = @OperatorBg, `OperatorRoundUrl` = @OperatorRoundUrl WHERE `AppID` = @AppID_Original AND `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorAppId", item.OperatorAppId != null ? item.OperatorAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UseBonus", item.UseBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@CashLimit", item.CashLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@PayLimit", item.PayLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@ActivityIds", item.ActivityIds != null ? item.ActivityIds : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrl", item.AppUrl != null ? item.AppUrl : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrlStaging", item.AppUrlStaging != null ? item.AppUrlStaging : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppUrlDebug", item.AppUrlDebug != null ? item.AppUrlDebug : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@EffectStatus", item.EffectStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorThumb", item.OperatorThumb != null ? item.OperatorThumb : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBg", item.OperatorBg != null ? item.OperatorBg : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorRoundUrl", item.OperatorRoundUrl != null ? item.OperatorRoundUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID_Original", item.HasOriginal ? item.OriginalAppID : item.AppID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_operator_appEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_operator_appEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", ConcatValues(values_, appID, operatorID));
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", ConcatValues(values_, appID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, appID, operatorID));
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", tm_, ConcatValues(values_, appID, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string appID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string appID, string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`AppID` = @AppID AND `OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
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
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutOperatorAppId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorAppIdByPK(string appID, string operatorID, string operatorAppId, TransactionManager tm_ = null)
		{
			RepairPutOperatorAppIdByPKData(appID, operatorID, operatorAppId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorAppIdByPKAsync(string appID, string operatorID, string operatorAppId, TransactionManager tm_ = null)
		{
			RepairPutOperatorAppIdByPKData(appID, operatorID, operatorAppId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorAppIdByPKData(string appID, string operatorID, string operatorAppId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorAppId` = @OperatorAppId  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorAppId", operatorAppId != null ? operatorAppId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorAppId(string operatorAppId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorAppId` = @OperatorAppId";
			var parameter_ = Database.CreateInParameter("@OperatorAppId", operatorAppId != null ? operatorAppId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorAppIdAsync(string operatorAppId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorAppId` = @OperatorAppId";
			var parameter_ = Database.CreateInParameter("@OperatorAppId", operatorAppId != null ? operatorAppId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorAppId
		#region PutUseBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUseBonusByPK(string appID, string operatorID, bool useBonus, TransactionManager tm_ = null)
		{
			RepairPutUseBonusByPKData(appID, operatorID, useBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUseBonusByPKAsync(string appID, string operatorID, bool useBonus, TransactionManager tm_ = null)
		{
			RepairPutUseBonusByPKData(appID, operatorID, useBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUseBonusByPKData(string appID, string operatorID, bool useBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UseBonus` = @UseBonus  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUseBonus(bool useBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UseBonus` = @UseBonus";
			var parameter_ = Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUseBonusAsync(bool useBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UseBonus` = @UseBonus";
			var parameter_ = Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUseBonus
		#region PutCashLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashLimitByPK(string appID, string operatorID, int cashLimit, TransactionManager tm_ = null)
		{
			RepairPutCashLimitByPKData(appID, operatorID, cashLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashLimitByPKAsync(string appID, string operatorID, int cashLimit, TransactionManager tm_ = null)
		{
			RepairPutCashLimitByPKData(appID, operatorID, cashLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashLimitByPKData(string appID, string operatorID, int cashLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashLimit` = @CashLimit  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashLimit(int cashLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashLimit` = @CashLimit";
			var parameter_ = Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashLimitAsync(int cashLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashLimit` = @CashLimit";
			var parameter_ = Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashLimit
		#region PutPayLimit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayLimitByPK(string appID, string operatorID, int payLimit, TransactionManager tm_ = null)
		{
			RepairPutPayLimitByPKData(appID, operatorID, payLimit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayLimitByPKAsync(string appID, string operatorID, int payLimit, TransactionManager tm_ = null)
		{
			RepairPutPayLimitByPKData(appID, operatorID, payLimit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayLimitByPKData(string appID, string operatorID, int payLimit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayLimit` = @PayLimit  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayLimit(int payLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayLimit` = @PayLimit";
			var parameter_ = Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayLimitAsync(int payLimit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayLimit` = @PayLimit";
			var parameter_ = Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayLimit
		#region PutActivityIds
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityIdsByPK(string appID, string operatorID, string activityIds, TransactionManager tm_ = null)
		{
			RepairPutActivityIdsByPKData(appID, operatorID, activityIds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutActivityIdsByPKAsync(string appID, string operatorID, string activityIds, TransactionManager tm_ = null)
		{
			RepairPutActivityIdsByPKData(appID, operatorID, activityIds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutActivityIdsByPKData(string appID, string operatorID, string activityIds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ActivityIds` = @ActivityIds  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ActivityIds", activityIds != null ? activityIds : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutActivityIds(string activityIds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityIds` = @ActivityIds";
			var parameter_ = Database.CreateInParameter("@ActivityIds", activityIds != null ? activityIds : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutActivityIdsAsync(string activityIds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ActivityIds` = @ActivityIds";
			var parameter_ = Database.CreateInParameter("@ActivityIds", activityIds != null ? activityIds : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutActivityIds
		#region PutAppUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrlByPK(string appID, string operatorID, string appUrl, TransactionManager tm_ = null)
		{
			RepairPutAppUrlByPKData(appID, operatorID, appUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppUrlByPKAsync(string appID, string operatorID, string appUrl, TransactionManager tm_ = null)
		{
			RepairPutAppUrlByPKData(appID, operatorID, appUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppUrlByPKData(string appID, string operatorID, string appUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppUrl` = @AppUrl  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppUrl", appUrl != null ? appUrl : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrl(string appUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrl` = @AppUrl";
			var parameter_ = Database.CreateInParameter("@AppUrl", appUrl != null ? appUrl : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppUrlAsync(string appUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrl` = @AppUrl";
			var parameter_ = Database.CreateInParameter("@AppUrl", appUrl != null ? appUrl : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppUrl
		#region PutAppUrlStaging
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrlStagingByPK(string appID, string operatorID, string appUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutAppUrlStagingByPKData(appID, operatorID, appUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppUrlStagingByPKAsync(string appID, string operatorID, string appUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutAppUrlStagingByPKData(appID, operatorID, appUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppUrlStagingByPKData(string appID, string operatorID, string appUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppUrlStaging` = @AppUrlStaging  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppUrlStaging", appUrlStaging != null ? appUrlStaging : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrlStaging(string appUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrlStaging` = @AppUrlStaging";
			var parameter_ = Database.CreateInParameter("@AppUrlStaging", appUrlStaging != null ? appUrlStaging : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppUrlStagingAsync(string appUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrlStaging` = @AppUrlStaging";
			var parameter_ = Database.CreateInParameter("@AppUrlStaging", appUrlStaging != null ? appUrlStaging : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppUrlStaging
		#region PutAppUrlDebug
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrlDebugByPK(string appID, string operatorID, string appUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutAppUrlDebugByPKData(appID, operatorID, appUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAppUrlDebugByPKAsync(string appID, string operatorID, string appUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutAppUrlDebugByPKData(appID, operatorID, appUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAppUrlDebugByPKData(string appID, string operatorID, string appUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AppUrlDebug` = @AppUrlDebug  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppUrlDebug", appUrlDebug != null ? appUrlDebug : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAppUrlDebug(string appUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrlDebug` = @AppUrlDebug";
			var parameter_ = Database.CreateInParameter("@AppUrlDebug", appUrlDebug != null ? appUrlDebug : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAppUrlDebugAsync(string appUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AppUrlDebug` = @AppUrlDebug";
			var parameter_ = Database.CreateInParameter("@AppUrlDebug", appUrlDebug != null ? appUrlDebug : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAppUrlDebug
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string appID, string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(appID, operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string appID, string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(appID, operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string appID, string operatorID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
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
		#region PutEffectStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEffectStatusByPK(string appID, string operatorID, int effectStatus, TransactionManager tm_ = null)
		{
			RepairPutEffectStatusByPKData(appID, operatorID, effectStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEffectStatusByPKAsync(string appID, string operatorID, int effectStatus, TransactionManager tm_ = null)
		{
			RepairPutEffectStatusByPKData(appID, operatorID, effectStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEffectStatusByPKData(string appID, string operatorID, int effectStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EffectStatus` = @EffectStatus  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEffectStatus(int effectStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EffectStatus` = @EffectStatus";
			var parameter_ = Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEffectStatusAsync(int effectStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EffectStatus` = @EffectStatus";
			var parameter_ = Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEffectStatus
		#region PutOperatorThumb
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "operatorThumb"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorThumbByPK(string appID, string operatorID, string operatorThumb, TransactionManager tm_ = null)
		{
			RepairPutOperatorThumbByPKData(appID, operatorID, operatorThumb, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorThumbByPKAsync(string appID, string operatorID, string operatorThumb, TransactionManager tm_ = null)
		{
			RepairPutOperatorThumbByPKData(appID, operatorID, operatorThumb, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorThumbByPKData(string appID, string operatorID, string operatorThumb, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorThumb` = @OperatorThumb  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorThumb", operatorThumb != null ? operatorThumb : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorThumb(string operatorThumb, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorThumb` = @OperatorThumb";
			var parameter_ = Database.CreateInParameter("@OperatorThumb", operatorThumb != null ? operatorThumb : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorThumbAsync(string operatorThumb, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorThumb` = @OperatorThumb";
			var parameter_ = Database.CreateInParameter("@OperatorThumb", operatorThumb != null ? operatorThumb : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorThumb
		#region PutOperatorBg
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorBgByPK(string appID, string operatorID, string operatorBg, TransactionManager tm_ = null)
		{
			RepairPutOperatorBgByPKData(appID, operatorID, operatorBg, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorBgByPKAsync(string appID, string operatorID, string operatorBg, TransactionManager tm_ = null)
		{
			RepairPutOperatorBgByPKData(appID, operatorID, operatorBg, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorBgByPKData(string appID, string operatorID, string operatorBg, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorBg` = @OperatorBg  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBg", operatorBg != null ? operatorBg : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorBg(string operatorBg, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorBg` = @OperatorBg";
			var parameter_ = Database.CreateInParameter("@OperatorBg", operatorBg != null ? operatorBg : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorBgAsync(string operatorBg, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorBg` = @OperatorBg";
			var parameter_ = Database.CreateInParameter("@OperatorBg", operatorBg != null ? operatorBg : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorBg
		#region PutOperatorRoundUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorRoundUrlByPK(string appID, string operatorID, string operatorRoundUrl, TransactionManager tm_ = null)
		{
			RepairPutOperatorRoundUrlByPKData(appID, operatorID, operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorRoundUrlByPKAsync(string appID, string operatorID, string operatorRoundUrl, TransactionManager tm_ = null)
		{
			RepairPutOperatorRoundUrlByPKData(appID, operatorID, operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorRoundUrlByPKData(string appID, string operatorID, string operatorRoundUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorRoundUrl` = @OperatorRoundUrl  WHERE `AppID` = @AppID AND `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl != null ? operatorRoundUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorRoundUrl(string operatorRoundUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorRoundUrl` = @OperatorRoundUrl";
			var parameter_ = Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl != null ? operatorRoundUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorRoundUrlAsync(string operatorRoundUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorRoundUrl` = @OperatorRoundUrl";
			var parameter_ = Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl != null ? operatorRoundUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorRoundUrl
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_operator_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.OperatorID) == null)
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
		public async Task<bool> SetAsync(S_operator_appEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.AppID, item.OperatorID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_operator_appEO GetByPK(string appID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<S_operator_appEO> GetByPKAsync(string appID, string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(appID, operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		private void RepairGetByPKData(string appID, string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`AppID` = @AppID AND `OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 AppID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppIDByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetAppIDByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorAppId（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorAppIdByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorAppId`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorAppIdByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorAppId`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UseBonus（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetUseBonusByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`UseBonus`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<bool> GetUseBonusByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`UseBonus`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashLimit（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashLimitByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CashLimit`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetCashLimitByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CashLimit`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayLimit（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPayLimitByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PayLimit`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetPayLimitByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PayLimit`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ActivityIds（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetActivityIdsByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ActivityIds`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetActivityIdsByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ActivityIds`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppUrl（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppUrlByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppUrl`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetAppUrlByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppUrl`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppUrlStaging（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppUrlStagingByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppUrlStaging`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetAppUrlStagingByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppUrlStaging`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AppUrlDebug（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAppUrlDebugByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AppUrlDebug`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetAppUrlDebugByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AppUrlDebug`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EffectStatus（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetEffectStatusByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`EffectStatus`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetEffectStatusByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`EffectStatus`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorThumb（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorThumbByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorThumb`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorThumbByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorThumb`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorBg（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorBgByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorBg`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorBgByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorBg`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorRoundUrl（字段）
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorRoundUrlByPK(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorRoundUrl`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorRoundUrlByPKAsync(string appID, string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorRoundUrl`", "`AppID` = @AppID AND `OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByAppID
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppID(string appID)
		{
			return GetByAppID(appID, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppID(string appID, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppID(string appID, int top_)
		{
			return GetByAppID(appID, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, int top_)
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
		public List<S_operator_appEO> GetByAppID(string appID, int top_, TransactionManager tm_)
		{
			return GetByAppID(appID, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, int top_, TransactionManager tm_)
		{
			return await GetByAppIDAsync(appID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppID（字段） 查询
		/// </summary>
		/// /// <param name = "appID">应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppID(string appID, string sort_)
		{
			return GetByAppID(appID, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, string sort_)
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
		public List<S_operator_appEO> GetByAppID(string appID, string sort_, TransactionManager tm_)
		{
			return GetByAppID(appID, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, string sort_, TransactionManager tm_)
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
		public List<S_operator_appEO> GetByAppID(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByAppIDAsync(string appID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AppID` = @AppID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AppID", appID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByAppID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_operator_appEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_operator_appEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_operator_appEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByOperatorAppId
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId)
		{
			return GetByOperatorAppId(operatorAppId, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, TransactionManager tm_)
		{
			return GetByOperatorAppId(operatorAppId, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, TransactionManager tm_)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, int top_)
		{
			return GetByOperatorAppId(operatorAppId, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, int top_)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, int top_, TransactionManager tm_)
		{
			return GetByOperatorAppId(operatorAppId, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, int top_, TransactionManager tm_)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, string sort_)
		{
			return GetByOperatorAppId(operatorAppId, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, string sort_)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, string sort_, TransactionManager tm_)
		{
			return GetByOperatorAppId(operatorAppId, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorAppIdAsync(operatorAppId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorAppId（字段） 查询
		/// </summary>
		/// /// <param name = "operatorAppId">对应的运营商应用编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorAppId(string operatorAppId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorAppId != null ? "`OperatorAppId` = @OperatorAppId" : "`OperatorAppId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorAppId != null)
				paras_.Add(Database.CreateInParameter("@OperatorAppId", operatorAppId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorAppIdAsync(string operatorAppId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorAppId != null ? "`OperatorAppId` = @OperatorAppId" : "`OperatorAppId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorAppId != null)
				paras_.Add(Database.CreateInParameter("@OperatorAppId", operatorAppId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByOperatorAppId
		#region GetByUseBonus
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus)
		{
			return GetByUseBonus(useBonus, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus)
		{
			return await GetByUseBonusAsync(useBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, TransactionManager tm_)
		{
			return await GetByUseBonusAsync(useBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, int top_)
		{
			return GetByUseBonus(useBonus, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, int top_)
		{
			return await GetByUseBonusAsync(useBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, int top_, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, int top_, TransactionManager tm_)
		{
			return await GetByUseBonusAsync(useBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, string sort_)
		{
			return GetByUseBonus(useBonus, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, string sort_)
		{
			return await GetByUseBonusAsync(useBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, string sort_, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, string sort_, TransactionManager tm_)
		{
			return await GetByUseBonusAsync(useBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByUseBonus(bool useBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UseBonus` = @UseBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByUseBonusAsync(bool useBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UseBonus` = @UseBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByUseBonus
		#region GetByCashLimit
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit)
		{
			return GetByCashLimit(cashLimit, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit)
		{
			return await GetByCashLimitAsync(cashLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, TransactionManager tm_)
		{
			return GetByCashLimit(cashLimit, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, TransactionManager tm_)
		{
			return await GetByCashLimitAsync(cashLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, int top_)
		{
			return GetByCashLimit(cashLimit, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, int top_)
		{
			return await GetByCashLimitAsync(cashLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, int top_, TransactionManager tm_)
		{
			return GetByCashLimit(cashLimit, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, int top_, TransactionManager tm_)
		{
			return await GetByCashLimitAsync(cashLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, string sort_)
		{
			return GetByCashLimit(cashLimit, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, string sort_)
		{
			return await GetByCashLimitAsync(cashLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, string sort_, TransactionManager tm_)
		{
			return GetByCashLimit(cashLimit, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, string sort_, TransactionManager tm_)
		{
			return await GetByCashLimitAsync(cashLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashLimit（字段） 查询
		/// </summary>
		/// /// <param name = "cashLimit">进入游戏cash最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByCashLimit(int cashLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashLimit` = @CashLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByCashLimitAsync(int cashLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashLimit` = @CashLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashLimit", cashLimit, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByCashLimit
		#region GetByPayLimit
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit)
		{
			return GetByPayLimit(payLimit, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit)
		{
			return await GetByPayLimitAsync(payLimit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, TransactionManager tm_)
		{
			return GetByPayLimit(payLimit, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, TransactionManager tm_)
		{
			return await GetByPayLimitAsync(payLimit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, int top_)
		{
			return GetByPayLimit(payLimit, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, int top_)
		{
			return await GetByPayLimitAsync(payLimit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, int top_, TransactionManager tm_)
		{
			return GetByPayLimit(payLimit, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, int top_, TransactionManager tm_)
		{
			return await GetByPayLimitAsync(payLimit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, string sort_)
		{
			return GetByPayLimit(payLimit, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, string sort_)
		{
			return await GetByPayLimitAsync(payLimit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, string sort_, TransactionManager tm_)
		{
			return GetByPayLimit(payLimit, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, string sort_, TransactionManager tm_)
		{
			return await GetByPayLimitAsync(payLimit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayLimit（字段） 查询
		/// </summary>
		/// /// <param name = "payLimit">进入游戏充值最小数量限制0-不限制</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByPayLimit(int payLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayLimit` = @PayLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByPayLimitAsync(int payLimit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayLimit` = @PayLimit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayLimit", payLimit, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByPayLimit
		#region GetByActivityIds
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds)
		{
			return GetByActivityIds(activityIds, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds)
		{
			return await GetByActivityIdsAsync(activityIds, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, TransactionManager tm_)
		{
			return GetByActivityIds(activityIds, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, TransactionManager tm_)
		{
			return await GetByActivityIdsAsync(activityIds, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, int top_)
		{
			return GetByActivityIds(activityIds, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, int top_)
		{
			return await GetByActivityIdsAsync(activityIds, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, int top_, TransactionManager tm_)
		{
			return GetByActivityIds(activityIds, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, int top_, TransactionManager tm_)
		{
			return await GetByActivityIdsAsync(activityIds, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, string sort_)
		{
			return GetByActivityIds(activityIds, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, string sort_)
		{
			return await GetByActivityIdsAsync(activityIds, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, string sort_, TransactionManager tm_)
		{
			return GetByActivityIds(activityIds, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, string sort_, TransactionManager tm_)
		{
			return await GetByActivityIdsAsync(activityIds, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ActivityIds（字段） 查询
		/// </summary>
		/// /// <param name = "activityIds">支持的活动ID集合，|分割，如: 100001|100002</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByActivityIds(string activityIds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(activityIds != null ? "`ActivityIds` = @ActivityIds" : "`ActivityIds` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (activityIds != null)
				paras_.Add(Database.CreateInParameter("@ActivityIds", activityIds, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByActivityIdsAsync(string activityIds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(activityIds != null ? "`ActivityIds` = @ActivityIds" : "`ActivityIds` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (activityIds != null)
				paras_.Add(Database.CreateInParameter("@ActivityIds", activityIds, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByActivityIds
		#region GetByAppUrl
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl)
		{
			return GetByAppUrl(appUrl, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl)
		{
			return await GetByAppUrlAsync(appUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, TransactionManager tm_)
		{
			return GetByAppUrl(appUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, TransactionManager tm_)
		{
			return await GetByAppUrlAsync(appUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, int top_)
		{
			return GetByAppUrl(appUrl, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, int top_)
		{
			return await GetByAppUrlAsync(appUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, int top_, TransactionManager tm_)
		{
			return GetByAppUrl(appUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, int top_, TransactionManager tm_)
		{
			return await GetByAppUrlAsync(appUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, string sort_)
		{
			return GetByAppUrl(appUrl, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, string sort_)
		{
			return await GetByAppUrlAsync(appUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, string sort_, TransactionManager tm_)
		{
			return GetByAppUrl(appUrl, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, string sort_, TransactionManager tm_)
		{
			return await GetByAppUrlAsync(appUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppUrl（字段） 查询
		/// </summary>
		/// /// <param name = "appUrl">应用客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrl(string appUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrl != null ? "`AppUrl` = @AppUrl" : "`AppUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrl != null)
				paras_.Add(Database.CreateInParameter("@AppUrl", appUrl, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlAsync(string appUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrl != null ? "`AppUrl` = @AppUrl" : "`AppUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrl != null)
				paras_.Add(Database.CreateInParameter("@AppUrl", appUrl, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByAppUrl
		#region GetByAppUrlStaging
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging)
		{
			return GetByAppUrlStaging(appUrlStaging, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, TransactionManager tm_)
		{
			return GetByAppUrlStaging(appUrlStaging, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, TransactionManager tm_)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, int top_)
		{
			return GetByAppUrlStaging(appUrlStaging, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, int top_)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByAppUrlStaging(appUrlStaging, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, int top_, TransactionManager tm_)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, string sort_)
		{
			return GetByAppUrlStaging(appUrlStaging, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, string sort_)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByAppUrlStaging(appUrlStaging, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, string sort_, TransactionManager tm_)
		{
			return await GetByAppUrlStagingAsync(appUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlStaging">应用客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlStaging(string appUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrlStaging != null ? "`AppUrlStaging` = @AppUrlStaging" : "`AppUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@AppUrlStaging", appUrlStaging, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlStagingAsync(string appUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrlStaging != null ? "`AppUrlStaging` = @AppUrlStaging" : "`AppUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@AppUrlStaging", appUrlStaging, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByAppUrlStaging
		#region GetByAppUrlDebug
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug)
		{
			return GetByAppUrlDebug(appUrlDebug, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, TransactionManager tm_)
		{
			return GetByAppUrlDebug(appUrlDebug, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, TransactionManager tm_)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, int top_)
		{
			return GetByAppUrlDebug(appUrlDebug, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, int top_)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByAppUrlDebug(appUrlDebug, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, int top_, TransactionManager tm_)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, string sort_)
		{
			return GetByAppUrlDebug(appUrlDebug, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, string sort_)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByAppUrlDebug(appUrlDebug, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, string sort_, TransactionManager tm_)
		{
			return await GetByAppUrlDebugAsync(appUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AppUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "appUrlDebug">应用客户端联调URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByAppUrlDebug(string appUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrlDebug != null ? "`AppUrlDebug` = @AppUrlDebug" : "`AppUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@AppUrlDebug", appUrlDebug, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByAppUrlDebugAsync(string appUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(appUrlDebug != null ? "`AppUrlDebug` = @AppUrlDebug" : "`AppUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (appUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@AppUrlDebug", appUrlDebug, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByAppUrlDebug
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-无效1-在线2-维护中3-测试中</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByEffectStatus
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus)
		{
			return GetByEffectStatus(effectStatus, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus)
		{
			return await GetByEffectStatusAsync(effectStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, TransactionManager tm_)
		{
			return GetByEffectStatus(effectStatus, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, TransactionManager tm_)
		{
			return await GetByEffectStatusAsync(effectStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, int top_)
		{
			return GetByEffectStatus(effectStatus, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, int top_)
		{
			return await GetByEffectStatusAsync(effectStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, int top_, TransactionManager tm_)
		{
			return GetByEffectStatus(effectStatus, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, int top_, TransactionManager tm_)
		{
			return await GetByEffectStatusAsync(effectStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, string sort_)
		{
			return GetByEffectStatus(effectStatus, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, string sort_)
		{
			return await GetByEffectStatusAsync(effectStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, string sort_, TransactionManager tm_)
		{
			return GetByEffectStatus(effectStatus, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, string sort_, TransactionManager tm_)
		{
			return await GetByEffectStatusAsync(effectStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EffectStatus（字段） 查询
		/// </summary>
		/// /// <param name = "effectStatus">游戏入口效果标识Flag值 </param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByEffectStatus(int effectStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EffectStatus` = @EffectStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByEffectStatusAsync(int effectStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EffectStatus` = @EffectStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EffectStatus", effectStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByEffectStatus
		#region GetByOperatorThumb
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb)
		{
			return GetByOperatorThumb(operatorThumb, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb)
		{
			return await GetByOperatorThumbAsync(operatorThumb, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, TransactionManager tm_)
		{
			return GetByOperatorThumb(operatorThumb, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, TransactionManager tm_)
		{
			return await GetByOperatorThumbAsync(operatorThumb, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, int top_)
		{
			return GetByOperatorThumb(operatorThumb, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, int top_)
		{
			return await GetByOperatorThumbAsync(operatorThumb, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, int top_, TransactionManager tm_)
		{
			return GetByOperatorThumb(operatorThumb, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, int top_, TransactionManager tm_)
		{
			return await GetByOperatorThumbAsync(operatorThumb, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, string sort_)
		{
			return GetByOperatorThumb(operatorThumb, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, string sort_)
		{
			return await GetByOperatorThumbAsync(operatorThumb, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, string sort_, TransactionManager tm_)
		{
			return GetByOperatorThumb(operatorThumb, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorThumbAsync(operatorThumb, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorThumb（字段） 查询
		/// </summary>
		/// /// <param name = "operatorThumb"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorThumb(string operatorThumb, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorThumb != null ? "`OperatorThumb` = @OperatorThumb" : "`OperatorThumb` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorThumb != null)
				paras_.Add(Database.CreateInParameter("@OperatorThumb", operatorThumb, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorThumbAsync(string operatorThumb, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorThumb != null ? "`OperatorThumb` = @OperatorThumb" : "`OperatorThumb` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorThumb != null)
				paras_.Add(Database.CreateInParameter("@OperatorThumb", operatorThumb, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByOperatorThumb
		#region GetByOperatorBg
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg)
		{
			return GetByOperatorBg(operatorBg, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg)
		{
			return await GetByOperatorBgAsync(operatorBg, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, TransactionManager tm_)
		{
			return GetByOperatorBg(operatorBg, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, TransactionManager tm_)
		{
			return await GetByOperatorBgAsync(operatorBg, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, int top_)
		{
			return GetByOperatorBg(operatorBg, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, int top_)
		{
			return await GetByOperatorBgAsync(operatorBg, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, int top_, TransactionManager tm_)
		{
			return GetByOperatorBg(operatorBg, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, int top_, TransactionManager tm_)
		{
			return await GetByOperatorBgAsync(operatorBg, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, string sort_)
		{
			return GetByOperatorBg(operatorBg, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, string sort_)
		{
			return await GetByOperatorBgAsync(operatorBg, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, string sort_, TransactionManager tm_)
		{
			return GetByOperatorBg(operatorBg, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorBgAsync(operatorBg, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBg（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBg">游戏背景图url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorBg(string operatorBg, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorBg != null ? "`OperatorBg` = @OperatorBg" : "`OperatorBg` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorBg != null)
				paras_.Add(Database.CreateInParameter("@OperatorBg", operatorBg, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorBgAsync(string operatorBg, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorBg != null ? "`OperatorBg` = @OperatorBg" : "`OperatorBg` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorBg != null)
				paras_.Add(Database.CreateInParameter("@OperatorBg", operatorBg, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByOperatorBg
		#region GetByOperatorRoundUrl
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, 0, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, TransactionManager tm_)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, TransactionManager tm_)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, int top_)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, top_, string.Empty, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, int top_)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, int top_, TransactionManager tm_)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, int top_, TransactionManager tm_)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, string sort_)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, 0, sort_, null);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, string sort_)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, string sort_, TransactionManager tm_)
		{
			return GetByOperatorRoundUrl(operatorRoundUrl, 0, sort_, tm_);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorRoundUrlAsync(operatorRoundUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorRoundUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operatorRoundUrl">游戏回合url</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_appEO> GetByOperatorRoundUrl(string operatorRoundUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorRoundUrl != null ? "`OperatorRoundUrl` = @OperatorRoundUrl" : "`OperatorRoundUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorRoundUrl != null)
				paras_.Add(Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		public async Task<List<S_operator_appEO>> GetByOperatorRoundUrlAsync(string operatorRoundUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorRoundUrl != null ? "`OperatorRoundUrl` = @OperatorRoundUrl" : "`OperatorRoundUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorRoundUrl != null)
				paras_.Add(Database.CreateInParameter("@OperatorRoundUrl", operatorRoundUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_appEO.MapDataReader);
		}
		#endregion // GetByOperatorRoundUrl
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
