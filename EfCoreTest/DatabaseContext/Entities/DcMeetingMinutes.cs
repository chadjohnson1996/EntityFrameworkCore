using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcMeetingMinutes
    {
        public DcMeetingMinutes()
        {
            DcMeetingMinutesAttendees = new HashSet<DcMeetingMinutesAttendees>();
            DcMeetingMinutesTopics = new HashSet<DcMeetingMinutesTopics>();
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string DcMeetingMinutesNo { get; set; }
        public string Description { get; set; }
        public string CreateTransmittal { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string Location { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; }
        public string FormPrintedFlag { get; set; }
        public DateTime? NextMeetingDate { get; set; }
        public DateTime? NextMeetingTime { get; set; }
        public string NextMeetingLocation { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string DcMeetingMinutesId { get; set; }
        public string JobId { get; set; }
        public string MeetingTypeId { get; set; }

        public DcTransmittals DcTransmittals { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
        public ICollection<DcMeetingMinutesAttendees> DcMeetingMinutesAttendees { get; set; }
        public ICollection<DcMeetingMinutesTopics> DcMeetingMinutesTopics { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
    }
}
