using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogTaskContacts
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int TaskLineNo { get; set; }
        public int LineNo { get; set; }
        public string TaskContactNo { get; set; }
        public int? TaskContactLineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcFieldLogId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string TaskContactLineId { get; set; }
        public string TaskContactId { get; set; }
        public string TaskLineId { get; set; }

        public DcFieldLogTasks DcFieldLogTasks { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons TaskContact { get; set; }
        public CmContacts TaskContactNoNavigation { get; set; }
    }
}
