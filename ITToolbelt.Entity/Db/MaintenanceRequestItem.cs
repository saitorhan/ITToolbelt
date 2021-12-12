using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITToolbelt.Entity.Db
{
    public class MaintenanceRequestItem
    {
        public int Id { get; set; }
        public int MaintenanceRequestId { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public bool Installed { get; set; }
        public int? InstalledBy { get; set; }
        public SystemUser InstalledByUser { get; set; }

        public MaintenanceRequest MaintenanceRequest { get; set; }
    }
}
