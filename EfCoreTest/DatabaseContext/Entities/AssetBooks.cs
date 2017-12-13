using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AssetBooks
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public int LineNo { get; set; }
        public string BookType { get; set; }
        public string Method { get; set; }
        public string MethodCode { get; set; }
        public decimal FixedAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string LineId { get; set; }

        public BookTypes BookTypes { get; set; }
        public DeprMethods DeprMethods { get; set; }
        public Equipment Equipment { get; set; }
    }
}
