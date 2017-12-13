using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpPayPeriods
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int LineNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }

        public Employees Employees { get; set; }
        public PayPeriods PayPeriods { get; set; }
    }
}
