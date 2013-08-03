using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
namespace ServiceLib.Util
{
    public sealed class SqlHelper
    {
        //public static readonly string UFDATA_010_2009Con = ConfigurationManager.ConnectionStrings["UFDATA_010_2009Con"].ConnectionString;
        //public static readonly string TBRobotCon = ConfigurationManager.ConnectionStrings["TBRobotCon"].ConnectionString;
        public static readonly string Double12Con = ConfigurationManager.ConnectionStrings["Double12Con"].ConnectionString;

        //public static readonly string Double12Con =
        //    @"server=127.0.0.1,17189;database=double12;user id=sa;password=HELLO151;pooling=true;min pool size=20;max pool size=100; Connect Timeout=300; ";

        //调试模式
        //public static readonly string UFDATA_010_2009Con =
        //    @"server=192.168.2.100;database=UFDATA_016_2010;user id=sa;password=pA$$w0Rd;pooling=true;min pool size=20;max pool size=100; Connect Timeout=300; ";

        //public static readonly string TBRobotCon =
        //    @"server=192.168.2.100;database=TBRobot;user id=sa;password=pA$$w0Rd;pooling=true;min pool size=20;max pool size=100; Connect Timeout=300;";


        //调试模式
        //public static readonly string UFDATA_010_2009Con =
        //    @"server=222.73.93.216;database=UFDATA_016_2010;user id=sa;password=1IN$GS0s;pooling=true;min pool size=20;max pool size=100; Connect Timeout=300; ";

        //public static readonly string TBRobotCon =
        //    @"server=222.73.93.216;database=TBRobot;user id=sa;password=1IN$GS0s;pooling=true;min pool size=20;max pool size=100; Connect Timeout=300;";
		

