using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MeetingAgendas
    {
        public MeetingAgendas()
        {
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MeetingAgendaTopicsMeetingAgendas = new HashSet<MeetingAgendaTopics>();
            MeetingAgendaTopicsMeetingAgendasNavigation = new HashSet<MeetingAgendaTopics>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfpAttachments = new HashSet<RfpAttachments>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string MeetingAgendaNo { get; set; }
        public string Description { get; set; }
        public string JobNo { get; set; }
        public string MeetingTypeNo { get; set; }
        public string CreateTransmittal { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string Location { get; set; }
        public DateTime MeetingDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; }
        public string FormPrintedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string MeetingAgendaId { get; set; }
        public string MeetingTypeId { get; set; }

        public Jobs Jobs { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopicsMeetingAgendas { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopicsMeetingAgendasNavigation { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
    }
}
