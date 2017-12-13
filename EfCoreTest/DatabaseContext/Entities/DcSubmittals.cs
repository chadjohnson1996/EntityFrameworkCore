using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcSubmittals
    {
        public DcSubmittals()
        {
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcSubmittalCorrespondences = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalItems = new HashSet<DcSubmittalItems>();
            DcSubmittalRecipients = new HashSet<DcSubmittalRecipients>();
            DcSubmittalRevisions = new HashSet<DcSubmittalRevisions>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SubmittalPackageNo { get; set; }
        public string DcSubmittalNo { get; set; }
        public string Description { get; set; }
        public string CreateTransmittal { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public string DocStatusNo { get; set; }
        public string BallInCourtNo { get; set; }
        public string FromCmContactNo { get; set; }
        public DateTime? FromContactDate { get; set; }
        public string ToCmContactNo { get; set; }
        public DateTime? ToContactDate { get; set; }
        public string ReturnedCmContactNo { get; set; }
        public DateTime? ReturnedContactDate { get; set; }
        public string FwdCmContactNo { get; set; }
        public DateTime? FwdContactDate { get; set; }
        public string Remarks { get; set; }
        public int? WpDesignNo { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string BicContactType { get; set; }
        public int? BicPersonLineNo { get; set; }
        public int? FromPersonLineNo { get; set; }
        public int? ToPersonLineNo { get; set; }
        public int? ReturnedPersonLineNo { get; set; }
        public int? FwdPersonLineNo { get; set; }
        public string OwnerNo { get; set; }
        public string SentOrReceived { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DcDisciplineNo { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string BallInCourtId { get; set; }
        public string BicPersonLineId { get; set; }
        public string CompanyId { get; set; }
        public string DcDisciplineId { get; set; }
        public string DcSubmittalId { get; set; }
        public string DocStatusId { get; set; }
        public string FromCmContactId { get; set; }
        public string FromPersonLineId { get; set; }
        public string FwdCmContactId { get; set; }
        public string FwdPersonLineId { get; set; }
        public string JobId { get; set; }
        public string OwnerId { get; set; }
        public string ReturnedCmContactId { get; set; }
        public string ReturnedPersonLineId { get; set; }
        public string SubmittalPackageId { get; set; }
        public string ToCmContactId { get; set; }
        public string ToPersonLineId { get; set; }
        public string WpDesignId { get; set; }

        public DcDisciplines DcDisciplines { get; set; }
        public DcTransmittals DcTransmittals { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public CmContactPersons From { get; set; }
        public CmContacts FromCmContactNoNavigation { get; set; }
        public CmContactPersons Fwd { get; set; }
        public CmContacts FwdCmContactNoNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons Returned { get; set; }
        public CmContacts ReturnedCmContactNoNavigation { get; set; }
        public CmContactPersons To { get; set; }
        public CmContacts ToCmContactNoNavigation { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondences { get; set; }
        public ICollection<DcSubmittalItems> DcSubmittalItems { get; set; }
        public ICollection<DcSubmittalRecipients> DcSubmittalRecipients { get; set; }
        public ICollection<DcSubmittalRevisions> DcSubmittalRevisions { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
    }
}
