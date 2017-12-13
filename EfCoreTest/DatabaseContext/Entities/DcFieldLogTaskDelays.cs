using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogTaskDelays
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int TaskLineNo { get; set; }
        public int LineNo { get; set; }
        public string DelayNo { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcFieldLogId { get; set; }
        public string DelayId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string TaskLineId { get; set; }

        public DcFieldLogTasks DcFieldLogTasks { get; set; }
        public Jobs Jobs { get; set; }
    }
}
