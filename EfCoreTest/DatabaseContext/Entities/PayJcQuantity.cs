using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayJcQuantity
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public string JobNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string TimecardType { get; set; }
        public DateTime? Dated { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal JcQuantity { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string TransactionId { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
    }
}
