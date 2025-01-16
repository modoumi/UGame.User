/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:49
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
	/// 与应用提供商通讯日志
	/// 【表 s_provider_trans_log 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_provider_trans_logEO : IRowMapper<S_provider_trans_logEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_provider_trans_logEO()
		{
			this.TransType = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalTransLogID;
		/// <summary>
		/// 【数据库中的原始主键 TransLogID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalTransLogID
		{
			get { return _originalTransLogID; }
			set { HasOriginal = true; _originalTransLogID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "TransLogID", TransLogID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 请求应答日志编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string TransLogID { get; set; }
		/// <summary>
		/// 供应商请求生成的订单编码 GUID
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OrderID { get; set; }
		/// <summary>
		/// 应用提供商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 通讯类型(0-我方发起1-对方发起)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int TransType { get; set; }
		/// <summary>
		/// 通讯标记（接口标识）
		/// 【字段 varchar(500)】
		/// </summary>
		[DataMember(Order = 6)]
		public string TransMark { get; set; }
		/// <summary>
		/// 请求时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime RequestTime { get; set; }
		/// <summary>
		/// 请求消息（我方请求或对方请求）json
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string RequestBody { get; set; }
		/// <summary>
		/// 消息状态（0-初始1-返回成功2-返回失败）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 返回时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime? ResponseTime { get; set; }
		/// <summary>
		/// 响应消息（对方响应或我方响应）json
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 12)]
		public string ResponseBody { get; set; }
		/// <summary>
		/// 异常消息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 13)]
		public string Exception { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_provider_trans_logEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_provider_trans_logEO MapDataReader(IDataReader reader)
		{
		    S_provider_trans_logEO ret = new S_provider_trans_logEO();
			ret.TransLogID = reader.ToString("TransLogID");
			ret.OriginalTransLogID = ret.TransLogID;
			ret.OrderID = reader.ToString("OrderID");
			ret.ProviderID = reader.ToString("ProviderID");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.TransType = reader.ToInt32("TransType");
			ret.TransMark = reader.ToString("TransMark");
			ret.RequestTime = reader.ToDateTime("RequestTime");
			ret.RequestBody = reader.ToString("RequestBody");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.ResponseTime = reader.ToDateTimeN("ResponseTime");
			ret.ResponseBody = reader.ToString("ResponseBody");
			ret.Exception = reader.ToString("Exception");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 与应用提供商通讯日志
	/// 【表 s_provider_trans_log 的操作类】
	/// </summary>
	[Obsolete]
	public class S_provider_trans_logMO : MySqlTableMO<S_provider_trans_logEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_provider_trans_log`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_provider_trans_logMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_provider_trans_logMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_provider_trans_logMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_provider_trans_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_provider_trans_logEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_provider_trans_logEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`TransLogID`, `OrderID`, `ProviderID`, `OperatorID`, `TransType`, `TransMark`, `RequestTime`, `RequestBody`, `Status`, `RecDate`, `ResponseTime`, `ResponseBody`, `Exception`) VALUE (@TransLogID, @OrderID, @ProviderID, @OperatorID, @TransType, @TransMark, @RequestTime, @RequestBody, @Status, @RecDate, @ResponseTime, @ResponseBody, @Exception);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", item.TransLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID != null ? item.OrderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransType", item.TransType, MySqlDbType.Int32),
				Database.CreateInParameter("@TransMark", item.TransMark != null ? item.TransMark : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RequestTime", item.RequestTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@RequestBody", item.RequestBody != null ? item.RequestBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseBody", item.ResponseBody != null ? item.ResponseBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
			};
		}
		public int AddByBatch(IEnumerable<S_provider_trans_logEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_provider_trans_logEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_provider_trans_logEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`TransLogID`, `OrderID`, `ProviderID`, `OperatorID`, `TransType`, `TransMark`, `RequestTime`, `RequestBody`, `Status`, `RecDate`, `ResponseTime`, `ResponseBody`, `Exception`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.TransLogID}','{item.OrderID}','{item.ProviderID}','{item.OperatorID}',{item.TransType},'{item.TransMark}','{item.RequestTime.ToString("yyyy-MM-dd HH:mm:ss")}','{item.RequestBody}',{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ResponseTime?.ToString("yyyy-MM-dd HH:mm:ss")}','{item.ResponseBody}','{item.Exception}'),");
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
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string transLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(transLogID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(transLogID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string transLogID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_provider_trans_logEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.TransLogID, tm_);
		}
		public async Task<int> RemoveAsync(S_provider_trans_logEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.TransLogID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOrderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderID(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderIDData(string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOrderID
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
		#region RemoveByTransType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTransType(int transType, TransactionManager tm_ = null)
		{
			RepairRemoveByTransTypeData(transType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTransTypeAsync(int transType, TransactionManager tm_ = null)
		{
			RepairRemoveByTransTypeData(transType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTransTypeData(int transType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TransType` = @TransType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32));
		}
		#endregion // RemoveByTransType
		#region RemoveByTransMark
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTransMark(string transMark, TransactionManager tm_ = null)
		{
			RepairRemoveByTransMarkData(transMark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTransMarkAsync(string transMark, TransactionManager tm_ = null)
		{
			RepairRemoveByTransMarkData(transMark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTransMarkData(string transMark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (transMark != null ? "`TransMark` = @TransMark" : "`TransMark` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (transMark != null)
				paras_.Add(Database.CreateInParameter("@TransMark", transMark, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTransMark
		#region RemoveByRequestTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRequestTime(DateTime requestTime, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestTimeData(requestTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRequestTimeAsync(DateTime requestTime, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestTimeData(requestTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRequestTimeData(DateTime requestTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RequestTime` = @RequestTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRequestTime
		#region RemoveByRequestBody
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRequestBody(string requestBody, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestBodyData(requestBody, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRequestBodyAsync(string requestBody, TransactionManager tm_ = null)
		{
			RepairRemoveByRequestBodyData(requestBody, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRequestBodyData(string requestBody, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (requestBody != null)
				paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
		}
		#endregion // RemoveByRequestBody
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
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
		#region RemoveByResponseTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseTimeData(responseTime.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByResponseTimeData(DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByResponseTime
		#region RemoveByResponseBody
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByResponseBody(string responseBody, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseBodyData(responseBody, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByResponseBodyAsync(string responseBody, TransactionManager tm_ = null)
		{
			RepairRemoveByResponseBodyData(responseBody, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByResponseBodyData(string responseBody, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (responseBody != null)
				paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
		}
		#endregion // RemoveByResponseBody
		#region RemoveByException
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByException(string exception, TransactionManager tm_ = null)
		{
			RepairRemoveByExceptionData(exception, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByExceptionAsync(string exception, TransactionManager tm_ = null)
		{
			RepairRemoveByExceptionData(exception, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByExceptionData(string exception, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
		}
		#endregion // RemoveByException
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
		public int Put(S_provider_trans_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_provider_trans_logEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_provider_trans_logEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TransLogID` = @TransLogID, `OrderID` = @OrderID, `ProviderID` = @ProviderID, `OperatorID` = @OperatorID, `TransType` = @TransType, `TransMark` = @TransMark, `RequestTime` = @RequestTime, `RequestBody` = @RequestBody, `Status` = @Status, `ResponseTime` = @ResponseTime, `ResponseBody` = @ResponseBody, `Exception` = @Exception WHERE `TransLogID` = @TransLogID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", item.TransLogID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID != null ? item.OrderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", item.ProviderID != null ? item.ProviderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransType", item.TransType, MySqlDbType.Int32),
				Database.CreateInParameter("@TransMark", item.TransMark != null ? item.TransMark : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@RequestTime", item.RequestTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@RequestBody", item.RequestBody != null ? item.RequestBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@ResponseTime", item.ResponseTime.HasValue ? item.ResponseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@ResponseBody", item.ResponseBody != null ? item.ResponseBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Exception", item.Exception != null ? item.Exception : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@TransLogID_Original", item.HasOriginal ? item.OriginalTransLogID : item.TransLogID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_provider_trans_logEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_provider_trans_logEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string transLogID, string set_, params object[] values_)
		{
			return Put(set_, "`TransLogID` = @TransLogID", ConcatValues(values_, transLogID));
		}
		public async Task<int> PutByPKAsync(string transLogID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`TransLogID` = @TransLogID", ConcatValues(values_, transLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string transLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`TransLogID` = @TransLogID", tm_, ConcatValues(values_, transLogID));
		}
		public async Task<int> PutByPKAsync(string transLogID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`TransLogID` = @TransLogID", tm_, ConcatValues(values_, transLogID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string transLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`TransLogID` = @TransLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string transLogID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`TransLogID` = @TransLogID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOrderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderIDByPK(string transLogID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(transLogID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderIDByPKAsync(string transLogID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(transLogID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderIDByPKData(string transLogID, string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderID(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID != null ? orderID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderID
		#region PutProviderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderIDByPK(string transLogID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(transLogID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderIDByPKAsync(string transLogID, string providerID, TransactionManager tm_ = null)
		{
			RepairPutProviderIDByPKData(transLogID, providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderIDByPKData(string transLogID, string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID != null ? providerID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
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
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string transLogID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(transLogID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string transLogID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(transLogID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string transLogID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
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
		#region PutTransType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTransTypeByPK(string transLogID, int transType, TransactionManager tm_ = null)
		{
			RepairPutTransTypeByPKData(transLogID, transType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTransTypeByPKAsync(string transLogID, int transType, TransactionManager tm_ = null)
		{
			RepairPutTransTypeByPKData(transLogID, transType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTransTypeByPKData(string transLogID, int transType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TransType` = @TransType  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTransType(int transType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TransType` = @TransType";
			var parameter_ = Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTransTypeAsync(int transType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TransType` = @TransType";
			var parameter_ = Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTransType
		#region PutTransMark
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTransMarkByPK(string transLogID, string transMark, TransactionManager tm_ = null)
		{
			RepairPutTransMarkByPKData(transLogID, transMark, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTransMarkByPKAsync(string transLogID, string transMark, TransactionManager tm_ = null)
		{
			RepairPutTransMarkByPKData(transLogID, transMark, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTransMarkByPKData(string transLogID, string transMark, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TransMark` = @TransMark  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransMark", transMark != null ? transMark : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTransMark(string transMark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TransMark` = @TransMark";
			var parameter_ = Database.CreateInParameter("@TransMark", transMark != null ? transMark : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTransMarkAsync(string transMark, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TransMark` = @TransMark";
			var parameter_ = Database.CreateInParameter("@TransMark", transMark != null ? transMark : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTransMark
		#region PutRequestTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestTimeByPK(string transLogID, DateTime requestTime, TransactionManager tm_ = null)
		{
			RepairPutRequestTimeByPKData(transLogID, requestTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRequestTimeByPKAsync(string transLogID, DateTime requestTime, TransactionManager tm_ = null)
		{
			RepairPutRequestTimeByPKData(transLogID, requestTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRequestTimeByPKData(string transLogID, DateTime requestTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestTime(DateTime requestTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime";
			var parameter_ = Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRequestTimeAsync(DateTime requestTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestTime` = @RequestTime";
			var parameter_ = Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRequestTime
		#region PutRequestBody
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestBodyByPK(string transLogID, string requestBody, TransactionManager tm_ = null)
		{
			RepairPutRequestBodyByPKData(transLogID, requestBody, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRequestBodyByPKAsync(string transLogID, string requestBody, TransactionManager tm_ = null)
		{
			RepairPutRequestBodyByPKData(transLogID, requestBody, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRequestBodyByPKData(string transLogID, string requestBody, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRequestBody(string requestBody, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody";
			var parameter_ = Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRequestBodyAsync(string requestBody, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RequestBody` = @RequestBody";
			var parameter_ = Database.CreateInParameter("@RequestBody", requestBody != null ? requestBody : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRequestBody
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string transLogID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(transLogID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string transLogID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(transLogID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string transLogID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string transLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(transLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string transLogID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(transLogID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string transLogID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
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
		#region PutResponseTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseTimeByPK(string transLogID, DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairPutResponseTimeByPKData(transLogID, responseTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutResponseTimeByPKAsync(string transLogID, DateTime? responseTime, TransactionManager tm_ = null)
		{
			RepairPutResponseTimeByPKData(transLogID, responseTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutResponseTimeByPKData(string transLogID, DateTime? responseTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseTime(DateTime? responseTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
			var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutResponseTimeAsync(DateTime? responseTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseTime` = @ResponseTime";
			var parameter_ = Database.CreateInParameter("@ResponseTime", responseTime.HasValue ? responseTime.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutResponseTime
		#region PutResponseBody
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseBodyByPK(string transLogID, string responseBody, TransactionManager tm_ = null)
		{
			RepairPutResponseBodyByPKData(transLogID, responseBody, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutResponseBodyByPKAsync(string transLogID, string responseBody, TransactionManager tm_ = null)
		{
			RepairPutResponseBodyByPKData(transLogID, responseBody, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutResponseBodyByPKData(string transLogID, string responseBody, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutResponseBody(string responseBody, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody";
			var parameter_ = Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutResponseBodyAsync(string responseBody, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ResponseBody` = @ResponseBody";
			var parameter_ = Database.CreateInParameter("@ResponseBody", responseBody != null ? responseBody : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutResponseBody
		#region PutException
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutExceptionByPK(string transLogID, string exception, TransactionManager tm_ = null)
		{
			RepairPutExceptionByPKData(transLogID, exception, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutExceptionByPKAsync(string transLogID, string exception, TransactionManager tm_ = null)
		{
			RepairPutExceptionByPKData(transLogID, exception, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutExceptionByPKData(string transLogID, string exception, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Exception` = @Exception  WHERE `TransLogID` = @TransLogID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutException(string exception, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Exception` = @Exception";
			var parameter_ = Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutExceptionAsync(string exception, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Exception` = @Exception";
			var parameter_ = Database.CreateInParameter("@Exception", exception != null ? exception : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutException
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_provider_trans_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TransLogID) == null)
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
		public async Task<bool> SetAsync(S_provider_trans_logEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.TransLogID) == null)
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
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_provider_trans_logEO GetByPK(string transLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(transLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<S_provider_trans_logEO> GetByPKAsync(string transLogID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(transLogID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		private void RepairGetByPKData(string transLogID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`TransLogID` = @TransLogID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OrderID（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOrderIDByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OrderID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetOrderIDByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OrderID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderID（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderIDByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetProviderIDByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TransType（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTransTypeByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TransType`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<int> GetTransTypeByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TransType`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TransMark（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTransMarkByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`TransMark`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetTransMarkByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`TransMark`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RequestTime（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRequestTimeByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RequestTime`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<DateTime> GetRequestTimeByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RequestTime`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RequestBody（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRequestBodyByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`RequestBody`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetRequestBodyByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`RequestBody`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ResponseTime（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetResponseTimeByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`ResponseTime`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<DateTime?> GetResponseTimeByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`ResponseTime`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ResponseBody（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetResponseBodyByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ResponseBody`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetResponseBodyByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ResponseBody`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Exception（字段）
		/// </summary>
		/// /// <param name = "transLogID">请求应答日志编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetExceptionByPK(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Exception`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		public async Task<string> GetExceptionByPKAsync(string transLogID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TransLogID", transLogID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Exception`", "`TransLogID` = @TransLogID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOrderID
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID)
		{
			return GetByOrderID(orderID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, int top_)
		{
			return GetByOrderID(orderID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, int top_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, int top_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, int top_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, string sort_)
		{
			return GetByOrderID(orderID, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, string sort_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, string sort_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, string sort_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">供应商请求生成的订单编码 GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOrderID(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOrderIDAsync(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderID != null ? "`OrderID` = @OrderID" : "`OrderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderID != null)
				paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByOrderID
		#region GetByProviderID
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByProviderID(string providerID)
		{
			return GetByProviderID(providerID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, int top_)
		{
			return GetByProviderID(providerID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, int top_)
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
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, int top_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, int top_, TransactionManager tm_)
		{
			return await GetByProviderIDAsync(providerID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderID（字段） 查询
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, string sort_)
		{
			return GetByProviderID(providerID, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, string sort_)
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
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, string sort_, TransactionManager tm_)
		{
			return GetByProviderID(providerID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, string sort_, TransactionManager tm_)
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
		public List<S_provider_trans_logEO> GetByProviderID(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByProviderIDAsync(string providerID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerID != null ? "`ProviderID` = @ProviderID" : "`ProviderID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerID != null)
				paras_.Add(Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByProviderID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_provider_trans_logEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByTransType
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType)
		{
			return GetByTransType(transType, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType)
		{
			return await GetByTransTypeAsync(transType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, TransactionManager tm_)
		{
			return GetByTransType(transType, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, TransactionManager tm_)
		{
			return await GetByTransTypeAsync(transType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, int top_)
		{
			return GetByTransType(transType, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, int top_)
		{
			return await GetByTransTypeAsync(transType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, int top_, TransactionManager tm_)
		{
			return GetByTransType(transType, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, int top_, TransactionManager tm_)
		{
			return await GetByTransTypeAsync(transType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, string sort_)
		{
			return GetByTransType(transType, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, string sort_)
		{
			return await GetByTransTypeAsync(transType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, string sort_, TransactionManager tm_)
		{
			return GetByTransType(transType, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, string sort_, TransactionManager tm_)
		{
			return await GetByTransTypeAsync(transType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TransType（字段） 查询
		/// </summary>
		/// /// <param name = "transType">通讯类型(0-我方发起1-对方发起)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransType(int transType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TransType` = @TransType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransTypeAsync(int transType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TransType` = @TransType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TransType", transType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByTransType
		#region GetByTransMark
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark)
		{
			return GetByTransMark(transMark, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark)
		{
			return await GetByTransMarkAsync(transMark, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, TransactionManager tm_)
		{
			return GetByTransMark(transMark, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, TransactionManager tm_)
		{
			return await GetByTransMarkAsync(transMark, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, int top_)
		{
			return GetByTransMark(transMark, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, int top_)
		{
			return await GetByTransMarkAsync(transMark, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, int top_, TransactionManager tm_)
		{
			return GetByTransMark(transMark, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, int top_, TransactionManager tm_)
		{
			return await GetByTransMarkAsync(transMark, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, string sort_)
		{
			return GetByTransMark(transMark, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, string sort_)
		{
			return await GetByTransMarkAsync(transMark, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, string sort_, TransactionManager tm_)
		{
			return GetByTransMark(transMark, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, string sort_, TransactionManager tm_)
		{
			return await GetByTransMarkAsync(transMark, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TransMark（字段） 查询
		/// </summary>
		/// /// <param name = "transMark">通讯标记（接口标识）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByTransMark(string transMark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(transMark != null ? "`TransMark` = @TransMark" : "`TransMark` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (transMark != null)
				paras_.Add(Database.CreateInParameter("@TransMark", transMark, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByTransMarkAsync(string transMark, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(transMark != null ? "`TransMark` = @TransMark" : "`TransMark` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (transMark != null)
				paras_.Add(Database.CreateInParameter("@TransMark", transMark, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByTransMark
		#region GetByRequestTime
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime)
		{
			return GetByRequestTime(requestTime, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime)
		{
			return await GetByRequestTimeAsync(requestTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, TransactionManager tm_)
		{
			return GetByRequestTime(requestTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, TransactionManager tm_)
		{
			return await GetByRequestTimeAsync(requestTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, int top_)
		{
			return GetByRequestTime(requestTime, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, int top_)
		{
			return await GetByRequestTimeAsync(requestTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, int top_, TransactionManager tm_)
		{
			return GetByRequestTime(requestTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, int top_, TransactionManager tm_)
		{
			return await GetByRequestTimeAsync(requestTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, string sort_)
		{
			return GetByRequestTime(requestTime, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, string sort_)
		{
			return await GetByRequestTimeAsync(requestTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, string sort_, TransactionManager tm_)
		{
			return GetByRequestTime(requestTime, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, string sort_, TransactionManager tm_)
		{
			return await GetByRequestTimeAsync(requestTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RequestTime（字段） 查询
		/// </summary>
		/// /// <param name = "requestTime">请求时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestTime(DateTime requestTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RequestTime` = @RequestTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestTimeAsync(DateTime requestTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RequestTime` = @RequestTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RequestTime", requestTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByRequestTime
		#region GetByRequestBody
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody)
		{
			return GetByRequestBody(requestBody, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody)
		{
			return await GetByRequestBodyAsync(requestBody, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, TransactionManager tm_)
		{
			return GetByRequestBody(requestBody, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, TransactionManager tm_)
		{
			return await GetByRequestBodyAsync(requestBody, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, int top_)
		{
			return GetByRequestBody(requestBody, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, int top_)
		{
			return await GetByRequestBodyAsync(requestBody, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, int top_, TransactionManager tm_)
		{
			return GetByRequestBody(requestBody, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, int top_, TransactionManager tm_)
		{
			return await GetByRequestBodyAsync(requestBody, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, string sort_)
		{
			return GetByRequestBody(requestBody, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, string sort_)
		{
			return await GetByRequestBodyAsync(requestBody, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, string sort_, TransactionManager tm_)
		{
			return GetByRequestBody(requestBody, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, string sort_, TransactionManager tm_)
		{
			return await GetByRequestBodyAsync(requestBody, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RequestBody（字段） 查询
		/// </summary>
		/// /// <param name = "requestBody">请求消息（我方请求或对方请求）json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRequestBody(string requestBody, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (requestBody != null)
				paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRequestBodyAsync(string requestBody, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(requestBody != null ? "`RequestBody` = @RequestBody" : "`RequestBody` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (requestBody != null)
				paras_.Add(Database.CreateInParameter("@RequestBody", requestBody, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByRequestBody
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">消息状态（0-初始1-返回成功2-返回失败）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_provider_trans_logEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByResponseTime
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime)
		{
			return GetByResponseTime(responseTime, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime)
		{
			return await GetByResponseTimeAsync(responseTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, int top_)
		{
			return GetByResponseTime(responseTime, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_)
		{
			return await GetByResponseTimeAsync(responseTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, int top_, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, string sort_)
		{
			return GetByResponseTime(responseTime, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, string sort_, TransactionManager tm_)
		{
			return GetByResponseTime(responseTime, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, string sort_, TransactionManager tm_)
		{
			return await GetByResponseTimeAsync(responseTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ResponseTime（字段） 查询
		/// </summary>
		/// /// <param name = "responseTime">返回时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseTime(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseTimeAsync(DateTime? responseTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseTime.HasValue ? "`ResponseTime` = @ResponseTime" : "`ResponseTime` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseTime.HasValue)
				paras_.Add(Database.CreateInParameter("@ResponseTime", responseTime.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByResponseTime
		#region GetByResponseBody
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody)
		{
			return GetByResponseBody(responseBody, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody)
		{
			return await GetByResponseBodyAsync(responseBody, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, TransactionManager tm_)
		{
			return GetByResponseBody(responseBody, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, TransactionManager tm_)
		{
			return await GetByResponseBodyAsync(responseBody, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, int top_)
		{
			return GetByResponseBody(responseBody, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, int top_)
		{
			return await GetByResponseBodyAsync(responseBody, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, int top_, TransactionManager tm_)
		{
			return GetByResponseBody(responseBody, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, int top_, TransactionManager tm_)
		{
			return await GetByResponseBodyAsync(responseBody, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, string sort_)
		{
			return GetByResponseBody(responseBody, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, string sort_)
		{
			return await GetByResponseBodyAsync(responseBody, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, string sort_, TransactionManager tm_)
		{
			return GetByResponseBody(responseBody, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, string sort_, TransactionManager tm_)
		{
			return await GetByResponseBodyAsync(responseBody, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ResponseBody（字段） 查询
		/// </summary>
		/// /// <param name = "responseBody">响应消息（对方响应或我方响应）json</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByResponseBody(string responseBody, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseBody != null)
				paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByResponseBodyAsync(string responseBody, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(responseBody != null ? "`ResponseBody` = @ResponseBody" : "`ResponseBody` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (responseBody != null)
				paras_.Add(Database.CreateInParameter("@ResponseBody", responseBody, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByResponseBody
		#region GetByException
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception)
		{
			return GetByException(exception, 0, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception)
		{
			return await GetByExceptionAsync(exception, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, TransactionManager tm_)
		{
			return GetByException(exception, 0, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, int top_)
		{
			return GetByException(exception, top_, string.Empty, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, int top_)
		{
			return await GetByExceptionAsync(exception, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, int top_, TransactionManager tm_)
		{
			return GetByException(exception, top_, string.Empty, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, int top_, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, string sort_)
		{
			return GetByException(exception, 0, sort_, null);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, string sort_)
		{
			return await GetByExceptionAsync(exception, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, string sort_, TransactionManager tm_)
		{
			return GetByException(exception, 0, sort_, tm_);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, string sort_, TransactionManager tm_)
		{
			return await GetByExceptionAsync(exception, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Exception（字段） 查询
		/// </summary>
		/// /// <param name = "exception">异常消息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_provider_trans_logEO> GetByException(string exception, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		public async Task<List<S_provider_trans_logEO>> GetByExceptionAsync(string exception, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(exception != null ? "`Exception` = @Exception" : "`Exception` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (exception != null)
				paras_.Add(Database.CreateInParameter("@Exception", exception, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_provider_trans_logEO.MapDataReader);
		}
		#endregion // GetByException
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
