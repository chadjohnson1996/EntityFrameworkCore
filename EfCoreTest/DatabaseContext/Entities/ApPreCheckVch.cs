using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPreCheckVch
    {
        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public int MultiCheck { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? RetainageAmount { get; set; }
        public decimal? ApAmount { get; set; }
        public string LineSelect { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public string Type { get; set; }
        public decimal GlCash { get; set; }
        public string Name { get; set; }

        public ApInvoiceD ApInvoiceD { get; set; }
        public ApPreCheck ApPreCheck { get; set; }
    }
}
