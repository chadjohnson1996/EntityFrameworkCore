using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpEmploymentActionChanges
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int LineNo { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionType { get; set; }
        public string TerminationReason { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangedFromFlag { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }

        public Employees Employees { get; set; }
    }
}
