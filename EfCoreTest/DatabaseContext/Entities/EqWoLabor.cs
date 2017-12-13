using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoLabor
    {
        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public int LineNo { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? EstimateHours { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal ActualHours { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EqWoId { get; set; }
        public string LineId { get; set; }
        public string ServiceCodeId { get; set; }

        public Employees Employees { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public EqWo EqWo { get; set; }
    }
}
