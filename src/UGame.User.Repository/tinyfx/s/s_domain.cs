/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * AiUo代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/AiUo
 * 文档生成时间：2024-03-04 21: 35:07
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
	/// 域名
	/// 【表 s_domain 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class S_domainEO : IRowMapper<S_domainEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public S_domainEO()
		{
			this.IsHttps = true;
			this.IsStats = false;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalDomainID;
		/// <summary>
		/// 【数据库中的原始主键 DomainID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalDomainID
		{
			get { return _originalDomainID; }
			set { HasOriginal = true; _originalDomainID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "DomainID", DomainID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 域名（不带http）
		/// 【主键 varchar(255)】
		/// </summary>
		[DataMember(Order = 1)]
		public string DomainID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 是否是https(跨域)
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 3)]
		public bool IsHttps { get; set; }
		/// <summary>
		/// 是否统计
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 4)]
		public bool IsStats { get; set; }
		/// <summary>
		/// 备注
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 5)]
		public string Note { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 6)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public S_domainEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static S_domainEO MapDataReader(IDataReader reader)
		{
		    S_domainEO ret = new S_domainEO();
			ret.DomainID = reader.ToString("DomainID");
			ret.OriginalDomainID = ret.DomainID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.IsHttps = reader.ToBoolean("IsHttps");
			ret.IsStats = reader.ToBoolean("IsStats");
			ret.Note = reader.ToString("Note");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 域名
	/// 【表 s_domain 的操作类】
	/// </summary>
	[Obsolete]
	public class S_domainMO : MySqlTableMO<S_domainEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`s_domain`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public S_domainMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public S_domainMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public S_domainMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(S_domainEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(S_domainEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(S_domainEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`DomainID`, `OperatorID`, `IsHttps`, `IsStats`, `Note`, `RecDate`) VALUE (@DomainID, @OperatorID, @IsHttps, @IsStats, @Note, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", item.DomainID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsHttps", item.IsHttps, MySqlDbType.Byte),
				Database.CreateInParameter("@IsStats", item.IsStats, MySqlDbType.Byte),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<S_domainEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<S_domainEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<S_domainEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`DomainID`, `OperatorID`, `IsHttps`, `IsStats`, `Note`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.DomainID}','{item.OperatorID}',{item.IsHttps},{item.IsStats},'{item.Note}','{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string domainID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(domainID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(domainID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string domainID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(S_domainEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.DomainID, tm_);
		}
		public async Task<int> RemoveAsync(S_domainEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.DomainID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
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
		#region RemoveByIsHttps
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsHttps(bool isHttps, TransactionManager tm_ = null)
		{
			RepairRemoveByIsHttpsData(isHttps, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsHttpsAsync(bool isHttps, TransactionManager tm_ = null)
		{
			RepairRemoveByIsHttpsData(isHttps, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsHttpsData(bool isHttps, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsHttps` = @IsHttps";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsHttps
		#region RemoveByIsStats
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsStats(bool isStats, TransactionManager tm_ = null)
		{
			RepairRemoveByIsStatsData(isStats, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsStatsAsync(bool isStats, TransactionManager tm_ = null)
		{
			RepairRemoveByIsStatsData(isStats, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsStatsData(bool isStats, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsStats` = @IsStats";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsStats
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
		public int Put(S_domainEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(S_domainEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(S_domainEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `DomainID` = @DomainID, `OperatorID` = @OperatorID, `IsHttps` = @IsHttps, `IsStats` = @IsStats, `Note` = @Note WHERE `DomainID` = @DomainID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", item.DomainID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID != null ? item.OperatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@IsHttps", item.IsHttps, MySqlDbType.Byte),
				Database.CreateInParameter("@IsStats", item.IsStats, MySqlDbType.Byte),
				Database.CreateInParameter("@Note", item.Note != null ? item.Note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@DomainID_Original", item.HasOriginal ? item.OriginalDomainID : item.DomainID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<S_domainEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<S_domainEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string domainID, string set_, params object[] values_)
		{
			return Put(set_, "`DomainID` = @DomainID", ConcatValues(values_, domainID));
		}
		public async Task<int> PutByPKAsync(string domainID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`DomainID` = @DomainID", ConcatValues(values_, domainID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string domainID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`DomainID` = @DomainID", tm_, ConcatValues(values_, domainID));
		}
		public async Task<int> PutByPKAsync(string domainID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`DomainID` = @DomainID", tm_, ConcatValues(values_, domainID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string domainID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`DomainID` = @DomainID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string domainID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`DomainID` = @DomainID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorIDByPK(string domainID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(domainID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOperatorIDByPKAsync(string domainID, string operatorID, TransactionManager tm_ = null)
		{
			RepairPutOperatorIDByPKData(domainID, operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOperatorIDByPKData(string domainID, string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID  WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID != null ? operatorID : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
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
		#region PutIsHttps
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsHttpsByPK(string domainID, bool isHttps, TransactionManager tm_ = null)
		{
			RepairPutIsHttpsByPKData(domainID, isHttps, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsHttpsByPKAsync(string domainID, bool isHttps, TransactionManager tm_ = null)
		{
			RepairPutIsHttpsByPKData(domainID, isHttps, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsHttpsByPKData(string domainID, bool isHttps, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsHttps` = @IsHttps  WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte),
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsHttps(bool isHttps, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsHttps` = @IsHttps";
			var parameter_ = Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsHttpsAsync(bool isHttps, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsHttps` = @IsHttps";
			var parameter_ = Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsHttps
		#region PutIsStats
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsStatsByPK(string domainID, bool isStats, TransactionManager tm_ = null)
		{
			RepairPutIsStatsByPKData(domainID, isStats, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsStatsByPKAsync(string domainID, bool isStats, TransactionManager tm_ = null)
		{
			RepairPutIsStatsByPKData(domainID, isStats, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsStatsByPKData(string domainID, bool isStats, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsStats` = @IsStats  WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte),
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsStats(bool isStats, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsStats` = @IsStats";
			var parameter_ = Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsStatsAsync(bool isStats, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsStats` = @IsStats";
			var parameter_ = Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsStats
		#region PutNote
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// /// <param name = "note">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNoteByPK(string domainID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(domainID, note, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNoteByPKAsync(string domainID, string note, TransactionManager tm_ = null)
		{
			RepairPutNoteByPKData(domainID, note, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNoteByPKData(string domainID, string note, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Note` = @Note  WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Note", note != null ? note : (object)DBNull.Value, MySqlDbType.Text),
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
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
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string domainID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(domainID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string domainID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(domainID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string domainID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `DomainID` = @DomainID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
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
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(S_domainEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DomainID) == null)
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
		public async Task<bool> SetAsync(S_domainEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.DomainID) == null)
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
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public S_domainEO GetByPK(string domainID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(domainID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<S_domainEO> GetByPKAsync(string domainID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(domainID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		private void RepairGetByPKData(string domainID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`DomainID` = @DomainID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`DomainID` = @DomainID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`DomainID` = @DomainID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsHttps（字段）
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsHttpsByPK(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsHttps`", "`DomainID` = @DomainID", paras_, tm_);
		}
		public async Task<bool> GetIsHttpsByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsHttps`", "`DomainID` = @DomainID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsStats（字段）
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsStatsByPK(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (bool)GetScalar("`IsStats`", "`DomainID` = @DomainID", paras_, tm_);
		}
		public async Task<bool> GetIsStatsByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (bool)await GetScalarAsync("`IsStats`", "`DomainID` = @DomainID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Note（字段）
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNoteByPK(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`Note`", "`DomainID` = @DomainID", paras_, tm_);
		}
		public async Task<string> GetNoteByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`Note`", "`DomainID` = @DomainID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "domainID">域名（不带http）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`DomainID` = @DomainID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string domainID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@DomainID", domainID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`DomainID` = @DomainID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<S_domainEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<S_domainEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<S_domainEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<List<S_domainEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(operatorID != null ? "`OperatorID` = @OperatorID" : "`OperatorID` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (operatorID != null)
				paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByIsHttps
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps)
		{
			return GetByIsHttps(isHttps, 0, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps)
		{
			return await GetByIsHttpsAsync(isHttps, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, TransactionManager tm_)
		{
			return GetByIsHttps(isHttps, 0, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, TransactionManager tm_)
		{
			return await GetByIsHttpsAsync(isHttps, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, int top_)
		{
			return GetByIsHttps(isHttps, top_, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, int top_)
		{
			return await GetByIsHttpsAsync(isHttps, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, int top_, TransactionManager tm_)
		{
			return GetByIsHttps(isHttps, top_, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, int top_, TransactionManager tm_)
		{
			return await GetByIsHttpsAsync(isHttps, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, string sort_)
		{
			return GetByIsHttps(isHttps, 0, sort_, null);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, string sort_)
		{
			return await GetByIsHttpsAsync(isHttps, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, string sort_, TransactionManager tm_)
		{
			return GetByIsHttps(isHttps, 0, sort_, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, string sort_, TransactionManager tm_)
		{
			return await GetByIsHttpsAsync(isHttps, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsHttps（字段） 查询
		/// </summary>
		/// /// <param name = "isHttps">是否是https(跨域)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsHttps(bool isHttps, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsHttps` = @IsHttps", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<List<S_domainEO>> GetByIsHttpsAsync(bool isHttps, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsHttps` = @IsHttps", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsHttps", isHttps, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		#endregion // GetByIsHttps
		#region GetByIsStats
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats)
		{
			return GetByIsStats(isStats, 0, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats)
		{
			return await GetByIsStatsAsync(isStats, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, TransactionManager tm_)
		{
			return GetByIsStats(isStats, 0, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, TransactionManager tm_)
		{
			return await GetByIsStatsAsync(isStats, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, int top_)
		{
			return GetByIsStats(isStats, top_, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, int top_)
		{
			return await GetByIsStatsAsync(isStats, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, int top_, TransactionManager tm_)
		{
			return GetByIsStats(isStats, top_, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, int top_, TransactionManager tm_)
		{
			return await GetByIsStatsAsync(isStats, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, string sort_)
		{
			return GetByIsStats(isStats, 0, sort_, null);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, string sort_)
		{
			return await GetByIsStatsAsync(isStats, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, string sort_, TransactionManager tm_)
		{
			return GetByIsStats(isStats, 0, sort_, tm_);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, string sort_, TransactionManager tm_)
		{
			return await GetByIsStatsAsync(isStats, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsStats（字段） 查询
		/// </summary>
		/// /// <param name = "isStats">是否统计</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByIsStats(bool isStats, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsStats` = @IsStats", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<List<S_domainEO>> GetByIsStatsAsync(bool isStats, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsStats` = @IsStats", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsStats", isStats, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		#endregion // GetByIsStats
		#region GetByNote
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByNote(string note)
		{
			return GetByNote(note, 0, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note)
		{
			return await GetByNoteAsync(note, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByNote(string note, TransactionManager tm_)
		{
			return GetByNote(note, 0, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByNote(string note, int top_)
		{
			return GetByNote(note, top_, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, int top_)
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
		public List<S_domainEO> GetByNote(string note, int top_, TransactionManager tm_)
		{
			return GetByNote(note, top_, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, int top_, TransactionManager tm_)
		{
			return await GetByNoteAsync(note, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Note（字段） 查询
		/// </summary>
		/// /// <param name = "note">备注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByNote(string note, string sort_)
		{
			return GetByNote(note, 0, sort_, null);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, string sort_)
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
		public List<S_domainEO> GetByNote(string note, string sort_, TransactionManager tm_)
		{
			return GetByNote(note, 0, sort_, tm_);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, string sort_, TransactionManager tm_)
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
		public List<S_domainEO> GetByNote(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<List<S_domainEO>> GetByNoteAsync(string note, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(note != null ? "`Note` = @Note" : "`Note` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (note != null)
				paras_.Add(Database.CreateInParameter("@Note", note, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		#endregion // GetByNote
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<S_domainEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<S_domainEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<S_domainEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<S_domainEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		public async Task<List<S_domainEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, S_domainEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
