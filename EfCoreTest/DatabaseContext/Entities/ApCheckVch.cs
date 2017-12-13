using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApCheckVch
    {
        public int CompanyNo { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string VoidFlag { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? ApAmount { get; set; }
        public string TaxNo { get; set; }
        public decimal? TaxBasePaid { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string TaxId { get; set; }
        public string VoucherId { get; set; }
        public string Type { get; set; }

        public ApCheck ApCheck { get; set; }
        public ApInvoiceD ApInvoiceD { get; set; }
    }
}
