using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Emp401kLevels
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string P401kDeductionNo { get; set; }
        public int LineNo { get; set; }
        public decimal? EmployerPercent { get; set; }
        public decimal? EmployeePercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string P401kDeductionId { get; set; }

        public Emp401k Emp401k { get; set; }
    }
}
