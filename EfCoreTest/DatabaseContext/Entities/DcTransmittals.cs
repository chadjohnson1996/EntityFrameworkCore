using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcTransmittals
    {
        public DcTransmittals()
        {
            DcMeetingMinutes = new HashSet<DcMeetingMinutes>();
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcMiscDocs = new HashSet<DcMiscDocs>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfcs = new HashSet<DcRfcs>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfis = new HashSet<DcRfis>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcRfps = new HashSet<DcRfps>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcSubmittals = new HashSet<DcSubmittals>();
            DcTransmittalAttachmentsDcTransmittals = new HashSet<DcTransmittalAttachments>();
            DcTransmittalAttachmentsDcTransmittalsNavigation = new HashSet<DcTransmittalAttachments>();
            DcTransmittalCorrespondences = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittalItems = new HashSet<DcTransmittalItems>();
            DcTransmittalRecipients = new HashSet<DcTransmittalRecipients>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcTransmittalNo { get; set; }
        public string ReferringTo { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string SentOrReceived { get; set; }
        public string FromCmContactNo { get; set; }
        public int? FromPersonLineNo { get; set; }
        public DateTime? FromContactDate { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime DocStatusDate { get; set; }
        public string SourceDocTypeNo { get; set; }
        public string FormPrintedFlag { get; set; }
        public string ToCmContactNo { get; set; }
        public int? ToPersonLineNo { get; set; }
        public DateTime? ToContactDate { get; set; }
        public string PrintOption { get; set; }
        public string PrintSubmittals { get; set; }
        public string PrintRfps { get; set; }
        public string PrintRfcs { get; set; }
        public string PrintRfis { get; set; }
        public string PrintSending1 { get; set; }
        public string PrintSending2 { get; set; }
        public string PrintSending3 { get; set; }
        public string PrintSending4 { get; set; }
        public string PrintSending5 { get; set; }
        public string PrintSending6 { get; set; }
        public string PrintSendingLbl1 { get; set; }
        public string PrintSendingLbl2 { get; set; }
        public string PrintSendingLbl3 { get; set; }
        public string PrintSendingLbl4 { get; set; }
        public string PrintSendingLbl5 { get; set; }
        public string PrintSendingLbl6 { get; set; }
        public string SubmittedForApproval { get; set; }
        public string SubmittedForYourUse { get; set; }
        public string SubmittedAsRequested { get; set; }
        public string SubmittedForReview { get; set; }
        public string ApprovedAsSubmitted { get; set; }
        public string ApprovedAsNoted { get; set; }
        public string ReviseAndResubmit { get; set; }
        public string RejectedFlag { get; set; }
        public int? WpDesignNo { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PrintSending7 { get; set; }
        public string PrintSendingLbl7 { get; set; }
        public string PrintSending8 { get; set; }
        public string PrintSendingLbl8 { get; set; }
        public string PrintSending9 { get; set; }
        public string PrintSendingLbl9 { get; set; }
        public string PrintSending10 { get; set; }
        public string PrintSendingLbl10 { get; set; }
        public string PrintSending11 { get; set; }
        public string PrintSendingLbl11 { get; set; }
        public string PrintSending12 { get; set; }
        public string PrintSendingLbl12 { get; set; }
        public string PrintSending13 { get; set; }
        public string PrintSendingLbl13 { get; set; }
        public string PrintSending14 { get; set; }
        public string PrintSendingLbl14 { get; set; }
        public string PrintSending15 { get; set; }
        public string PrintSendingLbl15 { get; set; }
        public string PrintSending16 { get; set; }
        public string PrintSendingLbl16 { get; set; }
        public string SubmittedFor1 { get; set; }
        public string SubmittedForLbl1 { get; set; }
        public string SubmittedFor2 { get; set; }
        public string SubmittedForLbl2 { get; set; }
        public string ActionRequired1 { get; set; }
        public string ActionRequiredLbl1 { get; set; }
        public string ActionRequired2 { get; set; }
        public string ActionRequiredLbl2 { get; set; }
        public string CompanyId { get; set; }
        public string DcTransmittalId { get; set; }
        public string DocStatusId { get; set; }
        public string FromCmContactId { get; set; }
        public string FromPersonLineId { get; set; }
        public string JobId { get; set; }
        public string SourceDocTypeId { get; set; }
        public string ToCmContactId { get; set; }
        public string ToPersonLineId { get; set; }
        public string WpDesignId { get; set; }
        public DateTime RespondByDate { get; set; }

        public DocStatuses DocStatuses { get; set; }
        public CmContactPersons From { get; set; }
        public CmContacts FromCmContactNoNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons To { get; set; }
        public CmContacts ToCmContactNoNavigation { get; set; }
        public ICollection<DcMeetingMinutes> DcMeetingMinutes { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocs { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfcs> DcRfcs { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfis> DcRfis { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcRfps> DcRfps { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcSubmittals> DcSubmittals { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachmentsDcTransmittals { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachmentsDcTransmittalsNavigation { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondences { get; set; }
        public ICollection<DcTransmittalItems> DcTransmittalItems { get; set; }
        public ICollection<DcTransmittalRecipients> DcTransmittalRecipients { get; set; }
    }
}
