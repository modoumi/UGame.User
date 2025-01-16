/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-05-30 11: 04:16
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
	/// 运营商
	/// 【表 s_operator 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_operatorEO : IRowMapper<S_operatorEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_operatorEO()
		{
			this.OperatorVersion = 0;
			this.EnableBonus = true;
			this.ChangeBalanceMode = 1;
			this.FlowMode = 1;
			this.FirstPayFlowMultip = 1;
			this.PayFlowMultip = 1;
			this.FlowBalance = 0;
			this.FlowDevideBalance = 0;
			this.WithdrawAmountMode = 0;
			this.WithdrawRuleMode = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
			this.OrderNum = 0;
			this.BetRatioOfWithdrawAmount = 0.00m;
			this.WinRatioOfWithdrawAmount = 0.00m;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
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
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码（小写，唯一）
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 运营商基础编码（小写，唯一）
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorBaseID { get; set; }
		/// <summary>
		/// 运营商逻辑版本0-基础版本1-长效版本
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int OperatorVersion { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CountryID { get; set; }
		/// <summary>
		/// 平台支持的语言。|分割
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 5)]
		public string Langs { get; set; }
		/// <summary>
		/// 货币类型（货币缩写USD）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 6)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 对应的主域名如: 777gana.com
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 7)]
		public string MapDomain { get; set; }
		/// <summary>
		/// 大厅客户端线上URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 8)]
		public string LobbyUrl { get; set; }
		/// <summary>
		/// 大厅客户端仿真URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 9)]
		public string LobbyUrlStaging { get; set; }
		/// <summary>
		/// 大厅客户端调试URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 10)]
		public string LobbyUrlDebug { get; set; }
		/// <summary>
		/// 银行客户端线上URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 11)]
		public string BankUrl { get; set; }
		/// <summary>
		/// 银行客户端仿真URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 12)]
		public string BankUrlStaging { get; set; }
		/// <summary>
		/// 银行客户端调试URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 13)]
		public string BankUrlDebug { get; set; }
		/// <summary>
		/// branch关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 14)]
		public string BranchKey { get; set; }
		/// <summary>
		/// GA关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 15)]
		public string GAKey { get; set; }
		/// <summary>
		/// 运营商标题描述
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 16)]
		public string Title { get; set; }
		/// <summary>
		/// 备注
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 17)]
		public string Note { get; set; }
		/// <summary>
		/// 是否启用bonus（用户是否有bonus账户）
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 18)]
		public bool EnableBonus { get; set; }
		/// <summary>
		/// 扣减balance模式1-优先bonus2-优先真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 19)]
		public int ChangeBalanceMode { get; set; }
		/// <summary>
		/// 流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 20)]
		public int FlowMode { get; set; }
		/// <summary>
		/// 首充流水倍数，如20倍
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 21)]
		public int FirstPayFlowMultip { get; set; }
		/// <summary>
		/// 充值流水倍数，如20倍
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 22)]
		public int PayFlowMultip { get; set; }
		/// <summary>
		/// 用户余额大于此值则流水需继承
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 23)]
		public long FlowBalance { get; set; }
		/// <summary>
		/// 流水除以用户余额的倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 24)]
		public int FlowDevideBalance { get; set; }
		/// <summary>
		/// 客户端样式配置
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 25)]
		public string ClientThemes { get; set; }
		/// <summary>
		/// 可提现金额模式0-真金余额 1-根据固定算法调整
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 26)]
		public int WithdrawAmountMode { get; set; }
		/// <summary>
		/// 提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 27)]
		public int WithdrawRuleMode { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 28)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 29)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 排序号
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 30)]
		public int? OrderNum { get; set; }
		/// <summary>
		/// 用户bet的计算比例,0<=X<=1
		/// 【字段 decimal(3,2)】
		/// </summary>
		[DataMember(Order = 31)]
		public decimal BetRatioOfWithdrawAmount { get; set; }
		/// <summary>
		/// 用户reward的计算比例,0<=Y<=1
		/// 【字段 decimal(3,2)】
		/// </summary>
		[DataMember(Order = 32)]
		public decimal WinRatioOfWithdrawAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_operatorEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_operatorEO MapDataReader(IDataReader reader)
		{
		    S_operatorEO ret = new S_operatorEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.OperatorBaseID = reader.ToString("OperatorBaseID");
			ret.OperatorVersion = reader.ToInt32("OperatorVersion");
			ret.CountryID = reader.ToString("CountryID");
			ret.Langs = reader.ToString("Langs");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.MapDomain = reader.ToString("MapDomain");
			ret.LobbyUrl = reader.ToString("LobbyUrl");
			ret.LobbyUrlStaging = reader.ToString("LobbyUrlStaging");
			ret.LobbyUrlDebug = reader.ToString("LobbyUrlDebug");
			ret.BankUrl = reader.ToString("BankUrl");
			ret.BankUrlStaging = reader.ToString("BankUrlStaging");
			ret.BankUrlDebug = reader.ToString("BankUrlDebug");
			ret.BranchKey = reader.ToString("BranchKey");
			ret.GAKey = reader.ToString("GAKey");
			ret.Title = reader.ToString("Title");
			ret.Note = reader.ToString("Note");
			ret.EnableBonus = reader.ToBoolean("EnableBonus");
			ret.ChangeBalanceMode = reader.ToInt32("ChangeBalanceMode");
			ret.FlowMode = reader.ToInt32("FlowMode");
			ret.FirstPayFlowMultip = reader.ToInt32("FirstPayFlowMultip");
			ret.PayFlowMultip = reader.ToInt32("PayFlowMultip");
			ret.FlowBalance = reader.ToInt64("FlowBalance");
			ret.FlowDevideBalance = reader.ToInt32("FlowDevideBalance");
			ret.ClientThemes = reader.ToString("ClientThemes");
			ret.WithdrawAmountMode = reader.ToInt32("WithdrawAmountMode");
			ret.WithdrawRuleMode = reader.ToInt32("WithdrawRuleMode");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.OrderNum = reader.ToInt32N("OrderNum");
			ret.BetRatioOfWithdrawAmount = reader.ToDecimal("BetRatioOfWithdrawAmount");
			ret.WinRatioOfWithdrawAmount = reader.ToDecimal("WinRatioOfWithdrawAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 运营商
	/// 【表 s_operator 的操作类】
	/// </summary>
	[Obsolete]
	public class S_operatorMO : MySqlTableMO<S_operatorEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_operator`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_operatorMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_operatorMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_operatorMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_operatorEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_operatorEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `OperatorBaseID`, `OperatorVersion`, `CountryID`, `Langs`, `CurrencyID`, `MapDomain`, `LobbyUrl`, `LobbyUrlStaging`, `LobbyUrlDebug`, `BankUrl`, `BankUrlStaging`, `BankUrlDebug`, `BranchKey`, `GAKey`, `Title`, `Note`, `EnableBonus`, `ChangeBalanceMode`, `FlowMode`, `FirstPayFlowMultip`, `PayFlowMultip`, `FlowBalance`, `FlowDevideBalance`, `ClientThemes`, `WithdrawAmountMode`, `WithdrawRuleMode`, `Status`, `RecDate`, `OrderNum`, `BetRatioOfWithdrawAmount`, `WinRatioOfWithdrawAmount`) VALUE (@OperatorID, @OperatorBaseID, @OperatorVersion, @CountryID, @Langs, @CurrencyID, @MapDomain, @LobbyUrl, @LobbyUrlStaging, @LobbyUrlDebug, @BankUrl, @BankUrlStaging, @BankUrlDebug, @BranchKey, @GAKey, @Title, @Note, @EnableBonus, @ChangeBalanceMode, @FlowMode, @FirstPayFlowMultip, @PayFlowMultip, @FlowBalance, @FlowDevideBalance, @ClientThemes, @WithdrawAmountMode, @WithdrawRuleMode, @Status, @RecDate, @OrderNum, @BetRatioOfWithdrawAmount, @WinRatioOfWithdrawAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", item.OperatorBaseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorVersion", item.OperatorVersion, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Langs", item.Langs != null ? item.Langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MapDomain", item.MapDomain != null ? item.MapDomain : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrl", item.LobbyUrl != null ? item.LobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrlStaging", item.LobbyUrlStaging != null ? item.LobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrlDebug", item.LobbyUrlDebug != null ? item.LobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrl", item.BankUrl != null ? item.BankUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrlStaging", item.BankUrlStaging != null ? item.BankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrlDebug", item.BankUrlDebug != null ? item.BankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BranchKey", item.BranchKey != null ? item.BranchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAKey", item.GAKey != null ? item.GAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@EnableBonus", item.EnableBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ChangeBalanceMode", item.ChangeBalanceMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMode", item.FlowMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayFlowMultip", item.FirstPayFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@PayFlowMultip", item.PayFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowBalance", item.FlowBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowDevideBalance", item.FlowDevideBalance, MySqlDbType.Int32),
				Database.CreateInParameter("@ClientThemes", item.ClientThemes != null ? item.ClientThemes : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@WithdrawAmountMode", item.WithdrawAmountMode, MySqlDbType.Int32),
				Database.CreateInParameter("@WithdrawRuleMode", item.WithdrawRuleMode, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OrderNum", item.OrderNum.HasValue ? item.OrderNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@BetRatioOfWithdrawAmount", item.BetRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@WinRatioOfWithdrawAmount", item.WinRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
			};
		}
		public int AddByBatch(IEnumerable<S_operatorEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_operatorEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_operatorEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `OperatorBaseID`, `OperatorVersion`, `CountryID`, `Langs`, `CurrencyID`, `MapDomain`, `LobbyUrl`, `LobbyUrlStaging`, `LobbyUrlDebug`, `BankUrl`, `BankUrlStaging`, `BankUrlDebug`, `BranchKey`, `GAKey`, `Title`, `Note`, `EnableBonus`, `ChangeBalanceMode`, `FlowMode`, `FirstPayFlowMultip`, `PayFlowMultip`, `FlowBalance`, `FlowDevideBalance`, `ClientThemes`, `WithdrawAmountMode`, `WithdrawRuleMode`, `Status`, `RecDate`, `OrderNum`, `BetRatioOfWithdrawAmount`, `WinRatioOfWithdrawAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.OperatorBaseID}',{item.OperatorVersion},'{item.CountryID}','{item.Langs}','{item.CurrencyID}','{item.MapDomain}','{item.LobbyUrl}','{item.LobbyUrlStaging}','{item.LobbyUrlDebug}','{item.BankUrl}','{item.BankUrlStaging}','{item.BankUrlDebug}','{item.BranchKey}','{item.GAKey}','{item.Title}','{item.Note}',{item.EnableBonus},{item.ChangeBalanceMode},{item.FlowMode},{item.FirstPayFlowMultip},{item.PayFlowMultip},{item.FlowBalance},{item.FlowDevideBalance},'{item.ClientThemes}',{item.WithdrawAmountMode},{item.WithdrawRuleMode},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}',{item.OrderNum?.ToString()??null},{item.BetRatioOfWithdrawAmount},{item.WinRatioOfWithdrawAmount}),");
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
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_operatorEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, tm_);
		}
		public async Task<int> RemoveAsync(S_operatorEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorBaseID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorBaseID(string operatorBaseID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorBaseIDData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorBaseIDAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorBaseIDData(operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorBaseIDData(string operatorBaseID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorBaseID` = @OperatorBaseID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorBaseID
		#region RemoveByOperatorVersion
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorVersion(int operatorVersion, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorVersionData(operatorVersion, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorVersionAsync(int operatorVersion, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorVersionData(operatorVersion, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorVersionData(int operatorVersion, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorVersion` = @OperatorVersion";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32));
		}
		#endregion // RemoveByOperatorVersion
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
		#region RemoveByLangs
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
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
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
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
		#region RemoveByMapDomain
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMapDomain(string mapDomain, TransactionManager tm_ = null)
		{
			RepairRemoveByMapDomainData(mapDomain, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMapDomainAsync(string mapDomain, TransactionManager tm_ = null)
		{
			RepairRemoveByMapDomainData(mapDomain, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMapDomainData(string mapDomain, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (mapDomain != null ? "`MapDomain` = @MapDomain" : "`MapDomain` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (mapDomain != null)
				paras_.Add(Database.CreateInParameter("@MapDomain", mapDomain, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMapDomain
		#region RemoveByLobbyUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLobbyUrl(string lobbyUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlData(lobbyUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLobbyUrlAsync(string lobbyUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlData(lobbyUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLobbyUrlData(string lobbyUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lobbyUrl != null ? "`LobbyUrl` = @LobbyUrl" : "`LobbyUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lobbyUrl != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrl", lobbyUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLobbyUrl
		#region RemoveByLobbyUrlStaging
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLobbyUrlStaging(string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlStagingData(lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLobbyUrlStagingAsync(string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlStagingData(lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLobbyUrlStagingData(string lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lobbyUrlStaging != null ? "`LobbyUrlStaging` = @LobbyUrlStaging" : "`LobbyUrlStaging` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lobbyUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLobbyUrlStaging
		#region RemoveByLobbyUrlDebug
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLobbyUrlDebug(string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlDebugData(lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLobbyUrlDebugAsync(string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByLobbyUrlDebugData(lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLobbyUrlDebugData(string lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lobbyUrlDebug != null ? "`LobbyUrlDebug` = @LobbyUrlDebug" : "`LobbyUrlDebug` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lobbyUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLobbyUrlDebug
		#region RemoveByBankUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankUrl(string bankUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlData(bankUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankUrlAsync(string bankUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlData(bankUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankUrlData(string bankUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bankUrl != null ? "`BankUrl` = @BankUrl" : "`BankUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bankUrl != null)
				paras_.Add(Database.CreateInParameter("@BankUrl", bankUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankUrl
		#region RemoveByBankUrlStaging
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankUrlStaging(string bankUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlStagingData(bankUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankUrlStagingAsync(string bankUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlStagingData(bankUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankUrlStagingData(string bankUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bankUrlStaging != null ? "`BankUrlStaging` = @BankUrlStaging" : "`BankUrlStaging` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bankUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@BankUrlStaging", bankUrlStaging, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankUrlStaging
		#region RemoveByBankUrlDebug
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBankUrlDebug(string bankUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlDebugData(bankUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBankUrlDebugAsync(string bankUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByBankUrlDebugData(bankUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBankUrlDebugData(string bankUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (bankUrlDebug != null ? "`BankUrlDebug` = @BankUrlDebug" : "`BankUrlDebug` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (bankUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@BankUrlDebug", bankUrlDebug, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBankUrlDebug
		#region RemoveByBranchKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBranchKey(string branchKey, TransactionManager tm_ = null)
		{
			RepairRemoveByBranchKeyData(branchKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBranchKeyAsync(string branchKey, TransactionManager tm_ = null)
		{
			RepairRemoveByBranchKeyData(branchKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBranchKeyData(string branchKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
		}
		#endregion // RemoveByBranchKey
		#region RemoveByGAKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGAKey(string gAKey, TransactionManager tm_ = null)
		{
			RepairRemoveByGAKeyData(gAKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGAKeyAsync(string gAKey, TransactionManager tm_ = null)
		{
			RepairRemoveByGAKeyData(gAKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGAKeyData(string gAKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGAKey
		#region RemoveByTitle
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTitle(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTitleAsync(string title, TransactionManager tm_ = null)
		{
			RepairRemoveByTitleData(title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTitleData(string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (title != null ? "`Title` = @Title" : "`Title` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
		}
		#endregion // RemoveByTitle
		#region RemoveByNote
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "note">备注</param>
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
		#region RemoveByEnableBonus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEnableBonus(bool enableBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEnableBonusData(enableBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEnableBonusAsync(bool enableBonus, TransactionManager tm_ = null)
		{
			RepairRemoveByEnableBonusData(enableBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEnableBonusData(bool enableBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EnableBonus` = @EnableBonus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte));
		}
		#endregion // RemoveByEnableBonus
		#region RemoveByChangeBalanceMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChangeBalanceMode(int changeBalanceMode, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeBalanceModeData(changeBalanceMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChangeBalanceModeAsync(int changeBalanceMode, TransactionManager tm_ = null)
		{
			RepairRemoveByChangeBalanceModeData(changeBalanceMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChangeBalanceModeData(int changeBalanceMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChangeBalanceMode` = @ChangeBalanceMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByChangeBalanceMode
		#region RemoveByFlowMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowMode(int flowMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowModeData(flowMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowModeAsync(int flowMode, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowModeData(flowMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowModeData(int flowMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowMode` = @FlowMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowMode
		#region RemoveByFirstPayFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFirstPayFlowMultip(int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayFlowMultipData(firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFirstPayFlowMultipAsync(int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByFirstPayFlowMultipData(firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFirstPayFlowMultipData(int firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FirstPayFlowMultip` = @FirstPayFlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByFirstPayFlowMultip
		#region RemoveByPayFlowMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPayFlowMultip(int payFlowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByPayFlowMultipData(payFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPayFlowMultipAsync(int payFlowMultip, TransactionManager tm_ = null)
		{
			RepairRemoveByPayFlowMultipData(payFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPayFlowMultipData(int payFlowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PayFlowMultip` = @PayFlowMultip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32));
		}
		#endregion // RemoveByPayFlowMultip
		#region RemoveByFlowBalance
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowBalance(long flowBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowBalanceData(flowBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowBalanceAsync(long flowBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowBalanceData(flowBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowBalanceData(long flowBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowBalance` = @FlowBalance";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64));
		}
		#endregion // RemoveByFlowBalance
		#region RemoveByFlowDevideBalance
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFlowDevideBalance(int flowDevideBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowDevideBalanceData(flowDevideBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFlowDevideBalanceAsync(int flowDevideBalance, TransactionManager tm_ = null)
		{
			RepairRemoveByFlowDevideBalanceData(flowDevideBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFlowDevideBalanceData(int flowDevideBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FlowDevideBalance` = @FlowDevideBalance";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32));
		}
		#endregion // RemoveByFlowDevideBalance
		#region RemoveByClientThemes
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByClientThemes(string clientThemes, TransactionManager tm_ = null)
		{
			RepairRemoveByClientThemesData(clientThemes, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByClientThemesAsync(string clientThemes, TransactionManager tm_ = null)
		{
			RepairRemoveByClientThemesData(clientThemes, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByClientThemesData(string clientThemes, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (clientThemes != null ? "`ClientThemes` = @ClientThemes" : "`ClientThemes` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (clientThemes != null)
				paras_.Add(Database.CreateInParameter("@ClientThemes", clientThemes, MySqlDbType.Text));
		}
		#endregion // RemoveByClientThemes
		#region RemoveByWithdrawAmountMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWithdrawAmountMode(int withdrawAmountMode, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawAmountModeData(withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWithdrawAmountModeAsync(int withdrawAmountMode, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawAmountModeData(withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWithdrawAmountModeData(int withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WithdrawAmountMode` = @WithdrawAmountMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByWithdrawAmountMode
		#region RemoveByWithdrawRuleMode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWithdrawRuleMode(int withdrawRuleMode, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawRuleModeData(withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWithdrawRuleModeAsync(int withdrawRuleMode, TransactionManager tm_ = null)
		{
			RepairRemoveByWithdrawRuleModeData(withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWithdrawRuleModeData(int withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WithdrawRuleMode` = @WithdrawRuleMode";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32));
		}
		#endregion // RemoveByWithdrawRuleMode
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
		#region RemoveByOrderNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderNum(int? orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderNumAsync(int? orderNum, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderNumData(orderNum.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderNumData(int? orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (orderNum.HasValue ? "`OrderNum` = @OrderNum" : "`OrderNum` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (orderNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderNum", orderNum.Value, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderNum
		#region RemoveByBetRatioOfWithdrawAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetRatioOfWithdrawAmountData(betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetRatioOfWithdrawAmountData(betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetRatioOfWithdrawAmountData(decimal betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByBetRatioOfWithdrawAmount
		#region RemoveByWinRatioOfWithdrawAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinRatioOfWithdrawAmountData(winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinRatioOfWithdrawAmountData(winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinRatioOfWithdrawAmountData(decimal winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByWinRatioOfWithdrawAmount
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
		public int Put(S_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_operatorEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_operatorEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `OperatorBaseID` = @OperatorBaseID, `OperatorVersion` = @OperatorVersion, `CountryID` = @CountryID, `Langs` = @Langs, `CurrencyID` = @CurrencyID, `MapDomain` = @MapDomain, `LobbyUrl` = @LobbyUrl, `LobbyUrlStaging` = @LobbyUrlStaging, `LobbyUrlDebug` = @LobbyUrlDebug, `BankUrl` = @BankUrl, `BankUrlStaging` = @BankUrlStaging, `BankUrlDebug` = @BankUrlDebug, `BranchKey` = @BranchKey, `GAKey` = @GAKey, `Title` = @Title, `Note` = @Note, `EnableBonus` = @EnableBonus, `ChangeBalanceMode` = @ChangeBalanceMode, `FlowMode` = @FlowMode, `FirstPayFlowMultip` = @FirstPayFlowMultip, `PayFlowMultip` = @PayFlowMultip, `FlowBalance` = @FlowBalance, `FlowDevideBalance` = @FlowDevideBalance, `ClientThemes` = @ClientThemes, `WithdrawAmountMode` = @WithdrawAmountMode, `WithdrawRuleMode` = @WithdrawRuleMode, `Status` = @Status, `OrderNum` = @OrderNum, `BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount, `WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount WHERE `OperatorID` = @OperatorID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorBaseID", item.OperatorBaseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorVersion", item.OperatorVersion, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", item.CountryID != null ? item.CountryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Langs", item.Langs != null ? item.Langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MapDomain", item.MapDomain != null ? item.MapDomain : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrl", item.LobbyUrl != null ? item.LobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrlStaging", item.LobbyUrlStaging != null ? item.LobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LobbyUrlDebug", item.LobbyUrlDebug != null ? item.LobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrl", item.BankUrl != null ? item.BankUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrlStaging", item.BankUrlStaging != null ? item.BankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BankUrlDebug", item.BankUrlDebug != null ? item.BankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BranchKey", item.BranchKey != null ? item.BranchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@GAKey", item.GAKey != null ? item.GAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Title", item.Title != null ? item.Title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@EnableBonus", item.EnableBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ChangeBalanceMode", item.ChangeBalanceMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowMode", item.FlowMode, MySqlDbType.Int32),
				Database.CreateInParameter("@FirstPayFlowMultip", item.FirstPayFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@PayFlowMultip", item.PayFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@FlowBalance", item.FlowBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@FlowDevideBalance", item.FlowDevideBalance, MySqlDbType.Int32),
				Database.CreateInParameter("@ClientThemes", item.ClientThemes != null ? item.ClientThemes : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@WithdrawAmountMode", item.WithdrawAmountMode, MySqlDbType.Int32),
				Database.CreateInParameter("@WithdrawRuleMode", item.WithdrawRuleMode, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@OrderNum", item.OrderNum.HasValue ? item.OrderNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@BetRatioOfWithdrawAmount", item.BetRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@WinRatioOfWithdrawAmount", item.WinRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_operatorEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_operatorEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID", tm_, ConcatValues(values_, operatorID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorBaseID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorBaseIDByPK(string operatorID, string operatorBaseID, TransactionManager tm_ = null)
		{
			RepairPutOperatorBaseIDByPKData(operatorID, operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorBaseIDByPKAsync(string operatorID, string operatorBaseID, TransactionManager tm_ = null)
		{
			RepairPutOperatorBaseIDByPKData(operatorID, operatorBaseID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorBaseIDByPKData(string operatorID, string operatorBaseID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorBaseID` = @OperatorBaseID  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorBaseID(string operatorBaseID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorBaseID` = @OperatorBaseID";
			var parameter_ = Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorBaseIDAsync(string operatorBaseID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorBaseID` = @OperatorBaseID";
			var parameter_ = Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorBaseID
		#region PutOperatorVersion
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorVersionByPK(string operatorID, int operatorVersion, TransactionManager tm_ = null)
		{
			RepairPutOperatorVersionByPKData(operatorID, operatorVersion, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorVersionByPKAsync(string operatorID, int operatorVersion, TransactionManager tm_ = null)
		{
			RepairPutOperatorVersionByPKData(operatorID, operatorVersion, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorVersionByPKData(string operatorID, int operatorVersion, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorVersion` = @OperatorVersion  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorVersion(int operatorVersion, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorVersion` = @OperatorVersion";
			var parameter_ = Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorVersionAsync(int operatorVersion, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorVersion` = @OperatorVersion";
			var parameter_ = Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorVersion
		#region PutCountryID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryIDByPK(string operatorID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(operatorID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryIDByPKAsync(string operatorID, string countryID, TransactionManager tm_ = null)
		{
			RepairPutCountryIDByPKData(operatorID, countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryIDByPKData(string operatorID, string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		#region PutLangs
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangsByPK(string operatorID, string langs, TransactionManager tm_ = null)
		{
			RepairPutLangsByPKData(operatorID, langs, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangsByPKAsync(string operatorID, string langs, TransactionManager tm_ = null)
		{
			RepairPutLangsByPKData(operatorID, langs, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangsByPKData(string operatorID, string langs, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Langs` = @Langs  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Langs", langs != null ? langs : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
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
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
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
		#region PutMapDomain
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMapDomainByPK(string operatorID, string mapDomain, TransactionManager tm_ = null)
		{
			RepairPutMapDomainByPKData(operatorID, mapDomain, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMapDomainByPKAsync(string operatorID, string mapDomain, TransactionManager tm_ = null)
		{
			RepairPutMapDomainByPKData(operatorID, mapDomain, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMapDomainByPKData(string operatorID, string mapDomain, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MapDomain` = @MapDomain  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MapDomain", mapDomain != null ? mapDomain : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMapDomain(string mapDomain, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MapDomain` = @MapDomain";
			var parameter_ = Database.CreateInParameter("@MapDomain", mapDomain != null ? mapDomain : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMapDomainAsync(string mapDomain, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MapDomain` = @MapDomain";
			var parameter_ = Database.CreateInParameter("@MapDomain", mapDomain != null ? mapDomain : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMapDomain
		#region PutLobbyUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrlByPK(string operatorID, string lobbyUrl, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlByPKData(operatorID, lobbyUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLobbyUrlByPKAsync(string operatorID, string lobbyUrl, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlByPKData(operatorID, lobbyUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLobbyUrlByPKData(string operatorID, string lobbyUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LobbyUrl` = @LobbyUrl  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LobbyUrl", lobbyUrl != null ? lobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrl(string lobbyUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrl` = @LobbyUrl";
			var parameter_ = Database.CreateInParameter("@LobbyUrl", lobbyUrl != null ? lobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLobbyUrlAsync(string lobbyUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrl` = @LobbyUrl";
			var parameter_ = Database.CreateInParameter("@LobbyUrl", lobbyUrl != null ? lobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLobbyUrl
		#region PutLobbyUrlStaging
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrlStagingByPK(string operatorID, string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlStagingByPKData(operatorID, lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLobbyUrlStagingByPKAsync(string operatorID, string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlStagingByPKData(operatorID, lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLobbyUrlStagingByPKData(string operatorID, string lobbyUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LobbyUrlStaging` = @LobbyUrlStaging  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging != null ? lobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrlStaging(string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrlStaging` = @LobbyUrlStaging";
			var parameter_ = Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging != null ? lobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLobbyUrlStagingAsync(string lobbyUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrlStaging` = @LobbyUrlStaging";
			var parameter_ = Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging != null ? lobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLobbyUrlStaging
		#region PutLobbyUrlDebug
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrlDebugByPK(string operatorID, string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlDebugByPKData(operatorID, lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLobbyUrlDebugByPKAsync(string operatorID, string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutLobbyUrlDebugByPKData(operatorID, lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLobbyUrlDebugByPKData(string operatorID, string lobbyUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LobbyUrlDebug` = @LobbyUrlDebug  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug != null ? lobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLobbyUrlDebug(string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrlDebug` = @LobbyUrlDebug";
			var parameter_ = Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug != null ? lobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLobbyUrlDebugAsync(string lobbyUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LobbyUrlDebug` = @LobbyUrlDebug";
			var parameter_ = Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug != null ? lobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLobbyUrlDebug
		#region PutBankUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrlByPK(string operatorID, string bankUrl, TransactionManager tm_ = null)
		{
			RepairPutBankUrlByPKData(operatorID, bankUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankUrlByPKAsync(string operatorID, string bankUrl, TransactionManager tm_ = null)
		{
			RepairPutBankUrlByPKData(operatorID, bankUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankUrlByPKData(string operatorID, string bankUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankUrl` = @BankUrl  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankUrl", bankUrl != null ? bankUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrl(string bankUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrl` = @BankUrl";
			var parameter_ = Database.CreateInParameter("@BankUrl", bankUrl != null ? bankUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankUrlAsync(string bankUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrl` = @BankUrl";
			var parameter_ = Database.CreateInParameter("@BankUrl", bankUrl != null ? bankUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankUrl
		#region PutBankUrlStaging
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrlStagingByPK(string operatorID, string bankUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutBankUrlStagingByPKData(operatorID, bankUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankUrlStagingByPKAsync(string operatorID, string bankUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutBankUrlStagingByPKData(operatorID, bankUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankUrlStagingByPKData(string operatorID, string bankUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankUrlStaging` = @BankUrlStaging  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankUrlStaging", bankUrlStaging != null ? bankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrlStaging(string bankUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrlStaging` = @BankUrlStaging";
			var parameter_ = Database.CreateInParameter("@BankUrlStaging", bankUrlStaging != null ? bankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankUrlStagingAsync(string bankUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrlStaging` = @BankUrlStaging";
			var parameter_ = Database.CreateInParameter("@BankUrlStaging", bankUrlStaging != null ? bankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankUrlStaging
		#region PutBankUrlDebug
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrlDebugByPK(string operatorID, string bankUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutBankUrlDebugByPKData(operatorID, bankUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBankUrlDebugByPKAsync(string operatorID, string bankUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutBankUrlDebugByPKData(operatorID, bankUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBankUrlDebugByPKData(string operatorID, string bankUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BankUrlDebug` = @BankUrlDebug  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BankUrlDebug", bankUrlDebug != null ? bankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBankUrlDebug(string bankUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrlDebug` = @BankUrlDebug";
			var parameter_ = Database.CreateInParameter("@BankUrlDebug", bankUrlDebug != null ? bankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBankUrlDebugAsync(string bankUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BankUrlDebug` = @BankUrlDebug";
			var parameter_ = Database.CreateInParameter("@BankUrlDebug", bankUrlDebug != null ? bankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBankUrlDebug
		#region PutBranchKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBranchKeyByPK(string operatorID, string branchKey, TransactionManager tm_ = null)
		{
			RepairPutBranchKeyByPKData(operatorID, branchKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBranchKeyByPKAsync(string operatorID, string branchKey, TransactionManager tm_ = null)
		{
			RepairPutBranchKeyByPKData(operatorID, branchKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBranchKeyByPKData(string operatorID, string branchKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBranchKey(string branchKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey";
			var parameter_ = Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBranchKeyAsync(string branchKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BranchKey` = @BranchKey";
			var parameter_ = Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBranchKey
		#region PutGAKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAKeyByPK(string operatorID, string gAKey, TransactionManager tm_ = null)
		{
			RepairPutGAKeyByPKData(operatorID, gAKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGAKeyByPKAsync(string operatorID, string gAKey, TransactionManager tm_ = null)
		{
			RepairPutGAKeyByPKData(operatorID, gAKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGAKeyByPKData(string operatorID, string gAKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGAKey(string gAKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey";
			var parameter_ = Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGAKeyAsync(string gAKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GAKey` = @GAKey";
			var parameter_ = Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGAKey
		#region PutTitle
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitleByPK(string operatorID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(operatorID, title, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTitleByPKAsync(string operatorID, string title, TransactionManager tm_ = null)
		{
			RepairPutTitleByPKData(operatorID, title, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTitleByPKData(string operatorID, string title, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Title` = @Title  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTitle(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTitleAsync(string title, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Title` = @Title";
			var parameter_ = Database.CreateInParameter("@Title", title != null ? title : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTitle
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "note">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string operatorID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(operatorID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string operatorID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(operatorID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string operatorID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "note">备注</param>
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
		#region PutEnableBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEnableBonusByPK(string operatorID, bool enableBonus, TransactionManager tm_ = null)
		{
			RepairPutEnableBonusByPKData(operatorID, enableBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEnableBonusByPKAsync(string operatorID, bool enableBonus, TransactionManager tm_ = null)
		{
			RepairPutEnableBonusByPKData(operatorID, enableBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEnableBonusByPKData(string operatorID, bool enableBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EnableBonus` = @EnableBonus  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEnableBonus(bool enableBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EnableBonus` = @EnableBonus";
			var parameter_ = Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEnableBonusAsync(bool enableBonus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EnableBonus` = @EnableBonus";
			var parameter_ = Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEnableBonus
		#region PutChangeBalanceMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeBalanceModeByPK(string operatorID, int changeBalanceMode, TransactionManager tm_ = null)
		{
			RepairPutChangeBalanceModeByPKData(operatorID, changeBalanceMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChangeBalanceModeByPKAsync(string operatorID, int changeBalanceMode, TransactionManager tm_ = null)
		{
			RepairPutChangeBalanceModeByPKData(operatorID, changeBalanceMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChangeBalanceModeByPKData(string operatorID, int changeBalanceMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChangeBalanceMode` = @ChangeBalanceMode  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChangeBalanceMode(int changeBalanceMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeBalanceMode` = @ChangeBalanceMode";
			var parameter_ = Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChangeBalanceModeAsync(int changeBalanceMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChangeBalanceMode` = @ChangeBalanceMode";
			var parameter_ = Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChangeBalanceMode
		#region PutFlowMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowModeByPK(string operatorID, int flowMode, TransactionManager tm_ = null)
		{
			RepairPutFlowModeByPKData(operatorID, flowMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowModeByPKAsync(string operatorID, int flowMode, TransactionManager tm_ = null)
		{
			RepairPutFlowModeByPKData(operatorID, flowMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowModeByPKData(string operatorID, int flowMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowMode` = @FlowMode  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowMode(int flowMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMode` = @FlowMode";
			var parameter_ = Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowModeAsync(int flowMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowMode` = @FlowMode";
			var parameter_ = Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowMode
		#region PutFirstPayFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayFlowMultipByPK(string operatorID, int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			RepairPutFirstPayFlowMultipByPKData(operatorID, firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFirstPayFlowMultipByPKAsync(string operatorID, int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			RepairPutFirstPayFlowMultipByPKData(operatorID, firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFirstPayFlowMultipByPKData(string operatorID, int firstPayFlowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FirstPayFlowMultip` = @FirstPayFlowMultip  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFirstPayFlowMultip(int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayFlowMultip` = @FirstPayFlowMultip";
			var parameter_ = Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFirstPayFlowMultipAsync(int firstPayFlowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FirstPayFlowMultip` = @FirstPayFlowMultip";
			var parameter_ = Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFirstPayFlowMultip
		#region PutPayFlowMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayFlowMultipByPK(string operatorID, int payFlowMultip, TransactionManager tm_ = null)
		{
			RepairPutPayFlowMultipByPKData(operatorID, payFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPayFlowMultipByPKAsync(string operatorID, int payFlowMultip, TransactionManager tm_ = null)
		{
			RepairPutPayFlowMultipByPKData(operatorID, payFlowMultip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPayFlowMultipByPKData(string operatorID, int payFlowMultip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PayFlowMultip` = @PayFlowMultip  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPayFlowMultip(int payFlowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayFlowMultip` = @PayFlowMultip";
			var parameter_ = Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPayFlowMultipAsync(int payFlowMultip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PayFlowMultip` = @PayFlowMultip";
			var parameter_ = Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPayFlowMultip
		#region PutFlowBalance
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowBalanceByPK(string operatorID, long flowBalance, TransactionManager tm_ = null)
		{
			RepairPutFlowBalanceByPKData(operatorID, flowBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowBalanceByPKAsync(string operatorID, long flowBalance, TransactionManager tm_ = null)
		{
			RepairPutFlowBalanceByPKData(operatorID, flowBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowBalanceByPKData(string operatorID, long flowBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowBalance` = @FlowBalance  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowBalance(long flowBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowBalance` = @FlowBalance";
			var parameter_ = Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowBalanceAsync(long flowBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowBalance` = @FlowBalance";
			var parameter_ = Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowBalance
		#region PutFlowDevideBalance
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowDevideBalanceByPK(string operatorID, int flowDevideBalance, TransactionManager tm_ = null)
		{
			RepairPutFlowDevideBalanceByPKData(operatorID, flowDevideBalance, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFlowDevideBalanceByPKAsync(string operatorID, int flowDevideBalance, TransactionManager tm_ = null)
		{
			RepairPutFlowDevideBalanceByPKData(operatorID, flowDevideBalance, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFlowDevideBalanceByPKData(string operatorID, int flowDevideBalance, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FlowDevideBalance` = @FlowDevideBalance  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFlowDevideBalance(int flowDevideBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowDevideBalance` = @FlowDevideBalance";
			var parameter_ = Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFlowDevideBalanceAsync(int flowDevideBalance, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FlowDevideBalance` = @FlowDevideBalance";
			var parameter_ = Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFlowDevideBalance
		#region PutClientThemes
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutClientThemesByPK(string operatorID, string clientThemes, TransactionManager tm_ = null)
		{
			RepairPutClientThemesByPKData(operatorID, clientThemes, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutClientThemesByPKAsync(string operatorID, string clientThemes, TransactionManager tm_ = null)
		{
			RepairPutClientThemesByPKData(operatorID, clientThemes, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutClientThemesByPKData(string operatorID, string clientThemes, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ClientThemes` = @ClientThemes  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ClientThemes", clientThemes != null ? clientThemes : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutClientThemes(string clientThemes, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ClientThemes` = @ClientThemes";
			var parameter_ = Database.CreateInParameter("@ClientThemes", clientThemes != null ? clientThemes : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutClientThemesAsync(string clientThemes, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ClientThemes` = @ClientThemes";
			var parameter_ = Database.CreateInParameter("@ClientThemes", clientThemes != null ? clientThemes : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutClientThemes
		#region PutWithdrawAmountMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawAmountModeByPK(string operatorID, int withdrawAmountMode, TransactionManager tm_ = null)
		{
			RepairPutWithdrawAmountModeByPKData(operatorID, withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWithdrawAmountModeByPKAsync(string operatorID, int withdrawAmountMode, TransactionManager tm_ = null)
		{
			RepairPutWithdrawAmountModeByPKData(operatorID, withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWithdrawAmountModeByPKData(string operatorID, int withdrawAmountMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WithdrawAmountMode` = @WithdrawAmountMode  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawAmountMode(int withdrawAmountMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawAmountMode` = @WithdrawAmountMode";
			var parameter_ = Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWithdrawAmountModeAsync(int withdrawAmountMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawAmountMode` = @WithdrawAmountMode";
			var parameter_ = Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWithdrawAmountMode
		#region PutWithdrawRuleMode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawRuleModeByPK(string operatorID, int withdrawRuleMode, TransactionManager tm_ = null)
		{
			RepairPutWithdrawRuleModeByPKData(operatorID, withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWithdrawRuleModeByPKAsync(string operatorID, int withdrawRuleMode, TransactionManager tm_ = null)
		{
			RepairPutWithdrawRuleModeByPKData(operatorID, withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWithdrawRuleModeByPKData(string operatorID, int withdrawRuleMode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WithdrawRuleMode` = @WithdrawRuleMode  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWithdrawRuleMode(int withdrawRuleMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawRuleMode` = @WithdrawRuleMode";
			var parameter_ = Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWithdrawRuleModeAsync(int withdrawRuleMode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WithdrawRuleMode` = @WithdrawRuleMode";
			var parameter_ = Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWithdrawRuleMode
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string operatorID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(operatorID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string operatorID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
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
		#region PutOrderNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNumByPK(string operatorID, int? orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(operatorID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderNumByPKAsync(string operatorID, int? orderNum, TransactionManager tm_ = null)
		{
			RepairPutOrderNumByPKData(operatorID, orderNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderNumByPKData(string operatorID, int? orderNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderNum", orderNum.HasValue ? orderNum.Value : (object)DBNull.Value, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderNum(int? orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum.HasValue ? orderNum.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderNumAsync(int? orderNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderNum` = @OrderNum";
			var parameter_ = Database.CreateInParameter("@OrderNum", orderNum.HasValue ? orderNum.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderNum
		#region PutBetRatioOfWithdrawAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetRatioOfWithdrawAmountByPK(string operatorID, decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutBetRatioOfWithdrawAmountByPKData(operatorID, betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetRatioOfWithdrawAmountByPKAsync(string operatorID, decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutBetRatioOfWithdrawAmountByPKData(operatorID, betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetRatioOfWithdrawAmountByPKData(string operatorID, decimal betRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetRatioOfWithdrawAmount
		#region PutWinRatioOfWithdrawAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinRatioOfWithdrawAmountByPK(string operatorID, decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutWinRatioOfWithdrawAmountByPKData(operatorID, winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinRatioOfWithdrawAmountByPKAsync(string operatorID, decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			RepairPutWinRatioOfWithdrawAmountByPKData(operatorID, winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinRatioOfWithdrawAmountByPKData(string operatorID, decimal winRatioOfWithdrawAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount  WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount";
			var parameter_ = Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinRatioOfWithdrawAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		public async Task<bool> SetAsync(S_operatorEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID) == null)
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
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_operatorEO GetByPK(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<S_operatorEO> GetByPKAsync(string operatorID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorBaseID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorBaseIDByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorBaseID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetOperatorBaseIDByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorBaseID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorVersion（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOperatorVersionByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OperatorVersion`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetOperatorVersionByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OperatorVersion`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryIDByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCountryIDByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Langs（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangsByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Langs`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetLangsByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Langs`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MapDomain（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMapDomainByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MapDomain`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetMapDomainByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MapDomain`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LobbyUrl（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLobbyUrlByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LobbyUrl`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetLobbyUrlByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LobbyUrl`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LobbyUrlStaging（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLobbyUrlStagingByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LobbyUrlStaging`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetLobbyUrlStagingByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LobbyUrlStaging`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LobbyUrlDebug（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLobbyUrlDebugByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LobbyUrlDebug`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetLobbyUrlDebugByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LobbyUrlDebug`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankUrl（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankUrlByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankUrl`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetBankUrlByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankUrl`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankUrlStaging（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankUrlStagingByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankUrlStaging`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetBankUrlStagingByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankUrlStaging`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BankUrlDebug（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBankUrlDebugByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BankUrlDebug`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetBankUrlDebugByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BankUrlDebug`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BranchKey（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetBranchKeyByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`BranchKey`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetBranchKeyByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`BranchKey`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GAKey（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGAKeyByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`GAKey`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetGAKeyByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`GAKey`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Title（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetTitleByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Title`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetTitleByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Title`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EnableBonus（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetEnableBonusByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`EnableBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<bool> GetEnableBonusByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`EnableBonus`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChangeBalanceMode（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChangeBalanceModeByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ChangeBalanceMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetChangeBalanceModeByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ChangeBalanceMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowMode（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlowModeByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FlowMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFlowModeByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FlowMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FirstPayFlowMultip（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFirstPayFlowMultipByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FirstPayFlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFirstPayFlowMultipByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FirstPayFlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PayFlowMultip（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPayFlowMultipByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`PayFlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetPayFlowMultipByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`PayFlowMultip`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowBalance（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetFlowBalanceByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`FlowBalance`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<long> GetFlowBalanceByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`FlowBalance`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FlowDevideBalance（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFlowDevideBalanceByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FlowDevideBalance`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetFlowDevideBalanceByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FlowDevideBalance`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ClientThemes（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetClientThemesByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ClientThemes`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<string> GetClientThemesByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ClientThemes`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WithdrawAmountMode（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWithdrawAmountModeByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WithdrawAmountMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetWithdrawAmountModeByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WithdrawAmountMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WithdrawRuleMode（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWithdrawRuleModeByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`WithdrawRuleMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetWithdrawRuleModeByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`WithdrawRuleMode`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderNum（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int? GetOrderNumByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int?)GetScalar("`OrderNum`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<int?> GetOrderNumByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (int?)await GetScalarAsync("`OrderNum`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetRatioOfWithdrawAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetBetRatioOfWithdrawAmountByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`BetRatioOfWithdrawAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<decimal> GetBetRatioOfWithdrawAmountByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`BetRatioOfWithdrawAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinRatioOfWithdrawAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetWinRatioOfWithdrawAmountByPK(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`WinRatioOfWithdrawAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		public async Task<decimal> GetWinRatioOfWithdrawAmountByPKAsync(string operatorID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`WinRatioOfWithdrawAmount`", "`OperatorID` = @OperatorID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorBaseID
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, TransactionManager tm_)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_)
		{
			return GetByOperatorBaseID(operatorBaseID, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, int top_)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, string sort_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, string sort_)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorBaseIDAsync(operatorBaseID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorBaseID` = @OperatorBaseID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByOperatorBaseIDAsync(string operatorBaseID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorBaseID` = @OperatorBaseID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorBaseID
		#region GetByOperatorVersion
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion)
		{
			return GetByOperatorVersion(operatorVersion, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion)
		{
			return await GetByOperatorVersionAsync(operatorVersion, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, TransactionManager tm_)
		{
			return await GetByOperatorVersionAsync(operatorVersion, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, int top_)
		{
			return GetByOperatorVersion(operatorVersion, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, int top_)
		{
			return await GetByOperatorVersionAsync(operatorVersion, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, int top_, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, int top_, TransactionManager tm_)
		{
			return await GetByOperatorVersionAsync(operatorVersion, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, string sort_)
		{
			return GetByOperatorVersion(operatorVersion, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, string sort_)
		{
			return await GetByOperatorVersionAsync(operatorVersion, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, string sort_, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorVersionAsync(operatorVersion, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOperatorVersion(int operatorVersion, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorVersion` = @OperatorVersion", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByOperatorVersionAsync(int operatorVersion, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorVersion` = @OperatorVersion", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorVersion
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, int top_)
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
		public List<S_operatorEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, int top_, TransactionManager tm_)
		{
			return await GetByCountryIDAsync(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, string sort_)
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
		public List<S_operatorEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, string sort_, TransactionManager tm_)
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
		public List<S_operatorEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByCountryIDAsync(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(countryID != null ? "`CountryID` = @CountryID" : "`CountryID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (countryID != null)
				paras_.Add(Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByLangs
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs)
		{
			return GetByLangs(langs, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs)
		{
			return await GetByLangsAsync(langs, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, int top_)
		{
			return GetByLangs(langs, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, int top_)
		{
			return await GetByLangsAsync(langs, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, int top_, TransactionManager tm_)
		{
			return GetByLangs(langs, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, int top_, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, string sort_)
		{
			return GetByLangs(langs, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, string sort_)
		{
			return await GetByLangsAsync(langs, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, string sort_, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, string sort_, TransactionManager tm_)
		{
			return await GetByLangsAsync(langs, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLangs(string langs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langs != null ? "`Langs` = @Langs" : "`Langs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langs != null)
				paras_.Add(Database.CreateInParameter("@Langs", langs, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByLangsAsync(string langs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langs != null ? "`Langs` = @Langs" : "`Langs` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langs != null)
				paras_.Add(Database.CreateInParameter("@Langs", langs, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByLangs
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByMapDomain
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain)
		{
			return GetByMapDomain(mapDomain, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain)
		{
			return await GetByMapDomainAsync(mapDomain, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, TransactionManager tm_)
		{
			return await GetByMapDomainAsync(mapDomain, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, int top_)
		{
			return GetByMapDomain(mapDomain, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, int top_)
		{
			return await GetByMapDomainAsync(mapDomain, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, int top_, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, int top_, TransactionManager tm_)
		{
			return await GetByMapDomainAsync(mapDomain, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, string sort_)
		{
			return GetByMapDomain(mapDomain, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, string sort_)
		{
			return await GetByMapDomainAsync(mapDomain, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, string sort_, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, string sort_, TransactionManager tm_)
		{
			return await GetByMapDomainAsync(mapDomain, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByMapDomain(string mapDomain, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mapDomain != null ? "`MapDomain` = @MapDomain" : "`MapDomain` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mapDomain != null)
				paras_.Add(Database.CreateInParameter("@MapDomain", mapDomain, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByMapDomainAsync(string mapDomain, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mapDomain != null ? "`MapDomain` = @MapDomain" : "`MapDomain` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mapDomain != null)
				paras_.Add(Database.CreateInParameter("@MapDomain", mapDomain, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByMapDomain
		#region GetByLobbyUrl
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl)
		{
			return GetByLobbyUrl(lobbyUrl, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, TransactionManager tm_)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_)
		{
			return GetByLobbyUrl(lobbyUrl, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, int top_)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, int top_, TransactionManager tm_)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, string sort_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, string sort_)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, string sort_, TransactionManager tm_)
		{
			return await GetByLobbyUrlAsync(lobbyUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrl != null ? "`LobbyUrl` = @LobbyUrl" : "`LobbyUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrl != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrl", lobbyUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlAsync(string lobbyUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrl != null ? "`LobbyUrl` = @LobbyUrl" : "`LobbyUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrl != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrl", lobbyUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrl
		#region GetByLobbyUrlStaging
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, TransactionManager tm_)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, int top_)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, int top_, TransactionManager tm_)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, string sort_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, string sort_)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, string sort_, TransactionManager tm_)
		{
			return await GetByLobbyUrlStagingAsync(lobbyUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrlStaging != null ? "`LobbyUrlStaging` = @LobbyUrlStaging" : "`LobbyUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlStagingAsync(string lobbyUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrlStaging != null ? "`LobbyUrlStaging` = @LobbyUrlStaging" : "`LobbyUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrlStaging
		#region GetByLobbyUrlDebug
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, TransactionManager tm_)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, int top_)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, int top_, TransactionManager tm_)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, string sort_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, string sort_)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, string sort_, TransactionManager tm_)
		{
			return await GetByLobbyUrlDebugAsync(lobbyUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrlDebug != null ? "`LobbyUrlDebug` = @LobbyUrlDebug" : "`LobbyUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByLobbyUrlDebugAsync(string lobbyUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lobbyUrlDebug != null ? "`LobbyUrlDebug` = @LobbyUrlDebug" : "`LobbyUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lobbyUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrlDebug
		#region GetByBankUrl
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl)
		{
			return GetByBankUrl(bankUrl, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl)
		{
			return await GetByBankUrlAsync(bankUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, TransactionManager tm_)
		{
			return await GetByBankUrlAsync(bankUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, int top_)
		{
			return GetByBankUrl(bankUrl, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, int top_)
		{
			return await GetByBankUrlAsync(bankUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, int top_, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, int top_, TransactionManager tm_)
		{
			return await GetByBankUrlAsync(bankUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, string sort_)
		{
			return GetByBankUrl(bankUrl, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, string sort_)
		{
			return await GetByBankUrlAsync(bankUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, string sort_, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, string sort_, TransactionManager tm_)
		{
			return await GetByBankUrlAsync(bankUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrl(string bankUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrl != null ? "`BankUrl` = @BankUrl" : "`BankUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrl != null)
				paras_.Add(Database.CreateInParameter("@BankUrl", bankUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlAsync(string bankUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrl != null ? "`BankUrl` = @BankUrl" : "`BankUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrl != null)
				paras_.Add(Database.CreateInParameter("@BankUrl", bankUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrl
		#region GetByBankUrlStaging
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, TransactionManager tm_)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_)
		{
			return GetByBankUrlStaging(bankUrlStaging, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, int top_)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, int top_, TransactionManager tm_)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, string sort_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, string sort_)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, string sort_, TransactionManager tm_)
		{
			return await GetByBankUrlStagingAsync(bankUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrlStaging != null ? "`BankUrlStaging` = @BankUrlStaging" : "`BankUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@BankUrlStaging", bankUrlStaging, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlStagingAsync(string bankUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrlStaging != null ? "`BankUrlStaging` = @BankUrlStaging" : "`BankUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@BankUrlStaging", bankUrlStaging, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrlStaging
		#region GetByBankUrlDebug
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, TransactionManager tm_)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_)
		{
			return GetByBankUrlDebug(bankUrlDebug, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, int top_)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, int top_, TransactionManager tm_)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, string sort_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, string sort_)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, string sort_, TransactionManager tm_)
		{
			return await GetByBankUrlDebugAsync(bankUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrlDebug != null ? "`BankUrlDebug` = @BankUrlDebug" : "`BankUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@BankUrlDebug", bankUrlDebug, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByBankUrlDebugAsync(string bankUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(bankUrlDebug != null ? "`BankUrlDebug` = @BankUrlDebug" : "`BankUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (bankUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@BankUrlDebug", bankUrlDebug, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrlDebug
		#region GetByBranchKey
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey)
		{
			return await GetByBranchKeyAsync(branchKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, int top_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, int top_)
		{
			return await GetByBranchKeyAsync(branchKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, int top_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, int top_, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, string sort_)
		{
			return GetByBranchKey(branchKey, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, string sort_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, string sort_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, string sort_, TransactionManager tm_)
		{
			return await GetByBranchKeyAsync(branchKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBranchKey(string branchKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByBranchKeyAsync(string branchKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(branchKey != null ? "`BranchKey` = @BranchKey" : "`BranchKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (branchKey != null)
				paras_.Add(Database.CreateInParameter("@BranchKey", branchKey, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByBranchKey
		#region GetByGAKey
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey)
		{
			return GetByGAKey(gAKey, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey)
		{
			return await GetByGAKeyAsync(gAKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, int top_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, int top_)
		{
			return await GetByGAKeyAsync(gAKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, int top_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, int top_, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, string sort_)
		{
			return GetByGAKey(gAKey, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, string sort_)
		{
			return await GetByGAKeyAsync(gAKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, string sort_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, string sort_, TransactionManager tm_)
		{
			return await GetByGAKeyAsync(gAKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByGAKey(string gAKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByGAKeyAsync(string gAKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(gAKey != null ? "`GAKey` = @GAKey" : "`GAKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (gAKey != null)
				paras_.Add(Database.CreateInParameter("@GAKey", gAKey, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByGAKey
		#region GetByTitle
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title)
		{
			return GetByTitle(title, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title)
		{
			return await GetByTitleAsync(title, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, TransactionManager tm_)
		{
			return GetByTitle(title, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, int top_)
		{
			return GetByTitle(title, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, int top_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, int top_, TransactionManager tm_)
		{
			return GetByTitle(title, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, int top_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, string sort_)
		{
			return GetByTitle(title, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, string sort_)
		{
			return await GetByTitleAsync(title, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, string sort_, TransactionManager tm_)
		{
			return GetByTitle(title, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, string sort_, TransactionManager tm_)
		{
			return await GetByTitleAsync(title, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Title（字段） 查询
		/// </summary>
		/// /// <param name = "title">运营商标题描述</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByTitle(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByTitleAsync(string title, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(title != null ? "`Title` = @Title" : "`Title` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (title != null)
				paras_.Add(Database.CreateInParameter("@Title", title, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByTitle
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, int top_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, string sort_)
		{
			return await GetByNoteAsync(note, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetByEnableBonus
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus)
		{
			return GetByEnableBonus(enableBonus, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus)
		{
			return await GetByEnableBonusAsync(enableBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, TransactionManager tm_)
		{
			return await GetByEnableBonusAsync(enableBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, int top_)
		{
			return GetByEnableBonus(enableBonus, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, int top_)
		{
			return await GetByEnableBonusAsync(enableBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, int top_, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, int top_, TransactionManager tm_)
		{
			return await GetByEnableBonusAsync(enableBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, string sort_)
		{
			return GetByEnableBonus(enableBonus, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, string sort_)
		{
			return await GetByEnableBonusAsync(enableBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, string sort_, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, string sort_, TransactionManager tm_)
		{
			return await GetByEnableBonusAsync(enableBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByEnableBonus(bool enableBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EnableBonus` = @EnableBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByEnableBonusAsync(bool enableBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EnableBonus` = @EnableBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByEnableBonus
		#region GetByChangeBalanceMode
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, TransactionManager tm_)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, int top_)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, int top_, TransactionManager tm_)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, string sort_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, string sort_)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, string sort_, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, string sort_, TransactionManager tm_)
		{
			return await GetByChangeBalanceModeAsync(changeBalanceMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeBalanceMode` = @ChangeBalanceMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByChangeBalanceModeAsync(int changeBalanceMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeBalanceMode` = @ChangeBalanceMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByChangeBalanceMode
		#region GetByFlowMode
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode)
		{
			return GetByFlowMode(flowMode, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode)
		{
			return await GetByFlowModeAsync(flowMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, TransactionManager tm_)
		{
			return await GetByFlowModeAsync(flowMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, int top_)
		{
			return GetByFlowMode(flowMode, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, int top_)
		{
			return await GetByFlowModeAsync(flowMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, int top_, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, int top_, TransactionManager tm_)
		{
			return await GetByFlowModeAsync(flowMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, string sort_)
		{
			return GetByFlowMode(flowMode, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, string sort_)
		{
			return await GetByFlowModeAsync(flowMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, string sort_, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, string sort_, TransactionManager tm_)
		{
			return await GetByFlowModeAsync(flowMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowMode(int flowMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMode` = @FlowMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByFlowModeAsync(int flowMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMode` = @FlowMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowMode
		#region GetByFirstPayFlowMultip
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, TransactionManager tm_)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, int top_)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, int top_, TransactionManager tm_)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, string sort_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, string sort_)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByFirstPayFlowMultipAsync(firstPayFlowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayFlowMultip` = @FirstPayFlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByFirstPayFlowMultipAsync(int firstPayFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayFlowMultip` = @FirstPayFlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByFirstPayFlowMultip
		#region GetByPayFlowMultip
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, TransactionManager tm_)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_)
		{
			return GetByPayFlowMultip(payFlowMultip, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, int top_)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, int top_, TransactionManager tm_)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, string sort_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, string sort_)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, string sort_, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, string sort_, TransactionManager tm_)
		{
			return await GetByPayFlowMultipAsync(payFlowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayFlowMultip` = @PayFlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByPayFlowMultipAsync(int payFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayFlowMultip` = @PayFlowMultip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByPayFlowMultip
		#region GetByFlowBalance
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance)
		{
			return GetByFlowBalance(flowBalance, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance)
		{
			return await GetByFlowBalanceAsync(flowBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, TransactionManager tm_)
		{
			return await GetByFlowBalanceAsync(flowBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, int top_)
		{
			return GetByFlowBalance(flowBalance, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, int top_)
		{
			return await GetByFlowBalanceAsync(flowBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, int top_, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, int top_, TransactionManager tm_)
		{
			return await GetByFlowBalanceAsync(flowBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, string sort_)
		{
			return GetByFlowBalance(flowBalance, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, string sort_)
		{
			return await GetByFlowBalanceAsync(flowBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, string sort_, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, string sort_, TransactionManager tm_)
		{
			return await GetByFlowBalanceAsync(flowBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowBalance(long flowBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowBalance` = @FlowBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByFlowBalanceAsync(long flowBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowBalance` = @FlowBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowBalance
		#region GetByFlowDevideBalance
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, TransactionManager tm_)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, int top_)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, int top_, TransactionManager tm_)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, string sort_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, string sort_)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, string sort_, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, string sort_, TransactionManager tm_)
		{
			return await GetByFlowDevideBalanceAsync(flowDevideBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowDevideBalance` = @FlowDevideBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByFlowDevideBalanceAsync(int flowDevideBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowDevideBalance` = @FlowDevideBalance", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowDevideBalance
		#region GetByClientThemes
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes)
		{
			return GetByClientThemes(clientThemes, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes)
		{
			return await GetByClientThemesAsync(clientThemes, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, TransactionManager tm_)
		{
			return await GetByClientThemesAsync(clientThemes, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, int top_)
		{
			return GetByClientThemes(clientThemes, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, int top_)
		{
			return await GetByClientThemesAsync(clientThemes, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, int top_, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, int top_, TransactionManager tm_)
		{
			return await GetByClientThemesAsync(clientThemes, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, string sort_)
		{
			return GetByClientThemes(clientThemes, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, string sort_)
		{
			return await GetByClientThemesAsync(clientThemes, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, string sort_, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, string sort_, TransactionManager tm_)
		{
			return await GetByClientThemesAsync(clientThemes, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByClientThemes(string clientThemes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(clientThemes != null ? "`ClientThemes` = @ClientThemes" : "`ClientThemes` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (clientThemes != null)
				paras_.Add(Database.CreateInParameter("@ClientThemes", clientThemes, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByClientThemesAsync(string clientThemes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(clientThemes != null ? "`ClientThemes` = @ClientThemes" : "`ClientThemes` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (clientThemes != null)
				paras_.Add(Database.CreateInParameter("@ClientThemes", clientThemes, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByClientThemes
		#region GetByWithdrawAmountMode
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, TransactionManager tm_)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, int top_)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, int top_, TransactionManager tm_)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, string sort_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, string sort_)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, string sort_, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, string sort_, TransactionManager tm_)
		{
			return await GetByWithdrawAmountModeAsync(withdrawAmountMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode">可提现金额模式0-真金余额 1-根据固定算法调整</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawAmountMode` = @WithdrawAmountMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawAmountModeAsync(int withdrawAmountMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawAmountMode` = @WithdrawAmountMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByWithdrawAmountMode
		#region GetByWithdrawRuleMode
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, TransactionManager tm_)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, int top_)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, int top_, TransactionManager tm_)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, string sort_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, string sort_)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, string sort_, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, string sort_, TransactionManager tm_)
		{
			return await GetByWithdrawRuleModeAsync(withdrawRuleMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawRuleMode` = @WithdrawRuleMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByWithdrawRuleModeAsync(int withdrawRuleMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawRuleMode` = @WithdrawRuleMode", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByWithdrawRuleMode
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_operatorEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_operatorEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_operatorEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_operatorEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_operatorEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_operatorEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByOrderNum
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, int top_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, int top_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, int top_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, int top_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, string sort_)
		{
			return GetByOrderNum(orderNum, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, string sort_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, string sort_, TransactionManager tm_)
		{
			return GetByOrderNum(orderNum, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, string sort_, TransactionManager tm_)
		{
			return await GetByOrderNumAsync(orderNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderNum（字段） 查询
		/// </summary>
		/// /// <param name = "orderNum">排序号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByOrderNum(int? orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderNum.HasValue ? "`OrderNum` = @OrderNum" : "`OrderNum` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderNum", orderNum.Value, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByOrderNumAsync(int? orderNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(orderNum.HasValue ? "`OrderNum` = @OrderNum" : "`OrderNum` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (orderNum.HasValue)
				paras_.Add(Database.CreateInParameter("@OrderNum", orderNum.Value, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByOrderNum
		#region GetByBetRatioOfWithdrawAmount
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, int top_)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, string sort_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, string sort_)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetRatioOfWithdrawAmountAsync(betRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByBetRatioOfWithdrawAmountAsync(decimal betRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByBetRatioOfWithdrawAmount
		#region GetByWinRatioOfWithdrawAmount
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, int top_)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, string sort_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, sort_, null);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, string sort_)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinRatioOfWithdrawAmountAsync(winRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		public async Task<List<S_operatorEO>> GetByWinRatioOfWithdrawAmountAsync(decimal winRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_operatorEO.MapDataReader);
		}
		#endregion // GetByWinRatioOfWithdrawAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
