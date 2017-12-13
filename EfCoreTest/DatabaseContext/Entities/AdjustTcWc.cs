using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AdjustTcWc
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int SequenceNo { get; set; }
        public string AdjustingTcType { get; set; }
        public int LineNo { get; set; }
        public string WcState { get; set; }
        public string WcClassNo { get; set; }
        public decimal? Liability { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Exposure { get; set; }
        public decimal? Gross { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string SequenceId { get; set; }
        public string WcClassId { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal? EmployeeLiability { get; set; }
        public string EarnTypeId { get; set; }

        public AdjustTc AdjustTc { get; set; }
    }
}
