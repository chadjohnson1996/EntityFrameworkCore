using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisEmpAcaMeasGroups
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime DateAssigned { get; set; }
        public string MeasurementGroupNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string MeasurementGroupId { get; set; }

        public Employees Employees { get; set; }
    }
}
