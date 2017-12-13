using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchrecurring
    {
        public string Company { get; set; }
        public string UniqueIdn { get; set; }
        public string RecurringFrequency { get; set; }
        public DateTime? RecurringStartDate { get; set; }
        public DateTime? LastDate { get; set; }
        public DateTime? NextDate { get; set; }
        public string RecurringEndFlag { get; set; }
        public int? RecurringTechnician { get; set; }
        public int MaxOccurrences { get; set; }
        public DateTime? RecurringEndDate { get; set; }
        public string CreateUnassignedCall { get; set; }
        public string CopyLastBilling { get; set; }
        public string CreateInvoice { get; set; }
        public int Occurrences { get; set; }
        public int? InvoiceDesign { get; set; }
        public string UpdateInventory { get; set; }
        public string JobOption { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string CustomRecurringInfo { get; set; }
        public int? CustomRecurringDigit { get; set; }
        public string CompleteGenerationFlag { get; set; }
        public string LastRecurringUnique { get; set; }
    }
}
