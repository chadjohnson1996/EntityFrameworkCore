using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcMeetingMinutesTopics
    {
        public DcMeetingMinutesTopics()
        {
            DcMeetingMinutesTopicContacts = new HashSet<DcMeetingMinutesTopicContacts>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string DcMeetingMinutesNo { get; set; }
        public int LineNo { get; set; }
        public string DocItemNo { get; set; }
        public string TopicTypeNo { get; set; }
        public string Description { get; set; }
        public int OrdinalPosition { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? InitialDueDate { get; set; }
        public DateTime? NewDueDate { get; set; }
        public DateTime? CompleteDate { get; set; }
        public string ClosedFlag { get; set; }
        public string ClosedInNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ClosedInId { get; set; }
        public string CompanyId { get; set; }
        public string DcMeetingMinutesId { get; set; }
        public string DocItemId { get; set; }
        public string DocStatusId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string MeetingTypeId { get; set; }
        public string TopicTypeId { get; set; }

        public DcMeetingMinutes DcMeetingMinutes { get; set; }
        public DcTopicTypes DcTopicTypes { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
        public ICollection<DcMeetingMinutesTopicContacts> DcMeetingMinutesTopicContacts { get; set; }
    }
}
