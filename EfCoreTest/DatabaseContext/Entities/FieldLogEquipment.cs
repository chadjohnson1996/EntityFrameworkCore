using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FieldLogEquipment
    {
        public int CompanyNo { get; set; }
        public string FieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string EquipmentNo { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public string EquipUsageType { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string FieldLogId { get; set; }
        public string LineId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public Equipment Equipment { get; set; }
        public FieldLogs FieldLogs { get; set; }
        public Jobs Jobs { get; set; }
    }
}
