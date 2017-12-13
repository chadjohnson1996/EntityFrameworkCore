using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MiscDocs
    {
        public MiscDocs()
        {
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MiscDocActivities = new HashSet<MiscDocActivities>();
            MiscDocAttachmentsMiscDocs = new HashSet<MiscDocAttachments>();
            MiscDocAttachmentsMiscDocsNavigation = new HashSet<MiscDocAttachments>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfpAttachments = new HashSet<RfpAttachments>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string MiscDocNo { get; set; }
        public string MiscDocTypeNo { get; set; }
        public string JobNo { get; set; }
        public string CreateTransmittal { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string Referencing { get; set; }
        public string Description { get; set; }
        public string SentOrReceived { get; set; }
        public string FromContactType { get; set; }
        public string FromCustomerNo { get; set; }
        public string FromVendorNo { get; set; }
        public string FromEmployeeNo { get; set; }
        public string FromProjectManagerNo { get; set; }
        public string FromBuyerNo { get; set; }
        public string FromMiscContactNo { get; set; }
        public DateTime? ExpectedResponseDate { get; set; }
        public DateTime RespondByDate { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PassOn { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string DocStatusId { get; set; }
        public string FromBuyerId { get; set; }
        public string FromCustomerId { get; set; }
        public string FromEmployeeId { get; set; }
        public string FromMiscContactId { get; set; }
        public string FromProjectManagerId { get; set; }
        public string FromVendorId { get; set; }
        public string JobId { get; set; }
        public string MiscDocId { get; set; }
        public string MiscDocTypeId { get; set; }
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
        public string DocumentFolder { get; set; }
        public string DocumentFile { get; set; }
        public string OwnerDocId { get; set; }
        public string ToBuyerId { get; set; }
        public string ToCustomerId { get; set; }
        public string ToEmployeeId { get; set; }
        public string ToMiscContactId { get; set; }
        public string ToProjectManagerId { get; set; }
        public string ToVendorId { get; set; }
        public int? WpDesignNo { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public string WpDesignId { get; set; }

        public Buyers Buyers { get; set; }
        public Buyers BuyersNavigation { get; set; }
        public Customers Customers { get; set; }
        public Customers CustomersNavigation { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public DocTypes DocTypes { get; set; }
        public Employees Employees { get; set; }
        public Employees EmployeesNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public MiscContacts MiscContactsNavigation { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public ProjectManagers ProjectManagersNavigation { get; set; }
        public Transmittals Transmittals { get; set; }
        public Vendors Vendors { get; set; }
        public Vendors VendorsNavigation { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivities { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachmentsMiscDocs { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachmentsMiscDocsNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
    }
}
