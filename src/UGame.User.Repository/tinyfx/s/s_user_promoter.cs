/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:45
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
	/// 推广员推广的用户表
	/// 【表 s_user_promoter 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_user_promoterEO : IRowMapper<S_user_promoterEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_user_promoterEO()
		{
			this.PromoteTime = DateTime.Now;
			this.UserKind = 1;
			this.FromMode = 0;
			this.CurrencyType = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalPUserID;
		/// <summary>
		/// 【数据库中的原始主键 PUserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalPUserID
		{
			get { return _originalPUserID; }
			set { HasOriginal = true; _originalPUserID = value; }
		}
		
		private string _originalIUserID;
		/// <summary>
		/// 【数据库中的原始主键 IUserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalIUserID
		{
			get { return _originalIUserID; }
			set { HasOriginal = true; _originalIUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "PUserID", PUserID },  { "IUserID", IUserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 推广员用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string PUserID { get; set; }
		/// <summary>
		/// 被邀请用户编码
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string IUserID { get; set; }
		/// <summary>
		/// 推广时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 3)]
		public DateTime PromoteTime { get; set; }
		/// <summary>
		/// 用户类型
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int UserKind { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 新用户来源方式
		///              0-获得运营商的新用户(s_operator)
		///              1-推广员获得的新用户（userid）
		///              2-推广渠道通过url获得的新用户（s_channel_url)
		///              3-推广渠道通过code获得的新用户（s_channel_code)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FromMode { get; set; }
		/// <summary>
		/// 对应的编码（根据FromMode变化）
		///              FromMode=
		///              0-运营商的新用户(s_operator)==> OperatorID
		///              1-推广员获得的新用户（userid） ==> 邀请人的UserID
		///              2-推广渠道通过url获得的新用户（s_channel_url) ==> CUrlID
		///              3-推广渠道通过code获得的新用户（s_channel_code) ==> CCodeID
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 7)]
		public string FromId { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 8)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型（货币缩写RMB,USD）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 9)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int CurrencyType { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_user_promoterEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_user_promoterEO MapDataReader(IDataReader reader)
		{
		    S_user_promoterEO ret = new S_user_promoterEO();
			ret.PUserID = reader.ToString("PUserID");
			ret.OriginalPUserID = ret.PUserID;
			ret.IUserID = reader.ToString("IUserID");
			ret.OriginalIUserID = ret.IUserID;
			ret.PromoteTime = reader.ToDateTime("PromoteTime");
			ret.UserKind = reader.ToInt32("UserKind");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.FromMode = reader.ToInt32("FromMode");
			ret.FromId = reader.ToString("FromId");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.CurrencyType = reader.ToInt32("CurrencyType");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 推广员推广的用户表
	/// 【表 s_user_promoter 的操作类】
	/// </summary>
	[Obsolete]
	public class S_user_promoterMO : MySqlTableMO<S_user_promoterEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_user_promoter`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_user_promoterMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_user_promoterMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_user_promoterMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_user_promoterEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_user_promoterEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_user_promoterEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`PUserID`, `IUserID`, `PromoteTime`, `UserKind`, `OperatorID`, `FromMode`, `FromId`, `CountryID`, `CurrencyID`, `CurrencyType`) VALUE (@PUserID, @IUserID, @PromoteTime, @UserKind, @OperatorID, @FromMode, @FromId, @CountryID, @CurrencyID, @CurrencyType);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", item.IUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@PromoteTime", item.PromoteTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<S_user_promoterEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_user_promoterEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_user_promoterEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`PUserID`, `IUserID`, `PromoteTime`, `UserKind`, `OperatorID`, `FromMode`, `FromId`, `CountryID`, `CurrencyID`, `CurrencyType`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.PUserID}','{item.IUserID}','{item.PromoteTime.ToString("yyyy-MM-dd HH:mm:ss")}',{item.UserKind},'{item.OperatorID}',{item.FromMode},'{item.FromId}','{item.CountryID}','{item.CurrencyID}',{item.CurrencyType}),");
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
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(pUserID, iUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(pUserID, iUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string pUserID, string iUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_user_promoterEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.PUserID, item.IUserID, tm_);
		}
		public async Task<int> RemoveAsync(S_user_promoterEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.PUserID, item.IUserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByPUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPUserID(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByPUserIDData(pUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPUserIDData(string pUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PUserID` = @PUserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPUserID
		#region RemoveByIUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIUserID(string iUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByIUserIDData(iUserID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIUserIDAsync(string iUserID, TransactionManager tm_ = null)
		{
			RepairRemoveByIUserIDData(iUserID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIUserIDData(string iUserID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByIUserID
		#region RemoveByPromoteTime
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPromoteTime(DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoteTimeData(promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairRemoveByPromoteTimeData(promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPromoteTimeData(DateTime promoteTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PromoteTime` = @PromoteTime";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
		}
		#endregion // RemoveByPromoteTime
		#region RemoveByUserKind
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserKind(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			RepairRemoveByUserKindData(userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserKindData(int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserKind` = @UserKind";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
		}
		#endregion // RemoveByUserKind
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
		#region RemoveByFromMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromMode(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFromModeData(fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromModeData(int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FromMode` = @FromMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByFromMode
		#region RemoveByFromId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFromId(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			RepairRemoveByFromIdData(fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFromIdData(string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFromId
		#region RemoveByCountryID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryIDData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryIDData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByCurrencyType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyType(int currencyType, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyTypeData(currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyTypeData(int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyType` = @CurrencyType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
		}
		#endregion // RemoveByCurrencyType
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
		public int Put(S_user_promoterEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_user_promoterEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_user_promoterEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID, `IUserID` = @IUserID, `UserKind` = @UserKind, `OperatorID` = @OperatorID, `FromMode` = @FromMode, `FromId` = @FromId, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `CurrencyType` = @CurrencyType WHERE `PUserID` = @PUserID_Original AND `IUserID` = @IUserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", item.IUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@FromMode", item.FromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FromId", item.FromId != null ? item.FromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID_Original", item.HasOriginal ? item.OriginalPUserID : item.PUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID_Original", item.HasOriginal ? item.OriginalIUserID : item.IUserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_user_promoterEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_user_promoterEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string iUserID, string set_, params object[] values_)
		{
			return Put(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", ConcatValues(values_, pUserID, iUserID));
		}
		public async Task<int> PutByPKAsync(string pUserID, string iUserID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", ConcatValues(values_, pUserID, iUserID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string iUserID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", tm_, ConcatValues(values_, pUserID, iUserID));
		}
		public async Task<int> PutByPKAsync(string pUserID, string iUserID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", tm_, ConcatValues(values_, pUserID, iUserID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string pUserID, string iUserID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string pUserID, string iUserID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`PUserID` = @PUserID AND `IUserID` = @IUserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutPUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPUserID(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPUserIDAsync(string pUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PUserID` = @PUserID";
			var parameter_ = Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPUserID
		#region PutIUserID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIUserID(string iUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IUserID` = @IUserID";
			var parameter_ = Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIUserIDAsync(string iUserID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IUserID` = @IUserID";
			var parameter_ = Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIUserID
		#region PutPromoteTime
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoteTimeByPK(string pUserID, string iUserID, DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairPutPromoteTimeByPKData(pUserID, iUserID, promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPromoteTimeByPKAsync(string pUserID, string iUserID, DateTime promoteTime, TransactionManager tm_ = null)
		{
			RepairPutPromoteTimeByPKData(pUserID, iUserID, promoteTime, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPromoteTimeByPKData(string pUserID, string iUserID, DateTime promoteTime, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPromoteTime(DateTime promoteTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime";
			var parameter_ = Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PromoteTime` = @PromoteTime";
			var parameter_ = Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPromoteTime
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string pUserID, string iUserID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(pUserID, iUserID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string pUserID, string iUserID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(pUserID, iUserID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string pUserID, string iUserID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKind(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserKindAsync(int userKind, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind";
			var parameter_ = Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserKind
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string pUserID, string iUserID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(pUserID, iUserID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string pUserID, string iUserID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(pUserID, iUserID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string pUserID, string iUserID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
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
		#region PutFromMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromModeByPK(string pUserID, string iUserID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(pUserID, iUserID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromModeByPKAsync(string pUserID, string iUserID, int fromMode, TransactionManager tm_ = null)
		{
			RepairPutFromModeByPKData(pUserID, iUserID, fromMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromModeByPKData(string pUserID, string iUserID, int fromMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromMode(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromModeAsync(int fromMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromMode` = @FromMode";
			var parameter_ = Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromMode
		#region PutFromId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromIdByPK(string pUserID, string iUserID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(pUserID, iUserID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFromIdByPKAsync(string pUserID, string iUserID, string fromId, TransactionManager tm_ = null)
		{
			RepairPutFromIdByPKData(pUserID, iUserID, fromId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFromIdByPKData(string pUserID, string iUserID, string fromId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FromId` = @FromId  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFromId(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFromIdAsync(string fromId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FromId` = @FromId";
			var parameter_ = Database.CreateInParameter("@FromId", fromId != null ? fromId : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFromId
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string pUserID, string iUserID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(pUserID, iUserID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string pUserID, string iUserID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(pUserID, iUserID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string pUserID, string iUserID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryIDAsync(string countryID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID";
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string pUserID, string iUserID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(pUserID, iUserID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string pUserID, string iUserID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(pUserID, iUserID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string pUserID, string iUserID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutCurrencyType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyTypeByPK(string pUserID, string iUserID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(pUserID, iUserID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyTypeByPKAsync(string pUserID, string iUserID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(pUserID, iUserID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyTypeByPKData(string pUserID, string iUserID, int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType  WHERE `PUserID` = @PUserID AND `IUserID` = @IUserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyType(int currencyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
			var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyTypeAsync(int currencyType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType";
			var parameter_ = Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyType
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_user_promoterEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PUserID, item.IUserID) == null)
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
		public async Task<bool> SetAsync(S_user_promoterEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.PUserID, item.IUserID) == null)
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
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_user_promoterEO GetByPK(string pUserID, string iUserID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(pUserID, iUserID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<S_user_promoterEO> GetByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(pUserID, iUserID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		private void RepairGetByPKData(string pUserID, string iUserID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`PUserID` = @PUserID AND `IUserID` = @IUserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 PUserID（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPUserIDByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`PUserID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetPUserIDByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`PUserID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IUserID（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetIUserIDByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`IUserID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetIUserIDByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`IUserID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PromoteTime（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetPromoteTimeByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`PromoteTime`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<DateTime> GetPromoteTimeByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`PromoteTime`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromMode（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFromModeByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FromMode`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetFromModeByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FromMode`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FromId（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFromIdByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FromId`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetFromIdByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FromId`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyType（字段）
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrencyTypeByPK(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrencyType`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		public async Task<int> GetCurrencyTypeByPKAsync(string pUserID, string iUserID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrencyType`", "`PUserID` = @PUserID AND `IUserID` = @IUserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByPUserID
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID)
		{
			return GetByPUserID(pUserID, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, int top_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, int top_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, int top_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, int top_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, string sort_)
		{
			return GetByPUserID(pUserID, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, string sort_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, string sort_, TransactionManager tm_)
		{
			return GetByPUserID(pUserID, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, string sort_, TransactionManager tm_)
		{
			return await GetByPUserIDAsync(pUserID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PUserID（字段） 查询
		/// </summary>
		/// /// <param name = "pUserID">推广员用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPUserID(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByPUserIDAsync(string pUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PUserID` = @PUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PUserID", pUserID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByPUserID
		#region GetByIUserID
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID)
		{
			return GetByIUserID(iUserID, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID)
		{
			return await GetByIUserIDAsync(iUserID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, int top_)
		{
			return GetByIUserID(iUserID, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, int top_)
		{
			return await GetByIUserIDAsync(iUserID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, int top_, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, int top_, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, string sort_)
		{
			return GetByIUserID(iUserID, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, string sort_)
		{
			return await GetByIUserIDAsync(iUserID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, string sort_, TransactionManager tm_)
		{
			return GetByIUserID(iUserID, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, string sort_, TransactionManager tm_)
		{
			return await GetByIUserIDAsync(iUserID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IUserID（字段） 查询
		/// </summary>
		/// /// <param name = "iUserID">被邀请用户编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByIUserID(string iUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IUserID` = @IUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByIUserIDAsync(string iUserID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IUserID` = @IUserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IUserID", iUserID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByIUserID
		#region GetByPromoteTime
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime)
		{
			return GetByPromoteTime(promoteTime, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, int top_)
		{
			return GetByPromoteTime(promoteTime, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_)
		{
			return await GetByPromoteTimeAsync(promoteTime, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, int top_, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, string sort_)
		{
			return GetByPromoteTime(promoteTime, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, string sort_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, string sort_, TransactionManager tm_)
		{
			return GetByPromoteTime(promoteTime, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, string sort_, TransactionManager tm_)
		{
			return await GetByPromoteTimeAsync(promoteTime, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PromoteTime（字段） 查询
		/// </summary>
		/// /// <param name = "promoteTime">推广时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByPromoteTime(DateTime promoteTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoteTime` = @PromoteTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByPromoteTimeAsync(DateTime promoteTime, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PromoteTime` = @PromoteTime", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PromoteTime", promoteTime, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByPromoteTime
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, int top_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, string sort_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_user_promoterEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByFromMode
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode)
		{
			return GetByFromMode(fromMode, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, int top_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, int top_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, int top_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, int top_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, string sort_)
		{
			return GetByFromMode(fromMode, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, string sort_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, string sort_, TransactionManager tm_)
		{
			return GetByFromMode(fromMode, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, string sort_, TransactionManager tm_)
		{
			return await GetByFromModeAsync(fromMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromMode（字段） 查询
		/// </summary>
		/// /// <param name = "fromMode">新用户来源方式</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromMode(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByFromModeAsync(int fromMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FromMode` = @FromMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FromMode", fromMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByFromMode
		#region GetByFromId
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId)
		{
			return GetByFromId(fromId, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, int top_)
		{
			return GetByFromId(fromId, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, int top_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, int top_, TransactionManager tm_)
		{
			return GetByFromId(fromId, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, int top_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, string sort_)
		{
			return GetByFromId(fromId, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, string sort_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, string sort_, TransactionManager tm_)
		{
			return GetByFromId(fromId, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, string sort_, TransactionManager tm_)
		{
			return await GetByFromIdAsync(fromId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FromId（字段） 查询
		/// </summary>
		/// /// <param name = "fromId">对应的编码（根据FromMode变化）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByFromId(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByFromIdAsync(string fromId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(fromId != null ? "`FromId` = @FromId" : "`FromId` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (fromId != null)
				paras_.Add(Database.CreateInParameter("@FromId", fromId, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByFromId
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, int top_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, string sort_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写RMB,USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCurrencyType
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, int top_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, int top_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, int top_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, string sort_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, null);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, string sort_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, tm_);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_promoterEO> GetByCurrencyType(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		public async Task<List<S_user_promoterEO>> GetByCurrencyTypeAsync(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_promoterEO.MapDataReader);
		}
		#endregion // GetByCurrencyType
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