        #region private utility methods & constructors
        private SqlHelper() { }
        private static void AttachParameters(SqlCommand command, SqlParameter[] commandParameters)
        {
            foreach (SqlParameter p in commandParameters)
            {
				if (p.Value == null)
				{
					p.Value = DBNull.Value;
				}

                command.Parameters.Add(p);
            }
        }
        private static void AssignParameterValues(SqlParameter[] commandParameters, object[] parameterValues)
        {
            if ((commandParameters == null) || (parameterValues == null))
            {
                return;
            }
            if (commandParameters.Length != parameterValues.Length)
            {
                throw new ArgumentException("Parameter count does not match Parameter Value count.");
            }
			for (int i = 0, j = commandParameters.Length; i < j; i++)
			{
				if (parameterValues[i] == null)
				{
					parameterValues[i] = DBNull.Value;
				}
				commandParameters[i].Value = parameterValues[i];
			}
        }
        private static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command.Connection = connection;
            command.CommandText = commandText;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            command.CommandType = commandType;
            //解决SQL TIMEOUT
            command.CommandTimeout = 60000;
            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }
            return;
        }
        #endregion private utility methods & constructors

        #region ExecuteNonQuery
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connectionString, commandType, commandText, (SqlParameter[])null);
        }
        public static int ExecuteNonQuery(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                return ExecuteNonQuery(cn, commandType, commandText, commandParameters);
            }
        }
        public static int ExecuteNonQuery(string connectionString, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteNonQuery(connectionString, CommandType.StoredProcedure, spName);
            }
        }
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connection, null, commandType, commandText);
        }
        public static int ExecuteNonQuery(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteNonQuery(connection, null, commandType, commandText, commandParameters);
        }
        public static int ExecuteNonQuery(SqlConnection connection, string spName, params object[] parameterValues)
        {
            return ExecuteNonQuery(connection, null, spName, parameterValues);
        }
        public static int ExecuteNonQuery(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteNonQuery(connection, transaction, commandType, commandText, (SqlParameter[])null);
        }
        public static int ExecuteNonQuery(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);
            return cmd.ExecuteNonQuery();
        }
        public static int ExecuteNonQuery(SqlConnection connection, SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteNonQuery(connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteNonQuery(connection, transaction, CommandType.StoredProcedure, spName);
            }
        }
        #endregion ExecuteNonQuery

        #region ExecuteDataSet
        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteDataset(connectionString, commandType, commandText, (SqlParameter[])null);
        }

 

        public static DataSet ExecuteDataset(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                return ExecuteDataset(cn, commandType, commandText, commandParameters);
            }
        }
        public static DataSet ExecuteDataset(string connectionString, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteDataset(connectionString, CommandType.StoredProcedure, spName);
            }
        }
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteDataset(connection, null, commandType, commandText);
        }
        public static DataSet ExecuteDataset(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteDataset(connection, null, commandType, commandText, commandParameters);
        }
        public static DataSet ExecuteDataset(SqlConnection connection, string spName, params object[] parameterValues)
        {
            return ExecuteDataset(connection, null, spName, parameterValues);
        }
        public static DataSet ExecuteDataset(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteDataset(connection, transaction, commandType, commandText, (SqlParameter[])null);
        }
        public static DataSet ExecuteDataset(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static DataSet ExecuteDataset(SqlConnection connection, SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteDataset(connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteDataset(connection, transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion ExecuteDataSet

        #region ExecuteReader
        private enum SqlConnectionOwnership
        {
            Internal,
            External
        }
        private static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, SqlParameter[] commandParameters, SqlConnectionOwnership connectionOwnership)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);
            SqlDataReader dr;
            if (connectionOwnership == SqlConnectionOwnership.External)
            {
                dr = cmd.ExecuteReader();
            }
            else
            {
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            return dr;
        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteReader(connectionString, commandType, commandText, (SqlParameter[])null);
        }
        public static SqlDataReader ExecuteReader(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            try
            {
                return ExecuteReader(cn, null, commandType, commandText, commandParameters, SqlConnectionOwnership.Internal);
            }
            catch
            {
                cn.Close();
                throw;
            }
        }

        public static SqlDataReader ExecuteReader(string connectionString, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteReader(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteReader(connectionString, CommandType.StoredProcedure, spName);
            }
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteReader(connection, null, commandType, commandText);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteReader(connection, null, commandType, commandText, commandParameters);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, string spName, params object[] parameterValues)
        {
            return ExecuteReader(connection, null, spName, parameterValues);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteReader(connection, transaction, commandType, commandText, (SqlParameter[])null);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteReader(connection, transaction, commandType, commandText, commandParameters, SqlConnectionOwnership.External);
        }
        public static SqlDataReader ExecuteReader(SqlConnection connection, SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteReader(connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteReader(connection, transaction, CommandType.StoredProcedure, spName);
            }
        }
        #endregion ExecuteReader

        #region ExecuteScalar
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connectionString, commandType, commandText, (SqlParameter[])null);
        }
        public static object ExecuteScalar(string connectionString, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                return ExecuteScalar(cn, commandType, commandText, commandParameters);
            }
        }
        public static object ExecuteScalar(string connectionString, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteScalar(connectionString, CommandType.StoredProcedure, spName);
            }
        }
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connection, null, commandType, commandText);
        }
        public static object ExecuteScalar(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteScalar(connection, null, commandType, commandText, commandParameters);
        }
        public static object ExecuteScalar(SqlConnection connection, string spName, params object[] parameterValues)
        {
            return ExecuteScalar(connection, null, spName, parameterValues);
        }
        public static object ExecuteScalar(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteScalar(connection, transaction, commandType, commandText, (SqlParameter[])null);
        }
        public static object ExecuteScalar(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);
            return cmd.ExecuteScalar();
        }
        public static object ExecuteScalar(SqlConnection connection, SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteScalar(connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteScalar(connection, transaction, CommandType.StoredProcedure, spName);
            }
        }

        #endregion ExecuteScalar

        #region ExecuteXmlReader
        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText)
        {
            return ExecuteXmlReader(connection, null, commandType, commandText);
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            return ExecuteXmlReader(connection, null, commandType, commandText, commandParameters);
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, string spName, params object[] parameterValues)
        {
            return ExecuteXmlReader(connection, null, spName, parameterValues);
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            return ExecuteXmlReader(connection, transaction, commandType, commandText, (SqlParameter[])null);
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText, params SqlParameter[] commandParameters)
        {
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, connection, transaction, commandType, commandText, commandParameters);
            return cmd.ExecuteXmlReader();
        }
        public static XmlReader ExecuteXmlReader(SqlConnection connection, SqlTransaction transaction, string spName, params object[] parameterValues)
        {
            if ((parameterValues != null) && (parameterValues.Length > 0))
            {
                SqlParameter[] commandParameters = SqlHelperParameterCache.GetSpParameterSet(connection.ConnectionString, spName);
                AssignParameterValues(commandParameters, parameterValues);
                return ExecuteXmlReader(connection, transaction, CommandType.StoredProcedure, spName, commandParameters);
            }
            else
            {
                return ExecuteXmlReader(connection, transaction, CommandType.StoredProcedure, spName);
            }
        }
        #endregion ExecuteXmlReader
    }

    public sealed class SqlHelperParameterCache
    {
        #region private methods, variables, and constructors
        private SqlHelperParameterCache() { }
        private static Hashtable paramCache = Hashtable.Synchronized(new Hashtable());
        private static Hashtable paramTypes = Hashtable.Synchronized(new Hashtable());
        private static Hashtable paramDirections = Hashtable.Synchronized(new Hashtable());
        private static SqlParameter[] DiscoverSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            DataTable paramDescriptions = new DataTable("paramDescriptions");
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("sp_procedure_params_rowset", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@procedure_name", spName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(paramDescriptions);
            }
            SqlParameter[] discoveredParameters;
            if (paramDescriptions.Rows.Count <= 0)
            {
                throw (new ArgumentException("Stored procedure '" + spName + "' not found", "spName"));
            }
            int startRow;
            if (includeReturnValueParameter)
            {
                discoveredParameters = new SqlParameter[paramDescriptions.Rows.Count];
                startRow = 0;
            }
            else
            {
                discoveredParameters = new SqlParameter[paramDescriptions.Rows.Count - 1];
                startRow = 1;
            }
            for (int i = 0, j = discoveredParameters.Length; i < j; i++)
            {
                DataRow paramRow = paramDescriptions.Rows[i + startRow];
                discoveredParameters[i] = new SqlParameter();
                discoveredParameters[i].ParameterName = (string)paramRow["PARAMETER_NAME"];
                discoveredParameters[i].SqlDbType = (SqlDbType)paramTypes[(string)paramRow["TYPE_NAME"]];
                discoveredParameters[i].Direction = (ParameterDirection)paramDirections[(short)paramRow["PARAMETER_TYPE"]];
                discoveredParameters[i].Size = paramRow["CHARACTER_OCTET_LENGTH"] == DBNull.Value ? 0 : (int)paramRow["CHARACTER_OCTET_LENGTH"];
                discoveredParameters[i].Precision = paramRow["NUMERIC_PRECISION"] == DBNull.Value ? (byte)0 : (byte)(short)paramRow["NUMERIC_PRECISION"];
                discoveredParameters[i].Scale = paramRow["NUMERIC_SCALE"] == DBNull.Value ? (byte)0 : (byte)(short)paramRow["NUMERIC_SCALE"];
            }
            return discoveredParameters;
        }
        static SqlHelperParameterCache()
        {
            paramTypes.Add("bigint", SqlDbType.BigInt);
            paramTypes.Add("binary", SqlDbType.Binary);
            paramTypes.Add("bit", SqlDbType.Bit);
            paramTypes.Add("char", SqlDbType.Char);
            paramTypes.Add("datetime", SqlDbType.DateTime);
            paramTypes.Add("decimal", SqlDbType.Decimal);
            paramTypes.Add("float", SqlDbType.Float);
            paramTypes.Add("image", SqlDbType.Image);
            paramTypes.Add("int", SqlDbType.Int);
            paramTypes.Add("money", SqlDbType.Money);
            paramTypes.Add("nchar", SqlDbType.NChar);
            paramTypes.Add("ntext", SqlDbType.NText);
            paramTypes.Add("numeric", SqlDbType.Decimal);
            paramTypes.Add("nvarchar", SqlDbType.NVarChar);
            paramTypes.Add("real", SqlDbType.Real);
            paramTypes.Add("smalldatetime", SqlDbType.SmallDateTime);
            paramTypes.Add("smallint", SqlDbType.SmallInt);
            paramTypes.Add("smallmoney", SqlDbType.SmallMoney);
            paramTypes.Add("sql_variant", SqlDbType.Variant);
            paramTypes.Add("text", SqlDbType.Text);
            paramTypes.Add("timestamp", SqlDbType.Timestamp);
            paramTypes.Add("tinyint", SqlDbType.TinyInt);
            paramTypes.Add("uniqueidentifier", SqlDbType.UniqueIdentifier);
            paramTypes.Add("varbinary", SqlDbType.VarBinary);
            paramTypes.Add("varchar", SqlDbType.VarChar);
            paramDirections.Add((short)1, ParameterDirection.Input);
            paramDirections.Add((short)2, ParameterDirection.InputOutput);
            paramDirections.Add((short)4, ParameterDirection.ReturnValue);
        }
        private static SqlParameter[] CloneParameters(SqlParameter[] originalParameters)
        {
            SqlParameter[] clonedParameters = new SqlParameter[originalParameters.Length];
            for (int i = 0, j = originalParameters.Length; i < j; i++)
            {
                clonedParameters[i] = (SqlParameter)((ICloneable)originalParameters[i]).Clone();
            }
            return clonedParameters;
        }
        #endregion private methods, variables, and constructors

        #region caching functions

        public static void CacheParameterSet(string connectionString, string commandText, params SqlParameter[] commandParameters)
        {
            string hashKey = connectionString + ":" + commandText;
            paramCache[hashKey] = commandParameters;
        }
        public static SqlParameter[] GetCachedParameterSet(string connectionString, string commandText)
        {
            string hashKey = connectionString + ":" + commandText;
            SqlParameter[] cachedParameters = (SqlParameter[])paramCache[hashKey];
            if (cachedParameters == null)
            {
                return null;
            }
            else
            {
                return CloneParameters(cachedParameters);
            }
        }

        #endregion caching functions

        #region Parameter Discovery Functions
        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName)
        {
            return GetSpParameterSet(connectionString, spName, false);
        }

        public static SqlParameter[] GetSpParameterSet(string connectionString, string spName, bool includeReturnValueParameter)
        {
            string hashKey = connectionString + ":" + spName + (includeReturnValueParameter ? ":include ReturnValue Parameter" : "");
            SqlParameter[] cachedParameters;
            cachedParameters = (SqlParameter[])paramCache[hashKey];
            if (cachedParameters == null)
            {
                cachedParameters = (SqlParameter[])(paramCache[hashKey] = DiscoverSpParameterSet(connectionString, spName, includeReturnValueParameter));
            }
            return CloneParameters(cachedParameters);
        }

        #endregion Parameter Discovery Functions
    }
}
