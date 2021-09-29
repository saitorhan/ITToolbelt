using System;
using System.Configuration;
using System.IO;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.WinForms
{
    public static class GlobalVariables
    {
        public static string DomainName => Environment.UserDomainName;
        public static string CurrentUser => Environment.UserName;
        public static string UserWithDomain => $"{DomainName}\\{CurrentUser}";

        public static DbServerType DbServerType
        {
            get
        {
            string serverType = ConfigurationManager.AppSettings["ServerType"];
            DbServerType dbServerType = (DbServerType)Enum.Parse(typeof(DbServerType), serverType);
            return dbServerType;
        }
        }
        public static string ConnectionString
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings[DbServerType == DbServerType.MsSql ? "ItToolbeltContext" : "ItToolbeltContextMySql"].ConnectionString;
                return connectionString;
            }
        }

        public static string DocPath
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = Path.Combine(path, "ItToolbelt");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                return path;
            }
        }

        public static ConnectInfo ConnectInfo => new ConnectInfo(ConnectionString, DbServerType);
    }

}