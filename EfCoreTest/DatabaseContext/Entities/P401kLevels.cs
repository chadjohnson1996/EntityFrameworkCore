using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class P401kLevels
    {
        public int CompanyNo { get; set; }
        public string P401kDeductionNo { get; set; }
        public int LineNo { get; set; }
        public decimal? EmployerPercent { get; set; }
        public decimal? EmployeePercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string P401kDeductionId { get; set; }

        public P401k P401k { get; set; }
    }
}
