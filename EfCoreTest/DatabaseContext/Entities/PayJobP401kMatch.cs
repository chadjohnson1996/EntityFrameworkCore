using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayJobP401kMatch
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public int ComputeSequence { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeFlag { get; set; }
        public string PayMethod { get; set; }
        public string EarnTypeNo { get; set; }
        public string DeptNo { get; set; }
        public string DedCostCodeNo { get; set; }
        public string DedCostClassNo { get; set; }
        public decimal? Dollars { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string DedCostClassId { get; set; }
        public string DedCostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }

        public Employees Employees { get; set; }
    }
}
