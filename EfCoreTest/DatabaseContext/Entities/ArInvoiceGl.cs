using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArInvoiceGl
    {
        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal GlIncome { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string AdjustmentFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AdjustmentNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullAccountNo { get; set; }
        public string Provider { get; set; }
        public string AdjustmentId { get; set; }
        public string CompanyId { get; set; }
        public string FullAccountId { get; set; }
        public string InvoiceId { get; set; }
        public string LineId { get; set; }
        public string InventoryFlag { get; set; }

        public ArInvoice ArInvoice { get; set; }
    }
}
