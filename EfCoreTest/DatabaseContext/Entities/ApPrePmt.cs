using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPrePmt
    {
        public ApPrePmt()
        {
            ApPrePmtVch = new HashSet<ApPrePmtVch>();
        }

        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public int MultiPmt { get; set; }
        public string PmtName { get; set; }
        public string JointName { get; set; }
        public string ReferenceNo { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public decimal GlCash { get; set; }
        public int? TransactionNo { get; set; }
        public DateTime? PmtDate { get; set; }
        public string JobNo { get; set; }
        public string PayRetainage { get; set; }
        public decimal RetainagePercent { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string IncludeHeldInvoice { get; set; }
        public string TransDescription { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string ReferenceId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
        public string MiscName { get; set; }
        public string AchFlag { get; set; }

        public ICollection<ApPrePmtVch> ApPrePmtVch { get; set; }
    }
}
