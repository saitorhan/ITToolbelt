using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;
using MySql.Data.MySqlClient;
using Database = ITToolbelt.Entity.EntityClass.Database;

namespace ITToolbelt.Dal.Contract.MySql
{
    public class MySqlConnectionDal : IConnectionDal
    {
        public ConnectInfo ConnectInfo { get; }

        public MySqlConnectionDal(ConnectInfo connectInfo)
        {
            ConnectInfo = connectInfo;
        }
        public bool AddConnection(Connection connection)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                context.Connections.Add(connection);
                return context.SaveChanges();
            }
        }

        public List<Connection> GetConnections(bool updateFromServer)
        {
            List<Connection> connections;
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                connections = context.Connections.ToList();


                if (!updateFromServer)
                {
                    return connections;
                }
                foreach (Connection connection in connections)
                {
                    switch (connection.DbServerTypeCode)
                    {
                        case DbServerType.MsSql:
                            MsSqlConnectionDal.GetServerProperties(connection);
                            break;
                        case DbServerType.MySql:
                            GetServerProperties(connection);
                            break;
                        default:
                            break;
                    }
                }

                context.SaveChanges();
            }

            return connections.OrderBy(c => c.Name).ToList();
        }

        public static void GetServerProperties(Connection connection)
        {
            try
            {
                using (MySqlConnection sqlConnection = new MySqlConnection(connection.ConnectionString))
                {
                    MySqlCommand sqlCommand = new MySqlCommand { Connection = sqlConnection };
                    sqlCommand.CommandText = "select @@hostname, @@hostname, @@version_comment, null ProductLevel, null ProductUpdateLevel, @@version, @@collation_server, null ProductMajorVersion, null ProductMinorVersion, null InstanceName";
                    sqlConnection.Open();
                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        connection.MachineName = sqlDataReader.GetString(0);
                        connection.ServerName = sqlDataReader.GetString(1);
                        connection.Edition = sqlDataReader.GetString(2);
                        // connection.ProductLevel = sqlDataReader.GetString(3);
                        // connection.ProductUpdateLevel = sqlDataReader.GetString(4);
                        connection.ProductVersion = sqlDataReader.GetString(5);
                        connection.Collation = sqlDataReader.GetString(6);
                        // connection.ProductMajorVersion = sqlDataReader.GetString(7);
                        // connection.ProductMinorVersion = sqlDataReader.GetString(8);
                        // connection.InstanceName = sqlDataReader.GetString(9);
                    }


                    connection.ConnectionInfo = Resource._018;
                }
            }
            catch (Exception e)
            {
                connection.ConnectionInfo = Resource._019;
            }
            finally
            {
                connection.ModifiedDate = DateTime.Now;
            }
        }

        public List<Database> GetDatabases()
        {
            List<Database> databases;
            using (MySqlConnection mySqlConnection = new MySqlConnection(ConnectInfo.ConnectionString))
            {
                MySqlCommand sqlCommand = new MySqlCommand { Connection = mySqlConnection };
                sqlCommand.CommandText = "select 0, SCHEMA_NAME , 0 from information_schema.schemata";
                try
                {
                    mySqlConnection.Open();
                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        databases = new List<Database>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Database database = new Database();

                        database.Id = sqlDataReader.GetInt32(0);
                        database.Name = sqlDataReader.GetString(1);
                        database.State = (byte)sqlDataReader.GetInt32(2);
                        
                        databases.Add(database);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (mySqlConnection.State != ConnectionState.Closed)
                    {
                        mySqlConnection.Close();
                    }
                }

                return databases.OrderBy(d => d.Name).ToList();
            }
        }

        public List<Table> GetTables()
        {
            List<Table> tables;
            using (MySqlConnection mySqlConnection = new MySqlConnection(ConnectInfo.ConnectionString))
            {
                MySqlCommand sqlCommand = new MySqlCommand { Connection = mySqlConnection };
                sqlCommand.CommandText = "select 0, 0, 0, TABLE_SCHEMA, null, TABLE_NAME from information_schema.tables where TABLE_SCHEMA = @dbName AND TABLE_TYPE = 'BASE TABLE'";
                sqlCommand.Parameters.AddWithValue("@dbName", mySqlConnection.Database);
                try
                {
                    mySqlConnection.Open();
                    MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        tables = new List<Table>();
                    }
                    else
                    {
                        return null;
                    }

                    while (sqlDataReader.Read())
                    {
                        Table database = new Table
                        {
                            DatabaseId = sqlDataReader.GetInt16(0),
                            SchemaId = sqlDataReader.GetInt32(1),
                            TableId = sqlDataReader.GetInt32(2),
                            DatabaseName = sqlDataReader.GetString(3),
                            SchemaName = sqlDataReader.GetString(4),
                            TableName = sqlDataReader.GetString(5),
                        };
                        tables.Add(database);
                    }
                }
                catch (Exception e)
                {

                    return null;
                }
                finally
                {
                    if (mySqlConnection.State != ConnectionState.Closed)
                    {
                        mySqlConnection.Close();
                    }
                }

                return tables.OrderBy(t => t.TableName).ToList();
            }
        }

        public bool Delete(int connectionId)
        {
            using (ItToolbeltContextMySql contextMySql = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                Connection connection = contextMySql.Connections.FirstOrDefault(c => c.Id == connectionId);
                if (connection is null)
                {
                    return false;
                }

                contextMySql.Connections.Remove(connection);
                bool changes = contextMySql.SaveChanges();
                return changes;
            }
        }

        public bool Update(Connection connection)
        {
            using (ItToolbeltContextMySql context = new ItToolbeltContextMySql(ConnectInfo.ConnectionString))
            {
                context.Entry(connection).State = EntityState.Modified;

                return context.SaveChanges();

            }
        }
    }
}