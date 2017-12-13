using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PunchLists
    {
        public PunchLists()
        {
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfpAttachments = new HashSet<RfpAttachments>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string PunchListNo { get; set; }
        public string JobNo { get; set; }
        public int JobAreaLineNo { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocStatusId { get; set; }
        public string JobAreaLineId { get; set; }
        public string JobId { get; set; }
        public string PunchListId { get; set; }

        public JobAreasD JobAreasD { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
    }
}
