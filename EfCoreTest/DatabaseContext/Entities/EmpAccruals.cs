using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpAccruals
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int LineNo { get; set; }
        public decimal? Hours { get; set; }
        public decimal? HoursWorked { get; set; }
        public string Type { get; set; }
        public string EarnTypeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }

        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
    }
}
