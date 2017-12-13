using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisSumMisc
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Year { get; set; }
        public string DeductionNo { get; set; }
        public decimal? DeductionAmount { get; set; }
        public decimal? P401kEarnings { get; set; }
        public decimal? P401kMatch { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }
        public string EmployeeId { get; set; }

        public Employees Employees { get; set; }
    }
}
