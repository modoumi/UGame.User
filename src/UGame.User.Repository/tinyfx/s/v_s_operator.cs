/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-06-27 12: 58:21
 ******************************************************/
using System;
using System.Data;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using AiUo;
using AiUo.Data;
using MySql.Data.MySqlClient;
using AiUo.Data.MySql;

namespace UGame.User.Repository
{
	#region EO
	/// <summary>
	/// 
	/// 【视图 v_s_operator 的实体类】
	/// </summary>
	[Serializable]
	[Obsolete]
	public class V_s_operatorEO : IRowMapper<V_s_operatorEO>
	{
		#region 所有字段
		/// <summary>
		/// 运营商编码（小写，唯一）
		/// 【字段 varchar(50)】
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
		/// 运营商名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 3)]
		public string OperatorName { get; set; }
		/// <summary>
		/// 运营商类型
		///              0-自有
		///              1-第三方有用户有充值
		///              2-第三方有用户无充值
		///              3-第三方无用户无充值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int OperatorType { get; set; }
		/// <summary>
		/// 独服混服类型(0-混服1-独服)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int? OperatorMode { get; set; }
		/// <summary>
		/// 是否允许游客
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 6)]
		public bool AllowVisitor { get; set; }
		/// <summary>
		/// 运营商公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 7)]
		public string OperPublicKey { get; set; }
		/// <summary>
		/// 运营商私钥（仅测试）
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string OperPrivateKey { get; set; }
		/// <summary>
		/// 我方的公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 9)]
		public string OwnPublicKey { get; set; }
		/// <summary>
		/// 我方的私钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 10)]
		public string OwnPrivateKey { get; set; }
		/// <summary>
		/// 运营商的配置信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 11)]
		public string OperatorConfig { get; set; }
		/// <summary>
		/// 结算日，如5表示每月结算包含5号
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int SettlDayNum { get; set; }
		/// <summary>
		/// 运营商逻辑版本0-基础版本1-长效版本
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int OperatorVersion { get; set; }
		/// <summary>
		/// 国家编码ISO 3166-1三位字母
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 14)]
		public string CountryID { get; set; }
		/// <summary>
		/// 平台支持的语言。|分割
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 15)]
		public string Langs { get; set; }
		/// <summary>
		/// 货币类型（货币缩写USD）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 16)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 对应的主域名如: 777gana.com
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 17)]
		public string MapDomain { get; set; }
		/// <summary>
		/// 大厅客户端线上URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 18)]
		public string LobbyUrl { get; set; }
		/// <summary>
		/// 大厅客户端仿真URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 19)]
		public string LobbyUrlStaging { get; set; }
		/// <summary>
		/// 大厅客户端调试URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 20)]
		public string LobbyUrlDebug { get; set; }
		/// <summary>
		/// 银行客户端线上URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 21)]
		public string BankUrl { get; set; }
		/// <summary>
		/// 银行客户端仿真URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 22)]
		public string BankUrlStaging { get; set; }
		/// <summary>
		/// 银行客户端调试URL
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 23)]
		public string BankUrlDebug { get; set; }
		/// <summary>
		/// branch关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 24)]
		public string BranchKey { get; set; }
		/// <summary>
		/// GA关键字
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 25)]
		public string GAKey { get; set; }
		/// <summary>
		/// 是否启用bonus（用户是否有bonus账户）
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 26)]
		public bool EnableBonus { get; set; }
		/// <summary>
		/// 扣减balance模式1-优先bonus2-优先真金
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 27)]
		public int ChangeBalanceMode { get; set; }
		/// <summary>
		/// 流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 28)]
		public int FlowMode { get; set; }
		/// <summary>
		/// 首充流水倍数，如20倍
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 29)]
		public int FirstPayFlowMultip { get; set; }
		/// <summary>
		/// 充值流水倍数，如20倍
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 30)]
		public int PayFlowMultip { get; set; }
		/// <summary>
		/// 用户余额大于此值则流水需继承
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 31)]
		public long FlowBalance { get; set; }
		/// <summary>
		/// 流水除以用户余额的倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 32)]
		public int FlowDevideBalance { get; set; }
		/// <summary>
		/// 客户端样式配置
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 33)]
		public string ClientThemes { get; set; }
		/// <summary>
		/// 
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 34)]
		public int WithdrawAmountMode { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 35)]
		public int Status { get; set; }
		/// <summary>
		/// 
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 36)]
		public int CashAudit { get; set; }
		/// <summary>
		/// 用户bet的计算比例,0<=X<=1
		/// 【字段 decimal(3,2)】
		/// </summary>
		[DataMember(Order = 37)]
		public decimal BetRatioOfWithdrawAmount { get; set; }
		/// <summary>
		/// 用户reward的计算比例,0<=Y<=1
		/// 【字段 decimal(3,2)】
		/// </summary>
		[DataMember(Order = 38)]
		public decimal WinRatioOfWithdrawAmount { get; set; }
		/// <summary>
		/// 提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 39)]
		public int WithdrawRuleMode { get; set; }
		/// <summary>
		/// 扩展字段
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 40)]
		public string Meta { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public V_s_operatorEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static V_s_operatorEO MapDataReader(IDataReader reader)
		{
		    V_s_operatorEO ret = new V_s_operatorEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OperatorBaseID = reader.ToString("OperatorBaseID");
			ret.OperatorName = reader.ToString("OperatorName");
			ret.OperatorType = reader.ToInt32("OperatorType");
			ret.OperatorMode = reader.ToInt32N("OperatorMode");
			ret.AllowVisitor = reader.ToBoolean("AllowVisitor");
			ret.OperPublicKey = reader.ToString("OperPublicKey");
			ret.OperPrivateKey = reader.ToString("OperPrivateKey");
			ret.OwnPublicKey = reader.ToString("OwnPublicKey");
			ret.OwnPrivateKey = reader.ToString("OwnPrivateKey");
			ret.OperatorConfig = reader.ToString("OperatorConfig");
			ret.SettlDayNum = reader.ToInt32("SettlDayNum");
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
			ret.EnableBonus = reader.ToBoolean("EnableBonus");
			ret.ChangeBalanceMode = reader.ToInt32("ChangeBalanceMode");
			ret.FlowMode = reader.ToInt32("FlowMode");
			ret.FirstPayFlowMultip = reader.ToInt32("FirstPayFlowMultip");
			ret.PayFlowMultip = reader.ToInt32("PayFlowMultip");
			ret.FlowBalance = reader.ToInt64("FlowBalance");
			ret.FlowDevideBalance = reader.ToInt32("FlowDevideBalance");
			ret.ClientThemes = reader.ToString("ClientThemes");
			ret.WithdrawAmountMode = reader.ToInt32("WithdrawAmountMode");
			ret.Status = reader.ToInt32("Status");
			ret.CashAudit = reader.ToInt32("CashAudit");
			ret.BetRatioOfWithdrawAmount = reader.ToDecimal("BetRatioOfWithdrawAmount");
			ret.WinRatioOfWithdrawAmount = reader.ToDecimal("WinRatioOfWithdrawAmount");
			ret.WithdrawRuleMode = reader.ToInt32("WithdrawRuleMode");
			ret.Meta = reader.ToString("Meta");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【视图 v_s_operator 的操作类】
	/// </summary>
	[Obsolete]
	public class V_s_operatorMO : MySqlViewMO<V_s_operatorEO>
	{
		/// <summary>
		/// 视图名
		/// </summary>
	    public override string ViewName { get; set; } = "`v_s_operator`"; 
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public V_s_operatorMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public V_s_operatorMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public V_s_operatorMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
		#region Get
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByOperatorBaseID
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_)
		{
			return GetByOperatorBaseID(operatorBaseID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, string sort_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorBaseID(operatorBaseID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorBaseID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorBaseID">运营商基础编码（小写，唯一）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorBaseID(string operatorBaseID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorBaseID` = @OperatorBaseID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorBaseID", operatorBaseID, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorBaseID
		#region GetByOperatorName
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, int top_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, int top_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, string sort_)
		{
			return GetByOperatorName(operatorName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, string sort_, TransactionManager tm_)
		{
			return GetByOperatorName(operatorName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorName（字段） 查询
		/// </summary>
		/// /// <param name = "operatorName">运营商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorName(string operatorName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorName` = @OperatorName", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorName", operatorName != null ? operatorName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorName
		#region GetByOperatorType
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType)
		{
			return GetByOperatorType(operatorType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, int top_)
		{
			return GetByOperatorType(operatorType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, int top_, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, string sort_)
		{
			return GetByOperatorType(operatorType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, string sort_, TransactionManager tm_)
		{
			return GetByOperatorType(operatorType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorType（字段） 查询
		/// </summary>
		/// /// <param name = "operatorType">运营商类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorType(int operatorType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorType` = @OperatorType", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorType", operatorType, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorType
		#region GetByOperatorMode
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode)
		{
			return GetByOperatorMode(operatorMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, int top_)
		{
			return GetByOperatorMode(operatorMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, int top_, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, string sort_)
		{
			return GetByOperatorMode(operatorMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, string sort_, TransactionManager tm_)
		{
			return GetByOperatorMode(operatorMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorMode（字段） 查询
		/// </summary>
		/// /// <param name = "operatorMode">独服混服类型(0-混服1-独服)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorMode(int? operatorMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorMode` = @OperatorMode", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorMode", operatorMode.HasValue ? operatorMode.Value : (object)DBNull.Value, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorMode
		#region GetByAllowVisitor
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor)
		{
			return GetByAllowVisitor(allowVisitor, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, int top_)
		{
			return GetByAllowVisitor(allowVisitor, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, int top_, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, string sort_)
		{
			return GetByAllowVisitor(allowVisitor, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, string sort_, TransactionManager tm_)
		{
			return GetByAllowVisitor(allowVisitor, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AllowVisitor（字段） 查询
		/// </summary>
		/// /// <param name = "allowVisitor">是否允许游客</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByAllowVisitor(bool allowVisitor, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AllowVisitor` = @AllowVisitor", top_, sort_);
			var parameter_ = Database.CreateInParameter("@AllowVisitor", allowVisitor, MySqlDbType.Byte);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByAllowVisitor
		#region GetByOperPublicKey
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey)
		{
			return GetByOperPublicKey(operPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, int top_)
		{
			return GetByOperPublicKey(operPublicKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, int top_, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, string sort_)
		{
			return GetByOperPublicKey(operPublicKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByOperPublicKey(operPublicKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPublicKey">运营商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPublicKey(string operPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperPublicKey` = @OperPublicKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperPublicKey", operPublicKey != null ? operPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperPublicKey
		#region GetByOperPrivateKey
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, int top_)
		{
			return GetByOperPrivateKey(operPrivateKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, string sort_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByOperPrivateKey(operPrivateKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "operPrivateKey">运营商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperPrivateKey(string operPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperPrivateKey` = @OperPrivateKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperPrivateKey", operPrivateKey != null ? operPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperPrivateKey
		#region GetByOwnPublicKey
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, int top_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, string sort_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPublicKey(string ownPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OwnPublicKey` = @OwnPublicKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OwnPublicKey", ownPublicKey != null ? ownPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOwnPublicKey
		#region GetByOwnPrivateKey
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, int top_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OwnPrivateKey` = @OwnPrivateKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey != null ? ownPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOwnPrivateKey
		#region GetByOperatorConfig
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig)
		{
			return GetByOperatorConfig(operatorConfig, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, int top_)
		{
			return GetByOperatorConfig(operatorConfig, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, int top_, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, string sort_)
		{
			return GetByOperatorConfig(operatorConfig, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, string sort_, TransactionManager tm_)
		{
			return GetByOperatorConfig(operatorConfig, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorConfig（字段） 查询
		/// </summary>
		/// /// <param name = "operatorConfig">运营商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorConfig(string operatorConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorConfig` = @OperatorConfig", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorConfig", operatorConfig != null ? operatorConfig : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorConfig
		#region GetBySettlDayNum
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, int top_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, int top_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, string sort_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, string sort_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetBySettlDayNum(int settlDayNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlDayNum` = @SettlDayNum", top_, sort_);
			var parameter_ = Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetBySettlDayNum
		#region GetByOperatorVersion
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion)
		{
			return GetByOperatorVersion(operatorVersion, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, int top_)
		{
			return GetByOperatorVersion(operatorVersion, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, int top_, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, string sort_)
		{
			return GetByOperatorVersion(operatorVersion, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, string sort_, TransactionManager tm_)
		{
			return GetByOperatorVersion(operatorVersion, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorVersion（字段） 查询
		/// </summary>
		/// /// <param name = "operatorVersion">运营商逻辑版本0-基础版本1-长效版本</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByOperatorVersion(int operatorVersion, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorVersion` = @OperatorVersion", top_, sort_);
			var parameter_ = Database.CreateInParameter("@OperatorVersion", operatorVersion, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByOperatorVersion
		#region GetByCountryID
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID)
		{
			return GetByCountryID(countryID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, int top_)
		{
			return GetByCountryID(countryID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, int top_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, string sort_)
		{
			return GetByCountryID(countryID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, string sort_, TransactionManager tm_)
		{
			return GetByCountryID(countryID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CountryID（字段） 查询
		/// </summary>
		/// /// <param name = "countryID">国家编码ISO 3166-1三位字母</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCountryID(string countryID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CountryID` = @CountryID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CountryID", countryID != null ? countryID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByCountryID
		#region GetByLangs
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs)
		{
			return GetByLangs(langs, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, int top_)
		{
			return GetByLangs(langs, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, int top_, TransactionManager tm_)
		{
			return GetByLangs(langs, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, string sort_)
		{
			return GetByLangs(langs, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, string sort_, TransactionManager tm_)
		{
			return GetByLangs(langs, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Langs（字段） 查询
		/// </summary>
		/// /// <param name = "langs">平台支持的语言。|分割</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLangs(string langs, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Langs` = @Langs", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Langs", langs != null ? langs : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByLangs
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币类型（货币缩写USD）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByMapDomain
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain)
		{
			return GetByMapDomain(mapDomain, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, int top_)
		{
			return GetByMapDomain(mapDomain, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, int top_, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, string sort_)
		{
			return GetByMapDomain(mapDomain, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, string sort_, TransactionManager tm_)
		{
			return GetByMapDomain(mapDomain, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MapDomain（字段） 查询
		/// </summary>
		/// /// <param name = "mapDomain">对应的主域名如: 777gana.com</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMapDomain(string mapDomain, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MapDomain` = @MapDomain", top_, sort_);
			var parameter_ = Database.CreateInParameter("@MapDomain", mapDomain != null ? mapDomain : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByMapDomain
		#region GetByLobbyUrl
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl)
		{
			return GetByLobbyUrl(lobbyUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_)
		{
			return GetByLobbyUrl(lobbyUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, string sort_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrl(lobbyUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrl（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrl">大厅客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrl(string lobbyUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LobbyUrl` = @LobbyUrl", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LobbyUrl", lobbyUrl != null ? lobbyUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrl
		#region GetByLobbyUrlStaging
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, string sort_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrlStaging(lobbyUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlStaging">大厅客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlStaging(string lobbyUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LobbyUrlStaging` = @LobbyUrlStaging", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LobbyUrlStaging", lobbyUrlStaging != null ? lobbyUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrlStaging
		#region GetByLobbyUrlDebug
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, string sort_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByLobbyUrlDebug(lobbyUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LobbyUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "lobbyUrlDebug">大厅客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByLobbyUrlDebug(string lobbyUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LobbyUrlDebug` = @LobbyUrlDebug", top_, sort_);
			var parameter_ = Database.CreateInParameter("@LobbyUrlDebug", lobbyUrlDebug != null ? lobbyUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByLobbyUrlDebug
		#region GetByBankUrl
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl)
		{
			return GetByBankUrl(bankUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, int top_)
		{
			return GetByBankUrl(bankUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, int top_, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, string sort_)
		{
			return GetByBankUrl(bankUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, string sort_, TransactionManager tm_)
		{
			return GetByBankUrl(bankUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrl（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrl">银行客户端线上URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrl(string bankUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankUrl` = @BankUrl", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BankUrl", bankUrl != null ? bankUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrl
		#region GetByBankUrlStaging
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_)
		{
			return GetByBankUrlStaging(bankUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, string sort_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByBankUrlStaging(bankUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlStaging">银行客户端仿真URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlStaging(string bankUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankUrlStaging` = @BankUrlStaging", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BankUrlStaging", bankUrlStaging != null ? bankUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrlStaging
		#region GetByBankUrlDebug
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_)
		{
			return GetByBankUrlDebug(bankUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, string sort_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByBankUrlDebug(bankUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BankUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "bankUrlDebug">银行客户端调试URL</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBankUrlDebug(string bankUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BankUrlDebug` = @BankUrlDebug", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BankUrlDebug", bankUrlDebug != null ? bankUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByBankUrlDebug
		#region GetByBranchKey
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, int top_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, int top_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, string sort_)
		{
			return GetByBranchKey(branchKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, string sort_, TransactionManager tm_)
		{
			return GetByBranchKey(branchKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BranchKey（字段） 查询
		/// </summary>
		/// /// <param name = "branchKey">branch关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBranchKey(string branchKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BranchKey` = @BranchKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BranchKey", branchKey != null ? branchKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByBranchKey
		#region GetByGAKey
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey)
		{
			return GetByGAKey(gAKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, int top_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, int top_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, string sort_)
		{
			return GetByGAKey(gAKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, string sort_, TransactionManager tm_)
		{
			return GetByGAKey(gAKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GAKey（字段） 查询
		/// </summary>
		/// /// <param name = "gAKey">GA关键字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByGAKey(string gAKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GAKey` = @GAKey", top_, sort_);
			var parameter_ = Database.CreateInParameter("@GAKey", gAKey != null ? gAKey : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByGAKey
		#region GetByEnableBonus
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus)
		{
			return GetByEnableBonus(enableBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, int top_)
		{
			return GetByEnableBonus(enableBonus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, int top_, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, string sort_)
		{
			return GetByEnableBonus(enableBonus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, string sort_, TransactionManager tm_)
		{
			return GetByEnableBonus(enableBonus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EnableBonus（字段） 查询
		/// </summary>
		/// /// <param name = "enableBonus">是否启用bonus（用户是否有bonus账户）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByEnableBonus(bool enableBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EnableBonus` = @EnableBonus", top_, sort_);
			var parameter_ = Database.CreateInParameter("@EnableBonus", enableBonus, MySqlDbType.Byte);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByEnableBonus
		#region GetByChangeBalanceMode
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, string sort_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, string sort_, TransactionManager tm_)
		{
			return GetByChangeBalanceMode(changeBalanceMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChangeBalanceMode（字段） 查询
		/// </summary>
		/// /// <param name = "changeBalanceMode">扣减balance模式1-优先bonus2-优先真金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByChangeBalanceMode(int changeBalanceMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChangeBalanceMode` = @ChangeBalanceMode", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ChangeBalanceMode", changeBalanceMode, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByChangeBalanceMode
		#region GetByFlowMode
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode)
		{
			return GetByFlowMode(flowMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, int top_)
		{
			return GetByFlowMode(flowMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, int top_, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, string sort_)
		{
			return GetByFlowMode(flowMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, string sort_, TransactionManager tm_)
		{
			return GetByFlowMode(flowMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowMode（字段） 查询
		/// </summary>
		/// /// <param name = "flowMode">流水计算方式（不同的执行类）1-仅流水+充值2-下注-返奖；3:新的Bonus流水</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowMode(int flowMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowMode` = @FlowMode", top_, sort_);
			var parameter_ = Database.CreateInParameter("@FlowMode", flowMode, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowMode
		#region GetByFirstPayFlowMultip
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, string sort_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, string sort_, TransactionManager tm_)
		{
			return GetByFirstPayFlowMultip(firstPayFlowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FirstPayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "firstPayFlowMultip">首充流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFirstPayFlowMultip(int firstPayFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FirstPayFlowMultip` = @FirstPayFlowMultip", top_, sort_);
			var parameter_ = Database.CreateInParameter("@FirstPayFlowMultip", firstPayFlowMultip, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByFirstPayFlowMultip
		#region GetByPayFlowMultip
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_)
		{
			return GetByPayFlowMultip(payFlowMultip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, string sort_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, string sort_, TransactionManager tm_)
		{
			return GetByPayFlowMultip(payFlowMultip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PayFlowMultip（字段） 查询
		/// </summary>
		/// /// <param name = "payFlowMultip">充值流水倍数，如20倍</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByPayFlowMultip(int payFlowMultip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PayFlowMultip` = @PayFlowMultip", top_, sort_);
			var parameter_ = Database.CreateInParameter("@PayFlowMultip", payFlowMultip, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByPayFlowMultip
		#region GetByFlowBalance
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance)
		{
			return GetByFlowBalance(flowBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, int top_)
		{
			return GetByFlowBalance(flowBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, int top_, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, string sort_)
		{
			return GetByFlowBalance(flowBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, string sort_, TransactionManager tm_)
		{
			return GetByFlowBalance(flowBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowBalance">用户余额大于此值则流水需继承</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowBalance(long flowBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowBalance` = @FlowBalance", top_, sort_);
			var parameter_ = Database.CreateInParameter("@FlowBalance", flowBalance, MySqlDbType.Int64);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowBalance
		#region GetByFlowDevideBalance
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, string sort_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, string sort_, TransactionManager tm_)
		{
			return GetByFlowDevideBalance(flowDevideBalance, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FlowDevideBalance（字段） 查询
		/// </summary>
		/// /// <param name = "flowDevideBalance">流水除以用户余额的倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByFlowDevideBalance(int flowDevideBalance, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FlowDevideBalance` = @FlowDevideBalance", top_, sort_);
			var parameter_ = Database.CreateInParameter("@FlowDevideBalance", flowDevideBalance, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByFlowDevideBalance
		#region GetByClientThemes
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes)
		{
			return GetByClientThemes(clientThemes, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, int top_)
		{
			return GetByClientThemes(clientThemes, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, int top_, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, string sort_)
		{
			return GetByClientThemes(clientThemes, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, string sort_, TransactionManager tm_)
		{
			return GetByClientThemes(clientThemes, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ClientThemes（字段） 查询
		/// </summary>
		/// /// <param name = "clientThemes">客户端样式配置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByClientThemes(string clientThemes, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ClientThemes` = @ClientThemes", top_, sort_);
			var parameter_ = Database.CreateInParameter("@ClientThemes", clientThemes != null ? clientThemes : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByClientThemes
		#region GetByWithdrawAmountMode
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, string sort_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, string sort_, TransactionManager tm_)
		{
			return GetByWithdrawAmountMode(withdrawAmountMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawAmountMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawAmountMode"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawAmountMode(int withdrawAmountMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawAmountMode` = @WithdrawAmountMode", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WithdrawAmountMode", withdrawAmountMode, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByWithdrawAmountMode
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByCashAudit
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit)
		{
			return GetByCashAudit(cashAudit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, int top_)
		{
			return GetByCashAudit(cashAudit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, int top_, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, string sort_)
		{
			return GetByCashAudit(cashAudit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, string sort_, TransactionManager tm_)
		{
			return GetByCashAudit(cashAudit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CashAudit（字段） 查询
		/// </summary>
		/// /// <param name = "cashAudit"></param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByCashAudit(int cashAudit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CashAudit` = @CashAudit", top_, sort_);
			var parameter_ = Database.CreateInParameter("@CashAudit", cashAudit, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByCashAudit
		#region GetByBetRatioOfWithdrawAmount
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, string sort_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetRatioOfWithdrawAmount(betRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betRatioOfWithdrawAmount">用户bet的计算比例,0<=X<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByBetRatioOfWithdrawAmount(decimal betRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetRatioOfWithdrawAmount` = @BetRatioOfWithdrawAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@BetRatioOfWithdrawAmount", betRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByBetRatioOfWithdrawAmount
		#region GetByWinRatioOfWithdrawAmount
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, string sort_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinRatioOfWithdrawAmount(winRatioOfWithdrawAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinRatioOfWithdrawAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winRatioOfWithdrawAmount">用户reward的计算比例,0<=Y<=1</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWinRatioOfWithdrawAmount(decimal winRatioOfWithdrawAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinRatioOfWithdrawAmount` = @WinRatioOfWithdrawAmount", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WinRatioOfWithdrawAmount", winRatioOfWithdrawAmount, MySqlDbType.NewDecimal);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByWinRatioOfWithdrawAmount
		#region GetByWithdrawRuleMode
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, string sort_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, string sort_, TransactionManager tm_)
		{
			return GetByWithdrawRuleMode(withdrawRuleMode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WithdrawRuleMode（字段） 查询
		/// </summary>
		/// /// <param name = "withdrawRuleMode">提现规则模式0-短版本 1-长版本 2-新货币算法 3-自动提现审核</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByWithdrawRuleMode(int withdrawRuleMode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WithdrawRuleMode` = @WithdrawRuleMode", top_, sort_);
			var parameter_ = Database.CreateInParameter("@WithdrawRuleMode", withdrawRuleMode, MySqlDbType.Int32);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByWithdrawRuleMode
		#region GetByMeta
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta)
		{
			return GetByMeta(meta, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, int top_)
		{
			return GetByMeta(meta, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, int top_, TransactionManager tm_)
		{
			return GetByMeta(meta, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, string sort_)
		{
			return GetByMeta(meta, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, string sort_, TransactionManager tm_)
		{
			return GetByMeta(meta, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Meta（字段） 查询
		/// </summary>
		/// /// <param name = "meta">扩展字段</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<V_s_operatorEO> GetByMeta(string meta, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Meta` = @Meta", top_, sort_);
			var parameter_ = Database.CreateInParameter("@Meta", meta != null ? meta : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlList(sql_, new MySqlParameter[] { parameter_ }, tm_, V_s_operatorEO.MapDataReader);
		}
		#endregion // GetByMeta
		#endregion // Get
	}
	#endregion // MO
}
