using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeductionExempt
    {
        public int CompanyNo { get; set; }
        public string DeductionNo { get; set; }
        public string ExemptDeduction { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeductionId { get; set; }

        public Deductions Deductions { get; set; }
        public Deductions DeductionsNavigation { get; set; }
    }
}
