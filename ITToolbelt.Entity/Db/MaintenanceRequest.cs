using ITToolbelt.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITToolbelt.Entity.Db
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        public int ComputerId { get; set; }
        public DateTime CreateDate { get; set; }
        public MaintenanceStatus Status { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? ClosedBy { get; set; }
        public SystemUser ClosedByUser { get; set; }

        public Computer Computer { get; set; }


        public List<MaintenanceRequestItem> MaintenanceRequestItems { get; set; }
    }
}
