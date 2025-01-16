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
	/// 货币定义大写 ISO 4217
	/// 【表 s_currency 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_currencyEO : IRowMapper<S_currencyEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_currencyEO()
		{
			this.BaseUnit = 1.000000000000000000m;
			this.CurrencyType = 0;
			this.Status = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalCurrencyID;
		/// <summary>
		/// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCurrencyID
		{
			get { return _originalCurrencyID; }
			set { HasOriginal = true; _originalCurrencyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "CurrencyID", CurrencyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 货币编码（ISO 4217大写3位）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 1)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 货币数字编码（ISO 4217 3位）
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyCode { get; set; }
		/// <summary>
		/// 基础货币单位（1单位货币等于多少最小币值）
		/// 【字段 decimal(27,18)】
		/// </summary>
		[DataMember(Order = 3)]
		public decimal BaseUnit { get; set; }
		/// <summary>
		/// 货币名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Name { get; set; }
		/// <summary>
		/// 货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int CurrencyType { get; set; }
		/// <summary>
		/// 状态0-初始1-启用
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Status { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_currencyEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_currencyEO MapDataReader(IDataReader reader)
		{
		    S_currencyEO ret = new S_currencyEO();
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.CurrencyCode = reader.ToString("CurrencyCode");
			ret.BaseUnit = reader.ToDecimal("BaseUnit");
			ret.Name = reader.ToString("Name");
			ret.CurrencyType = reader.ToInt32("CurrencyType");
			ret.Status = reader.ToInt32("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 货币定义大写 ISO 4217
	/// 【表 s_currency 的操作类】
	/// </summary>
	[Obsolete]
	public class S_currencyMO : MySqlTableMO<S_currencyEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_currency`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_currencyMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_currencyMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_currencyMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_currencyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_currencyEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`CurrencyID`, `CurrencyCode`, `BaseUnit`, `Name`, `CurrencyType`, `Status`) VALUE (@CurrencyID, @CurrencyCode, @BaseUnit, @Name, @CurrencyType, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyCode", item.CurrencyCode != null ? item.CurrencyCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseUnit", item.BaseUnit, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<S_currencyEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_currencyEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_currencyEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`CurrencyID`, `CurrencyCode`, `BaseUnit`, `Name`, `CurrencyType`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.CurrencyID}','{item.CurrencyCode}',{item.BaseUnit},'{item.Name}',{item.CurrencyType},{item.Status}),");
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
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_currencyEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(S_currencyEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.CurrencyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByCurrencyCode
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyCode(string currencyCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyCodeData(currencyCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyCodeAsync(string currencyCode, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyCodeData(currencyCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyCodeData(string currencyCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (currencyCode != null ? "`CurrencyCode` = @CurrencyCode" : "`CurrencyCode` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (currencyCode != null)
				paras_.Add(Database.CreateInParameter("@CurrencyCode", currencyCode, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyCode
		#region RemoveByBaseUnit
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBaseUnit(decimal baseUnit, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseUnitData(baseUnit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBaseUnitAsync(decimal baseUnit, TransactionManager tm_ = null)
		{
			RepairRemoveByBaseUnitData(baseUnit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBaseUnitData(decimal baseUnit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BaseUnit` = @BaseUnit";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal));
		}
		#endregion // RemoveByBaseUnit
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">货币名称</param>
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
		public int Put(S_currencyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_currencyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_currencyEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID, `CurrencyCode` = @CurrencyCode, `BaseUnit` = @BaseUnit, `Name` = @Name, `CurrencyType` = @CurrencyType, `Status` = @Status WHERE `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyCode", item.CurrencyCode != null ? item.CurrencyCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@BaseUnit", item.BaseUnit, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyType", item.CurrencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_currencyEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_currencyEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`CurrencyID` = @CurrencyID", ConcatValues(values_, currencyID));
		}
		public async Task<int> PutByPKAsync(string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`CurrencyID` = @CurrencyID", ConcatValues(values_, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, currencyID));
		}
		public async Task<int> PutByPKAsync(string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutCurrencyCode
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyCodeByPK(string currencyID, string currencyCode, TransactionManager tm_ = null)
		{
			RepairPutCurrencyCodeByPKData(currencyID, currencyCode, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyCodeByPKAsync(string currencyID, string currencyCode, TransactionManager tm_ = null)
		{
			RepairPutCurrencyCodeByPKData(currencyID, currencyCode, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyCodeByPKData(string currencyID, string currencyCode, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyCode` = @CurrencyCode  WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyCode", currencyCode != null ? currencyCode : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyCode(string currencyCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyCode` = @CurrencyCode";
			var parameter_ = Database.CreateInParameter("@CurrencyCode", currencyCode != null ? currencyCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyCodeAsync(string currencyCode, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyCode` = @CurrencyCode";
			var parameter_ = Database.CreateInParameter("@CurrencyCode", currencyCode != null ? currencyCode : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyCode
		#region PutBaseUnit
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseUnitByPK(string currencyID, decimal baseUnit, TransactionManager tm_ = null)
		{
			RepairPutBaseUnitByPKData(currencyID, baseUnit, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBaseUnitByPKAsync(string currencyID, decimal baseUnit, TransactionManager tm_ = null)
		{
			RepairPutBaseUnitByPKData(currencyID, baseUnit, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBaseUnitByPKData(string currencyID, decimal baseUnit, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BaseUnit` = @BaseUnit  WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBaseUnit(decimal baseUnit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseUnit` = @BaseUnit";
			var parameter_ = Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBaseUnitAsync(decimal baseUnit, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BaseUnit` = @BaseUnit";
			var parameter_ = Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBaseUnit
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// /// <param name = "name">货币名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(string currencyID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(currencyID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(string currencyID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(currencyID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(string currencyID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">货币名称</param>
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
		#region PutCurrencyType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyTypeByPK(string currencyID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(currencyID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCurrencyTypeByPKAsync(string currencyID, int currencyType, TransactionManager tm_ = null)
		{
			RepairPutCurrencyTypeByPKData(currencyID, currencyType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCurrencyTypeByPKData(string currencyID, int currencyType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CurrencyType` = @CurrencyType  WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string currencyID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(currencyID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string currencyID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(currencyID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string currencyID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
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
		public bool Set(S_currencyEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(S_currencyEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.CurrencyID) == null)
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
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_currencyEO GetByPK(string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<S_currencyEO> GetByPKAsync(string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		private void RepairGetByPKData(string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 CurrencyCode（字段）
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyCodeByPK(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyCode`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyCodeByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyCode`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BaseUnit（字段）
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public decimal GetBaseUnitByPK(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (decimal)GetScalar("`BaseUnit`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<decimal> GetBaseUnitByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (decimal)await GetScalarAsync("`BaseUnit`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Name`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Name`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyType（字段）
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCurrencyTypeByPK(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`CurrencyType`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetCurrencyTypeByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`CurrencyType`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByCurrencyCode
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode)
		{
			return GetByCurrencyCode(currencyCode, 0, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode)
		{
			return await GetByCurrencyCodeAsync(currencyCode, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, TransactionManager tm_)
		{
			return GetByCurrencyCode(currencyCode, 0, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, TransactionManager tm_)
		{
			return await GetByCurrencyCodeAsync(currencyCode, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, int top_)
		{
			return GetByCurrencyCode(currencyCode, top_, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, int top_)
		{
			return await GetByCurrencyCodeAsync(currencyCode, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, int top_, TransactionManager tm_)
		{
			return GetByCurrencyCode(currencyCode, top_, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyCodeAsync(currencyCode, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, string sort_)
		{
			return GetByCurrencyCode(currencyCode, 0, sort_, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, string sort_)
		{
			return await GetByCurrencyCodeAsync(currencyCode, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyCode(currencyCode, 0, sort_, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyCodeAsync(currencyCode, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyCode（字段） 查询
		/// </summary>
		/// /// <param name = "currencyCode">货币数字编码（ISO 4217 3位）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyCode(string currencyCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyCode != null ? "`CurrencyCode` = @CurrencyCode" : "`CurrencyCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyCode != null)
				paras_.Add(Database.CreateInParameter("@CurrencyCode", currencyCode, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyCodeAsync(string currencyCode, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(currencyCode != null ? "`CurrencyCode` = @CurrencyCode" : "`CurrencyCode` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (currencyCode != null)
				paras_.Add(Database.CreateInParameter("@CurrencyCode", currencyCode, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		#endregion // GetByCurrencyCode
		#region GetByBaseUnit
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit)
		{
			return GetByBaseUnit(baseUnit, 0, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit)
		{
			return await GetByBaseUnitAsync(baseUnit, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, TransactionManager tm_)
		{
			return GetByBaseUnit(baseUnit, 0, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, TransactionManager tm_)
		{
			return await GetByBaseUnitAsync(baseUnit, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, int top_)
		{
			return GetByBaseUnit(baseUnit, top_, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, int top_)
		{
			return await GetByBaseUnitAsync(baseUnit, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, int top_, TransactionManager tm_)
		{
			return GetByBaseUnit(baseUnit, top_, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, int top_, TransactionManager tm_)
		{
			return await GetByBaseUnitAsync(baseUnit, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, string sort_)
		{
			return GetByBaseUnit(baseUnit, 0, sort_, null);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, string sort_)
		{
			return await GetByBaseUnitAsync(baseUnit, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, string sort_, TransactionManager tm_)
		{
			return GetByBaseUnit(baseUnit, 0, sort_, tm_);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, string sort_, TransactionManager tm_)
		{
			return await GetByBaseUnitAsync(baseUnit, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BaseUnit（字段） 查询
		/// </summary>
		/// /// <param name = "baseUnit">基础货币单位（1单位货币等于多少最小币值）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByBaseUnit(decimal baseUnit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseUnit` = @BaseUnit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<List<S_currencyEO>> GetByBaseUnitAsync(decimal baseUnit, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BaseUnit` = @BaseUnit", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BaseUnit", baseUnit, MySqlDbType.NewDecimal));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		#endregion // GetByBaseUnit
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">货币名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<List<S_currencyEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetByCurrencyType
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyType(int currencyType)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyType(int currencyType, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyType(int currencyType, int top_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_)
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
		public List<S_currencyEO> GetByCurrencyType(int currencyType, int top_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, top_, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyTypeAsync(currencyType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyType（字段） 查询
		/// </summary>
		/// /// <param name = "currencyType">货币类型 1-COIN 2--GOLD 3-POINT 4-SWB 8-虚拟货币 9-CASH</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByCurrencyType(int currencyType, string sort_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, null);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, string sort_)
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
		public List<S_currencyEO> GetByCurrencyType(int currencyType, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyType(currencyType, 0, sort_, tm_);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, string sort_, TransactionManager tm_)
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
		public List<S_currencyEO> GetByCurrencyType(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<List<S_currencyEO>> GetByCurrencyTypeAsync(int currencyType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyType` = @CurrencyType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyType", currencyType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		#endregion // GetByCurrencyType
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_currencyEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_currencyEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_currencyEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_currencyEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		public async Task<List<S_currencyEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_currencyEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
