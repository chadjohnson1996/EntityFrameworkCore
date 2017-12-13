using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpRateChanges
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? NewRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? ActualEffectiveDate { get; set; }

        public Employees Employees { get; set; }
    }
}
