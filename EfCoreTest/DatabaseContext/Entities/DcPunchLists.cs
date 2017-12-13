using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcPunchLists
    {
        public DcPunchLists()
        {
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcPunchListItems = new HashSet<DcPunchListItems>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcPunchListNo { get; set; }
        public int JobAreaLineNo { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcPunchListId { get; set; }
        public string DocStatusId { get; set; }
        public string JobAreaLineId { get; set; }
        public string JobId { get; set; }

        public DocStatuses DocStatuses { get; set; }
        public JobAreasD JobAreasD { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcPunchListItems> DcPunchListItems { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
    }
}
