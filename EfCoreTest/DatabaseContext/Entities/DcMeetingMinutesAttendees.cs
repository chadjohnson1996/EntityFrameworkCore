using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcMeetingMinutesAttendees
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string DcMeetingMinutesNo { get; set; }
        public int LineNo { get; set; }
        public string AttendeeContactNo { get; set; }
        public int? AttendeeContactLineNo { get; set; }
        public string AttendeeStatus { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttendeeContactLineId { get; set; }
        public string AttendeeContactId { get; set; }
        public string CompanyId { get; set; }
        public string DcMeetingMinutesId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string MeetingTypeId { get; set; }

        public CmContactPersons AttendeeContact { get; set; }
        public CmContacts AttendeeContactNoNavigation { get; set; }
        public DcMeetingMinutes DcMeetingMinutes { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
    }
}
