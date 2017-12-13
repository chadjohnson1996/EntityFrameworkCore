using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApInvoiceSubtierVendors
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public string VendorNo { get; set; }
        public string ReceivedFromVendor { get; set; }
        public string RecordStatus { get; set; }
        public string CopiedFromPo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public Vendors Vendors { get; set; }
    }
}
