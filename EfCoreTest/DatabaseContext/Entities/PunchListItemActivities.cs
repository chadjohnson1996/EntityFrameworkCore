using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PunchListItemActivities
    {
        public int CompanyNo { get; set; }
        public string PunchListNo { get; set; }
        public int ItemLineNo { get; set; }
        public int LineNo { get; set; }
        public string DocActivityNo { get; set; }
        public string Description { get; set; }
        public DateTime ActivityDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocActivityId { get; set; }
        public string ItemLineId { get; set; }
        public string LineId { get; set; }
        public string PunchListId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public DocActivities DocActivities { get; set; }
        public Jobs Jobs { get; set; }
        public PunchListItems PunchListItems { get; set; }
    }
}
