/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:42
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
	/// 供应商基础定义
	/// 【表 s_operator_base 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_operator_baseEO : IRowMapper<S_operator_baseEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_operator_baseEO()
		{
			this.OperatorType = 1;
			this.AllowVisitor = false;
			this.SettlDayNum = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.CashAudit = 1;
			this.LowestCashAmount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorBaseID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorBaseID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorBaseID
		{
			get { return _originalOperatorBaseID; }
			set { HasOriginal = true; _originalOperatorBaseID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorBaseID", OperatorBaseID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商基础编码（小写，唯一）
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorBaseID { get; set; }
		/// <summary>
		/// 运营商名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorName { get; set; }
		/// <summary>
		/// 运营商类型
		///              0-自有
		///              1-第三方有用户有充值
		///              2-第三方有用户无充值
		///              3-第三方无用户无充值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int OperatorType { get; set; }
		/// <summary>
		/// 独服混服类型(0-混服1-独服)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int? OperatorMode { get; set; }
		/// <summary>
		/// 是否允许游客
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 5)]
		public bool AllowVisitor { get; set; }
		/// <summary>
		/// 运营商公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 6)]
		public string OperPublicKey { get; set; }
		/// <summary>
		/// 运营商私钥（仅测试）
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 7)]
		public string OperPrivateKey { get; set; }
		/// <summary>
		/// 我方的公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string OwnPublicKey { get; set; }
		/// <summary>
		/// 我方的私钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 9)]
		public string OwnPrivateKey { get; set; }
		/// <summary>
		/// 运营商的配置信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 10)]
		public string OperatorConfig { get; set; }
		/// <summary>
		/// 备注信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 11)]
		public string Note { get; set; }
		/// <summary>
		/// 结算日，如5表示每月结算包含5号
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int SettlDayNum { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 14)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 运营商后台地址
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 15)]
		public string OperAdminUrl { get; set; }
		/// <summary>
		/// 运营商后台账号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 16)]
		public string OperAdminUser { get; set; }
		/// <summary>
		/// 运营商后台密码
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 17)]
		public string OperAdminPwd { get; set; }
		/// <summary>
		/// 提现审计模式0-不审计1-审计
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int CashAudit { get; set; }
		/// <summary>
		/// 最低提现额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long LowestCashAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_operator_baseEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_operator_baseEO MapDataReader(IDataReader reader)
		{
		    S_operator_baseEO ret = new S_operator_baseEO();
			ret.OperatorBaseID = reader.ToString("OperatorBaseID");
			ret.OriginalOperatorBaseID = ret.OperatorBaseID;
			ret.OperatorName = reader.ToString("OperatorName");
			ret.OperatorType = reader.ToInt32("OperatorType");
			ret.OperatorMode = reader.ToInt32N("OperatorMode");
			ret.AllowVisitor = reader.ToBoolean("AllowVisitor");
			ret.OperPublicKey = reader.ToString("OperPublicKey");
			ret.OperPrivateKey = reader.ToString("OperPrivateKey");
			ret.OwnPublicKey = reader.ToString("OwnPublicKey");
			ret.OwnPrivateKey = reader.ToString("OwnPrivateKey");
			ret.OperatorConfig = reader.ToString("OperatorConfig");
			ret.Note = reader.ToString("Note");
			ret.SettlDayNum = reader.ToInt32("SettlDayNum");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.OperAdminUrl = reader.ToString("OperAdminUrl");
			ret.OperAdminUser = reader.ToString("OperAdminUser");
			ret.OperAdminPwd = reader.ToString("OperAdminPwd");
			ret.CashAudit = reader.ToInt32("CashAudit");
			ret.LowestCashAmount = reader.ToInt64("LowestCashAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 供应商基础定义
	/// 【表 s_operator_base 的操作类】
	/// </summary>
	[Obsolete]
	public class S_operator_baseMO : MySqlTableMO<S_operator_baseEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_operator_base`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_operator_baseMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_operator_baseMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_operator_baseMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_operator_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_operator_baseEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_operator_baseEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorBaseID`, `OperatorName`, `OperatorType`, `OperatorMode`, `AllowVisitor`, `OperPublicKey`, `OperPrivateKey`, `OwnPublicKey`, `OwnPrivateKey`, `OperatorConfig`, `Note`, `SettlDayNum`, `Status`, `RecDate`, `OperAdminUrl`, `OperAdminUser`, `OperAdminPwd`, `CashAudit`, `LowestCashAmount`) VALUE (@OperatorBaseID, @OperatorName, @OperatorType, @OperatorMode, @AllowVisitor, @OperPublicKey, @OperPrivateKey, @OwnPublicKey, @OwnPrivateKey, @OperatorConfig, @Note, @SettlDayNum, @Status, @RecDate, @OperAdminUrl, @OperAdminUser, @OperAdminPwd, @CashAudit, @LowestCashAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", item.OperatorBaseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorName", item.OperatorName != null ? item.OperatorName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorType", item.OperatorType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorMode", item.OperatorMode.HasValue ? item.OperatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@AllowVisitor", item.AllowVisitor, MySqlDbType.Byte),
				Database.CreateInParameter("@OperPublicKey", item.OperPublicKey != null ? item.OperPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperPrivateKey", item.OperPrivateKey != null ? item.OperPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPublicKey", item.OwnPublicKey != null ? item.OwnPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPrivateKey", item.OwnPrivateKey != null ? item.OwnPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorConfig", item.OperatorConfig != null ? item.OperatorConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SettlDayNum", item.SettlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperAdminUrl", item.OperAdminUrl != null ? item.OperAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperAdminUser", item.OperAdminUser != null ? item.OperAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperAdminPwd", item.OperAdminPwd != null ? item.OperAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CashAudit", item.CashAudit, MySqlDbType.Int32),
				Database.CreateInParameter("@LowestCashAmount", item.LowestCashAmount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<S_operator_baseEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_operator_baseEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_operator_baseEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorBaseID`, `OperatorName`, `OperatorType`, `OperatorMode`, `AllowVisitor`, `OperPublicKey`, `OperPrivateKey`, `OwnPublicKey`, `OwnPrivateKey`, `OperatorConfig`, `Note`, `SettlDayNum`, `Status`, `RecDate`, `OperAdminUrl`, `OperAdminUser`, `OperAdminPwd`, `CashAudit`, `LowestCashAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorBaseID}','{item.OperatorName}',{item.OperatorType},{item.OperatorMode?.ToString()??null},{item.AllowVisitor},'{item.OperPublicKey}','{item.OperPrivateKey}','{item.OwnPublicKey}','{item.OwnPrivateKey}','{item.OperatorConfig}','{item.Note}',{item.SettlDayNum},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.OperAdminUrl}','{item.OperAdminUser}','{item.OperAdminPwd}',{item.CashAudit},{item.LowestCashAmount}),");
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
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorBaseID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_operator_baseEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorBaseID, tm_);
		}
		public async Task<int> RemoveAsync(S_operator_baseEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorBaseID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorName(string operatorName, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorNameData(operatorName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorNameAsync(string operatorName, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorNameData(operatorName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorNameData(string operatorName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorName != null ? "`OperatorName` = @OperatorName" : "`OperatorName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorName != null)
				paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorName
		#region RemoveByOperatorType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorType(int operatorType, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorTypeData(operatorType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorTypeAsync(int operatorType, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorTypeData(operatorType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorTypeData(int operatorType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorType` = @OperatorType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32));
		}
		#endregion // RemoveByOperatorType
		#region RemoveByOperatorMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorMode(int? operatorMode, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorModeData(operatorMode.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorModeAsync(int? operatorMode, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorModeData(operatorMode.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorModeData(int? operatorMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorMode.HasValue ? "`OperatorMode` = @OperatorMode" : "`OperatorMode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorMode.HasValue)
				paras_.Add(Database.CreateInParameter("@OperatorMode", operatorMode.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByOperatorMode
		#region RemoveByAllowVisitor
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAllowVisitor(bool allowVisitor, TransactionManager tm_ = null)
		{
			RepairRemoveByAllowVisitorData(allowVisitor, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAllowVisitorAsync(bool allowVisitor, TransactionManager tm_ = null)
		{
			RepairRemoveByAllowVisitorData(allowVisitor, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAllowVisitorData(bool allowVisitor, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AllowVisitor` = @AllowVisitor";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte));
		}
		#endregion // RemoveByAllowVisitor
		#region RemoveByOperPublicKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperPublicKey(string operPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOperPublicKeyData(operPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperPublicKeyAsync(string operPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOperPublicKeyData(operPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperPublicKeyData(string operPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operPublicKey != null ? "`OperPublicKey` = @OperPublicKey" : "`OperPublicKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OperPublicKey", operPublicKey, MySqlDbType.Text));
		}
		#endregion // RemoveByOperPublicKey
		#region RemoveByOperPrivateKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperPrivateKey(string operPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOperPrivateKeyData(operPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperPrivateKeyAsync(string operPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOperPrivateKeyData(operPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperPrivateKeyData(string operPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operPrivateKey != null ? "`OperPrivateKey` = @OperPrivateKey" : "`OperPrivateKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OperPrivateKey", operPrivateKey, MySqlDbType.Text));
		}
		#endregion // RemoveByOperPrivateKey
		#region RemoveByOwnPublicKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOwnPublicKey(string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOwnPublicKeyData(ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOwnPublicKeyAsync(string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOwnPublicKeyData(ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOwnPublicKeyData(string ownPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (ownPublicKey != null ? "`OwnPublicKey` = @OwnPublicKey" : "`OwnPublicKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (ownPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPublicKey", ownPublicKey, MySqlDbType.Text));
		}
		#endregion // RemoveByOwnPublicKey
		#region RemoveByOwnPrivateKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOwnPrivateKey(string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOwnPrivateKeyData(ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOwnPrivateKeyAsync(string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByOwnPrivateKeyData(ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOwnPrivateKeyData(string ownPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (ownPrivateKey != null ? "`OwnPrivateKey` = @OwnPrivateKey" : "`OwnPrivateKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (ownPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey, MySqlDbType.Text));
		}
		#endregion // RemoveByOwnPrivateKey
		#region RemoveByOperatorConfig
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorConfig(string operatorConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorConfigData(operatorConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorConfigAsync(string operatorConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorConfigData(operatorConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorConfigData(string operatorConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operatorConfig != null ? "`OperatorConfig` = @OperatorConfig" : "`OperatorConfig` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operatorConfig != null)
				paras_.Add(Database.CreateInParameter("@OperatorConfig", operatorConfig, MySqlDbType.Text));
		}
		#endregion // RemoveByOperatorConfig
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
		#region RemoveBySettlDayNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySettlDayNum(int settlDayNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlDayNumData(settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySettlDayNumAsync(int settlDayNum, TransactionManager tm_ = null)
		{
			RepairRemoveBySettlDayNumData(settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySettlDayNumData(int settlDayNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `SettlDayNum` = @SettlDayNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32));
		}
		#endregion // RemoveBySettlDayNum
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
		#region RemoveByOperAdminUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperAdminUrl(string operAdminUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminUrlData(operAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperAdminUrlAsync(string operAdminUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminUrlData(operAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperAdminUrlData(string operAdminUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operAdminUrl != null ? "`OperAdminUrl` = @OperAdminUrl" : "`OperAdminUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUrl", operAdminUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperAdminUrl
		#region RemoveByOperAdminUser
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperAdminUser(string operAdminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminUserData(operAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperAdminUserAsync(string operAdminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminUserData(operAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperAdminUserData(string operAdminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operAdminUser != null ? "`OperAdminUser` = @OperAdminUser" : "`OperAdminUser` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operAdminUser != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUser", operAdminUser, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperAdminUser
		#region RemoveByOperAdminPwd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperAdminPwd(string operAdminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminPwdData(operAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperAdminPwdAsync(string operAdminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByOperAdminPwdData(operAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperAdminPwdData(string operAdminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (operAdminPwd != null ? "`OperAdminPwd` = @OperAdminPwd" : "`OperAdminPwd` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (operAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@OperAdminPwd", operAdminPwd, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperAdminPwd
		#region RemoveByCashAudit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCashAudit(int cashAudit, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditData(cashAudit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCashAuditAsync(int cashAudit, TransactionManager tm_ = null)
		{
			RepairRemoveByCashAuditData(cashAudit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCashAuditData(int cashAudit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CashAudit` = @CashAudit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32));
		}
		#endregion // RemoveByCashAudit
		#region RemoveByLowestCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLowestCashAmount(long lowestCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLowestCashAmountData(lowestCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLowestCashAmountAsync(long lowestCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLowestCashAmountData(lowestCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLowestCashAmountData(long lowestCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LowestCashAmount` = @LowestCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByLowestCashAmount
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
		public int Put(S_operator_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_operator_baseEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_operator_baseEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorBaseID` = @OperatorBaseID, `OperatorName` = @OperatorName, `OperatorType` = @OperatorType, `OperatorMode` = @OperatorMode, `AllowVisitor` = @AllowVisitor, `OperPublicKey` = @OperPublicKey, `OperPrivateKey` = @OperPrivateKey, `OwnPublicKey` = @OwnPublicKey, `OwnPrivateKey` = @OwnPrivateKey, `OperatorConfig` = @OperatorConfig, `Note` = @Note, `SettlDayNum` = @SettlDayNum, `Status` = @Status, `OperAdminUrl` = @OperAdminUrl, `OperAdminUser` = @OperAdminUser, `OperAdminPwd` = @OperAdminPwd, `CashAudit` = @CashAudit, `LowestCashAmount` = @LowestCashAmount WHERE `OperatorBaseID` = @OperatorBaseID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", item.OperatorBaseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorName", item.OperatorName != null ? item.OperatorName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorType", item.OperatorType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorMode", item.OperatorMode.HasValue ? item.OperatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@AllowVisitor", item.AllowVisitor, MySqlDbType.Byte),
				Database.CreateInParameter("@OperPublicKey", item.OperPublicKey != null ? item.OperPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperPrivateKey", item.OperPrivateKey != null ? item.OperPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPublicKey", item.OwnPublicKey != null ? item.OwnPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPrivateKey", item.OwnPrivateKey != null ? item.OwnPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorConfig", item.OperatorConfig != null ? item.OperatorConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SettlDayNum", item.SettlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@OperAdminUrl", item.OperAdminUrl != null ? item.OperAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperAdminUser", item.OperAdminUser != null ? item.OperAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperAdminPwd", item.OperAdminPwd != null ? item.OperAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CashAudit", item.CashAudit, MySqlDbType.Int32),
				Database.CreateInParameter("@LowestCashAmount", item.LowestCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorBaseID_Original", item.HasOriginal ? item.OriginalOperatorBaseID : item.OperatorBaseID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_operator_baseEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_operator_baseEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorBaseID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorBaseID` = @OperatorBaseID", ConcatValues(values_, operatorBaseID));
		}
		public async Task<int> PutByPKAsync(string operatorBaseID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorBaseID` = @OperatorBaseID", ConcatValues(values_, operatorBaseID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorBaseID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorBaseID` = @OperatorBaseID", tm_, ConcatValues(values_, operatorBaseID));
		}
		public async Task<int> PutByPKAsync(string operatorBaseID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorBaseID` = @OperatorBaseID", tm_, ConcatValues(values_, operatorBaseID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorBaseID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorBaseID` = @OperatorBaseID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorBaseID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorBaseID` = @OperatorBaseID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorNameByPK(string operatorBaseID, string operatorName, TransactionManager tm_ = null)
		{
			RepairPutOperatorNameByPKData(operatorBaseID, operatorName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorNameByPKAsync(string operatorBaseID, string operatorName, TransactionManager tm_ = null)
		{
			RepairPutOperatorNameByPKData(operatorBaseID, operatorName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorNameByPKData(string operatorBaseID, string operatorName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorName", operatorName != null ? operatorName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorName(string operatorName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName";
			var parameter_ = Database.CreateInParameter("@OperatorName", operatorName != null ? operatorName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorNameAsync(string operatorName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorName` = @OperatorName";
			var parameter_ = Database.CreateInParameter("@OperatorName", operatorName != null ? operatorName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorName
		#region PutOperatorType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorTypeByPK(string operatorBaseID, int operatorType, TransactionManager tm_ = null)
		{
			RepairPutOperatorTypeByPKData(operatorBaseID, operatorType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorTypeByPKAsync(string operatorBaseID, int operatorType, TransactionManager tm_ = null)
		{
			RepairPutOperatorTypeByPKData(operatorBaseID, operatorType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorTypeByPKData(string operatorBaseID, int operatorType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorType` = @OperatorType  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorType(int operatorType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorType` = @OperatorType";
			var parameter_ = Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorTypeAsync(int operatorType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorType` = @OperatorType";
			var parameter_ = Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorType
		#region PutOperatorMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorModeByPK(string operatorBaseID, int? operatorMode, TransactionManager tm_ = null)
		{
			RepairPutOperatorModeByPKData(operatorBaseID, operatorMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorModeByPKAsync(string operatorBaseID, int? operatorMode, TransactionManager tm_ = null)
		{
			RepairPutOperatorModeByPKData(operatorBaseID, operatorMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorModeByPKData(string operatorBaseID, int? operatorMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorMode` = @OperatorMode  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorMode", operatorMode.HasValue ? operatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorMode(int? operatorMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorMode` = @OperatorMode";
			var parameter_ = Database.CreateInParameter("@OperatorMode", operatorMode.HasValue ? operatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorModeAsync(int? operatorMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorMode` = @OperatorMode";
			var parameter_ = Database.CreateInParameter("@OperatorMode", operatorMode.HasValue ? operatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorMode
		#region PutAllowVisitor
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAllowVisitorByPK(string operatorBaseID, bool allowVisitor, TransactionManager tm_ = null)
		{
			RepairPutAllowVisitorByPKData(operatorBaseID, allowVisitor, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAllowVisitorByPKAsync(string operatorBaseID, bool allowVisitor, TransactionManager tm_ = null)
		{
			RepairPutAllowVisitorByPKData(operatorBaseID, allowVisitor, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAllowVisitorByPKData(string operatorBaseID, bool allowVisitor, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AllowVisitor` = @AllowVisitor  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAllowVisitor(bool allowVisitor, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AllowVisitor` = @AllowVisitor";
			var parameter_ = Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAllowVisitorAsync(bool allowVisitor, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AllowVisitor` = @AllowVisitor";
			var parameter_ = Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAllowVisitor
		#region PutOperPublicKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperPublicKeyByPK(string operatorBaseID, string operPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOperPublicKeyByPKData(operatorBaseID, operPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperPublicKeyByPKAsync(string operatorBaseID, string operPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOperPublicKeyByPKData(operatorBaseID, operPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperPublicKeyByPKData(string operatorBaseID, string operPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperPublicKey` = @OperPublicKey  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperPublicKey", operPublicKey != null ? operPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperPublicKey(string operPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperPublicKey` = @OperPublicKey";
			var parameter_ = Database.CreateInParameter("@OperPublicKey", operPublicKey != null ? operPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperPublicKeyAsync(string operPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperPublicKey` = @OperPublicKey";
			var parameter_ = Database.CreateInParameter("@OperPublicKey", operPublicKey != null ? operPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperPublicKey
		#region PutOperPrivateKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperPrivateKeyByPK(string operatorBaseID, string operPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOperPrivateKeyByPKData(operatorBaseID, operPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperPrivateKeyByPKAsync(string operatorBaseID, string operPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOperPrivateKeyByPKData(operatorBaseID, operPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperPrivateKeyByPKData(string operatorBaseID, string operPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperPrivateKey` = @OperPrivateKey  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperPrivateKey", operPrivateKey != null ? operPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperPrivateKey(string operPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperPrivateKey` = @OperPrivateKey";
			var parameter_ = Database.CreateInParameter("@OperPrivateKey", operPrivateKey != null ? operPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperPrivateKeyAsync(string operPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperPrivateKey` = @OperPrivateKey";
			var parameter_ = Database.CreateInParameter("@OperPrivateKey", operPrivateKey != null ? operPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperPrivateKey
		#region PutOwnPublicKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPublicKeyByPK(string operatorBaseID, string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPublicKeyByPKData(operatorBaseID, ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOwnPublicKeyByPKAsync(string operatorBaseID, string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPublicKeyByPKData(operatorBaseID, ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOwnPublicKeyByPKData(string operatorBaseID, string ownPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OwnPublicKey` = @OwnPublicKey  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OwnPublicKey", ownPublicKey != null ? ownPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPublicKey(string ownPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OwnPublicKey` = @OwnPublicKey";
			var parameter_ = Database.CreateInParameter("@OwnPublicKey", ownPublicKey != null ? ownPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOwnPublicKeyAsync(string ownPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OwnPublicKey` = @OwnPublicKey";
			var parameter_ = Database.CreateInParameter("@OwnPublicKey", ownPublicKey != null ? ownPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOwnPublicKey
		#region PutOwnPrivateKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPrivateKeyByPK(string operatorBaseID, string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPrivateKeyByPKData(operatorBaseID, ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOwnPrivateKeyByPKAsync(string operatorBaseID, string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPrivateKeyByPKData(operatorBaseID, ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOwnPrivateKeyByPKData(string operatorBaseID, string ownPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OwnPrivateKey` = @OwnPrivateKey  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey != null ? ownPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPrivateKey(string ownPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OwnPrivateKey` = @OwnPrivateKey";
			var parameter_ = Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey != null ? ownPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOwnPrivateKeyAsync(string ownPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OwnPrivateKey` = @OwnPrivateKey";
			var parameter_ = Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey != null ? ownPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOwnPrivateKey
		#region PutOperatorConfig
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorConfigByPK(string operatorBaseID, string operatorConfig, TransactionManager tm_ = null)
		{
			RepairPutOperatorConfigByPKData(operatorBaseID, operatorConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorConfigByPKAsync(string operatorBaseID, string operatorConfig, TransactionManager tm_ = null)
		{
			RepairPutOperatorConfigByPKData(operatorBaseID, operatorConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorConfigByPKData(string operatorBaseID, string operatorConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorConfig` = @OperatorConfig  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorConfig", operatorConfig != null ? operatorConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorConfig(string operatorConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorConfig` = @OperatorConfig";
			var parameter_ = Database.CreateInParameter("@OperatorConfig", operatorConfig != null ? operatorConfig : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorConfigAsync(string operatorConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorConfig` = @OperatorConfig";
			var parameter_ = Database.CreateInParameter("@OperatorConfig", operatorConfig != null ? operatorConfig : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorConfig
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string operatorBaseID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(operatorBaseID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string operatorBaseID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(operatorBaseID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string operatorBaseID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
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
		#region PutSettlDayNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlDayNumByPK(string operatorBaseID, int settlDayNum, TransactionManager tm_ = null)
		{
			RepairPutSettlDayNumByPKData(operatorBaseID, settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlDayNumByPKAsync(string operatorBaseID, int settlDayNum, TransactionManager tm_ = null)
		{
			RepairPutSettlDayNumByPKData(operatorBaseID, settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlDayNumByPKData(string operatorBaseID, int settlDayNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlDayNum` = @SettlDayNum  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlDayNum(int settlDayNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlDayNum` = @SettlDayNum";
			var parameter_ = Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSettlDayNumAsync(int settlDayNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `SettlDayNum` = @SettlDayNum";
			var parameter_ = Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSettlDayNum
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string operatorBaseID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorBaseID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string operatorBaseID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorBaseID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string operatorBaseID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorBaseID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorBaseID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorBaseID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorBaseID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorBaseID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
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
		#region PutOperAdminUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminUrlByPK(string operatorBaseID, string operAdminUrl, TransactionManager tm_ = null)
		{
			RepairPutOperAdminUrlByPKData(operatorBaseID, operAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperAdminUrlByPKAsync(string operatorBaseID, string operAdminUrl, TransactionManager tm_ = null)
		{
			RepairPutOperAdminUrlByPKData(operatorBaseID, operAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperAdminUrlByPKData(string operatorBaseID, string operAdminUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperAdminUrl` = @OperAdminUrl  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperAdminUrl", operAdminUrl != null ? operAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminUrl(string operAdminUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminUrl` = @OperAdminUrl";
			var parameter_ = Database.CreateInParameter("@OperAdminUrl", operAdminUrl != null ? operAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperAdminUrlAsync(string operAdminUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminUrl` = @OperAdminUrl";
			var parameter_ = Database.CreateInParameter("@OperAdminUrl", operAdminUrl != null ? operAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperAdminUrl
		#region PutOperAdminUser
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminUserByPK(string operatorBaseID, string operAdminUser, TransactionManager tm_ = null)
		{
			RepairPutOperAdminUserByPKData(operatorBaseID, operAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperAdminUserByPKAsync(string operatorBaseID, string operAdminUser, TransactionManager tm_ = null)
		{
			RepairPutOperAdminUserByPKData(operatorBaseID, operAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperAdminUserByPKData(string operatorBaseID, string operAdminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperAdminUser` = @OperAdminUser  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperAdminUser", operAdminUser != null ? operAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminUser(string operAdminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminUser` = @OperAdminUser";
			var parameter_ = Database.CreateInParameter("@OperAdminUser", operAdminUser != null ? operAdminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperAdminUserAsync(string operAdminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminUser` = @OperAdminUser";
			var parameter_ = Database.CreateInParameter("@OperAdminUser", operAdminUser != null ? operAdminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperAdminUser
		#region PutOperAdminPwd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminPwdByPK(string operatorBaseID, string operAdminPwd, TransactionManager tm_ = null)
		{
			RepairPutOperAdminPwdByPKData(operatorBaseID, operAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperAdminPwdByPKAsync(string operatorBaseID, string operAdminPwd, TransactionManager tm_ = null)
		{
			RepairPutOperAdminPwdByPKData(operatorBaseID, operAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperAdminPwdByPKData(string operatorBaseID, string operAdminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperAdminPwd` = @OperAdminPwd  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperAdminPwd", operAdminPwd != null ? operAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperAdminPwd(string operAdminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminPwd` = @OperAdminPwd";
			var parameter_ = Database.CreateInParameter("@OperAdminPwd", operAdminPwd != null ? operAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperAdminPwdAsync(string operAdminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperAdminPwd` = @OperAdminPwd";
			var parameter_ = Database.CreateInParameter("@OperAdminPwd", operAdminPwd != null ? operAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperAdminPwd
		#region PutCashAudit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAuditByPK(string operatorBaseID, int cashAudit, TransactionManager tm_ = null)
		{
			RepairPutCashAuditByPKData(operatorBaseID, cashAudit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCashAuditByPKAsync(string operatorBaseID, int cashAudit, TransactionManager tm_ = null)
		{
			RepairPutCashAuditByPKData(operatorBaseID, cashAudit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCashAuditByPKData(string operatorBaseID, int cashAudit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CashAudit` = @CashAudit  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCashAudit(int cashAudit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAudit` = @CashAudit";
			var parameter_ = Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCashAuditAsync(int cashAudit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CashAudit` = @CashAudit";
			var parameter_ = Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCashAudit
		#region PutLowestCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLowestCashAmountByPK(string operatorBaseID, long lowestCashAmount, TransactionManager tm_ = null)
		{
			RepairPutLowestCashAmountByPKData(operatorBaseID, lowestCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLowestCashAmountByPKAsync(string operatorBaseID, long lowestCashAmount, TransactionManager tm_ = null)
		{
			RepairPutLowestCashAmountByPKData(operatorBaseID, lowestCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLowestCashAmountByPKData(string operatorBaseID, long lowestCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LowestCashAmount` = @LowestCashAmount  WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLowestCashAmount(long lowestCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LowestCashAmount` = @LowestCashAmount";
			var parameter_ = Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLowestCashAmountAsync(long lowestCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LowestCashAmount` = @LowestCashAmount";
			var parameter_ = Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLowestCashAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_operator_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorBaseID) == null)
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
		public async Task<bool> SetAsync(S_operator_baseEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorBaseID) == null)
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
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_operator_baseEO GetByPK(string operatorBaseID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<S_operator_baseEO> GetByPKAsync(string operatorBaseID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorBaseID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorBaseID` = @OperatorBaseID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorName（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorNameByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorName`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperatorNameByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorName`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorType（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOperatorTypeByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OperatorType`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<int> GetOperatorTypeByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OperatorType`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorMode（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetOperatorModeByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`OperatorMode`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<int?> GetOperatorModeByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`OperatorMode`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AllowVisitor（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetAllowVisitorByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`AllowVisitor`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<bool> GetAllowVisitorByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`AllowVisitor`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperPublicKey（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperPublicKeyByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperPublicKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperPublicKeyByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperPublicKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperPrivateKey（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperPrivateKeyByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperPrivateKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperPrivateKeyByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperPrivateKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OwnPublicKey（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOwnPublicKeyByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OwnPublicKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOwnPublicKeyByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OwnPublicKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OwnPrivateKey（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOwnPrivateKeyByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OwnPrivateKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOwnPrivateKeyByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OwnPrivateKey`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorConfig（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorConfigByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorConfig`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperatorConfigByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorConfig`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlDayNum（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSettlDayNumByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SettlDayNum`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<int> GetSettlDayNumByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SettlDayNum`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperAdminUrl（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperAdminUrlByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperAdminUrl`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperAdminUrlByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperAdminUrl`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperAdminUser（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperAdminUserByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperAdminUser`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperAdminUserByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperAdminUser`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperAdminPwd（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperAdminPwdByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperAdminPwd`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<string> GetOperAdminPwdByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperAdminPwd`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CashAudit（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCashAuditByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CashAudit`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<int> GetCashAuditByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CashAudit`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LowestCashAmount（字段）
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLowestCashAmountByPK(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LowestCashAmount`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		public async Task<long> GetLowestCashAmountByPKAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LowestCashAmount`", "`OperatorBaseID` = @OperatorBaseID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorName
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName)
		{
			return await GetByOperatorNameAsync(operatorName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, int top_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, int top_)
		{
			return await GetByOperatorNameAsync(operatorName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, int top_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, int top_, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, string sort_)
		{
			return GetByOperatorName(operatorName, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, string sort_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, string sort_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorNameAsync(operatorName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorName(string operatorName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorName != null ? "`OperatorName` = @OperatorName" : "`OperatorName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorName != null)
				paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorNameAsync(string operatorName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorName != null ? "`OperatorName` = @OperatorName" : "`OperatorName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorName != null)
				paras_.Add(Database.CreateInParameter("@OperatorName", operatorName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperatorName
		#region GetByOperatorType
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType)
		{
			return GetByOperatorType(operatorType, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType)
		{
			return await GetByOperatorTypeAsync(operatorType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, TransactionManager tm_)
		{
			return await GetByOperatorTypeAsync(operatorType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, int top_)
		{
			return GetByOperatorType(operatorType, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, int top_)
		{
			return await GetByOperatorTypeAsync(operatorType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, int top_, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, int top_, TransactionManager tm_)
		{
			return await GetByOperatorTypeAsync(operatorType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, string sort_)
		{
			return GetByOperatorType(operatorType, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, string sort_)
		{
			return await GetByOperatorTypeAsync(operatorType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, string sort_, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorTypeAsync(operatorType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorType(int operatorType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorType` = @OperatorType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorTypeAsync(int operatorType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorType` = @OperatorType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperatorType
		#region GetByOperatorMode
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode)
		{
			return GetByOperatorMode(operatorMode, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode)
		{
			return await GetByOperatorModeAsync(operatorMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, TransactionManager tm_)
		{
			return await GetByOperatorModeAsync(operatorMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, int top_)
		{
			return GetByOperatorMode(operatorMode, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, int top_)
		{
			return await GetByOperatorModeAsync(operatorMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, int top_, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, int top_, TransactionManager tm_)
		{
			return await GetByOperatorModeAsync(operatorMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, string sort_)
		{
			return GetByOperatorMode(operatorMode, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, string sort_)
		{
			return await GetByOperatorModeAsync(operatorMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, string sort_, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorModeAsync(operatorMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorMode(int? operatorMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorMode.HasValue ? "`OperatorMode` = @OperatorMode" : "`OperatorMode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorMode.HasValue)
				paras_.Add(Database.CreateInParameter("@OperatorMode", operatorMode.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorModeAsync(int? operatorMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorMode.HasValue ? "`OperatorMode` = @OperatorMode" : "`OperatorMode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorMode.HasValue)
				paras_.Add(Database.CreateInParameter("@OperatorMode", operatorMode.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperatorMode
		#region GetByAllowVisitor
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor)
		{
			return GetByAllowVisitor(allowVisitor, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor)
		{
			return await GetByAllowVisitorAsync(allowVisitor, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, TransactionManager tm_)
		{
			return await GetByAllowVisitorAsync(allowVisitor, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, int top_)
		{
			return GetByAllowVisitor(allowVisitor, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, int top_)
		{
			return await GetByAllowVisitorAsync(allowVisitor, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, int top_, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, int top_, TransactionManager tm_)
		{
			return await GetByAllowVisitorAsync(allowVisitor, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, string sort_)
		{
			return GetByAllowVisitor(allowVisitor, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, string sort_)
		{
			return await GetByAllowVisitorAsync(allowVisitor, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, string sort_, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, string sort_, TransactionManager tm_)
		{
			return await GetByAllowVisitorAsync(allowVisitor, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByAllowVisitor(bool allowVisitor, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AllowVisitor` = @AllowVisitor", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByAllowVisitorAsync(bool allowVisitor, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AllowVisitor` = @AllowVisitor", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByAllowVisitor
		#region GetByOperPublicKey
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey)
		{
			return GetByOperPublicKey(operPublicKey, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, TransactionManager tm_)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, int top_)
		{
			return GetByOperPublicKey(operPublicKey, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, int top_)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, int top_, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, int top_, TransactionManager tm_)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, string sort_)
		{
			return GetByOperPublicKey(operPublicKey, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, string sort_)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, string sort_, TransactionManager tm_)
		{
			return await GetByOperPublicKeyAsync(operPublicKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPublicKey(string operPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operPublicKey != null ? "`OperPublicKey` = @OperPublicKey" : "`OperPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OperPublicKey", operPublicKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPublicKeyAsync(string operPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operPublicKey != null ? "`OperPublicKey` = @OperPublicKey" : "`OperPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OperPublicKey", operPublicKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperPublicKey
		#region GetByOperPrivateKey
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, TransactionManager tm_)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, int top_)
		{
			return GetByOperPrivateKey(operPrivateKey, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, int top_)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, int top_, TransactionManager tm_)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, string sort_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, string sort_)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, string sort_, TransactionManager tm_)
		{
			return await GetByOperPrivateKeyAsync(operPrivateKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperPrivateKey(string operPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operPrivateKey != null ? "`OperPrivateKey` = @OperPrivateKey" : "`OperPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OperPrivateKey", operPrivateKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperPrivateKeyAsync(string operPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operPrivateKey != null ? "`OperPrivateKey` = @OperPrivateKey" : "`OperPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OperPrivateKey", operPrivateKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperPrivateKey
		#region GetByOwnPublicKey
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, TransactionManager tm_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, int top_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_, TransactionManager tm_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, string sort_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, string sort_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, string sort_, TransactionManager tm_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPublicKey(string ownPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPublicKey != null ? "`OwnPublicKey` = @OwnPublicKey" : "`OwnPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPublicKey", ownPublicKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPublicKey != null ? "`OwnPublicKey` = @OwnPublicKey" : "`OwnPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPublicKey", ownPublicKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOwnPublicKey
		#region GetByOwnPrivateKey
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, TransactionManager tm_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, int top_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_, TransactionManager tm_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, string sort_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, string sort_, TransactionManager tm_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPrivateKey != null ? "`OwnPrivateKey` = @OwnPrivateKey" : "`OwnPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPrivateKey != null ? "`OwnPrivateKey` = @OwnPrivateKey" : "`OwnPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOwnPrivateKey
		#region GetByOperatorConfig
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig)
		{
			return GetByOperatorConfig(operatorConfig, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig)
		{
			return await GetByOperatorConfigAsync(operatorConfig, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, TransactionManager tm_)
		{
			return await GetByOperatorConfigAsync(operatorConfig, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, int top_)
		{
			return GetByOperatorConfig(operatorConfig, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, int top_)
		{
			return await GetByOperatorConfigAsync(operatorConfig, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, int top_, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, int top_, TransactionManager tm_)
		{
			return await GetByOperatorConfigAsync(operatorConfig, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, string sort_)
		{
			return GetByOperatorConfig(operatorConfig, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, string sort_)
		{
			return await GetByOperatorConfigAsync(operatorConfig, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, string sort_, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorConfigAsync(operatorConfig, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperatorConfig(string operatorConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorConfig != null ? "`OperatorConfig` = @OperatorConfig" : "`OperatorConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorConfig != null)
				paras_.Add(Database.CreateInParameter("@OperatorConfig", operatorConfig, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperatorConfigAsync(string operatorConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorConfig != null ? "`OperatorConfig` = @OperatorConfig" : "`OperatorConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorConfig != null)
				paras_.Add(Database.CreateInParameter("@OperatorConfig", operatorConfig, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperatorConfig
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, int top_)
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
		public List<S_operator_baseEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, string sort_)
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
		public List<S_operator_baseEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
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
		public List<S_operator_baseEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetBySettlDayNum
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, TransactionManager tm_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, int top_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, int top_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, int top_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, int top_, TransactionManager tm_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, string sort_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, string sort_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, string sort_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, string sort_, TransactionManager tm_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetBySettlDayNum(int settlDayNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlDayNum` = @SettlDayNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetBySettlDayNumAsync(int settlDayNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlDayNum` = @SettlDayNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetBySettlDayNum
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_operator_baseEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_operator_baseEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_operator_baseEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_operator_baseEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByOperAdminUrl
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl)
		{
			return GetByOperAdminUrl(operAdminUrl, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, TransactionManager tm_)
		{
			return GetByOperAdminUrl(operAdminUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, TransactionManager tm_)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, int top_)
		{
			return GetByOperAdminUrl(operAdminUrl, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, int top_)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, int top_, TransactionManager tm_)
		{
			return GetByOperAdminUrl(operAdminUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, int top_, TransactionManager tm_)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, string sort_)
		{
			return GetByOperAdminUrl(operAdminUrl, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, string sort_)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, string sort_, TransactionManager tm_)
		{
			return GetByOperAdminUrl(operAdminUrl, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, string sort_, TransactionManager tm_)
		{
			return await GetByOperAdminUrlAsync(operAdminUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUrl">运营商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUrl(string operAdminUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminUrl != null ? "`OperAdminUrl` = @OperAdminUrl" : "`OperAdminUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUrl", operAdminUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUrlAsync(string operAdminUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminUrl != null ? "`OperAdminUrl` = @OperAdminUrl" : "`OperAdminUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUrl", operAdminUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperAdminUrl
		#region GetByOperAdminUser
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser)
		{
			return GetByOperAdminUser(operAdminUser, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser)
		{
			return await GetByOperAdminUserAsync(operAdminUser, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, TransactionManager tm_)
		{
			return GetByOperAdminUser(operAdminUser, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, TransactionManager tm_)
		{
			return await GetByOperAdminUserAsync(operAdminUser, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, int top_)
		{
			return GetByOperAdminUser(operAdminUser, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, int top_)
		{
			return await GetByOperAdminUserAsync(operAdminUser, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, int top_, TransactionManager tm_)
		{
			return GetByOperAdminUser(operAdminUser, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, int top_, TransactionManager tm_)
		{
			return await GetByOperAdminUserAsync(operAdminUser, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, string sort_)
		{
			return GetByOperAdminUser(operAdminUser, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, string sort_)
		{
			return await GetByOperAdminUserAsync(operAdminUser, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, string sort_, TransactionManager tm_)
		{
			return GetByOperAdminUser(operAdminUser, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, string sort_, TransactionManager tm_)
		{
			return await GetByOperAdminUserAsync(operAdminUser, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminUser">运营商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminUser(string operAdminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminUser != null ? "`OperAdminUser` = @OperAdminUser" : "`OperAdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminUser != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUser", operAdminUser, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminUserAsync(string operAdminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminUser != null ? "`OperAdminUser` = @OperAdminUser" : "`OperAdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminUser != null)
				paras_.Add(Database.CreateInParameter("@OperAdminUser", operAdminUser, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperAdminUser
		#region GetByOperAdminPwd
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd)
		{
			return GetByOperAdminPwd(operAdminPwd, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, TransactionManager tm_)
		{
			return GetByOperAdminPwd(operAdminPwd, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, TransactionManager tm_)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, int top_)
		{
			return GetByOperAdminPwd(operAdminPwd, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, int top_)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, int top_, TransactionManager tm_)
		{
			return GetByOperAdminPwd(operAdminPwd, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, int top_, TransactionManager tm_)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, string sort_)
		{
			return GetByOperAdminPwd(operAdminPwd, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, string sort_)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, string sort_, TransactionManager tm_)
		{
			return GetByOperAdminPwd(operAdminPwd, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, string sort_, TransactionManager tm_)
		{
			return await GetByOperAdminPwdAsync(operAdminPwd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "operAdminPwd">运营商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByOperAdminPwd(string operAdminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminPwd != null ? "`OperAdminPwd` = @OperAdminPwd" : "`OperAdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@OperAdminPwd", operAdminPwd, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByOperAdminPwdAsync(string operAdminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operAdminPwd != null ? "`OperAdminPwd` = @OperAdminPwd" : "`OperAdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@OperAdminPwd", operAdminPwd, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByOperAdminPwd
		#region GetByCashAudit
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit)
		{
			return GetByCashAudit(cashAudit, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit)
		{
			return await GetByCashAuditAsync(cashAudit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, TransactionManager tm_)
		{
			return await GetByCashAuditAsync(cashAudit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, int top_)
		{
			return GetByCashAudit(cashAudit, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, int top_)
		{
			return await GetByCashAuditAsync(cashAudit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, int top_, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, int top_, TransactionManager tm_)
		{
			return await GetByCashAuditAsync(cashAudit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, string sort_)
		{
			return GetByCashAudit(cashAudit, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, string sort_)
		{
			return await GetByCashAuditAsync(cashAudit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, string sort_, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, string sort_, TransactionManager tm_)
		{
			return await GetByCashAuditAsync(cashAudit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit">提现审计模式0-不审计1-审计</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByCashAudit(int cashAudit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAudit` = @CashAudit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByCashAuditAsync(int cashAudit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAudit` = @CashAudit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByCashAudit
		#region GetByLowestCashAmount
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount)
		{
			return GetByLowestCashAmount(lowestCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, TransactionManager tm_)
		{
			return GetByLowestCashAmount(lowestCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, TransactionManager tm_)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, int top_)
		{
			return GetByLowestCashAmount(lowestCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, int top_)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, int top_, TransactionManager tm_)
		{
			return GetByLowestCashAmount(lowestCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, string sort_)
		{
			return GetByLowestCashAmount(lowestCashAmount, 0, sort_, null);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, string sort_)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByLowestCashAmount(lowestCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLowestCashAmountAsync(lowestCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LowestCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "lowestCashAmount">最低提现额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operator_baseEO> GetByLowestCashAmount(long lowestCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LowestCashAmount` = @LowestCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		public async Task<List<S_operator_baseEO>> GetByLowestCashAmountAsync(long lowestCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LowestCashAmount` = @LowestCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LowestCashAmount", lowestCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operator_baseEO.MapDataReader);
		}
		#endregion // GetByLowestCashAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
