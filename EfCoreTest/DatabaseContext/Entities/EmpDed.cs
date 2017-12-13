using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpDed
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string DeductionNo { get; set; }
        public string PayCycle { get; set; }
        public string OneTime { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Hourly { get; set; }
        public decimal? Fixed { get; set; }
        public decimal? Limit { get; set; }
        public decimal? ToDate { get; set; }
        public int LineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string VendorNo { get; set; }
        public string VendorId { get; set; }
        public DateTime? HoldThruDate { get; set; }

        public Deductions Deductions { get; set; }
        public Employees Employees { get; set; }
        public Vendors Vendors { get; set; }
    }
}
