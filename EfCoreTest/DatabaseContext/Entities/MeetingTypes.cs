using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MeetingTypes
    {
        public MeetingTypes()
        {
            ControlDc = new HashSet<ControlDc>();
            ControlPm = new HashSet<ControlPm>();
            DcMeetingMinutes = new HashSet<DcMeetingMinutes>();
            DcMeetingMinutesAttendees = new HashSet<DcMeetingMinutesAttendees>();
            DcMeetingMinutesTopicContacts = new HashSet<DcMeetingMinutesTopicContacts>();
            DcMeetingMinutesTopics = new HashSet<DcMeetingMinutesTopics>();
            MeetingAgendas = new HashSet<MeetingAgendas>();
        }

        public int CompanyNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MeetingTypeId { get; set; }

        public ICollection<ControlDc> ControlDc { get; set; }
        public ICollection<ControlPm> ControlPm { get; set; }
        public ICollection<DcMeetingMinutes> DcMeetingMinutes { get; set; }
        public ICollection<DcMeetingMinutesAttendees> DcMeetingMinutesAttendees { get; set; }
        public ICollection<DcMeetingMinutesTopicContacts> DcMeetingMinutesTopicContacts { get; set; }
        public ICollection<DcMeetingMinutesTopics> DcMeetingMinutesTopics { get; set; }
        public ICollection<MeetingAgendas> MeetingAgendas { get; set; }
    }
}
