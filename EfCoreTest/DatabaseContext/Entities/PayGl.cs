using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayGl
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public decimal AccountNo { get; set; }
        public string JobNo { get; set; }
        public string PayMethod { get; set; }
        public decimal? AmountDb { get; set; }
        public decimal? AmountCr { get; set; }
        public decimal? BaseAccount { get; set; }
        public decimal? DivAccount1 { get; set; }
        public decimal? DivAccount2 { get; set; }
        public decimal? DivAccount3 { get; set; }
        public decimal? DivAccount4 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccountId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string PayPeriodId { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
    }
}
