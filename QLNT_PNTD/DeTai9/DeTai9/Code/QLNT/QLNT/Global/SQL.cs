using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT.Global
{
    class SQL
    {
        static string fileName = "QLNT.mdf";
        static string path = Path.Combine(Environment.CurrentDirectory, fileName);
        //private static string connectString = @"Data Source=PC;Initial Catalog=QLNT;Integrated Security=True";
        private static string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLNT;Integrated Security=True";
        public static SqlConnection connection = new SqlConnection(connectString);
        public static DataTable GetData(string query, CommandType type, params SqlParameter[] parameter)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = type;
                if (parameter.Length > 0)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.Add(parameter[i]);
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                return tb;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return new DataTable();
            }
        }
        public static string ExcuteNonquery(string query, CommandType type, params SqlParameter[] parameter)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = type;
                if (parameter.Length > 0)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.Add(parameter[i]);
                    }
                }
                int ketqua = command.ExecuteNonQuery();
                if (ketqua == 0)
                {
                    return "Thất Bại";
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        #region temp table
        private static SqlDbType GetDBType(Type theType)
        {

            var pr = new SqlParameter();
            var tc = TypeDescriptor.GetConverter(pr.DbType);
            if (theType.Name == "Byte[]")
            {
                return SqlDbType.Binary;
            }
            if (tc.CanConvertFrom(theType))
            {
                var convertFrom = tc.ConvertFrom(theType.Name);
                if (convertFrom != null) pr.DbType = (DbType)convertFrom;
            }
            else
            {
                try
                {
                    var convertFrom = tc.ConvertFrom(theType.Name);
                    if (convertFrom != null) pr.DbType = (DbType)convertFrom;
                }
                catch (Exception)
                {
                    //Do Nothing; will return NVarChar as default
                }
            }
            return pr.SqlDbType;
        }
        private static string GetSqlType(DataColumn col, string def)
        {
            var sqltype = GetDBType(col.DataType);
            if (col.DataType == typeof(string) || col.DataType == typeof(Byte[]))
            {
                //todo: Length of nvarchar column
                return string.IsNullOrEmpty(def) ? sqltype + "(MAX) COLLATE DATABASE_DEFAULT " : sqltype + "(MAX) COLLATE " + def;
            }
            if (sqltype == SqlDbType.Decimal)
            {
                return sqltype + " (19,6)";
            }
            return sqltype.ToString();
        }
        private static string GetDefaultString()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(connectString);
                var database = builder.InitialCatalog;
                var sql = string.Format("SELECT DATABASEPROPERTYEX('{0}', 'Collation') as Coll", database);
                var resp = GetData(sql, CommandType.Text);
                if (resp != null && resp.Rows.Count > 0)
                {
                    return resp.Rows[0]["Coll"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            return "";
        }
        public static void CreateTempTable(DataTable dt, string tbName)
        {
            try
            {
                var stringDefault = GetDefaultString();
                var sql = string.Format(@"BEGIN TRY
                                        DROP TABLE [{0}]  
                                        END TRY
                                        BEGIN CATCH
                                        END CATCH", tbName);
                var cols = new List<string>();
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    var col = dt.Columns[i];
                    var item = string.Format("[{0}] {1} {2}", col.ColumnName, GetSqlType(col, stringDefault),
                        col.AllowDBNull ? "NULL" : "");
                    cols.Add(item);
                }
                sql += string.Format(" CREATE TABLE [{0}]({1})", tbName, string.Join(",", cols.ToArray()));
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = sql;
                command.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = tbName;
                    bulkCopy.BatchSize = 1000;
                    bulkCopy.BulkCopyTimeout = 60000;
                    bulkCopy.WriteToServer(dt);
                    bulkCopy.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        #region Create temp table 2
        public static void CreateTempTable2(DataTable dt, string tbname, string tempName)
        {
            try
            {
                using (var connection = new SqlConnection(connectString))
                {
                    var command = connection.CreateCommand();
                    // This will return the table schema information
                    command.CommandText = "select * from information_schema.columns where table_name = @tableName";
                    command.Parameters.Add("@tableName", SqlDbType.VarChar).Value = tbname;
                    command.CommandType = CommandType.Text;

                    connection.Open();
                    var columnList = new List<ColumnInfo>();
                    // Loop over the results and create a ColumnInfo object for each Column in the schema.
                    using (IDataReader reader = command.ExecuteReader(CommandBehavior.KeyInfo))
                    {
                        while (reader.Read())
                        {
                            columnList.Add(new ColumnInfo().ReadFromReader(reader));
                        }
                    }

                    string createTempCommand = @"BEGIN TRY
                                        DROP TABLE [{0}]  
                                        END TRY
                                        BEGIN CATCH
                                        END CATCH
                                        create table {0} ({1})";
                    StringBuilder sb = new StringBuilder();
                    // Loop over each column info object and construct the string needed for the SQL script.
                    foreach (var column in columnList)
                    {
                        sb.Append(column.ToString());
                    }

                    // create temp table
                    command.Connection = connection;
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    command.CommandText = string.Format(createTempCommand, tempName,
                                          string.Join(",", columnList.Select(c => c.ToString()).ToArray()));
                    command.ExecuteNonQuery();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                    {
                        bulkCopy.DestinationTableName = tempName;
                        bulkCopy.BatchSize = 1000;
                        bulkCopy.BulkCopyTimeout = 60000;
                        bulkCopy.WriteToServer(dt);
                        bulkCopy.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var a = ex.Message;
            }

        }
        public static List<ColumnInfo> GetListColumnInfo(string tbName)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            command.CommandText = "select * from information_schema.columns where table_name = @tableName";
            command.Parameters.Add("@tableName", SqlDbType.VarChar).Value = tbName;
            command.CommandType = CommandType.Text;
            var columnList = new List<ColumnInfo>();
            // Loop over the results and create a ColumnInfo object for each Column in the schema.
            using (IDataReader reader = command.ExecuteReader(CommandBehavior.KeyInfo))
            {
                while (reader.Read())
                {
                    columnList.Add(new ColumnInfo().ReadFromReader(reader));
                }
            }
            return columnList;
        }
        public static void CreateTempTable3(DataTable dt, string tbName, string tempTBName)
        {
            try
            {

                var columnList = GetListColumnInfo(tbName);
                string createTempCommand = @"BEGIN TRY
                                        DROP TABLE [{0}]  
                                        END TRY
                                        BEGIN CATCH
                                        END CATCH
                                        create table {0} ({1})";
                StringBuilder sb = new StringBuilder();
                // Loop over each column info object and construct the string needed for the SQL script.
                foreach (var column in columnList)
                {
                    sb.Append(column.ToString());
                }
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                command.CommandText = string.Format(createTempCommand, tempTBName,
                                          string.Join(",", columnList.Select(c => c.ToString()).ToArray()));
                command.ExecuteNonQuery();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    bulkCopy.DestinationTableName = tempTBName;
                    bulkCopy.BatchSize = 1000;
                    bulkCopy.BulkCopyTimeout = 60000;
                    bulkCopy.WriteToServer(dt);
                    bulkCopy.Close();
                }

            }
            catch (Exception ex)
            {
                var a = ex.Message;
            }
        }
        #endregion
    }
}
