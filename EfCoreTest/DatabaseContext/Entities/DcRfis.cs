using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcRfis
    {
        public DcRfis()
        {
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfiCorrespondences = new HashSet<DcRfiCorrespondences>();
            DcRfiRecipients = new HashSet<DcRfiRecipients>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcRfiNo { get; set; }
        public string Description { get; set; }
        public string CreateTransmittal { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string DcPriorityNo { get; set; }
        public string DcDisciplineNo { get; set; }
        public string DcCategoryNo { get; set; }
        public string SentOrReceived { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime RespondByDate { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime DocStatusDate { get; set; }
        public string FromCmContactNo { get; set; }
        public int? FromPersonLineNo { get; set; }
        public DateTime? FromContactDate { get; set; }
        public int? ToPersonLineNo { get; set; }
        public string ToCmContactNo { get; set; }
        public DateTime? ToContactDate { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Remarks { get; set; }
        public int? WpDesignNo { get; set; }
        public DateTime? RowPrintedOn { get; set; }
        public decimal CostImpact { get; set; }
        public string CostImpactDesc { get; set; }
        public decimal ScheduleImpact { get; set; }
        public string ScheduleImpactDesc { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string DcCategoryId { get; set; }
        public string DcDisciplineId { get; set; }
        public string DcPriorityId { get; set; }
        public string DcRfiId { get; set; }
        public string DocStatusId { get; set; }
        public string FromCmContactId { get; set; }
        public string FromPersonLineId { get; set; }
        public string JobId { get; set; }
        public string ToCmContactId { get; set; }
        public string ToPersonLineId { get; set; }
        public string WpDesignId { get; set; }

        public DcCategories DcCategories { get; set; }
        public DcDisciplines DcDisciplines { get; set; }
        public DcPriorities DcPriorities { get; set; }
        public DcTransmittals DcTransmittals { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public CmContactPersons From { get; set; }
        public CmContacts FromCmContactNoNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons To { get; set; }
        public CmContacts ToCmContactNoNavigation { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfiCorrespondences> DcRfiCorrespondences { get; set; }
        public ICollection<DcRfiRecipients> DcRfiRecipients { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
    }
}
