using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryActivityH
    {
        public InventoryActivityH()
        {
            InventoryActivityD = new HashSet<InventoryActivityD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public string Source { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string EqWoNo { get; set; }
        public int? EqWoTrxNo { get; set; }
        public string ArInvoiceSource { get; set; }
        public string ArInvoiceNo { get; set; }
        public string ArOriginalInvoiceNo { get; set; }
        public int? ApVoucherNo { get; set; }
        public string ApVoucherId { get; set; }
        public string ArInvoiceId { get; set; }
        public string ArOriginalInvoiceId { get; set; }
        public string CompanyId { get; set; }
        public string EqWoId { get; set; }
        public string EqWoTrxId { get; set; }
        public string TransactionId { get; set; }
        public int? InWoNo { get; set; }
        public string InWoId { get; set; }
        public string HoldFlag { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public ArInvoice ArInvoice { get; set; }
        public EqWo EqWo { get; set; }
        public EqWoJournal EqWoJournal { get; set; }
        public InventoryWorksheetsH InventoryWorksheetsH { get; set; }
        public ICollection<InventoryActivityD> InventoryActivityD { get; set; }
    }
}
