using System;
using System.Collections.Generic;
using System.Data;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Entity.EntityClass;
using System.Data.SqlClient;
using ITToolbelt.Shared;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlIndexDal : IIndexDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MsSqlIndexDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }

        public List<Index> GetIndexes()
        {

            List<Index> indexes;
            using (SqlConnection sqlConnection = new SqlConnection(ConnectInfo.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand { Connection = sqlConnection };
                sqlCommand.CommandText = "SELECT S.name as [Schema], " + // 0
                                         "T.name as [Table], " + // 1
                                         "I.name as [IndexName], " + // 2
                                         $"[State] = (case I.is_disabled when 1 then '{Resource._006}' WHEN 0 THEN '{Resource._007}' END), " + // 3
                                         "DDIPS.avg_fragmentation_in_percent as Fragmantation," + // 4
                                         "DDIPS.page_count as [PageCount] " + // 5
                                         "FROM sys.indexes I join sys.tables T on I.object_id = T.object_id join sys.schemas S on T.schema_id = S.schema_id LEFT join sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, NULL) AS DDIPS on DDIPS.object_id = T.object_id AND DDIPS.index_id = I.index_id where I.[name] is not null ORDER BY [Schema], [Table], IndexName";
                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        indexes = new List<Index>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Index index = new Index();

                        index.Schema = sqlDataReader.GetString(0);
                        index.Table = sqlDataReader.GetString(1);
                        index.IndexName = sqlDataReader.GetString(2);
                        index.State = sqlDataReader.GetString(3);
                        if (!sqlDataReader.IsDBNull(4))
                        {
                            index.Fragmantation = (double?)sqlDataReader.GetSqlDouble(4);
                        }
                        if (!sqlDataReader.IsDBNull(5))
                        {
                            index.PageCount = sqlDataReader.GetSqlInt64(5).Value;
                        }

                        indexes.Add(index);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }

                return indexes;
            }
        }

        public bool SetDisable(Index index)
        {
            string sql = $"ALTER INDEX [{index.IndexName}] ON [{index.Schema}].[{index.Table}] DISABLE";
            using (SqlConnection sqlConnection = new SqlConnection(ConnectInfo.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand { Connection = sqlConnection };

                try
                {
                    sqlCommand.CommandText = sql;
                    sqlConnection.Open();
                    int nonQuery = sqlCommand.ExecuteNonQuery();
                    return nonQuery > 1;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }
            }
        }

        public List<Column> GetColumns(Index index)
        {
            List<Column> columns;
            string sql = $"SELECT ColumnName = col.name, " +
                         $"SortType = (case ic.is_descending_key when 0 then '{Resource._020}' when 1 then '{Resource._021}' end), " +
                         $"[Type] = tp.name, " +
                         $"IsInclude = ic.is_included_column " +
                         "FROM sys.indexes ind INNER JOIN sys.index_columns ic ON  ind.object_id = ic.object_id and ind.index_id = ic.index_id INNER JOIN sys.columns col ON ic.object_id = col.object_id and ic.column_id = col.column_id join sys.types tp on col.user_type_id = tp.user_type_id WHERE ind.name = @iname ORDER BY col.name";
            using (SqlConnection sqlConnection = new SqlConnection(ConnectInfo.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@iname", index.IndexName);
                try
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        columns = new List<Column>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Column column = new Column
                        {
                            ColumnName = sqlDataReader.GetString(0),
                            SortType = sqlDataReader.GetString(1),
                            Type = sqlDataReader.GetString(2),
                            IsInclude = sqlDataReader.GetBoolean(3)
                        };

                        

                        columns.Add(column);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (sqlConnection.State != ConnectionState.Closed)
                    {
                        sqlConnection.Close();
                    }
                }

                return columns;
            }

        }
    }
}