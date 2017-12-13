using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPmt
    {
        public ApPmt()
        {
            ApPmtVch = new HashSet<ApPmtVch>();
        }

        public int CompanyNo { get; set; }
        public decimal GlCash { get; set; }
        public int TransactionNo { get; set; }
        public string VoidFlag { get; set; }
        public string VendorNo { get; set; }
        public int? MultiPmt { get; set; }
        public DateTime? PmtDate { get; set; }
        public string PmtType { get; set; }
        public int? FirstPmtInSet { get; set; }
        public int? LastPmtInSet { get; set; }
        public string PmtName { get; set; }
        public string JointName { get; set; }
        public string ReferenceNo { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string TransDescription { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ReferenceId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
        public string AchFlag { get; set; }
        public int? VndDirPayBatchNo { get; set; }
        public string VndDirPayBatchId { get; set; }
        public string PrepaidFlag { get; set; }
        public int? AuditNumber { get; set; }

        public HisVndDirPay HisVndDirPay { get; set; }
        public ICollection<ApPmtVch> ApPmtVch { get; set; }
    }
}
