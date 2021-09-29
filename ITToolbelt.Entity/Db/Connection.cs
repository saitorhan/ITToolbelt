using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ITToolbelt.Entity.Enum;

namespace ITToolbelt.Entity.Db
{
    public class Connection
    {
        public int Id { get; set; }

        [DisplayName("DB Server Type Code")]
        public DbServerType DbServerTypeCode { get; set; }

        [Required]
        [DisplayName("Connection Name")]
        [MaxLength(128)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        [DisplayName("Connection String")]
        public string ConnectionString { get; set; }

        [DisplayName("Creation Date")]
        [Required]
        public DateTime CreateDate { get; set; }

        [DisplayName("Date of update")]
        public DateTime? ModifiedDate { get; set; }

        #region FromServer

        [MaxLength(128)]
        [DisplayName("Machine Name")]
        public string MachineName { get; set; }
        [MaxLength(128)]
        [DisplayName("Server Name")]
        public string ServerName { get; set; }
        [MaxLength(128)]
        [DisplayName("Instance Name")]
        public string InstanceName { get; set; }
        [MaxLength(128)]
        [DisplayName("Edition")]
        public string Edition { get; set; }
        [MaxLength(128)]
        [DisplayName("Product Level")]
        public string ProductLevel { get; set; }
        [MaxLength(128)]
        [DisplayName("Product Update Level")]
        public string ProductUpdateLevel { get; set; }
        [MaxLength(128)]
        [DisplayName("Product Version")]
        public string ProductVersion { get; set; }
        [MaxLength(128)]
        [DisplayName("Collation")]
        public string Collation { get; set; }
        [MaxLength(128)]
        [DisplayName("Product Major Version")]
        public string ProductMajorVersion { get; set; }
        [MaxLength(128)]
        [DisplayName("Product Minor Version")]
        public string ProductMinorVersion { get; set; }

        [DisplayName("Connection Info")]
        [MaxLength(10)]
        public string ConnectionInfo { get; set; }
        

        #endregion FromServer

        [NotMapped]
        [DisplayName("DB Server Type")]
        public string DbServerType {
            get
            {
                switch (DbServerTypeCode)
                {
                    case Enum.DbServerType.MsSql:
                        return "Microsoft SQL Server";
                    case Enum.DbServerType.MySql:
                        return "MySQL Server";
                    default:
                        return "Unknown";
                }
            }}
        
    }
}