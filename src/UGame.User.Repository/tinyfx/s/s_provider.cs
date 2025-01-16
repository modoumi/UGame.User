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
	/// 应用提供商
	/// 【表 s_provider 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_providerEO : IRowMapper<S_providerEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_providerEO()
		{
			this.ProviderType = 1;
			this.UseBonus = false;
			this.SettlDayNum = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalProviderID;
		/// <summary>
		/// 【数据库中的原始主键 ProviderID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalProviderID
		{
			get { return _originalProviderID; }
			set { HasOriginal = true; _originalProviderID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ProviderID", ProviderID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 应用提供商编码（小写，唯一）自有own
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string ProviderID { get; set; }
		/// <summary>
		/// 应用提供商名称
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 2)]
		public string ProviderName { get; set; }
		/// <summary>
		/// 应用提供商类型（0-自有 1-第三方）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ProviderType { get; set; }
		/// <summary>
		/// 是否使用bonus
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 4)]
		public bool UseBonus { get; set; }
		/// <summary>
		/// 获取应用客户端URL的API路径（应用提供商提供）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string ApiUrl { get; set; }
		/// <summary>
		/// 获取应用客户端URL的API路径（仿真）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string ApiUrlStaging { get; set; }
		/// <summary>
		/// 获取应用客户端URL的API路径（联调）
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 7)]
		public string ApiUrlDebug { get; set; }
		/// <summary>
		/// 应用提供商公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 8)]
		public string ProvPublicKey { get; set; }
		/// <summary>
		/// 应用提供商私钥（仅测试）
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 9)]
		public string ProvPrivateKey { get; set; }
		/// <summary>
		/// 我方的公钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 10)]
		public string OwnPublicKey { get; set; }
		/// <summary>
		/// 我方的私钥
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 11)]
		public string OwnPrivateKey { get; set; }
		/// <summary>
		/// 应用提供商的配置信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 12)]
		public string ProviderConfig { get; set; }
		/// <summary>
		/// 手机号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 13)]
		public string Mobile { get; set; }
		/// <summary>
		/// 邮箱
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 14)]
		public string Email { get; set; }
		/// <summary>
		/// 备注信息
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 15)]
		public string Note { get; set; }
		/// <summary>
		/// 结算日，如5表示每月结算包含5号
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 16)]
		public int SettlDayNum { get; set; }
		/// <summary>
		/// 状态(0-无效1-有效)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 17)]
		public int Status { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 18)]
		public DateTime RecDate { get; set; }
		/// <summary>
		/// 我方提供的后台账号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 19)]
		public string AdminUser { get; set; }
		/// <summary>
		/// 我方提供的后台密码
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 20)]
		public string AdminPwd { get; set; }
		/// <summary>
		/// 应用提供商后台地址
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 21)]
		public string ProvAdminUrl { get; set; }
		/// <summary>
		/// 应用提供商后台账号
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 22)]
		public string ProvAdminUser { get; set; }
		/// <summary>
		/// 应用提供商后台密码
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 23)]
		public string ProvAdminPwd { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_providerEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_providerEO MapDataReader(IDataReader reader)
		{
		    S_providerEO ret = new S_providerEO();
			ret.ProviderID = reader.ToString("ProviderID");
			ret.OriginalProviderID = ret.ProviderID;
			ret.ProviderName = reader.ToString("ProviderName");
			ret.ProviderType = reader.ToInt32("ProviderType");
			ret.UseBonus = reader.ToBoolean("UseBonus");
			ret.ApiUrl = reader.ToString("ApiUrl");
			ret.ApiUrlStaging = reader.ToString("ApiUrlStaging");
			ret.ApiUrlDebug = reader.ToString("ApiUrlDebug");
			ret.ProvPublicKey = reader.ToString("ProvPublicKey");
			ret.ProvPrivateKey = reader.ToString("ProvPrivateKey");
			ret.OwnPublicKey = reader.ToString("OwnPublicKey");
			ret.OwnPrivateKey = reader.ToString("OwnPrivateKey");
			ret.ProviderConfig = reader.ToString("ProviderConfig");
			ret.Mobile = reader.ToString("Mobile");
			ret.Email = reader.ToString("Email");
			ret.Note = reader.ToString("Note");
			ret.SettlDayNum = reader.ToInt32("SettlDayNum");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
			ret.AdminUser = reader.ToString("AdminUser");
			ret.AdminPwd = reader.ToString("AdminPwd");
			ret.ProvAdminUrl = reader.ToString("ProvAdminUrl");
			ret.ProvAdminUser = reader.ToString("ProvAdminUser");
			ret.ProvAdminPwd = reader.ToString("ProvAdminPwd");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 应用提供商
	/// 【表 s_provider 的操作类】
	/// </summary>
	[Obsolete]
	public class S_providerMO : MySqlTableMO<S_providerEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_provider`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_providerMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_providerMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_providerMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_providerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_providerEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_providerEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ProviderID`, `ProviderName`, `ProviderType`, `UseBonus`, `ApiUrl`, `ApiUrlStaging`, `ApiUrlDebug`, `ProvPublicKey`, `ProvPrivateKey`, `OwnPublicKey`, `OwnPrivateKey`, `ProviderConfig`, `Mobile`, `Email`, `Note`, `SettlDayNum`, `Status`, `RecDate`, `AdminUser`, `AdminPwd`, `ProvAdminUrl`, `ProvAdminUser`, `ProvAdminPwd`) VALUE (@ProviderID, @ProviderName, @ProviderType, @UseBonus, @ApiUrl, @ApiUrlStaging, @ApiUrlDebug, @ProvPublicKey, @ProvPrivateKey, @OwnPublicKey, @OwnPrivateKey, @ProviderConfig, @Mobile, @Email, @Note, @SettlDayNum, @Status, @RecDate, @AdminUser, @AdminPwd, @ProvAdminUrl, @ProvAdminUser, @ProvAdminPwd);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", item.ProviderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderName", item.ProviderName != null ? item.ProviderName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderType", item.ProviderType, MySqlDbType.Int32),
				Database.CreateInParameter("@UseBonus", item.UseBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ApiUrl", item.ApiUrl != null ? item.ApiUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ApiUrlStaging", item.ApiUrlStaging != null ? item.ApiUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ApiUrlDebug", item.ApiUrlDebug != null ? item.ApiUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvPublicKey", item.ProvPublicKey != null ? item.ProvPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProvPrivateKey", item.ProvPrivateKey != null ? item.ProvPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPublicKey", item.OwnPublicKey != null ? item.OwnPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPrivateKey", item.OwnPrivateKey != null ? item.OwnPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderConfig", item.ProviderConfig != null ? item.ProviderConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SettlDayNum", item.SettlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@AdminUser", item.AdminUser != null ? item.AdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AdminPwd", item.AdminPwd != null ? item.AdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminUrl", item.ProvAdminUrl != null ? item.ProvAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminUser", item.ProvAdminUser != null ? item.ProvAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminPwd", item.ProvAdminPwd != null ? item.ProvAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<S_providerEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_providerEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_providerEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ProviderID`, `ProviderName`, `ProviderType`, `UseBonus`, `ApiUrl`, `ApiUrlStaging`, `ApiUrlDebug`, `ProvPublicKey`, `ProvPrivateKey`, `OwnPublicKey`, `OwnPrivateKey`, `ProviderConfig`, `Mobile`, `Email`, `Note`, `SettlDayNum`, `Status`, `RecDate`, `AdminUser`, `AdminPwd`, `ProvAdminUrl`, `ProvAdminUser`, `ProvAdminPwd`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.ProviderID}','{item.ProviderName}',{item.ProviderType},{item.UseBonus},'{item.ApiUrl}','{item.ApiUrlStaging}','{item.ApiUrlDebug}','{item.ProvPublicKey}','{item.ProvPrivateKey}','{item.OwnPublicKey}','{item.OwnPrivateKey}','{item.ProviderConfig}','{item.Mobile}','{item.Email}','{item.Note}',{item.SettlDayNum},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}','{item.AdminUser}','{item.AdminPwd}','{item.ProvAdminUrl}','{item.ProvAdminUser}','{item.ProvAdminPwd}'),");
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string providerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(providerID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string providerID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_providerEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ProviderID, tm_);
		}
		public async Task<int> RemoveAsync(S_providerEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ProviderID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByProviderName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderName(string providerName, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderNameData(providerName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderNameAsync(string providerName, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderNameData(providerName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderNameData(string providerName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerName != null ? "`ProviderName` = @ProviderName" : "`ProviderName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerName != null)
				paras_.Add(Database.CreateInParameter("@ProviderName", providerName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProviderName
		#region RemoveByProviderType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderType(int providerType, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderTypeData(providerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderTypeAsync(int providerType, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderTypeData(providerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderTypeData(int providerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ProviderType` = @ProviderType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32));
		}
		#endregion // RemoveByProviderType
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
		#region RemoveByApiUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByApiUrl(string apiUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlData(apiUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByApiUrlAsync(string apiUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlData(apiUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByApiUrlData(string apiUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (apiUrl != null ? "`ApiUrl` = @ApiUrl" : "`ApiUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (apiUrl != null)
				paras_.Add(Database.CreateInParameter("@ApiUrl", apiUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByApiUrl
		#region RemoveByApiUrlStaging
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByApiUrlStaging(string apiUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlStagingData(apiUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByApiUrlStagingAsync(string apiUrlStaging, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlStagingData(apiUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByApiUrlStagingData(string apiUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (apiUrlStaging != null ? "`ApiUrlStaging` = @ApiUrlStaging" : "`ApiUrlStaging` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (apiUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging, MySqlDbType.VarChar));
		}
		#endregion // RemoveByApiUrlStaging
		#region RemoveByApiUrlDebug
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByApiUrlDebug(string apiUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlDebugData(apiUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByApiUrlDebugAsync(string apiUrlDebug, TransactionManager tm_ = null)
		{
			RepairRemoveByApiUrlDebugData(apiUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByApiUrlDebugData(string apiUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (apiUrlDebug != null ? "`ApiUrlDebug` = @ApiUrlDebug" : "`ApiUrlDebug` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (apiUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug, MySqlDbType.VarChar));
		}
		#endregion // RemoveByApiUrlDebug
		#region RemoveByProvPublicKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProvPublicKey(string provPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByProvPublicKeyData(provPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProvPublicKeyAsync(string provPublicKey, TransactionManager tm_ = null)
		{
			RepairRemoveByProvPublicKeyData(provPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProvPublicKeyData(string provPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (provPublicKey != null ? "`ProvPublicKey` = @ProvPublicKey" : "`ProvPublicKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (provPublicKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPublicKey", provPublicKey, MySqlDbType.Text));
		}
		#endregion // RemoveByProvPublicKey
		#region RemoveByProvPrivateKey
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProvPrivateKey(string provPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByProvPrivateKeyData(provPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProvPrivateKeyAsync(string provPrivateKey, TransactionManager tm_ = null)
		{
			RepairRemoveByProvPrivateKeyData(provPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProvPrivateKeyData(string provPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (provPrivateKey != null ? "`ProvPrivateKey` = @ProvPrivateKey" : "`ProvPrivateKey` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (provPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPrivateKey", provPrivateKey, MySqlDbType.Text));
		}
		#endregion // RemoveByProvPrivateKey
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
		#region RemoveByProviderConfig
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProviderConfig(string providerConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderConfigData(providerConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProviderConfigAsync(string providerConfig, TransactionManager tm_ = null)
		{
			RepairRemoveByProviderConfigData(providerConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProviderConfigData(string providerConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (providerConfig != null ? "`ProviderConfig` = @ProviderConfig" : "`ProviderConfig` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (providerConfig != null)
				paras_.Add(Database.CreateInParameter("@ProviderConfig", providerConfig, MySqlDbType.Text));
		}
		#endregion // RemoveByProviderConfig
		#region RemoveByMobile
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMobile(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			RepairRemoveByMobileData(mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMobileData(string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMobile
		#region RemoveByEmail
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEmail(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEmailAsync(string email, TransactionManager tm_ = null)
		{
			RepairRemoveByEmailData(email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEmailData(string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (email != null ? "`Email` = @Email" : "`Email` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
		}
		#endregion // RemoveByEmail
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
		#region RemoveByAdminUser
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAdminUser(string adminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByAdminUserData(adminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAdminUserAsync(string adminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByAdminUserData(adminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAdminUserData(string adminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (adminUser != null ? "`AdminUser` = @AdminUser" : "`AdminUser` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (adminUser != null)
				paras_.Add(Database.CreateInParameter("@AdminUser", adminUser, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAdminUser
		#region RemoveByAdminPwd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAdminPwd(string adminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByAdminPwdData(adminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAdminPwdAsync(string adminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByAdminPwdData(adminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAdminPwdData(string adminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (adminPwd != null ? "`AdminPwd` = @AdminPwd" : "`AdminPwd` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (adminPwd != null)
				paras_.Add(Database.CreateInParameter("@AdminPwd", adminPwd, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAdminPwd
		#region RemoveByProvAdminUrl
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProvAdminUrl(string provAdminUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminUrlData(provAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProvAdminUrlAsync(string provAdminUrl, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminUrlData(provAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProvAdminUrlData(string provAdminUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (provAdminUrl != null ? "`ProvAdminUrl` = @ProvAdminUrl" : "`ProvAdminUrl` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (provAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUrl", provAdminUrl, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProvAdminUrl
		#region RemoveByProvAdminUser
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProvAdminUser(string provAdminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminUserData(provAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProvAdminUserAsync(string provAdminUser, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminUserData(provAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProvAdminUserData(string provAdminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (provAdminUser != null ? "`ProvAdminUser` = @ProvAdminUser" : "`ProvAdminUser` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (provAdminUser != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUser", provAdminUser, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProvAdminUser
		#region RemoveByProvAdminPwd
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByProvAdminPwd(string provAdminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminPwdData(provAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByProvAdminPwdAsync(string provAdminPwd, TransactionManager tm_ = null)
		{
			RepairRemoveByProvAdminPwdData(provAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByProvAdminPwdData(string provAdminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (provAdminPwd != null ? "`ProvAdminPwd` = @ProvAdminPwd" : "`ProvAdminPwd` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (provAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminPwd", provAdminPwd, MySqlDbType.VarChar));
		}
		#endregion // RemoveByProvAdminPwd
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
		public int Put(S_providerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_providerEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_providerEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderID` = @ProviderID, `ProviderName` = @ProviderName, `ProviderType` = @ProviderType, `UseBonus` = @UseBonus, `ApiUrl` = @ApiUrl, `ApiUrlStaging` = @ApiUrlStaging, `ApiUrlDebug` = @ApiUrlDebug, `ProvPublicKey` = @ProvPublicKey, `ProvPrivateKey` = @ProvPrivateKey, `OwnPublicKey` = @OwnPublicKey, `OwnPrivateKey` = @OwnPrivateKey, `ProviderConfig` = @ProviderConfig, `Mobile` = @Mobile, `Email` = @Email, `Note` = @Note, `SettlDayNum` = @SettlDayNum, `Status` = @Status, `AdminUser` = @AdminUser, `AdminPwd` = @AdminPwd, `ProvAdminUrl` = @ProvAdminUrl, `ProvAdminUser` = @ProvAdminUser, `ProvAdminPwd` = @ProvAdminPwd WHERE `ProviderID` = @ProviderID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", item.ProviderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderName", item.ProviderName != null ? item.ProviderName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderType", item.ProviderType, MySqlDbType.Int32),
				Database.CreateInParameter("@UseBonus", item.UseBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ApiUrl", item.ApiUrl != null ? item.ApiUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ApiUrlStaging", item.ApiUrlStaging != null ? item.ApiUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ApiUrlDebug", item.ApiUrlDebug != null ? item.ApiUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvPublicKey", item.ProvPublicKey != null ? item.ProvPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProvPrivateKey", item.ProvPrivateKey != null ? item.ProvPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPublicKey", item.OwnPublicKey != null ? item.OwnPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@OwnPrivateKey", item.OwnPrivateKey != null ? item.OwnPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderConfig", item.ProviderConfig != null ? item.ProviderConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@Mobile", item.Mobile != null ? item.Mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Email", item.Email != null ? item.Email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@SettlDayNum", item.SettlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@AdminUser", item.AdminUser != null ? item.AdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@AdminPwd", item.AdminPwd != null ? item.AdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminUrl", item.ProvAdminUrl != null ? item.ProvAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminUser", item.ProvAdminUser != null ? item.ProvAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProvAdminPwd", item.ProvAdminPwd != null ? item.ProvAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID_Original", item.HasOriginal ? item.OriginalProviderID : item.ProviderID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_providerEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_providerEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string providerID, string set_, params object[] values_)
		{
			return Put(set_, "`ProviderID` = @ProviderID", ConcatValues(values_, providerID));
		}
		public async Task<int> PutByPKAsync(string providerID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ProviderID` = @ProviderID", ConcatValues(values_, providerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string providerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ProviderID` = @ProviderID", tm_, ConcatValues(values_, providerID));
		}
		public async Task<int> PutByPKAsync(string providerID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ProviderID` = @ProviderID", tm_, ConcatValues(values_, providerID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string providerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`ProviderID` = @ProviderID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string providerID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`ProviderID` = @ProviderID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutProviderName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderNameByPK(string providerID, string providerName, TransactionManager tm_ = null)
		{
			RepairPutProviderNameByPKData(providerID, providerName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderNameByPKAsync(string providerID, string providerName, TransactionManager tm_ = null)
		{
			RepairPutProviderNameByPKData(providerID, providerName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderNameByPKData(string providerID, string providerName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderName` = @ProviderName  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderName", providerName != null ? providerName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderName(string providerName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderName` = @ProviderName";
			var parameter_ = Database.CreateInParameter("@ProviderName", providerName != null ? providerName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderNameAsync(string providerName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderName` = @ProviderName";
			var parameter_ = Database.CreateInParameter("@ProviderName", providerName != null ? providerName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderName
		#region PutProviderType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderTypeByPK(string providerID, int providerType, TransactionManager tm_ = null)
		{
			RepairPutProviderTypeByPKData(providerID, providerType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderTypeByPKAsync(string providerID, int providerType, TransactionManager tm_ = null)
		{
			RepairPutProviderTypeByPKData(providerID, providerType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderTypeByPKData(string providerID, int providerType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderType` = @ProviderType  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderType(int providerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderType` = @ProviderType";
			var parameter_ = Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderTypeAsync(int providerType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderType` = @ProviderType";
			var parameter_ = Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderType
		#region PutUseBonus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUseBonusByPK(string providerID, bool useBonus, TransactionManager tm_ = null)
		{
			RepairPutUseBonusByPKData(providerID, useBonus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUseBonusByPKAsync(string providerID, bool useBonus, TransactionManager tm_ = null)
		{
			RepairPutUseBonusByPKData(providerID, useBonus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUseBonusByPKData(string providerID, bool useBonus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UseBonus` = @UseBonus  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		#region PutApiUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrlByPK(string providerID, string apiUrl, TransactionManager tm_ = null)
		{
			RepairPutApiUrlByPKData(providerID, apiUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutApiUrlByPKAsync(string providerID, string apiUrl, TransactionManager tm_ = null)
		{
			RepairPutApiUrlByPKData(providerID, apiUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutApiUrlByPKData(string providerID, string apiUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ApiUrl` = @ApiUrl  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ApiUrl", apiUrl != null ? apiUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrl(string apiUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrl` = @ApiUrl";
			var parameter_ = Database.CreateInParameter("@ApiUrl", apiUrl != null ? apiUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutApiUrlAsync(string apiUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrl` = @ApiUrl";
			var parameter_ = Database.CreateInParameter("@ApiUrl", apiUrl != null ? apiUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutApiUrl
		#region PutApiUrlStaging
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrlStagingByPK(string providerID, string apiUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutApiUrlStagingByPKData(providerID, apiUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutApiUrlStagingByPKAsync(string providerID, string apiUrlStaging, TransactionManager tm_ = null)
		{
			RepairPutApiUrlStagingByPKData(providerID, apiUrlStaging, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutApiUrlStagingByPKData(string providerID, string apiUrlStaging, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ApiUrlStaging` = @ApiUrlStaging  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging != null ? apiUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrlStaging(string apiUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrlStaging` = @ApiUrlStaging";
			var parameter_ = Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging != null ? apiUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutApiUrlStagingAsync(string apiUrlStaging, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrlStaging` = @ApiUrlStaging";
			var parameter_ = Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging != null ? apiUrlStaging : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutApiUrlStaging
		#region PutApiUrlDebug
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrlDebugByPK(string providerID, string apiUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutApiUrlDebugByPKData(providerID, apiUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutApiUrlDebugByPKAsync(string providerID, string apiUrlDebug, TransactionManager tm_ = null)
		{
			RepairPutApiUrlDebugByPKData(providerID, apiUrlDebug, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutApiUrlDebugByPKData(string providerID, string apiUrlDebug, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ApiUrlDebug` = @ApiUrlDebug  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug != null ? apiUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutApiUrlDebug(string apiUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrlDebug` = @ApiUrlDebug";
			var parameter_ = Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug != null ? apiUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutApiUrlDebugAsync(string apiUrlDebug, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ApiUrlDebug` = @ApiUrlDebug";
			var parameter_ = Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug != null ? apiUrlDebug : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutApiUrlDebug
		#region PutProvPublicKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvPublicKeyByPK(string providerID, string provPublicKey, TransactionManager tm_ = null)
		{
			RepairPutProvPublicKeyByPKData(providerID, provPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProvPublicKeyByPKAsync(string providerID, string provPublicKey, TransactionManager tm_ = null)
		{
			RepairPutProvPublicKeyByPKData(providerID, provPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProvPublicKeyByPKData(string providerID, string provPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProvPublicKey` = @ProvPublicKey  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProvPublicKey", provPublicKey != null ? provPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvPublicKey(string provPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvPublicKey` = @ProvPublicKey";
			var parameter_ = Database.CreateInParameter("@ProvPublicKey", provPublicKey != null ? provPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProvPublicKeyAsync(string provPublicKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvPublicKey` = @ProvPublicKey";
			var parameter_ = Database.CreateInParameter("@ProvPublicKey", provPublicKey != null ? provPublicKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProvPublicKey
		#region PutProvPrivateKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvPrivateKeyByPK(string providerID, string provPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutProvPrivateKeyByPKData(providerID, provPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProvPrivateKeyByPKAsync(string providerID, string provPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutProvPrivateKeyByPKData(providerID, provPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProvPrivateKeyByPKData(string providerID, string provPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProvPrivateKey` = @ProvPrivateKey  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProvPrivateKey", provPrivateKey != null ? provPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvPrivateKey(string provPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvPrivateKey` = @ProvPrivateKey";
			var parameter_ = Database.CreateInParameter("@ProvPrivateKey", provPrivateKey != null ? provPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProvPrivateKeyAsync(string provPrivateKey, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvPrivateKey` = @ProvPrivateKey";
			var parameter_ = Database.CreateInParameter("@ProvPrivateKey", provPrivateKey != null ? provPrivateKey : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProvPrivateKey
		#region PutOwnPublicKey
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPublicKeyByPK(string providerID, string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPublicKeyByPKData(providerID, ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOwnPublicKeyByPKAsync(string providerID, string ownPublicKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPublicKeyByPKData(providerID, ownPublicKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOwnPublicKeyByPKData(string providerID, string ownPublicKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OwnPublicKey` = @OwnPublicKey  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OwnPublicKey", ownPublicKey != null ? ownPublicKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOwnPrivateKeyByPK(string providerID, string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPrivateKeyByPKData(providerID, ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOwnPrivateKeyByPKAsync(string providerID, string ownPrivateKey, TransactionManager tm_ = null)
		{
			RepairPutOwnPrivateKeyByPKData(providerID, ownPrivateKey, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOwnPrivateKeyByPKData(string providerID, string ownPrivateKey, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OwnPrivateKey` = @OwnPrivateKey  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey != null ? ownPrivateKey : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		#region PutProviderConfig
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderConfigByPK(string providerID, string providerConfig, TransactionManager tm_ = null)
		{
			RepairPutProviderConfigByPKData(providerID, providerConfig, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProviderConfigByPKAsync(string providerID, string providerConfig, TransactionManager tm_ = null)
		{
			RepairPutProviderConfigByPKData(providerID, providerConfig, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProviderConfigByPKData(string providerID, string providerConfig, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProviderConfig` = @ProviderConfig  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderConfig", providerConfig != null ? providerConfig : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProviderConfig(string providerConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderConfig` = @ProviderConfig";
			var parameter_ = Database.CreateInParameter("@ProviderConfig", providerConfig != null ? providerConfig : (object)DBNull.Value, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProviderConfigAsync(string providerConfig, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProviderConfig` = @ProviderConfig";
			var parameter_ = Database.CreateInParameter("@ProviderConfig", providerConfig != null ? providerConfig : (object)DBNull.Value, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProviderConfig
		#region PutMobile
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobileByPK(string providerID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(providerID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMobileByPKAsync(string providerID, string mobile, TransactionManager tm_ = null)
		{
			RepairPutMobileByPKData(providerID, mobile, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMobileByPKData(string providerID, string mobile, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMobile(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMobileAsync(string mobile, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mobile` = @Mobile";
			var parameter_ = Database.CreateInParameter("@Mobile", mobile != null ? mobile : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMobile
		#region PutEmail
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmailByPK(string providerID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(providerID, email, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEmailByPKAsync(string providerID, string email, TransactionManager tm_ = null)
		{
			RepairPutEmailByPKData(providerID, email, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEmailByPKData(string providerID, string email, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Email` = @Email  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEmail(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEmailAsync(string email, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Email` = @Email";
			var parameter_ = Database.CreateInParameter("@Email", email != null ? email : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEmail
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string providerID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(providerID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string providerID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(providerID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string providerID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSettlDayNumByPK(string providerID, int settlDayNum, TransactionManager tm_ = null)
		{
			RepairPutSettlDayNumByPKData(providerID, settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSettlDayNumByPKAsync(string providerID, int settlDayNum, TransactionManager tm_ = null)
		{
			RepairPutSettlDayNumByPKData(providerID, settlDayNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSettlDayNumByPKData(string providerID, int settlDayNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `SettlDayNum` = @SettlDayNum  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string providerID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(providerID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string providerID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(providerID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string providerID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string providerID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(providerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string providerID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(providerID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string providerID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
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
		#region PutAdminUser
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAdminUserByPK(string providerID, string adminUser, TransactionManager tm_ = null)
		{
			RepairPutAdminUserByPKData(providerID, adminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAdminUserByPKAsync(string providerID, string adminUser, TransactionManager tm_ = null)
		{
			RepairPutAdminUserByPKData(providerID, adminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAdminUserByPKData(string providerID, string adminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AdminUser` = @AdminUser  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdminUser", adminUser != null ? adminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAdminUser(string adminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AdminUser` = @AdminUser";
			var parameter_ = Database.CreateInParameter("@AdminUser", adminUser != null ? adminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAdminUserAsync(string adminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AdminUser` = @AdminUser";
			var parameter_ = Database.CreateInParameter("@AdminUser", adminUser != null ? adminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAdminUser
		#region PutAdminPwd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAdminPwdByPK(string providerID, string adminPwd, TransactionManager tm_ = null)
		{
			RepairPutAdminPwdByPKData(providerID, adminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAdminPwdByPKAsync(string providerID, string adminPwd, TransactionManager tm_ = null)
		{
			RepairPutAdminPwdByPKData(providerID, adminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAdminPwdByPKData(string providerID, string adminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AdminPwd` = @AdminPwd  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AdminPwd", adminPwd != null ? adminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAdminPwd(string adminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AdminPwd` = @AdminPwd";
			var parameter_ = Database.CreateInParameter("@AdminPwd", adminPwd != null ? adminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAdminPwdAsync(string adminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AdminPwd` = @AdminPwd";
			var parameter_ = Database.CreateInParameter("@AdminPwd", adminPwd != null ? adminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAdminPwd
		#region PutProvAdminUrl
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminUrlByPK(string providerID, string provAdminUrl, TransactionManager tm_ = null)
		{
			RepairPutProvAdminUrlByPKData(providerID, provAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProvAdminUrlByPKAsync(string providerID, string provAdminUrl, TransactionManager tm_ = null)
		{
			RepairPutProvAdminUrlByPKData(providerID, provAdminUrl, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProvAdminUrlByPKData(string providerID, string provAdminUrl, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProvAdminUrl` = @ProvAdminUrl  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProvAdminUrl", provAdminUrl != null ? provAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminUrl(string provAdminUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminUrl` = @ProvAdminUrl";
			var parameter_ = Database.CreateInParameter("@ProvAdminUrl", provAdminUrl != null ? provAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProvAdminUrlAsync(string provAdminUrl, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminUrl` = @ProvAdminUrl";
			var parameter_ = Database.CreateInParameter("@ProvAdminUrl", provAdminUrl != null ? provAdminUrl : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProvAdminUrl
		#region PutProvAdminUser
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminUserByPK(string providerID, string provAdminUser, TransactionManager tm_ = null)
		{
			RepairPutProvAdminUserByPKData(providerID, provAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProvAdminUserByPKAsync(string providerID, string provAdminUser, TransactionManager tm_ = null)
		{
			RepairPutProvAdminUserByPKData(providerID, provAdminUser, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProvAdminUserByPKData(string providerID, string provAdminUser, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProvAdminUser` = @ProvAdminUser  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProvAdminUser", provAdminUser != null ? provAdminUser : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminUser(string provAdminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminUser` = @ProvAdminUser";
			var parameter_ = Database.CreateInParameter("@ProvAdminUser", provAdminUser != null ? provAdminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProvAdminUserAsync(string provAdminUser, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminUser` = @ProvAdminUser";
			var parameter_ = Database.CreateInParameter("@ProvAdminUser", provAdminUser != null ? provAdminUser : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProvAdminUser
		#region PutProvAdminPwd
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminPwdByPK(string providerID, string provAdminPwd, TransactionManager tm_ = null)
		{
			RepairPutProvAdminPwdByPKData(providerID, provAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutProvAdminPwdByPKAsync(string providerID, string provAdminPwd, TransactionManager tm_ = null)
		{
			RepairPutProvAdminPwdByPKData(providerID, provAdminPwd, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutProvAdminPwdByPKData(string providerID, string provAdminPwd, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ProvAdminPwd` = @ProvAdminPwd  WHERE `ProviderID` = @ProviderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProvAdminPwd", provAdminPwd != null ? provAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutProvAdminPwd(string provAdminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminPwd` = @ProvAdminPwd";
			var parameter_ = Database.CreateInParameter("@ProvAdminPwd", provAdminPwd != null ? provAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutProvAdminPwdAsync(string provAdminPwd, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ProvAdminPwd` = @ProvAdminPwd";
			var parameter_ = Database.CreateInParameter("@ProvAdminPwd", provAdminPwd != null ? provAdminPwd : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutProvAdminPwd
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_providerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ProviderID) == null)
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
		public async Task<bool> SetAsync(S_providerEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ProviderID) == null)
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
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_providerEO GetByPK(string providerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(providerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<S_providerEO> GetByPKAsync(string providerID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(providerID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		private void RepairGetByPKData(string providerID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ProviderID` = @ProviderID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ProviderName（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderNameByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderName`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProviderNameByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderName`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderType（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetProviderTypeByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`ProviderType`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<int> GetProviderTypeByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`ProviderType`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UseBonus（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetUseBonusByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`UseBonus`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<bool> GetUseBonusByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`UseBonus`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ApiUrl（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetApiUrlByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ApiUrl`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetApiUrlByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ApiUrl`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ApiUrlStaging（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetApiUrlStagingByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ApiUrlStaging`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetApiUrlStagingByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ApiUrlStaging`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ApiUrlDebug（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetApiUrlDebugByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ApiUrlDebug`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetApiUrlDebugByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ApiUrlDebug`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProvPublicKey（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProvPublicKeyByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProvPublicKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProvPublicKeyByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProvPublicKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProvPrivateKey（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProvPrivateKeyByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProvPrivateKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProvPrivateKeyByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProvPrivateKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OwnPublicKey（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOwnPublicKeyByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OwnPublicKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetOwnPublicKeyByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OwnPublicKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OwnPrivateKey（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOwnPrivateKeyByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OwnPrivateKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetOwnPrivateKeyByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OwnPrivateKey`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProviderConfig（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProviderConfigByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProviderConfig`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProviderConfigByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProviderConfig`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Mobile（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMobileByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Mobile`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetMobileByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Mobile`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Email（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEmailByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Email`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetEmailByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Email`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 SettlDayNum（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSettlDayNumByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`SettlDayNum`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<int> GetSettlDayNumByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`SettlDayNum`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AdminUser（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAdminUserByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AdminUser`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetAdminUserByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AdminUser`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AdminPwd（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAdminPwdByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`AdminPwd`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetAdminPwdByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`AdminPwd`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProvAdminUrl（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProvAdminUrlByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProvAdminUrl`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProvAdminUrlByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProvAdminUrl`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProvAdminUser（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProvAdminUserByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProvAdminUser`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProvAdminUserByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProvAdminUser`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ProvAdminPwd（字段）
		/// </summary>
		/// /// <param name = "providerID">应用提供商编码（小写，唯一）自有own</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetProvAdminPwdByPK(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`ProvAdminPwd`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		public async Task<string> GetProvAdminPwdByPKAsync(string providerID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ProviderID", providerID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`ProvAdminPwd`", "`ProviderID` = @ProviderID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByProviderName
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName)
		{
			return GetByProviderName(providerName, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName)
		{
			return await GetByProviderNameAsync(providerName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, TransactionManager tm_)
		{
			return GetByProviderName(providerName, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, TransactionManager tm_)
		{
			return await GetByProviderNameAsync(providerName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, int top_)
		{
			return GetByProviderName(providerName, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, int top_)
		{
			return await GetByProviderNameAsync(providerName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, int top_, TransactionManager tm_)
		{
			return GetByProviderName(providerName, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, int top_, TransactionManager tm_)
		{
			return await GetByProviderNameAsync(providerName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, string sort_)
		{
			return GetByProviderName(providerName, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, string sort_)
		{
			return await GetByProviderNameAsync(providerName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, string sort_, TransactionManager tm_)
		{
			return GetByProviderName(providerName, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, string sort_, TransactionManager tm_)
		{
			return await GetByProviderNameAsync(providerName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderName（字段） 查询
		/// </summary>
		/// /// <param name = "providerName">应用提供商名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderName(string providerName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerName != null ? "`ProviderName` = @ProviderName" : "`ProviderName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerName != null)
				paras_.Add(Database.CreateInParameter("@ProviderName", providerName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProviderNameAsync(string providerName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerName != null ? "`ProviderName` = @ProviderName" : "`ProviderName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerName != null)
				paras_.Add(Database.CreateInParameter("@ProviderName", providerName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProviderName
		#region GetByProviderType
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType)
		{
			return GetByProviderType(providerType, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType)
		{
			return await GetByProviderTypeAsync(providerType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, TransactionManager tm_)
		{
			return GetByProviderType(providerType, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, TransactionManager tm_)
		{
			return await GetByProviderTypeAsync(providerType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, int top_)
		{
			return GetByProviderType(providerType, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, int top_)
		{
			return await GetByProviderTypeAsync(providerType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, int top_, TransactionManager tm_)
		{
			return GetByProviderType(providerType, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, int top_, TransactionManager tm_)
		{
			return await GetByProviderTypeAsync(providerType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, string sort_)
		{
			return GetByProviderType(providerType, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, string sort_)
		{
			return await GetByProviderTypeAsync(providerType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, string sort_, TransactionManager tm_)
		{
			return GetByProviderType(providerType, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, string sort_, TransactionManager tm_)
		{
			return await GetByProviderTypeAsync(providerType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderType（字段） 查询
		/// </summary>
		/// /// <param name = "providerType">应用提供商类型（0-自有 1-第三方）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderType(int providerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProviderType` = @ProviderType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProviderTypeAsync(int providerType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ProviderType` = @ProviderType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ProviderType", providerType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProviderType
		#region GetByUseBonus
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByUseBonus(bool useBonus)
		{
			return GetByUseBonus(useBonus, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus)
		{
			return await GetByUseBonusAsync(useBonus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByUseBonus(bool useBonus, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, TransactionManager tm_)
		{
			return await GetByUseBonusAsync(useBonus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByUseBonus(bool useBonus, int top_)
		{
			return GetByUseBonus(useBonus, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, int top_)
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
		public List<S_providerEO> GetByUseBonus(bool useBonus, int top_, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, int top_, TransactionManager tm_)
		{
			return await GetByUseBonusAsync(useBonus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UseBonus（字段） 查询
		/// </summary>
		/// /// <param name = "useBonus">是否使用bonus</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByUseBonus(bool useBonus, string sort_)
		{
			return GetByUseBonus(useBonus, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, string sort_)
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
		public List<S_providerEO> GetByUseBonus(bool useBonus, string sort_, TransactionManager tm_)
		{
			return GetByUseBonus(useBonus, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByUseBonus(bool useBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UseBonus` = @UseBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByUseBonusAsync(bool useBonus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UseBonus` = @UseBonus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UseBonus", useBonus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByUseBonus
		#region GetByApiUrl
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl)
		{
			return GetByApiUrl(apiUrl, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl)
		{
			return await GetByApiUrlAsync(apiUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, TransactionManager tm_)
		{
			return GetByApiUrl(apiUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, TransactionManager tm_)
		{
			return await GetByApiUrlAsync(apiUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, int top_)
		{
			return GetByApiUrl(apiUrl, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, int top_)
		{
			return await GetByApiUrlAsync(apiUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, int top_, TransactionManager tm_)
		{
			return GetByApiUrl(apiUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, int top_, TransactionManager tm_)
		{
			return await GetByApiUrlAsync(apiUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, string sort_)
		{
			return GetByApiUrl(apiUrl, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, string sort_)
		{
			return await GetByApiUrlAsync(apiUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, string sort_, TransactionManager tm_)
		{
			return GetByApiUrl(apiUrl, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, string sort_, TransactionManager tm_)
		{
			return await GetByApiUrlAsync(apiUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrl（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrl">获取应用客户端URL的API路径（应用提供商提供）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrl(string apiUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrl != null ? "`ApiUrl` = @ApiUrl" : "`ApiUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrl != null)
				paras_.Add(Database.CreateInParameter("@ApiUrl", apiUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByApiUrlAsync(string apiUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrl != null ? "`ApiUrl` = @ApiUrl" : "`ApiUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrl != null)
				paras_.Add(Database.CreateInParameter("@ApiUrl", apiUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByApiUrl
		#region GetByApiUrlStaging
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging)
		{
			return GetByApiUrlStaging(apiUrlStaging, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, TransactionManager tm_)
		{
			return GetByApiUrlStaging(apiUrlStaging, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, TransactionManager tm_)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, int top_)
		{
			return GetByApiUrlStaging(apiUrlStaging, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, int top_)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, int top_, TransactionManager tm_)
		{
			return GetByApiUrlStaging(apiUrlStaging, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, int top_, TransactionManager tm_)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, string sort_)
		{
			return GetByApiUrlStaging(apiUrlStaging, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, string sort_)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, string sort_, TransactionManager tm_)
		{
			return GetByApiUrlStaging(apiUrlStaging, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, string sort_, TransactionManager tm_)
		{
			return await GetByApiUrlStagingAsync(apiUrlStaging, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlStaging（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlStaging">获取应用客户端URL的API路径（仿真）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlStaging(string apiUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrlStaging != null ? "`ApiUrlStaging` = @ApiUrlStaging" : "`ApiUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByApiUrlStagingAsync(string apiUrlStaging, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrlStaging != null ? "`ApiUrlStaging` = @ApiUrlStaging" : "`ApiUrlStaging` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrlStaging != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlStaging", apiUrlStaging, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByApiUrlStaging
		#region GetByApiUrlDebug
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug)
		{
			return GetByApiUrlDebug(apiUrlDebug, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, TransactionManager tm_)
		{
			return GetByApiUrlDebug(apiUrlDebug, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, TransactionManager tm_)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, int top_)
		{
			return GetByApiUrlDebug(apiUrlDebug, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, int top_)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, int top_, TransactionManager tm_)
		{
			return GetByApiUrlDebug(apiUrlDebug, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, int top_, TransactionManager tm_)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, string sort_)
		{
			return GetByApiUrlDebug(apiUrlDebug, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, string sort_)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, string sort_, TransactionManager tm_)
		{
			return GetByApiUrlDebug(apiUrlDebug, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, string sort_, TransactionManager tm_)
		{
			return await GetByApiUrlDebugAsync(apiUrlDebug, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ApiUrlDebug（字段） 查询
		/// </summary>
		/// /// <param name = "apiUrlDebug">获取应用客户端URL的API路径（联调）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByApiUrlDebug(string apiUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrlDebug != null ? "`ApiUrlDebug` = @ApiUrlDebug" : "`ApiUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByApiUrlDebugAsync(string apiUrlDebug, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(apiUrlDebug != null ? "`ApiUrlDebug` = @ApiUrlDebug" : "`ApiUrlDebug` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (apiUrlDebug != null)
				paras_.Add(Database.CreateInParameter("@ApiUrlDebug", apiUrlDebug, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByApiUrlDebug
		#region GetByProvPublicKey
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey)
		{
			return GetByProvPublicKey(provPublicKey, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, TransactionManager tm_)
		{
			return GetByProvPublicKey(provPublicKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, TransactionManager tm_)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, int top_)
		{
			return GetByProvPublicKey(provPublicKey, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, int top_)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, int top_, TransactionManager tm_)
		{
			return GetByProvPublicKey(provPublicKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, int top_, TransactionManager tm_)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, string sort_)
		{
			return GetByProvPublicKey(provPublicKey, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, string sort_)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByProvPublicKey(provPublicKey, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, string sort_, TransactionManager tm_)
		{
			return await GetByProvPublicKeyAsync(provPublicKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProvPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPublicKey">应用提供商公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPublicKey(string provPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provPublicKey != null ? "`ProvPublicKey` = @ProvPublicKey" : "`ProvPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provPublicKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPublicKey", provPublicKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProvPublicKeyAsync(string provPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provPublicKey != null ? "`ProvPublicKey` = @ProvPublicKey" : "`ProvPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provPublicKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPublicKey", provPublicKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProvPublicKey
		#region GetByProvPrivateKey
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey)
		{
			return GetByProvPrivateKey(provPrivateKey, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, TransactionManager tm_)
		{
			return GetByProvPrivateKey(provPrivateKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, TransactionManager tm_)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, int top_)
		{
			return GetByProvPrivateKey(provPrivateKey, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, int top_)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByProvPrivateKey(provPrivateKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, int top_, TransactionManager tm_)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, string sort_)
		{
			return GetByProvPrivateKey(provPrivateKey, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, string sort_)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByProvPrivateKey(provPrivateKey, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, string sort_, TransactionManager tm_)
		{
			return await GetByProvPrivateKeyAsync(provPrivateKey, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProvPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "provPrivateKey">应用提供商私钥（仅测试）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvPrivateKey(string provPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provPrivateKey != null ? "`ProvPrivateKey` = @ProvPrivateKey" : "`ProvPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPrivateKey", provPrivateKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProvPrivateKeyAsync(string provPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provPrivateKey != null ? "`ProvPrivateKey` = @ProvPrivateKey" : "`ProvPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@ProvPrivateKey", provPrivateKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProvPrivateKey
		#region GetByOwnPublicKey
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, TransactionManager tm_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, int top_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_)
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
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_, TransactionManager tm_)
		{
			return await GetByOwnPublicKeyAsync(ownPublicKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPublicKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPublicKey">我方的公钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, string sort_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, string sort_)
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
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPublicKey(ownPublicKey, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByOwnPublicKey(string ownPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPublicKey != null ? "`OwnPublicKey` = @OwnPublicKey" : "`OwnPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPublicKey", ownPublicKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByOwnPublicKeyAsync(string ownPublicKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPublicKey != null ? "`OwnPublicKey` = @OwnPublicKey" : "`OwnPublicKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPublicKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPublicKey", ownPublicKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByOwnPublicKey
		#region GetByOwnPrivateKey
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, TransactionManager tm_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, int top_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_)
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
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_, TransactionManager tm_)
		{
			return await GetByOwnPrivateKeyAsync(ownPrivateKey, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OwnPrivateKey（字段） 查询
		/// </summary>
		/// /// <param name = "ownPrivateKey">我方的私钥</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, string sort_)
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
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, string sort_, TransactionManager tm_)
		{
			return GetByOwnPrivateKey(ownPrivateKey, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByOwnPrivateKey(string ownPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPrivateKey != null ? "`OwnPrivateKey` = @OwnPrivateKey" : "`OwnPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByOwnPrivateKeyAsync(string ownPrivateKey, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(ownPrivateKey != null ? "`OwnPrivateKey` = @OwnPrivateKey" : "`OwnPrivateKey` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (ownPrivateKey != null)
				paras_.Add(Database.CreateInParameter("@OwnPrivateKey", ownPrivateKey, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByOwnPrivateKey
		#region GetByProviderConfig
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig)
		{
			return GetByProviderConfig(providerConfig, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig)
		{
			return await GetByProviderConfigAsync(providerConfig, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, TransactionManager tm_)
		{
			return GetByProviderConfig(providerConfig, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, TransactionManager tm_)
		{
			return await GetByProviderConfigAsync(providerConfig, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, int top_)
		{
			return GetByProviderConfig(providerConfig, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, int top_)
		{
			return await GetByProviderConfigAsync(providerConfig, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, int top_, TransactionManager tm_)
		{
			return GetByProviderConfig(providerConfig, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, int top_, TransactionManager tm_)
		{
			return await GetByProviderConfigAsync(providerConfig, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, string sort_)
		{
			return GetByProviderConfig(providerConfig, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, string sort_)
		{
			return await GetByProviderConfigAsync(providerConfig, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, string sort_, TransactionManager tm_)
		{
			return GetByProviderConfig(providerConfig, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, string sort_, TransactionManager tm_)
		{
			return await GetByProviderConfigAsync(providerConfig, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProviderConfig（字段） 查询
		/// </summary>
		/// /// <param name = "providerConfig">应用提供商的配置信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProviderConfig(string providerConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerConfig != null ? "`ProviderConfig` = @ProviderConfig" : "`ProviderConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerConfig != null)
				paras_.Add(Database.CreateInParameter("@ProviderConfig", providerConfig, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProviderConfigAsync(string providerConfig, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(providerConfig != null ? "`ProviderConfig` = @ProviderConfig" : "`ProviderConfig` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (providerConfig != null)
				paras_.Add(Database.CreateInParameter("@ProviderConfig", providerConfig, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProviderConfig
		#region GetByMobile
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile)
		{
			return GetByMobile(mobile, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, int top_)
		{
			return GetByMobile(mobile, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, int top_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, int top_, TransactionManager tm_)
		{
			return GetByMobile(mobile, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, int top_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, string sort_)
		{
			return GetByMobile(mobile, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, string sort_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, string sort_, TransactionManager tm_)
		{
			return GetByMobile(mobile, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, string sort_, TransactionManager tm_)
		{
			return await GetByMobileAsync(mobile, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Mobile（字段） 查询
		/// </summary>
		/// /// <param name = "mobile">手机号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByMobile(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByMobileAsync(string mobile, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(mobile != null ? "`Mobile` = @Mobile" : "`Mobile` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (mobile != null)
				paras_.Add(Database.CreateInParameter("@Mobile", mobile, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByMobile
		#region GetByEmail
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email)
		{
			return GetByEmail(email, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email)
		{
			return await GetByEmailAsync(email, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, TransactionManager tm_)
		{
			return GetByEmail(email, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, int top_)
		{
			return GetByEmail(email, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, int top_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, int top_, TransactionManager tm_)
		{
			return GetByEmail(email, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, int top_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, string sort_)
		{
			return GetByEmail(email, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, string sort_)
		{
			return await GetByEmailAsync(email, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, string sort_, TransactionManager tm_)
		{
			return GetByEmail(email, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, string sort_, TransactionManager tm_)
		{
			return await GetByEmailAsync(email, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Email（字段） 查询
		/// </summary>
		/// /// <param name = "email">邮箱</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByEmail(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByEmailAsync(string email, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(email != null ? "`Email` = @Email" : "`Email` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (email != null)
				paras_.Add(Database.CreateInParameter("@Email", email, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByEmail
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, int top_)
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
		public List<S_providerEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, string sort_)
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
		public List<S_providerEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetBySettlDayNum
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, TransactionManager tm_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, int top_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, int top_)
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
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, int top_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, int top_, TransactionManager tm_)
		{
			return await GetBySettlDayNumAsync(settlDayNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 SettlDayNum（字段） 查询
		/// </summary>
		/// /// <param name = "settlDayNum">结算日，如5表示每月结算包含5号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, string sort_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, string sort_)
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
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, string sort_, TransactionManager tm_)
		{
			return GetBySettlDayNum(settlDayNum, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetBySettlDayNum(int settlDayNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlDayNum` = @SettlDayNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetBySettlDayNumAsync(int settlDayNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`SettlDayNum` = @SettlDayNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@SettlDayNum", settlDayNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetBySettlDayNum
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_providerEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态(0-无效1-有效)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_providerEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_providerEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_providerEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_providerEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#region GetByAdminUser
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser)
		{
			return GetByAdminUser(adminUser, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser)
		{
			return await GetByAdminUserAsync(adminUser, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, TransactionManager tm_)
		{
			return GetByAdminUser(adminUser, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, TransactionManager tm_)
		{
			return await GetByAdminUserAsync(adminUser, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, int top_)
		{
			return GetByAdminUser(adminUser, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, int top_)
		{
			return await GetByAdminUserAsync(adminUser, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, int top_, TransactionManager tm_)
		{
			return GetByAdminUser(adminUser, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, int top_, TransactionManager tm_)
		{
			return await GetByAdminUserAsync(adminUser, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, string sort_)
		{
			return GetByAdminUser(adminUser, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, string sort_)
		{
			return await GetByAdminUserAsync(adminUser, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, string sort_, TransactionManager tm_)
		{
			return GetByAdminUser(adminUser, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, string sort_, TransactionManager tm_)
		{
			return await GetByAdminUserAsync(adminUser, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "adminUser">我方提供的后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminUser(string adminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(adminUser != null ? "`AdminUser` = @AdminUser" : "`AdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (adminUser != null)
				paras_.Add(Database.CreateInParameter("@AdminUser", adminUser, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByAdminUserAsync(string adminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(adminUser != null ? "`AdminUser` = @AdminUser" : "`AdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (adminUser != null)
				paras_.Add(Database.CreateInParameter("@AdminUser", adminUser, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByAdminUser
		#region GetByAdminPwd
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd)
		{
			return GetByAdminPwd(adminPwd, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd)
		{
			return await GetByAdminPwdAsync(adminPwd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, TransactionManager tm_)
		{
			return GetByAdminPwd(adminPwd, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, TransactionManager tm_)
		{
			return await GetByAdminPwdAsync(adminPwd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, int top_)
		{
			return GetByAdminPwd(adminPwd, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, int top_)
		{
			return await GetByAdminPwdAsync(adminPwd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, int top_, TransactionManager tm_)
		{
			return GetByAdminPwd(adminPwd, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, int top_, TransactionManager tm_)
		{
			return await GetByAdminPwdAsync(adminPwd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, string sort_)
		{
			return GetByAdminPwd(adminPwd, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, string sort_)
		{
			return await GetByAdminPwdAsync(adminPwd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, string sort_, TransactionManager tm_)
		{
			return GetByAdminPwd(adminPwd, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, string sort_, TransactionManager tm_)
		{
			return await GetByAdminPwdAsync(adminPwd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "adminPwd">我方提供的后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByAdminPwd(string adminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(adminPwd != null ? "`AdminPwd` = @AdminPwd" : "`AdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (adminPwd != null)
				paras_.Add(Database.CreateInParameter("@AdminPwd", adminPwd, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByAdminPwdAsync(string adminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(adminPwd != null ? "`AdminPwd` = @AdminPwd" : "`AdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (adminPwd != null)
				paras_.Add(Database.CreateInParameter("@AdminPwd", adminPwd, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByAdminPwd
		#region GetByProvAdminUrl
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl)
		{
			return GetByProvAdminUrl(provAdminUrl, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, TransactionManager tm_)
		{
			return GetByProvAdminUrl(provAdminUrl, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, TransactionManager tm_)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, int top_)
		{
			return GetByProvAdminUrl(provAdminUrl, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, int top_)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, int top_, TransactionManager tm_)
		{
			return GetByProvAdminUrl(provAdminUrl, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, int top_, TransactionManager tm_)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, string sort_)
		{
			return GetByProvAdminUrl(provAdminUrl, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, string sort_)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, string sort_, TransactionManager tm_)
		{
			return GetByProvAdminUrl(provAdminUrl, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, string sort_, TransactionManager tm_)
		{
			return await GetByProvAdminUrlAsync(provAdminUrl, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUrl（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUrl">应用提供商后台地址</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUrl(string provAdminUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminUrl != null ? "`ProvAdminUrl` = @ProvAdminUrl" : "`ProvAdminUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUrl", provAdminUrl, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUrlAsync(string provAdminUrl, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminUrl != null ? "`ProvAdminUrl` = @ProvAdminUrl" : "`ProvAdminUrl` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminUrl != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUrl", provAdminUrl, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProvAdminUrl
		#region GetByProvAdminUser
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser)
		{
			return GetByProvAdminUser(provAdminUser, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser)
		{
			return await GetByProvAdminUserAsync(provAdminUser, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, TransactionManager tm_)
		{
			return GetByProvAdminUser(provAdminUser, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, TransactionManager tm_)
		{
			return await GetByProvAdminUserAsync(provAdminUser, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, int top_)
		{
			return GetByProvAdminUser(provAdminUser, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, int top_)
		{
			return await GetByProvAdminUserAsync(provAdminUser, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, int top_, TransactionManager tm_)
		{
			return GetByProvAdminUser(provAdminUser, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, int top_, TransactionManager tm_)
		{
			return await GetByProvAdminUserAsync(provAdminUser, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, string sort_)
		{
			return GetByProvAdminUser(provAdminUser, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, string sort_)
		{
			return await GetByProvAdminUserAsync(provAdminUser, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, string sort_, TransactionManager tm_)
		{
			return GetByProvAdminUser(provAdminUser, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, string sort_, TransactionManager tm_)
		{
			return await GetByProvAdminUserAsync(provAdminUser, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminUser（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminUser">应用提供商后台账号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminUser(string provAdminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminUser != null ? "`ProvAdminUser` = @ProvAdminUser" : "`ProvAdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminUser != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUser", provAdminUser, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProvAdminUserAsync(string provAdminUser, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminUser != null ? "`ProvAdminUser` = @ProvAdminUser" : "`ProvAdminUser` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminUser != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminUser", provAdminUser, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProvAdminUser
		#region GetByProvAdminPwd
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd)
		{
			return GetByProvAdminPwd(provAdminPwd, 0, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, TransactionManager tm_)
		{
			return GetByProvAdminPwd(provAdminPwd, 0, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, TransactionManager tm_)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, int top_)
		{
			return GetByProvAdminPwd(provAdminPwd, top_, string.Empty, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, int top_)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, int top_, TransactionManager tm_)
		{
			return GetByProvAdminPwd(provAdminPwd, top_, string.Empty, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, int top_, TransactionManager tm_)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, string sort_)
		{
			return GetByProvAdminPwd(provAdminPwd, 0, sort_, null);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, string sort_)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, string sort_, TransactionManager tm_)
		{
			return GetByProvAdminPwd(provAdminPwd, 0, sort_, tm_);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, string sort_, TransactionManager tm_)
		{
			return await GetByProvAdminPwdAsync(provAdminPwd, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ProvAdminPwd（字段） 查询
		/// </summary>
		/// /// <param name = "provAdminPwd">应用提供商后台密码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_providerEO> GetByProvAdminPwd(string provAdminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminPwd != null ? "`ProvAdminPwd` = @ProvAdminPwd" : "`ProvAdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminPwd", provAdminPwd, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		public async Task<List<S_providerEO>> GetByProvAdminPwdAsync(string provAdminPwd, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(provAdminPwd != null ? "`ProvAdminPwd` = @ProvAdminPwd" : "`ProvAdminPwd` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (provAdminPwd != null)
				paras_.Add(Database.CreateInParameter("@ProvAdminPwd", provAdminPwd, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_providerEO.MapDataReader);
		}
		#endregion // GetByProvAdminPwd
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
