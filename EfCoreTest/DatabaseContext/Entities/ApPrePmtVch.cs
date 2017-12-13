using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPrePmtVch
    {
        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public int MultiPmt { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public string Type { get; set; }
        public decimal GlCash { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? ApAmount { get; set; }
        public string LineSelect { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PmtName { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public string MiscName { get; set; }

        public ApInvoiceD ApInvoiceD { get; set; }
        public ApPrePmt ApPrePmt { get; set; }
    }
}
