/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2023-12-29 15: 09:40
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
	/// 系统语言定义（ISO 639-1 中的小写双字母）
	/// zh-cn 简体中文和zh-tw繁体中文
	/// 【表 s_language 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_languageEO : IRowMapper<S_languageEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_languageEO()
		{
			this.Status = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalLangID;
		/// <summary>
		/// 【数据库中的原始主键 LangID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalLangID
		{
			get { return _originalLangID; }
			set { HasOriginal = true; _originalLangID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "LangID", LangID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 语言代码2位小写（ISO 639-1 ）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 1)]
		public string LangID { get; set; }
		/// <summary>
		/// 语言代码3位小写
		/// 【字段 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string LangID3 { get; set; }
		/// <summary>
		/// 中文名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 3)]
		public string Name { get; set; }
		/// <summary>
		/// 英文名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 4)]
		public string EnName { get; set; }
		/// <summary>
		/// 对应语言的名称
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 5)]
		public string LangName { get; set; }
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
		public S_languageEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_languageEO MapDataReader(IDataReader reader)
		{
		    S_languageEO ret = new S_languageEO();
			ret.LangID = reader.ToString("LangID");
			ret.OriginalLangID = ret.LangID;
			ret.LangID3 = reader.ToString("LangID3");
			ret.Name = reader.ToString("Name");
			ret.EnName = reader.ToString("EnName");
			ret.LangName = reader.ToString("LangName");
			ret.Status = reader.ToInt32("Status");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 系统语言定义（ISO 639-1 中的小写双字母）
	/// zh-cn 简体中文和zh-tw繁体中文
	/// 【表 s_language 的操作类】
	/// </summary>
	[Obsolete]
	public class S_languageMO : MySqlTableMO<S_languageEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_language`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_languageMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_languageMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_languageMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_languageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_languageEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_languageEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`LangID`, `LangID3`, `Name`, `EnName`, `LangName`, `Status`) VALUE (@LangID, @LangID3, @Name, @EnName, @LangName, @Status);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID3", item.LangID3, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@EnName", item.EnName != null ? item.EnName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangName", item.LangName != null ? item.LangName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<S_languageEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_languageEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_languageEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`LangID`, `LangID3`, `Name`, `EnName`, `LangName`, `Status`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.LangID}','{item.LangID3}','{item.Name}','{item.EnName}','{item.LangName}',{item.Status}),");
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
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(langID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string langID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(langID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string langID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_languageEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.LangID, tm_);
		}
		public async Task<int> RemoveAsync(S_languageEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.LangID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLangID3
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "langID3">语言代码3位小写</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLangID3(string langID3, TransactionManager tm_ = null)
		{
			RepairRemoveByLangID3Data(langID3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLangID3Async(string langID3, TransactionManager tm_ = null)
		{
			RepairRemoveByLangID3Data(langID3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLangID3Data(string langID3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LangID3` = @LangID3";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LangID3", langID3, MySqlDbType.VarChar));
		}
		#endregion // RemoveByLangID3
		#region RemoveByName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "name">中文名称</param>
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
		public int Put(S_languageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_languageEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_languageEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID` = @LangID, `LangID3` = @LangID3, `Name` = @Name, `EnName` = @EnName, `LangName` = @LangName, `Status` = @Status WHERE `LangID` = @LangID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", item.LangID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID3", item.LangID3, MySqlDbType.VarChar),
				Database.CreateInParameter("@Name", item.Name != null ? item.Name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@EnName", item.EnName != null ? item.EnName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangName", item.LangName != null ? item.LangName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID_Original", item.HasOriginal ? item.OriginalLangID : item.LangID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_languageEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_languageEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string langID, string set_, params object[] values_)
		{
			return Put(set_, "`LangID` = @LangID", ConcatValues(values_, langID));
		}
		public async Task<int> PutByPKAsync(string langID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`LangID` = @LangID", ConcatValues(values_, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`LangID` = @LangID", tm_, ConcatValues(values_, langID));
		}
		public async Task<int> PutByPKAsync(string langID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`LangID` = @LangID", tm_, ConcatValues(values_, langID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string langID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`LangID` = @LangID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutLangID3
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// /// <param name = "langID3">语言代码3位小写</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID3ByPK(string langID, string langID3, TransactionManager tm_ = null)
		{
			RepairPutLangID3ByPKData(langID, langID3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangID3ByPKAsync(string langID, string langID3, TransactionManager tm_ = null)
		{
			RepairPutLangID3ByPKData(langID, langID3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangID3ByPKData(string langID, string langID3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangID3` = @LangID3  WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID3", langID3, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "langID3">语言代码3位小写</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangID3(string langID3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID3` = @LangID3";
			var parameter_ = Database.CreateInParameter("@LangID3", langID3, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLangID3Async(string langID3, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LangID3` = @LangID3";
			var parameter_ = Database.CreateInParameter("@LangID3", langID3, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLangID3
		#region PutName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// /// <param name = "name">中文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNameByPK(string langID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(langID, name, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNameByPKAsync(string langID, string name, TransactionManager tm_ = null)
		{
			RepairPutNameByPKData(langID, name, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNameByPKData(string langID, string name, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Name` = @Name  WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Name", name != null ? name : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "name">中文名称</param>
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
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEnNameByPK(string langID, string enName, TransactionManager tm_ = null)
		{
			RepairPutEnNameByPKData(langID, enName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEnNameByPKAsync(string langID, string enName, TransactionManager tm_ = null)
		{
			RepairPutEnNameByPKData(langID, enName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEnNameByPKData(string langID, string enName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EnName` = @EnName  WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EnName", enName != null ? enName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLangNameByPK(string langID, string langName, TransactionManager tm_ = null)
		{
			RepairPutLangNameByPKData(langID, langName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLangNameByPKAsync(string langID, string langName, TransactionManager tm_ = null)
		{
			RepairPutLangNameByPKData(langID, langName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLangNameByPKData(string langID, string langName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LangName` = @LangName  WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangName", langName != null ? langName : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string langID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(langID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string langID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(langID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string langID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `LangID` = @LangID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
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
		public bool Set(S_languageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LangID) == null)
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
		public async Task<bool> SetAsync(S_languageEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.LangID) == null)
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
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_languageEO GetByPK(string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<S_languageEO> GetByPKAsync(string langID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(langID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		private void RepairGetByPKData(string langID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`LangID` = @LangID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetByUnique
		/// <summary>
		/// 按【唯一索引】查询
		/// </summary>
		/// /// <param name = "langID3">语言代码3位小写</param>
		/// <param name="tm_">事务管理对象</param>
		public S_languageEO GetByLangID3(string langID3, TransactionManager tm_ = null)
		{
			RepairGetByLangID3Data(langID3, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<S_languageEO> GetByLangID3Async(string langID3, TransactionManager tm_ = null)
		{
			RepairGetByLangID3Data(langID3, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		private void RepairGetByLangID3Data(string langID3, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = BuildSelectSQL("`LangID3` = @LangID3", 0, null);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID3", langID3, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByUnique
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 LangID3（字段）
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangID3ByPK(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangID3`", "`LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangID3ByPKAsync(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangID3`", "`LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Name（字段）
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNameByPK(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Name`", "`LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetNameByPKAsync(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Name`", "`LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EnName（字段）
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetEnNameByPK(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`EnName`", "`LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetEnNameByPKAsync(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`EnName`", "`LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LangName（字段）
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetLangNameByPK(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`LangName`", "`LangID` = @LangID", paras_, tm_);
		}
		public async Task<string> GetLangNameByPKAsync(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`LangName`", "`LangID` = @LangID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "langID">语言代码2位小写（ISO 639-1 ）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`LangID` = @LangID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string langID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LangID", langID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`LangID` = @LangID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByName
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name)
		{
			return GetByName(name, 0, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name)
		{
			return await GetByNameAsync(name, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, TransactionManager tm_)
		{
			return GetByName(name, 0, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, int top_)
		{
			return GetByName(name, top_, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, int top_)
		{
			return await GetByNameAsync(name, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, int top_, TransactionManager tm_)
		{
			return GetByName(name, top_, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, int top_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, string sort_)
		{
			return GetByName(name, 0, sort_, null);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, string sort_)
		{
			return await GetByNameAsync(name, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, string sort_, TransactionManager tm_)
		{
			return GetByName(name, 0, sort_, tm_);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, string sort_, TransactionManager tm_)
		{
			return await GetByNameAsync(name, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Name（字段） 查询
		/// </summary>
		/// /// <param name = "name">中文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByName(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<List<S_languageEO>> GetByNameAsync(string name, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(name != null ? "`Name` = @Name" : "`Name` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (name != null)
				paras_.Add(Database.CreateInParameter("@Name", name, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		#endregion // GetByName
		#region GetByEnName
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByEnName(string enName)
		{
			return GetByEnName(enName, 0, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName)
		{
			return await GetByEnNameAsync(enName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByEnName(string enName, TransactionManager tm_)
		{
			return GetByEnName(enName, 0, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, TransactionManager tm_)
		{
			return await GetByEnNameAsync(enName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByEnName(string enName, int top_)
		{
			return GetByEnName(enName, top_, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, int top_)
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
		public List<S_languageEO> GetByEnName(string enName, int top_, TransactionManager tm_)
		{
			return GetByEnName(enName, top_, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, int top_, TransactionManager tm_)
		{
			return await GetByEnNameAsync(enName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EnName（字段） 查询
		/// </summary>
		/// /// <param name = "enName">英文名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByEnName(string enName, string sort_)
		{
			return GetByEnName(enName, 0, sort_, null);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, string sort_)
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
		public List<S_languageEO> GetByEnName(string enName, string sort_, TransactionManager tm_)
		{
			return GetByEnName(enName, 0, sort_, tm_);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, string sort_, TransactionManager tm_)
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
		public List<S_languageEO> GetByEnName(string enName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(enName != null ? "`EnName` = @EnName" : "`EnName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (enName != null)
				paras_.Add(Database.CreateInParameter("@EnName", enName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<List<S_languageEO>> GetByEnNameAsync(string enName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(enName != null ? "`EnName` = @EnName" : "`EnName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (enName != null)
				paras_.Add(Database.CreateInParameter("@EnName", enName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		#endregion // GetByEnName
		#region GetByLangName
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByLangName(string langName)
		{
			return GetByLangName(langName, 0, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName)
		{
			return await GetByLangNameAsync(langName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByLangName(string langName, TransactionManager tm_)
		{
			return GetByLangName(langName, 0, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, TransactionManager tm_)
		{
			return await GetByLangNameAsync(langName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByLangName(string langName, int top_)
		{
			return GetByLangName(langName, top_, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, int top_)
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
		public List<S_languageEO> GetByLangName(string langName, int top_, TransactionManager tm_)
		{
			return GetByLangName(langName, top_, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, int top_, TransactionManager tm_)
		{
			return await GetByLangNameAsync(langName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LangName（字段） 查询
		/// </summary>
		/// /// <param name = "langName">对应语言的名称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByLangName(string langName, string sort_)
		{
			return GetByLangName(langName, 0, sort_, null);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, string sort_)
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
		public List<S_languageEO> GetByLangName(string langName, string sort_, TransactionManager tm_)
		{
			return GetByLangName(langName, 0, sort_, tm_);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, string sort_, TransactionManager tm_)
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
		public List<S_languageEO> GetByLangName(string langName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langName != null ? "`LangName` = @LangName" : "`LangName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langName != null)
				paras_.Add(Database.CreateInParameter("@LangName", langName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<List<S_languageEO>> GetByLangNameAsync(string langName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(langName != null ? "`LangName` = @LangName" : "`LangName` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (langName != null)
				paras_.Add(Database.CreateInParameter("@LangName", langName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		#endregion // GetByLangName
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, int top_)
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
		public List<S_languageEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态0-初始1-启用</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_languageEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, string sort_)
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
		public List<S_languageEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<S_languageEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		public async Task<List<S_languageEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_languageEO.MapDataReader);
		}
		#endregion // GetByStatus
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
