using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SubmittalItems
    {
        public SubmittalItems()
        {
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            SubmittalItemActivities = new HashSet<SubmittalItemActivities>();
        }

        public int CompanyNo { get; set; }
        public string SubmittalNo { get; set; }
        public int LineNo { get; set; }
        public string DocItemNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string Description { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocItemId { get; set; }
        public string DocStatusId { get; set; }
        public string LineId { get; set; }
        public string SubmittalId { get; set; }
        public string SubmittalTypeNo { get; set; }
        public int NbrCopies { get; set; }
        public string SubmittalTypeId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public DocStatuses DocStatuses { get; set; }
        public Jobs Jobs { get; set; }
        public SubmittalTypes SubmittalTypes { get; set; }
        public Submittals Submittals { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivities { get; set; }
    }
}
