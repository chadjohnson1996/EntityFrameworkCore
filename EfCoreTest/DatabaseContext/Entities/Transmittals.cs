using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Transmittals
    {
        public Transmittals()
        {
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            MiscDocs = new HashSet<MiscDocs>();
            RfcAttachments = new HashSet<RfcAttachments>();
            Rfcs = new HashSet<Rfcs>();
            RfiAttachments = new HashSet<RfiAttachments>();
            Rfis = new HashSet<Rfis>();
            RfpAttachments = new HashSet<RfpAttachments>();
            Rfps = new HashSet<Rfps>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            Submittals = new HashSet<Submittals>();
            TransmittalActivities = new HashSet<TransmittalActivities>();
            TransmittalAttachmentsTransmittals = new HashSet<TransmittalAttachments>();
            TransmittalAttachmentsTransmittalsNavigation = new HashSet<TransmittalAttachments>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
        }

        public int CompanyNo { get; set; }
        public string TransmittalNo { get; set; }
        public string JobNo { get; set; }
        public string Referencing { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public string SentOrReceived { get; set; }
        public string FromContactType { get; set; }
        public string FromCustomerNo { get; set; }
        public string FromVendorNo { get; set; }
        public string FromEmployeeNo { get; set; }
        public string FromProjectManagerNo { get; set; }
        public string FromBuyerNo { get; set; }
        public string FromMiscContactNo { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string SourceDocTypeNo { get; set; }
        public string FormPrintedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string CompanyId { get; set; }
        public string DocStatusId { get; set; }
        public string FromBuyerId { get; set; }
        public string FromCustomerId { get; set; }
        public string FromEmployeeId { get; set; }
        public string FromMiscContactId { get; set; }
        public string FromProjectManagerId { get; set; }
        public string FromVendorId { get; set; }
        public string JobId { get; set; }
        public string SourceDocTypeId { get; set; }
        public string TransmittalId { get; set; }
        public string OwnerDocNo { get; set; }
        public string ToContactType { get; set; }
        public string ToCustomerNo { get; set; }
        public string ToVendorNo { get; set; }
        public string ToEmployeeNo { get; set; }
        public string ToProjectManagerNo { get; set; }
        public string ToBuyerNo { get; set; }
        public string ToMiscContactNo { get; set; }
        public DateTime? FromContactDate { get; set; }
        public DateTime? ToContactDate { get; set; }
        public string PassOn { get; set; }
        public string DocumentFolder { get; set; }
        public string DocumentFile { get; set; }
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
        public string OwnerDocId { get; set; }
        public string ToBuyerId { get; set; }
        public string ToCustomerId { get; set; }
        public string ToEmployeeId { get; set; }
        public string ToMiscContactId { get; set; }
        public string ToProjectManagerId { get; set; }
        public string ToVendorId { get; set; }
        public int? WpDesignNo { get; set; }
        public string WpDesignId { get; set; }

        public Buyers Buyers { get; set; }
        public Buyers BuyersNavigation { get; set; }
        public Customers Customers { get; set; }
        public Customers CustomersNavigation { get; set; }
        public DocTypes DocTypes { get; set; }
        public Employees Employees { get; set; }
        public Employees EmployeesNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public MiscContacts MiscContactsNavigation { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public ProjectManagers ProjectManagersNavigation { get; set; }
        public Vendors Vendors { get; set; }
        public Vendors VendorsNavigation { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<MiscDocs> MiscDocs { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<Rfcs> Rfcs { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<Rfis> Rfis { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<Rfps> Rfps { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<Submittals> Submittals { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivities { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachmentsTransmittals { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachmentsTransmittalsNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
    }
}
