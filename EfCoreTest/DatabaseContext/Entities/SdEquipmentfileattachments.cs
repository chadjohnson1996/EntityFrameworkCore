using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdEquipmentfileattachments
    {
        public int SequenceNumber { get; set; }
        public string Company { get; set; }
        public string SiteNumber { get; set; }
        public int EquipmentSequence { get; set; }
        public string FilePath { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
    }
}
