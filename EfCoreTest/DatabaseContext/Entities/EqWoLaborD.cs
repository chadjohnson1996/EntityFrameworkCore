using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoLaborD
    {
        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public int LineNo { get; set; }
        public int TransferLineNo { get; set; }
        public string Source { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal Hours { get; set; }
        public decimal PayRate { get; set; }
        public decimal Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EqWoId { get; set; }
        public string LineId { get; set; }
        public string ServiceCodeId { get; set; }
        public string TransferLineId { get; set; }
        public decimal PayFactor { get; set; }
        public string TimecardDesc { get; set; }

        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public EqWo EqWo { get; set; }
    }
}
