/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-05-08 14: 41:11
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
	/// 用户实时数据
	/// 【表 s_user_ex 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_user_exEO : IRowMapper<S_user_exEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_user_exEO()
		{
			this.UserKind = 0;
			this.TotalBonus = 0;
			this.TotalBonusCount = 0;
			this.TotalChangeAmount = 0;
			this.TotalChangeCount = 0;
			this.TotalBetAmount = 0;
			this.TotalBetCount = 0;
			this.TotalWinAmount = 0;
			this.TotalWinCount = 0;
			this.TotalPayAmount = 0;
			this.TotalPayCount = 0;
			this.TotalCashAmount = 0;
			this.TotalCashCount = 0;
			this.FirstPayAmount = 0;
			this.BetCashAmount = 0;
			this.WinCashAmount = 0;
			this.BalanceCashAmount = 0;
			this.TempWithdrawAmount = 0;
			this.WithdrawAmount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户编码(GUID)
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户类型
		///              0-未知
		///              1-普通用户
		///              2-开发用户
		///              3-线上测试用户（调用第三方扣减）
		///              4-线上测试用户（不调用第三方扣减）
		///              5-仿真用户
		///              6-接口联调用户
		///              9-管理员
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int UserKind { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CountryID { get; set; }
		/// <summary>
		/// 货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 赠金总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long TotalBonus { get; set; }
		/// <summary>
		/// 赠金次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int TotalBonusCount { get; set; }
		/// <summary>
		/// 变化总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long TotalChangeAmount { get; set; }
		/// <summary>
		/// 变化次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int TotalChangeCount { get; set; }
		/// <summary>
		/// 下注总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long TotalBetAmount { get; set; }
		/// <summary>
		/// 下注次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int TotalBetCount { get; set; }
		/// <summary>
		/// 返奖总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 12)]
		public long TotalWinAmount { get; set; }
		/// <summary>
		/// 返奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int TotalWinCount { get; set; }
		/// <summary>
		/// 充值总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 14)]
		public long TotalPayAmount { get; set; }
		/// <summary>
		/// 充值次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int TotalPayCount { get; set; }
		/// <summary>
		/// 提现总额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 16)]
		public long TotalCashAmount { get; set; }
		/// <summary>
		/// 提现次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 17)]
		public int TotalCashCount { get; set; }
		/// <summary>
		/// 第一次充值金额
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int FirstPayAmount { get; set; }
		/// <summary>
		/// 真金下注总额(计算可提现金额,会重置)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 19)]
		public long BetCashAmount { get; set; }
		/// <summary>
		/// 真金返奖总额(计算可提现金额,会重置)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 20)]
		public long WinCashAmount { get; set; }
		/// <summary>
		/// 真金余额(计算可提现金额)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 21)]
		public long BalanceCashAmount { get; set; }
		/// <summary>
		/// 充值后的临时可提现真金金额(计算可提现金额)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 22)]
		public long TempWithdrawAmount { get; set; }
		/// <summary>
		/// 可提现真金金额(计算可提现金额)
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long WithdrawAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_user_exEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_user_exEO MapDataReader(IDataReader reader)
		{
		    S_user_exEO ret = new S_user_exEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.UserKind = reader.ToInt32("UserKind");
			ret.OperatorID = reader.ToString("OperatorID");
			ret.CountryID = reader.ToString("CountryID");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.TotalBonus = reader.ToInt64("TotalBonus");
			ret.TotalBonusCount = reader.ToInt32("TotalBonusCount");
			ret.TotalChangeAmount = reader.ToInt64("TotalChangeAmount");
			ret.TotalChangeCount = reader.ToInt32("TotalChangeCount");
			ret.TotalBetAmount = reader.ToInt64("TotalBetAmount");
			ret.TotalBetCount = reader.ToInt32("TotalBetCount");
			ret.TotalWinAmount = reader.ToInt64("TotalWinAmount");
			ret.TotalWinCount = reader.ToInt32("TotalWinCount");
			ret.TotalPayAmount = reader.ToInt64("TotalPayAmount");
			ret.TotalPayCount = reader.ToInt32("TotalPayCount");
			ret.TotalCashAmount = reader.ToInt64("TotalCashAmount");
			ret.TotalCashCount = reader.ToInt32("TotalCashCount");
			ret.FirstPayAmount = reader.ToInt32("FirstPayAmount");
			ret.BetCashAmount = reader.ToInt64("BetCashAmount");
			ret.WinCashAmount = reader.ToInt64("WinCashAmount");
			ret.BalanceCashAmount = reader.ToInt64("BalanceCashAmount");
			ret.TempWithdrawAmount = reader.ToInt64("TempWithdrawAmount");
			ret.WithdrawAmount = reader.ToInt64("WithdrawAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户实时数据
	/// 【表 s_user_ex 的操作类】
	/// </summary>
	[Obsolete]
	public class S_user_exMO : MySqlTableMO<S_user_exEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_user_ex`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_user_exMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_user_exMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_user_exMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_user_exEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_user_exEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_user_exEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `TotalBonus`, `TotalBonusCount`, `TotalChangeAmount`, `TotalChangeCount`, `TotalBetAmount`, `TotalBetCount`, `TotalWinAmount`, `TotalWinCount`, `TotalPayAmount`, `TotalPayCount`, `TotalCashAmount`, `TotalCashCount`, `FirstPayAmount`, `BetCashAmount`, `WinCashAmount`, `BalanceCashAmount`, `TempWithdrawAmount`, `WithdrawAmount`) VALUE (@UserID, @UserKind, @OperatorID, @CountryID, @CurrencyID, @TotalBonus, @TotalBonusCount, @TotalChangeAmount, @TotalChangeCount, @TotalBetAmount, @TotalBetCount, @TotalWinAmount, @TotalWinCount, @TotalPayAmount, @TotalPayCount, @TotalCashAmount, @TotalCashCount, @FirstPayAmount, @BetCashAmount, @WinCashAmount, @BalanceCashAmount, @TempWithdrawAmount, @WithdrawAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TotalBonus", item.TotalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBonusCount", item.TotalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeCount", item.TotalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBetCount", item.TotalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinCount", item.TotalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalPayCount", item.TotalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalCashCount", item.TotalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayAmount", item.FirstPayAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceCashAmount", item.BalanceCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TempWithdrawAmount", item.TempWithdrawAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WithdrawAmount", item.WithdrawAmount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<S_user_exEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_user_exEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_user_exEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `UserKind`, `OperatorID`, `CountryID`, `CurrencyID`, `TotalBonus`, `TotalBonusCount`, `TotalChangeAmount`, `TotalChangeCount`, `TotalBetAmount`, `TotalBetCount`, `TotalWinAmount`, `TotalWinCount`, `TotalPayAmount`, `TotalPayCount`, `TotalCashAmount`, `TotalCashCount`, `FirstPayAmount`, `BetCashAmount`, `WinCashAmount`, `BalanceCashAmount`, `TempWithdrawAmount`, `WithdrawAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}',{item.UserKind},'{item.OperatorID}','{item.CountryID}','{item.CurrencyID}',{item.TotalBonus},{item.TotalBonusCount},{item.TotalChangeAmount},{item.TotalChangeCount},{item.TotalBetAmount},{item.TotalBetCount},{item.TotalWinAmount},{item.TotalWinCount},{item.TotalPayAmount},{item.TotalPayCount},{item.TotalCashAmount},{item.TotalCashCount},{item.FirstPayAmount},{item.BetCashAmount},{item.WinCashAmount},{item.BalanceCashAmount},{item.TempWithdrawAmount},{item.WithdrawAmount}),");
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_user_exEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(S_user_exEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		/// /// <param name = "currencyID">货币类型</param>
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
		#region RemoveByTotalBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBonus(long totalBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusData(totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBonusAsync(long totalBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusData(totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBonusData(long totalBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBonus` = @TotalBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBonus
		#region RemoveByTotalBonusCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBonusCount(int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusCountData(totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBonusCountData(totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBonusCountData(int totalBonusCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBonusCount` = @TotalBonusCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalBonusCount
		#region RemoveByTotalChangeAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeAmountData(totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalChangeAmountData(long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalChangeAmount` = @TotalChangeAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalChangeAmount
		#region RemoveByTotalChangeCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalChangeCount(int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeCountData(totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalChangeCountData(totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalChangeCountData(int totalChangeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalChangeCount` = @TotalChangeCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalChangeCount
		#region RemoveByTotalBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetAmountData(totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetAmountData(long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBetAmount` = @TotalBetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalBetAmount
		#region RemoveByTotalBetCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalBetCount(int totalBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetCountData(totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalBetCountAsync(int totalBetCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalBetCountData(totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalBetCountData(int totalBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalBetCount` = @TotalBetCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalBetCount
		#region RemoveByTotalWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinAmountData(totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalWinAmountData(long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalWinAmount` = @TotalWinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalWinAmount
		#region RemoveByTotalWinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalWinCount(int totalWinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinCountData(totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalWinCountAsync(int totalWinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalWinCountData(totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalWinCountData(int totalWinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalWinCount` = @TotalWinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalWinCount
		#region RemoveByTotalPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayAmountData(totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPayAmountData(long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPayAmount` = @TotalPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalPayAmount
		#region RemoveByTotalPayCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalPayCount(int totalPayCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayCountData(totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalPayCountAsync(int totalPayCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalPayCountData(totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalPayCountData(int totalPayCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalPayCount` = @TotalPayCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalPayCount
		#region RemoveByTotalCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashAmountData(totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalCashAmountData(long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalCashAmount` = @TotalCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTotalCashAmount
		#region RemoveByTotalCashCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTotalCashCount(int totalCashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashCountData(totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTotalCashCountAsync(int totalCashCount, TransactionManager tm_ = null)
		{
			RepairRemoveByTotalCashCountData(totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTotalCashCountData(int totalCashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TotalCashCount` = @TotalCashCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByTotalCashCount
		#region RemoveByFirstPayAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPayAmount(int firstPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayAmountData(firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayAmountAsync(int firstPayAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayAmountData(firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayAmountData(int firstPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstPayAmount` = @FirstPayAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32));
		}
		#endregion // RemoveByFirstPayAmount
		#region RemoveByBetCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetCashAmount(long betCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCashAmountData(betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetCashAmountAsync(long betCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetCashAmountData(betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetCashAmountData(long betCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetCashAmount` = @BetCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetCashAmount
		#region RemoveByWinCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinCashAmount(long winCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCashAmountData(winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinCashAmountAsync(long winCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinCashAmountData(winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinCashAmountData(long winCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinCashAmount` = @WinCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinCashAmount
		#region RemoveByBalanceCashAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBalanceCashAmount(long balanceCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceCashAmountData(balanceCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBalanceCashAmountAsync(long balanceCashAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBalanceCashAmountData(balanceCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBalanceCashAmountData(long balanceCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BalanceCashAmount` = @BalanceCashAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBalanceCashAmount
		#region RemoveByTempWithdrawAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTempWithdrawAmount(long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTempWithdrawAmountData(tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTempWithdrawAmountAsync(long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByTempWithdrawAmountData(tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTempWithdrawAmountData(long tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TempWithdrawAmount` = @TempWithdrawAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByTempWithdrawAmount
		#region RemoveByWithdrawAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWithdrawAmount(long withdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawAmountData(withdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWithdrawAmountAsync(long withdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawAmountData(withdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWithdrawAmountData(long withdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WithdrawAmount` = @WithdrawAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWithdrawAmount
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
		public int Put(S_user_exEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_user_exEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_user_exEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `UserKind` = @UserKind, `OperatorID` = @OperatorID, `CountryID` = @CountryID, `CurrencyID` = @CurrencyID, `TotalBonus` = @TotalBonus, `TotalBonusCount` = @TotalBonusCount, `TotalChangeAmount` = @TotalChangeAmount, `TotalChangeCount` = @TotalChangeCount, `TotalBetAmount` = @TotalBetAmount, `TotalBetCount` = @TotalBetCount, `TotalWinAmount` = @TotalWinAmount, `TotalWinCount` = @TotalWinCount, `TotalPayAmount` = @TotalPayAmount, `TotalPayCount` = @TotalPayCount, `TotalCashAmount` = @TotalCashAmount, `TotalCashCount` = @TotalCashCount, `FirstPayAmount` = @FirstPayAmount, `BetCashAmount` = @BetCashAmount, `WinCashAmount` = @WinCashAmount, `BalanceCashAmount` = @BalanceCashAmount, `TempWithdrawAmount` = @TempWithdrawAmount, `WithdrawAmount` = @WithdrawAmount WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserKind", item.UserKind, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TotalBonus", item.TotalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBonusCount", item.TotalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalChangeAmount", item.TotalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalChangeCount", item.TotalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalBetAmount", item.TotalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalBetCount", item.TotalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalWinAmount", item.TotalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalWinCount", item.TotalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalPayAmount", item.TotalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalPayCount", item.TotalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@TotalCashAmount", item.TotalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TotalCashCount", item.TotalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayAmount", item.FirstPayAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetCashAmount", item.BetCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinCashAmount", item.WinCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BalanceCashAmount", item.BalanceCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@TempWithdrawAmount", item.TempWithdrawAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WithdrawAmount", item.WithdrawAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_user_exEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_user_exEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserKind
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserKindByPK(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserKindByPKAsync(string userID, int userKind, TransactionManager tm_ = null)
		{
			RepairPutUserKindByPKData(userID, userKind, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserKindByPKData(string userID, int userKind, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserKind` = @UserKind  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string userID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(userID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string userID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string userID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(userID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string userID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string userID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(userID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string userID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
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
		#region PutTotalBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusByPK(string userID, long totalBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusByPKData(userID, totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBonusByPKAsync(string userID, long totalBonus, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusByPKData(userID, totalBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBonusByPKData(string userID, long totalBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonus(long totalBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus";
			var parameter_ = Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBonusAsync(long totalBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonus` = @TotalBonus";
			var parameter_ = Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBonus
		#region PutTotalBonusCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusCountByPK(string userID, int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusCountByPKData(userID, totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBonusCountByPKAsync(string userID, int totalBonusCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBonusCountByPKData(userID, totalBonusCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBonusCountByPKData(string userID, int totalBonusCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBonusCount(int totalBonusCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount";
			var parameter_ = Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBonusCount` = @TotalBonusCount";
			var parameter_ = Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBonusCount
		#region PutTotalChangeAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeAmountByPK(string userID, long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeAmountByPKData(userID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalChangeAmountByPKAsync(string userID, long totalChangeAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeAmountByPKData(userID, totalChangeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalChangeAmountByPKData(string userID, long totalChangeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeAmount(long totalChangeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
			var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeAmount` = @TotalChangeAmount";
			var parameter_ = Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalChangeAmount
		#region PutTotalChangeCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeCountByPK(string userID, int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeCountByPKData(userID, totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalChangeCountByPKAsync(string userID, int totalChangeCount, TransactionManager tm_ = null)
		{
			RepairPutTotalChangeCountByPKData(userID, totalChangeCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalChangeCountByPKData(string userID, int totalChangeCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalChangeCount(int totalChangeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount";
			var parameter_ = Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalChangeCount` = @TotalChangeCount";
			var parameter_ = Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalChangeCount
		#region PutTotalBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetAmountByPK(string userID, long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetAmountByPKData(userID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetAmountByPKAsync(string userID, long totalBetAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetAmountByPKData(userID, totalBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetAmountByPKData(string userID, long totalBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetAmount(long totalBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
			var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetAmount` = @TotalBetAmount";
			var parameter_ = Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBetAmount
		#region PutTotalBetCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetCountByPK(string userID, int totalBetCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetCountByPKData(userID, totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalBetCountByPKAsync(string userID, int totalBetCount, TransactionManager tm_ = null)
		{
			RepairPutTotalBetCountByPKData(userID, totalBetCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalBetCountByPKData(string userID, int totalBetCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalBetCount(int totalBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount";
			var parameter_ = Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalBetCountAsync(int totalBetCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalBetCount` = @TotalBetCount";
			var parameter_ = Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalBetCount
		#region PutTotalWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinAmountByPK(string userID, long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinAmountByPKData(userID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalWinAmountByPKAsync(string userID, long totalWinAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinAmountByPKData(userID, totalWinAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalWinAmountByPKData(string userID, long totalWinAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinAmount(long totalWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
			var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinAmount` = @TotalWinAmount";
			var parameter_ = Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalWinAmount
		#region PutTotalWinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinCountByPK(string userID, int totalWinCount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinCountByPKData(userID, totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalWinCountByPKAsync(string userID, int totalWinCount, TransactionManager tm_ = null)
		{
			RepairPutTotalWinCountByPKData(userID, totalWinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalWinCountByPKData(string userID, int totalWinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalWinCount(int totalWinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount";
			var parameter_ = Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalWinCountAsync(int totalWinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalWinCount` = @TotalWinCount";
			var parameter_ = Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalWinCount
		#region PutTotalPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmountByPK(string userID, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(userID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPayAmountByPKAsync(string userID, long totalPayAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayAmountByPKData(userID, totalPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPayAmountByPKData(string userID, long totalPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayAmount(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayAmount` = @TotalPayAmount";
			var parameter_ = Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPayAmount
		#region PutTotalPayCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayCountByPK(string userID, int totalPayCount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayCountByPKData(userID, totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalPayCountByPKAsync(string userID, int totalPayCount, TransactionManager tm_ = null)
		{
			RepairPutTotalPayCountByPKData(userID, totalPayCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalPayCountByPKData(string userID, int totalPayCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalPayCount(int totalPayCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount";
			var parameter_ = Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalPayCountAsync(int totalPayCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalPayCount` = @TotalPayCount";
			var parameter_ = Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalPayCount
		#region PutTotalCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashAmountByPK(string userID, long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashAmountByPKData(userID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalCashAmountByPKAsync(string userID, long totalCashAmount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashAmountByPKData(userID, totalCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalCashAmountByPKData(string userID, long totalCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashAmount(long totalCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
			var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashAmount` = @TotalCashAmount";
			var parameter_ = Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalCashAmount
		#region PutTotalCashCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashCountByPK(string userID, int totalCashCount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashCountByPKData(userID, totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTotalCashCountByPKAsync(string userID, int totalCashCount, TransactionManager tm_ = null)
		{
			RepairPutTotalCashCountByPKData(userID, totalCashCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTotalCashCountByPKData(string userID, int totalCashCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTotalCashCount(int totalCashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount";
			var parameter_ = Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTotalCashCountAsync(int totalCashCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TotalCashCount` = @TotalCashCount";
			var parameter_ = Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTotalCashCount
		#region PutFirstPayAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayAmountByPK(string userID, int firstPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstPayAmountByPKData(userID, firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayAmountByPKAsync(string userID, int firstPayAmount, TransactionManager tm_ = null)
		{
			RepairPutFirstPayAmountByPKData(userID, firstPayAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayAmountByPKData(string userID, int firstPayAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayAmount(int firstPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayAmountAsync(int firstPayAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayAmount` = @FirstPayAmount";
			var parameter_ = Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPayAmount
		#region PutBetCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCashAmountByPK(string userID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(userID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetCashAmountByPKAsync(string userID, long betCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBetCashAmountByPKData(userID, betCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetCashAmountByPKData(string userID, long betCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetCashAmount(long betCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount";
			var parameter_ = Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetCashAmountAsync(long betCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetCashAmount` = @BetCashAmount";
			var parameter_ = Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetCashAmount
		#region PutWinCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCashAmountByPK(string userID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(userID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinCashAmountByPKAsync(string userID, long winCashAmount, TransactionManager tm_ = null)
		{
			RepairPutWinCashAmountByPKData(userID, winCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinCashAmountByPKData(string userID, long winCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinCashAmount(long winCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount";
			var parameter_ = Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinCashAmountAsync(long winCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinCashAmount` = @WinCashAmount";
			var parameter_ = Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinCashAmount
		#region PutBalanceCashAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceCashAmountByPK(string userID, long balanceCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBalanceCashAmountByPKData(userID, balanceCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBalanceCashAmountByPKAsync(string userID, long balanceCashAmount, TransactionManager tm_ = null)
		{
			RepairPutBalanceCashAmountByPKData(userID, balanceCashAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBalanceCashAmountByPKData(string userID, long balanceCashAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BalanceCashAmount` = @BalanceCashAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBalanceCashAmount(long balanceCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceCashAmount` = @BalanceCashAmount";
			var parameter_ = Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBalanceCashAmountAsync(long balanceCashAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BalanceCashAmount` = @BalanceCashAmount";
			var parameter_ = Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBalanceCashAmount
		#region PutTempWithdrawAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTempWithdrawAmountByPK(string userID, long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutTempWithdrawAmountByPKData(userID, tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTempWithdrawAmountByPKAsync(string userID, long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutTempWithdrawAmountByPKData(userID, tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTempWithdrawAmountByPKData(string userID, long tempWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TempWithdrawAmount` = @TempWithdrawAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTempWithdrawAmount(long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TempWithdrawAmount` = @TempWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTempWithdrawAmountAsync(long tempWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TempWithdrawAmount` = @TempWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTempWithdrawAmount
		#region PutWithdrawAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawAmountByPK(string userID, long withdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutWithdrawAmountByPKData(userID, withdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWithdrawAmountByPKAsync(string userID, long withdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutWithdrawAmountByPKData(userID, withdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWithdrawAmountByPKData(string userID, long withdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WithdrawAmount` = @WithdrawAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawAmount(long withdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawAmount` = @WithdrawAmount";
			var parameter_ = Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWithdrawAmountAsync(long withdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawAmount` = @WithdrawAmount";
			var parameter_ = Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWithdrawAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_user_exEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(S_user_exEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_user_exEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<S_user_exEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserKind（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetUserKindByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetUserKindByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`UserKind`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBonus（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBonusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalBonus`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalBonusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalBonus`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBonusCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalBonusCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalBonusCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalBonusCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalBonusCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalChangeAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalChangeAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalChangeAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalChangeAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalChangeAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalChangeCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalChangeCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalChangeCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalChangeCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalChangeCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBetAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalBetAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalBetAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalBetAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalBetAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalBetCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalBetCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalBetCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalBetCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalBetCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalWinAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalWinAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalWinAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalWinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalWinCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalWinCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalWinCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalWinCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalWinCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPayAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalPayAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalPayAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalPayAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalPayAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalPayCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalPayCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalPayCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalPayCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalPayCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTotalCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TotalCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTotalCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TotalCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TotalCashCount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTotalCashCountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TotalCashCount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetTotalCashCountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TotalCashCount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPayAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFirstPayAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FirstPayAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFirstPayAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FirstPayAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BalanceCashAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBalanceCashAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BalanceCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBalanceCashAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BalanceCashAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TempWithdrawAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetTempWithdrawAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`TempWithdrawAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetTempWithdrawAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`TempWithdrawAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WithdrawAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户编码(GUID)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWithdrawAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WithdrawAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWithdrawAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WithdrawAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserKind
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByUserKind(int userKind)
		{
			return GetByUserKind(userKind, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByUserKind(int userKind, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByUserKind(int userKind, int top_)
		{
			return GetByUserKind(userKind, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, int top_)
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
		public List<S_user_exEO> GetByUserKind(int userKind, int top_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, int top_, TransactionManager tm_)
		{
			return await GetByUserKindAsync(userKind, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserKind（字段） 查询
		/// </summary>
		/// /// <param name = "userKind">用户类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByUserKind(int userKind, string sort_)
		{
			return GetByUserKind(userKind, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, string sort_)
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
		public List<S_user_exEO> GetByUserKind(int userKind, string sort_, TransactionManager tm_)
		{
			return GetByUserKind(userKind, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, string sort_, TransactionManager tm_)
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
		public List<S_user_exEO> GetByUserKind(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByUserKindAsync(int userKind, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserKind` = @UserKind", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserKind", userKind, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByUserKind
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_user_exEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_user_exEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_user_exEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<S_user_exEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<S_user_exEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<S_user_exEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByTotalBonus
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus)
		{
			return GetByTotalBonus(totalBonus, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, int top_)
		{
			return GetByTotalBonus(totalBonus, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, int top_)
		{
			return await GetByTotalBonusAsync(totalBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, int top_, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, int top_, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, string sort_)
		{
			return GetByTotalBonus(totalBonus, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, string sort_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, string sort_, TransactionManager tm_)
		{
			return GetByTotalBonus(totalBonus, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBonusAsync(totalBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonus（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonus">赠金总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonus(long totalBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonus` = @TotalBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusAsync(long totalBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonus` = @TotalBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonus", totalBonus, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalBonus
		#region GetByTotalBonusCount
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, int top_)
		{
			return GetByTotalBonusCount(totalBonusCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, int top_, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, string sort_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, string sort_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBonusCount(totalBonusCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBonusCountAsync(totalBonusCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBonusCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBonusCount">赠金次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBonusCount(int totalBonusCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonusCount` = @TotalBonusCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalBonusCountAsync(int totalBonusCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBonusCount` = @TotalBonusCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBonusCount", totalBonusCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalBonusCount
		#region GetByTotalChangeAmount
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, int top_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalChangeAmount(totalChangeAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalChangeAmountAsync(totalChangeAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeAmount">变化总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeAmount(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeAmountAsync(long totalChangeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeAmount` = @TotalChangeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeAmount", totalChangeAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalChangeAmount
		#region GetByTotalChangeCount
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, int top_)
		{
			return GetByTotalChangeCount(totalChangeCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, int top_, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, string sort_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, string sort_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalChangeCount(totalChangeCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalChangeCountAsync(totalChangeCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalChangeCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalChangeCount">变化次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalChangeCount(int totalChangeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeCount` = @TotalChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalChangeCountAsync(int totalChangeCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalChangeCount` = @TotalChangeCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalChangeCount", totalChangeCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalChangeCount
		#region GetByTotalBetAmount
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, int top_)
		{
			return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, string sort_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBetAmount(totalBetAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetAmountAsync(totalBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetAmount">下注总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetAmount(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetAmountAsync(long totalBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetAmount` = @TotalBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetAmount", totalBetAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalBetAmount
		#region GetByTotalBetCount
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount)
		{
			return GetByTotalBetCount(totalBetCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, int top_)
		{
			return GetByTotalBetCount(totalBetCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, int top_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, int top_, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, string sort_)
		{
			return GetByTotalBetCount(totalBetCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, string sort_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalBetCount(totalBetCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalBetCountAsync(totalBetCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalBetCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalBetCount">下注次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalBetCount(int totalBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetCount` = @TotalBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalBetCountAsync(int totalBetCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalBetCount` = @TotalBetCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalBetCount", totalBetCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalBetCount
		#region GetByTotalWinAmount
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, int top_)
		{
			return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, string sort_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalWinAmount(totalWinAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalWinAmountAsync(totalWinAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinAmount">返奖总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinAmount(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinAmountAsync(long totalWinAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinAmount` = @TotalWinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinAmount", totalWinAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalWinAmount
		#region GetByTotalWinCount
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount)
		{
			return GetByTotalWinCount(totalWinCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, int top_)
		{
			return GetByTotalWinCount(totalWinCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, int top_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, int top_, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, string sort_)
		{
			return GetByTotalWinCount(totalWinCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, string sort_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalWinCount(totalWinCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalWinCountAsync(totalWinCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalWinCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalWinCount">返奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalWinCount(int totalWinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinCount` = @TotalWinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalWinCountAsync(int totalWinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalWinCount` = @TotalWinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalWinCount", totalWinCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalWinCount
		#region GetByTotalPayAmount
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, int top_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, string sort_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalPayAmount(totalPayAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPayAmountAsync(totalPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayAmount">充值总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayAmount(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayAmountAsync(long totalPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayAmount` = @TotalPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayAmount", totalPayAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalPayAmount
		#region GetByTotalPayCount
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount)
		{
			return GetByTotalPayCount(totalPayCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, int top_)
		{
			return GetByTotalPayCount(totalPayCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, int top_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, int top_, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, string sort_)
		{
			return GetByTotalPayCount(totalPayCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, string sort_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalPayCount(totalPayCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalPayCountAsync(totalPayCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalPayCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalPayCount">充值次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalPayCount(int totalPayCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayCount` = @TotalPayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalPayCountAsync(int totalPayCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalPayCount` = @TotalPayCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalPayCount", totalPayCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalPayCount
		#region GetByTotalCashAmount
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, int top_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, int top_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, string sort_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByTotalCashAmount(totalCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalCashAmountAsync(totalCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashAmount">提现总额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashAmount(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashAmountAsync(long totalCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashAmount` = @TotalCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashAmount", totalCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalCashAmount
		#region GetByTotalCashCount
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount)
		{
			return GetByTotalCashCount(totalCashCount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, int top_)
		{
			return GetByTotalCashCount(totalCashCount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, int top_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, int top_, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, int top_, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, string sort_)
		{
			return GetByTotalCashCount(totalCashCount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, string sort_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, string sort_, TransactionManager tm_)
		{
			return GetByTotalCashCount(totalCashCount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, string sort_, TransactionManager tm_)
		{
			return await GetByTotalCashCountAsync(totalCashCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TotalCashCount（字段） 查询
		/// </summary>
		/// /// <param name = "totalCashCount">提现次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTotalCashCount(int totalCashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashCount` = @TotalCashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTotalCashCountAsync(int totalCashCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TotalCashCount` = @TotalCashCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TotalCashCount", totalCashCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTotalCashCount
		#region GetByFirstPayAmount
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, int top_)
		{
			return GetByFirstPayAmount(firstPayAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, int top_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, int top_, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, string sort_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, string sort_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayAmount(firstPayAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayAmountAsync(firstPayAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayAmount（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayAmount">第一次充值金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByFirstPayAmount(int firstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayAmount` = @FirstPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByFirstPayAmountAsync(int firstPayAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayAmount` = @FirstPayAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayAmount", firstPayAmount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByFirstPayAmount
		#region GetByBetCashAmount
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, int top_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, int top_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, int top_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, string sort_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetCashAmount(betCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetCashAmountAsync(betCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betCashAmount">真金下注总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBetCashAmount(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByBetCashAmountAsync(long betCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetCashAmount` = @BetCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetCashAmount", betCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByBetCashAmount
		#region GetByWinCashAmount
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, int top_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, int top_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, int top_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, string sort_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinCashAmount(winCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinCashAmountAsync(winCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winCashAmount">真金返奖总额(计算可提现金额,会重置)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWinCashAmount(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByWinCashAmountAsync(long winCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinCashAmount` = @WinCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinCashAmount", winCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByWinCashAmount
		#region GetByBalanceCashAmount
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount)
		{
			return GetByBalanceCashAmount(balanceCashAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, TransactionManager tm_)
		{
			return GetByBalanceCashAmount(balanceCashAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, TransactionManager tm_)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, int top_)
		{
			return GetByBalanceCashAmount(balanceCashAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, int top_)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, int top_, TransactionManager tm_)
		{
			return GetByBalanceCashAmount(balanceCashAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, int top_, TransactionManager tm_)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, string sort_)
		{
			return GetByBalanceCashAmount(balanceCashAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, string sort_)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, string sort_, TransactionManager tm_)
		{
			return GetByBalanceCashAmount(balanceCashAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBalanceCashAmountAsync(balanceCashAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BalanceCashAmount（字段） 查询
		/// </summary>
		/// /// <param name = "balanceCashAmount">真金余额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByBalanceCashAmount(long balanceCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceCashAmount` = @BalanceCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByBalanceCashAmountAsync(long balanceCashAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BalanceCashAmount` = @BalanceCashAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BalanceCashAmount", balanceCashAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByBalanceCashAmount
		#region GetByTempWithdrawAmount
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, TransactionManager tm_)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, TransactionManager tm_)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, int top_)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, int top_)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, int top_, TransactionManager tm_)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, string sort_)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, string sort_)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByTempWithdrawAmount(tempWithdrawAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return await GetByTempWithdrawAmountAsync(tempWithdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TempWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "tempWithdrawAmount">充值后的临时可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByTempWithdrawAmount(long tempWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TempWithdrawAmount` = @TempWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByTempWithdrawAmountAsync(long tempWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TempWithdrawAmount` = @TempWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TempWithdrawAmount", tempWithdrawAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByTempWithdrawAmount
		#region GetByWithdrawAmount
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount)
		{
			return GetByWithdrawAmount(withdrawAmount, 0, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, TransactionManager tm_)
		{
			return GetByWithdrawAmount(withdrawAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, TransactionManager tm_)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, int top_)
		{
			return GetByWithdrawAmount(withdrawAmount, top_, string.Empty, null);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, int top_)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByWithdrawAmount(withdrawAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, int top_, TransactionManager tm_)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, string sort_)
		{
			return GetByWithdrawAmount(withdrawAmount, 0, sort_, null);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, string sort_)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByWithdrawAmount(withdrawAmount, 0, sort_, tm_);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWithdrawAmountAsync(withdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmount">可提现真金金额(计算可提现金额)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_user_exEO> GetByWithdrawAmount(long withdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawAmount` = @WithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		public async Task<List<S_user_exEO>> GetByWithdrawAmountAsync(long withdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawAmount` = @WithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmount", withdrawAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_user_exEO.MapDataReader);
		}
		#endregion // GetByWithdrawAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
