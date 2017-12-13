using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FieldLogMaterials
    {
        public int CompanyNo { get; set; }
        public string FieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string VendorNo { get; set; }
        public decimal Quantity { get; set; }
        public string UnitNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FieldLogId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string UnitId { get; set; }
        public string VendorId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public FieldLogs FieldLogs { get; set; }
        public Items Items { get; set; }
        public Jobs Jobs { get; set; }
        public Units Units { get; set; }
        public Vendors Vendors { get; set; }
    }
}
