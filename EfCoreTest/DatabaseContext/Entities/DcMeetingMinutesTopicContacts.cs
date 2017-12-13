using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcMeetingMinutesTopicContacts
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string DcMeetingMinutesNo { get; set; }
        public int TopicLineNo { get; set; }
        public int LineNo { get; set; }
        public string TopicContactNo { get; set; }
        public int? TopicContactLineNo { get; set; }
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
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string MeetingTypeId { get; set; }
        public string TopicContactLineId { get; set; }
        public string TopicContactId { get; set; }
        public string TopicLineId { get; set; }

        public DcMeetingMinutesTopics DcMeetingMinutesTopics { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
        public CmContactPersons TopicContact { get; set; }
        public CmContacts TopicContactNoNavigation { get; set; }
    }
}
