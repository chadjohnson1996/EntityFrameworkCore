using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocTypes
    {
        public DocTypes()
        {
            ControlDc = new HashSet<ControlDc>();
            ControlPm = new HashSet<ControlPm>();
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcMiscDocs = new HashSet<DcMiscDocs>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MiscDocActivities = new HashSet<MiscDocActivities>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocs = new HashSet<MiscDocs>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfpAttachments = new HashSet<RfpAttachments>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
            Transmittals = new HashSet<Transmittals>();
        }

        public int CompanyNo { get; set; }
        public string DocTypeNo { get; set; }
        public string Description { get; set; }
        public string CreateTransmittal { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocTypeId { get; set; }

        public ICollection<ControlDc> ControlDc { get; set; }
        public ICollection<ControlPm> ControlPm { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocs { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivities { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocs { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
        public ICollection<Transmittals> Transmittals { get; set; }
    }
}
