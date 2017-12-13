using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoNonInv
    {
        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqWoId { get; set; }
        public string LineId { get; set; }
        public string UnitId { get; set; }
        public decimal UsedQuantity { get; set; }
        public decimal UsedUnitCost { get; set; }
        public string UsedFlag { get; set; }
        public string ServiceCodeNo { get; set; }
        public decimal UsedExtCost { get; set; }
        public int? ApLineNo { get; set; }
        public string SourceFrom { get; set; }
        public int? ApVoucherNo { get; set; }
        public string ApLineId { get; set; }
        public string ApVoucherId { get; set; }
        public string ServiceCodeId { get; set; }

        public EqWo EqWo { get; set; }
        public Units Units { get; set; }
    }
}
