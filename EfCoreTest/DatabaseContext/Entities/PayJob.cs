using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayJob
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeFlag { get; set; }
        public string PayMethod { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Dollars { get; set; }
        public decimal? Fica { get; set; }
        public decimal? UniFringe { get; set; }
        public string CostClassNo { get; set; }
        public decimal? Burden { get; set; }
        public decimal? WorkersComp { get; set; }
        public decimal? Futa { get; set; }
        public decimal? Suta { get; set; }
        public decimal? P401kMatch { get; set; }
        public decimal? Equipment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }
        public string DeptNo { get; set; }
        public string DeptId { get; set; }
        public int ComputeSequence { get; set; }
        public decimal? BurdenToPost { get; set; }
        public decimal? P401kMatchToPost { get; set; }

        public Employees Employees { get; set; }
    }
}
