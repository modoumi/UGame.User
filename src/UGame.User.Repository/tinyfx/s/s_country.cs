/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:44
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
	/// 国家编码ISO 3166-1三位字母大写 USA
	/// 【表 s_country 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_countryEO : IRowMapper<S_countryEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_countryEO()
		{
			this.TimeZone = 0;
			this.Status = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalCountryID;
		/// <summary>
		/// 【数据库中的原始主键 CountryID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCountryID
		{
			get { return _originalCountryID; }
			set { HasOriginal = true; _originalCountryID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "CountryID", CountryID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 国家编码3位大写（ISO 3166-1）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 1)]
		public string CountryID { get; set; }
		/// <summary>
		/// 国家编码2位大写（ISO 3166-1）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CountryID2 { get; set; }
		/// <summary>
		/// 国家数字编码
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CountryCode { get; set; }
		/// <summary>
		/// 主货币类型
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 4)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 国际电话区号不带+号
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 5)]
		public string CallingCode { get; set; }
		/// <summary>
		/// 国家名称
		/// 【字段 varchar(20)】
		/// </summary>
		[DataMember(Order = 6)]
		public string Name { get; set; }
		/// <summary>
		/// 英文名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 7)]
		public string EnName { get; set; }
		/// <summary>
		/// 对应语言的名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 8)]
		public string LangName { get; set; }
		/// <summary>
		/// 默认国家时区
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int TimeZone { get; set; }
		/// <summary>
		/// 状态0-初始1-启用
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int Status { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_countryEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_countryEO MapDataReader(IDataReader reader)
		{
		    S_countryEO ret = new S_countryEO();
			ret.CountryID = reader.ToString("CountryID");
			ret.OriginalCountryID = ret.CountryID;
			ret.CountryID2 = reader.ToString("CountryID2");
			ret.CountryCode = reader.ToString("CountryCode");
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.CallingCode = reader.ToString("CallingCode");
			ret.Name = reader.ToString("Name");
			ret.EnName = reader.ToString("EnName");
			ret.LangName = reader.ToString("LangName");
			ret.TimeZone = reader.ToInt32("TimeZone");
			ret.Status = reader.ToInt32("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 国家编码ISO 3166-1三位字母大写 USA
	/// 【表 s_country 的操作类】
	/// </summary>
	[Obsolete]
	public class S_countryMO : MySqlTableMO<S_countryEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_country`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_countryMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_countryMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_countryMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_countryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_countryEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_countryEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`CountryID`, `CountryID2`, `CountryCode`, `CurrencyID`, `CallingCode`, `Name`, `EnName`, `LangName`, `TimeZone`, `Status`) VALUE (@CountryID, @CountryID2, @CountryCode, @CurrencyID, @CallingCode, @Name, @EnName, @LangName, @TimeZone, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID2", item.CountryID2 != null ? item.CountryID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryCode", item.CountryCode != null ? item.CountryCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CallingCode", item.CallingCode != null ? item.CallingCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@EnName", item.EnName != null ? item.EnName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangName", item.LangName != null ? item.LangName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TimeZone", item.TimeZone, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<S_countryEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_countryEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_countryEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`CountryID`, `CountryID2`, `CountryCode`, `CurrencyID`, `CallingCode`, `Name`, `EnName`, `LangName`, `TimeZone`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.CountryID}','{item.CountryID2}','{item.CountryCode}','{item.CurrencyID}','{item.CallingCode}','{item.Name}','{item.EnName}','{item.LangName}',{item.TimeZone},{item.Status}),");
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
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string countryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(countryID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string countryID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_countryEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.CountryID, tm_);
		}
		public async Task<int> RemoveAsync(S_countryEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.CountryID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByCountryID2
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryID2">国家编码2位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryID2(string countryID2, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryID2Data(countryID2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryID2Async(string countryID2, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryID2Data(countryID2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryID2Data(string countryID2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryID2 != null ? "`CountryID2` = @CountryID2" : "`CountryID2` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryID2 != null)
				paras_.Add(Database.CreateInParameter("@CountryID2", countryID2, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryID2
		#region RemoveByCountryCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "countryCode">国家数字编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCountryCode(string countryCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryCodeData(countryCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCountryCodeAsync(string countryCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCountryCodeData(countryCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCountryCodeData(string countryCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (countryCode != null ? "`CountryCode` = @CountryCode" : "`CountryCode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (countryCode != null)
				paras_.Add(Database.CreateInParameter("@CountryCode", countryCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCountryCode
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
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
		#region RemoveByCallingCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCallingCode(string callingCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCallingCodeData(callingCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCallingCodeAsync(string callingCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCallingCodeData(callingCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCallingCodeData(string callingCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (callingCode != null ? "`CallingCode` = @CallingCode" : "`CallingCode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (callingCode != null)
				paras_.Add(Database.CreateInParameter("@CallingCode", callingCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCallingCode
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByName(string name, TransactionManager tm_ = null)
		{
			RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNameAsync(string name, TransactionManager tm_ = null)
		{
			RepairRemoveByNameData(name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNameData(string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (name != null ? "`Name` = @Name" : "`Name` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
		}
		#endregion // RemoveByName
		#region RemoveByEnName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEnName(string enName, TransactionManager tm_ = null)
		{
			RepairRemoveByEnNameData(enName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEnNameAsync(string enName, TransactionManager tm_ = null)
		{
			RepairRemoveByEnNameData(enName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEnNameData(string enName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (enName != null ? "`EnName` = @EnName" : "`EnName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (enName != null)
				paras_.Add(Database.CreateInParameter("@EnName", enName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByEnName
		#region RemoveByLangName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangName(string langName, TransactionManager tm_ = null)
		{
			RepairRemoveByLangNameData(langName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangNameAsync(string langName, TransactionManager tm_ = null)
		{
			RepairRemoveByLangNameData(langName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangNameData(string langName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (langName != null ? "`LangName` = @LangName" : "`LangName` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (langName != null)
				paras_.Add(Database.CreateInParameter("@LangName", langName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangName
		#region RemoveByTimeZone
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByTimeZone(int timeZone, TransactionManager tm_ = null)
		{
			RepairRemoveByTimeZoneData(timeZone, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByTimeZoneAsync(int timeZone, TransactionManager tm_ = null)
		{
			RepairRemoveByTimeZoneData(timeZone, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByTimeZoneData(int timeZone, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `TimeZone` = @TimeZone";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32));
		}
		#endregion // RemoveByTimeZone
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
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
		public int Put(S_countryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_countryEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_countryEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID` = @CountryID, `CountryID2` = @CountryID2, `CountryCode` = @CountryCode, `CurrencyID` = @CurrencyID, `CallingCode` = @CallingCode, `Name` = @Name, `EnName` = @EnName, `LangName` = @LangName, `TimeZone` = @TimeZone, `Status` = @Status WHERE `CountryID` = @CountryID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", item.CountryID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID2", item.CountryID2 != null ? item.CountryID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryCode", item.CountryCode != null ? item.CountryCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID != null ? item.CurrencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CallingCode", item.CallingCode != null ? item.CallingCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@EnName", item.EnName != null ? item.EnName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangName", item.LangName != null ? item.LangName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@TimeZone", item.TimeZone, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID_Original", item.HasOriginal ? item.OriginalCountryID : item.CountryID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_countryEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_countryEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string set_, params object[] values_)
		{
			return Put(set_, "`CountryID` = @CountryID", ConcatValues(values_, countryID));
		}
		public async Task<int> PutByPKAsync(string countryID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`CountryID` = @CountryID", ConcatValues(values_, countryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`CountryID` = @CountryID", tm_, ConcatValues(values_, countryID));
		}
		public async Task<int> PutByPKAsync(string countryID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`CountryID` = @CountryID", tm_, ConcatValues(values_, countryID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string countryID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`CountryID` = @CountryID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCountryID2
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "countryID2">国家编码2位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID2ByPK(string countryID, string countryID2, TransactionManager tm_ = null)
		{
			RepairPutCountryID2ByPKData(countryID, countryID2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryID2ByPKAsync(string countryID, string countryID2, TransactionManager tm_ = null)
		{
			RepairPutCountryID2ByPKData(countryID, countryID2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryID2ByPKData(string countryID, string countryID2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryID2` = @CountryID2  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID2", countryID2 != null ? countryID2 : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryID2">国家编码2位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryID2(string countryID2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID2` = @CountryID2";
			var parameter_ = Database.CreateInParameter("@CountryID2", countryID2 != null ? countryID2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryID2Async(string countryID2, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryID2` = @CountryID2";
			var parameter_ = Database.CreateInParameter("@CountryID2", countryID2 != null ? countryID2 : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryID2
		#region PutCountryCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "countryCode">国家数字编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryCodeByPK(string countryID, string countryCode, TransactionManager tm_ = null)
		{
			RepairPutCountryCodeByPKData(countryID, countryCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCountryCodeByPKAsync(string countryID, string countryCode, TransactionManager tm_ = null)
		{
			RepairPutCountryCodeByPKData(countryID, countryCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCountryCodeByPKData(string countryID, string countryCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CountryCode` = @CountryCode  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryCode", countryCode != null ? countryCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "countryCode">国家数字编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCountryCode(string countryCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryCode` = @CountryCode";
			var parameter_ = Database.CreateInParameter("@CountryCode", countryCode != null ? countryCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCountryCodeAsync(string countryCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CountryCode` = @CountryCode";
			var parameter_ = Database.CreateInParameter("@CountryCode", countryCode != null ? countryCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCountryCode
		#region PutCurrencyID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyIDByPK(string countryID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyIDByPKAsync(string countryID, string currencyID, TransactionManager tm_ = null)
		{
			RepairPutCurrencyIDByPKData(countryID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyIDByPKData(string countryID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID != null ? currencyID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
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
		#region PutCallingCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCallingCodeByPK(string countryID, string callingCode, TransactionManager tm_ = null)
		{
			RepairPutCallingCodeByPKData(countryID, callingCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCallingCodeByPKAsync(string countryID, string callingCode, TransactionManager tm_ = null)
		{
			RepairPutCallingCodeByPKData(countryID, callingCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCallingCodeByPKData(string countryID, string callingCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CallingCode` = @CallingCode  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CallingCode", callingCode != null ? callingCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCallingCode(string callingCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CallingCode` = @CallingCode";
			var parameter_ = Database.CreateInParameter("@CallingCode", callingCode != null ? callingCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCallingCodeAsync(string callingCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CallingCode` = @CallingCode";
			var parameter_ = Database.CreateInParameter("@CallingCode", callingCode != null ? callingCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCallingCode
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "name">国家名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(string countryID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(countryID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(string countryID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(countryID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(string countryID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutName(string name, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
			var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNameAsync(string name, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Name` = @Name";
			var parameter_ = Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutName
		#region PutEnName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEnNameByPK(string countryID, string enName, TransactionManager tm_ = null)
		{
			RepairPutEnNameByPKData(countryID, enName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEnNameByPKAsync(string countryID, string enName, TransactionManager tm_ = null)
		{
			RepairPutEnNameByPKData(countryID, enName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEnNameByPKData(string countryID, string enName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EnName` = @EnName  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EnName", enName != null ? enName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEnName(string enName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EnName` = @EnName";
			var parameter_ = Database.CreateInParameter("@EnName", enName != null ? enName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEnNameAsync(string enName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EnName` = @EnName";
			var parameter_ = Database.CreateInParameter("@EnName", enName != null ? enName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEnName
		#region PutLangName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangNameByPK(string countryID, string langName, TransactionManager tm_ = null)
		{
			RepairPutLangNameByPKData(countryID, langName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangNameByPKAsync(string countryID, string langName, TransactionManager tm_ = null)
		{
			RepairPutLangNameByPKData(countryID, langName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangNameByPKData(string countryID, string langName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangName` = @LangName  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangName", langName != null ? langName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangName(string langName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangName` = @LangName";
			var parameter_ = Database.CreateInParameter("@LangName", langName != null ? langName : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangNameAsync(string langName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangName` = @LangName";
			var parameter_ = Database.CreateInParameter("@LangName", langName != null ? langName : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangName
		#region PutTimeZone
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTimeZoneByPK(string countryID, int timeZone, TransactionManager tm_ = null)
		{
			RepairPutTimeZoneByPKData(countryID, timeZone, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutTimeZoneByPKAsync(string countryID, int timeZone, TransactionManager tm_ = null)
		{
			RepairPutTimeZoneByPKData(countryID, timeZone, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutTimeZoneByPKData(string countryID, int timeZone, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `TimeZone` = @TimeZone  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutTimeZone(int timeZone, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TimeZone` = @TimeZone";
			var parameter_ = Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutTimeZoneAsync(int timeZone, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `TimeZone` = @TimeZone";
			var parameter_ = Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutTimeZone
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string countryID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(countryID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string countryID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(countryID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string countryID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `CountryID` = @CountryID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_countryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CountryID) == null)
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
		public async Task<bool> SetAsync(S_countryEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CountryID) == null)
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
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_countryEO GetByPK(string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<S_countryEO> GetByPKAsync(string countryID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(countryID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		private void RepairGetByPKData(string countryID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`CountryID` = @CountryID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "countryID2">国家编码2位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		public S_countryEO GetByCountryID2(string countryID2, TransactionManager tm_ = null)
		{
			RepairGetByCountryID2Data(countryID2, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<S_countryEO> GetByCountryID2Async(string countryID2, TransactionManager tm_ = null)
		{
			RepairGetByCountryID2Data(countryID2, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		private void RepairGetByCountryID2Data(string countryID2, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`CountryID2` = @CountryID2", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID2", countryID2 != null ? countryID2 : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "countryCode">国家数字编码</param>
		/// <param name="tm_">事务管理对象</param>
		public S_countryEO GetByCountryCode(string countryCode, TransactionManager tm_ = null)
		{
			RepairGetByCountryCodeData(countryCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<S_countryEO> GetByCountryCodeAsync(string countryCode, TransactionManager tm_ = null)
		{
			RepairGetByCountryCodeData(countryCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		private void RepairGetByCountryCodeData(string countryCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`CountryCode` = @CountryCode", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryCode", countryCode != null ? countryCode : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 CountryID2（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryID2ByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryID2`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCountryID2ByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryID2`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CountryCode（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCountryCodeByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CountryCode`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCountryCodeByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CountryCode`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CallingCode（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCallingCodeByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CallingCode`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetCallingCodeByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CallingCode`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Name`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Name`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EnName（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEnNameByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`EnName`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetEnNameByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`EnName`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangName（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangNameByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangName`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<string> GetLangNameByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangName`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 TimeZone（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetTimeZoneByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`TimeZone`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<int> GetTimeZoneByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`TimeZone`", "`CountryID` = @CountryID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "countryID">国家编码3位大写（ISO 3166-1）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`CountryID` = @CountryID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string countryID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CountryID", countryID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`CountryID` = @CountryID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">主货币类型</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyID != null ? "`CurrencyID` = @CurrencyID" : "`CurrencyID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyID != null)
				paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByCallingCode
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode)
		{
			return GetByCallingCode(callingCode, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode)
		{
			return await GetByCallingCodeAsync(callingCode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, TransactionManager tm_)
		{
			return GetByCallingCode(callingCode, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, TransactionManager tm_)
		{
			return await GetByCallingCodeAsync(callingCode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, int top_)
		{
			return GetByCallingCode(callingCode, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, int top_)
		{
			return await GetByCallingCodeAsync(callingCode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, int top_, TransactionManager tm_)
		{
			return GetByCallingCode(callingCode, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, int top_, TransactionManager tm_)
		{
			return await GetByCallingCodeAsync(callingCode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, string sort_)
		{
			return GetByCallingCode(callingCode, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, string sort_)
		{
			return await GetByCallingCodeAsync(callingCode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, string sort_, TransactionManager tm_)
		{
			return GetByCallingCode(callingCode, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, string sort_, TransactionManager tm_)
		{
			return await GetByCallingCodeAsync(callingCode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CallingCode（字段） 查询
		/// </summary>
		/// /// <param name = "callingCode">国际电话区号不带+号</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByCallingCode(string callingCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(callingCode != null ? "`CallingCode` = @CallingCode" : "`CallingCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (callingCode != null)
				paras_.Add(Database.CreateInParameter("@CallingCode", callingCode, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByCallingCodeAsync(string callingCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(callingCode != null ? "`CallingCode` = @CallingCode" : "`CallingCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (callingCode != null)
				paras_.Add(Database.CreateInParameter("@CallingCode", callingCode, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByCallingCode
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">国家名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetByEnName
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName)
		{
			return GetByEnName(enName, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName)
		{
			return await GetByEnNameAsync(enName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, TransactionManager tm_)
		{
			return GetByEnName(enName, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, TransactionManager tm_)
		{
			return await GetByEnNameAsync(enName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, int top_)
		{
			return GetByEnName(enName, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, int top_)
		{
			return await GetByEnNameAsync(enName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, int top_, TransactionManager tm_)
		{
			return GetByEnName(enName, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, int top_, TransactionManager tm_)
		{
			return await GetByEnNameAsync(enName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, string sort_)
		{
			return GetByEnName(enName, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, string sort_)
		{
			return await GetByEnNameAsync(enName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, string sort_, TransactionManager tm_)
		{
			return GetByEnName(enName, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, string sort_, TransactionManager tm_)
		{
			return await GetByEnNameAsync(enName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByEnName(string enName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(enName != null ? "`EnName` = @EnName" : "`EnName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (enName != null)
				paras_.Add(Database.CreateInParameter("@EnName", enName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByEnNameAsync(string enName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(enName != null ? "`EnName` = @EnName" : "`EnName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (enName != null)
				paras_.Add(Database.CreateInParameter("@EnName", enName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByEnName
		#region GetByLangName
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName)
		{
			return GetByLangName(langName, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName)
		{
			return await GetByLangNameAsync(langName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, TransactionManager tm_)
		{
			return GetByLangName(langName, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, TransactionManager tm_)
		{
			return await GetByLangNameAsync(langName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, int top_)
		{
			return GetByLangName(langName, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, int top_)
		{
			return await GetByLangNameAsync(langName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, int top_, TransactionManager tm_)
		{
			return GetByLangName(langName, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, int top_, TransactionManager tm_)
		{
			return await GetByLangNameAsync(langName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, string sort_)
		{
			return GetByLangName(langName, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, string sort_)
		{
			return await GetByLangNameAsync(langName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, string sort_, TransactionManager tm_)
		{
			return GetByLangName(langName, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, string sort_, TransactionManager tm_)
		{
			return await GetByLangNameAsync(langName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByLangName(string langName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langName != null ? "`LangName` = @LangName" : "`LangName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langName != null)
				paras_.Add(Database.CreateInParameter("@LangName", langName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByLangNameAsync(string langName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langName != null ? "`LangName` = @LangName" : "`LangName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langName != null)
				paras_.Add(Database.CreateInParameter("@LangName", langName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByLangName
		#region GetByTimeZone
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone)
		{
			return GetByTimeZone(timeZone, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone)
		{
			return await GetByTimeZoneAsync(timeZone, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, TransactionManager tm_)
		{
			return GetByTimeZone(timeZone, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, TransactionManager tm_)
		{
			return await GetByTimeZoneAsync(timeZone, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, int top_)
		{
			return GetByTimeZone(timeZone, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, int top_)
		{
			return await GetByTimeZoneAsync(timeZone, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, int top_, TransactionManager tm_)
		{
			return GetByTimeZone(timeZone, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, int top_, TransactionManager tm_)
		{
			return await GetByTimeZoneAsync(timeZone, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, string sort_)
		{
			return GetByTimeZone(timeZone, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, string sort_)
		{
			return await GetByTimeZoneAsync(timeZone, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, string sort_, TransactionManager tm_)
		{
			return GetByTimeZone(timeZone, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, string sort_, TransactionManager tm_)
		{
			return await GetByTimeZoneAsync(timeZone, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 TimeZone（字段） 查询
		/// </summary>
		/// /// <param name = "timeZone">默认国家时区</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByTimeZone(int timeZone, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TimeZone` = @TimeZone", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByTimeZoneAsync(int timeZone, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`TimeZone` = @TimeZone", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@TimeZone", timeZone, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByTimeZone
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_countryEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		public async Task<List<S_countryEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_countryEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
