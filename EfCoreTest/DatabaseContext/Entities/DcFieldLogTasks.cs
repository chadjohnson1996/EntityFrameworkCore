using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogTasks
    {
        public DcFieldLogTasks()
        {
            DcFieldLogTaskContacts = new HashSet<DcFieldLogTaskContacts>();
            DcFieldLogTaskDelays = new HashSet<DcFieldLogTaskDelays>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string DcTaskNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string Description { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcFieldLogId { get; set; }
        public string DcTaskId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }

        public DcFieldLogs DcFieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<DcFieldLogTaskContacts> DcFieldLogTaskContacts { get; set; }
        public ICollection<DcFieldLogTaskDelays> DcFieldLogTaskDelays { get; set; }
    }
}
