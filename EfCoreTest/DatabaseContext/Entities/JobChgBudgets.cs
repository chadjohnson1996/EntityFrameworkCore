using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobChgBudgets
    {
        public int CompanyNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal? CostAdj { get; set; }
        public decimal? UnitAdj { get; set; }
        public decimal QuantityAdj { get; set; }
        public decimal IncomeAdj { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string VendorNo { get; set; }
        public int LineNo { get; set; }
        public string LineId { get; set; }
        public string VendorId { get; set; }

        public Vendors Vendors { get; set; }
    }
}
