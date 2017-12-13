using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayMisc
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string DeductionNo { get; set; }
        public string PayMethod { get; set; }
        public decimal? DeductionAmount { get; set; }
        public decimal? P401kEarnings { get; set; }
        public decimal? P401kMatching { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string VendorNo { get; set; }
        public string IntegrationType { get; set; }
        public string VendorId { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
        public Vendors Vendors { get; set; }
    }
}
