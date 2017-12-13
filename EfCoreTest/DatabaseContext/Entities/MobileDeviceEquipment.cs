using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MobileDeviceEquipment
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string EquipmentNo { get; set; }
        public string AllowEquipment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string UserId { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
