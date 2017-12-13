using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RfiQuestions
    {
        public RfiQuestions()
        {
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            RfiQuestionActivities = new HashSet<RfiQuestionActivities>();
        }

        public int CompanyNo { get; set; }
        public string RfiNo { get; set; }
        public int LineNo { get; set; }
        public string DocQuestionNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string Question { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocQuestionId { get; set; }
        public string DocStatusId { get; set; }
        public string LineId { get; set; }
        public string RfiId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public DocStatuses DocStatuses { get; set; }
        public Jobs Jobs { get; set; }
        public Rfis Rfis { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivities { get; set; }
    }
}
