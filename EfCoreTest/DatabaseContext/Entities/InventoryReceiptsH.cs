using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryReceiptsH
    {
        public InventoryReceiptsH()
        {
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string PoSubNo { get; set; }
        public DateTime DateReceived { get; set; }
        public string VendorNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? ApVoucherNo { get; set; }
        public string ApVoucherId { get; set; }
        public string CompanyId { get; set; }
        public string PoSubId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
        public string Comment { get; set; }
        public string DcFieldLogJobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public string DcFieldLogJobId { get; set; }
        public string DcFieldLogId { get; set; }
        public string WarehouseOrJobTransfer { get; set; }
        public string DefaultWarehouseNo { get; set; }
        public string DefaultTaxNo { get; set; }
        public string IncludeInAvgCost { get; set; }
        public string Source { get; set; }
        public string DefaultTaxId { get; set; }
        public string DefaultWarehouseId { get; set; }
        public string ReversalFlag { get; set; }
        public int? OriginalTransactionNo { get; set; }
        public int? ReversalTransactionNo { get; set; }
        public string OriginalTransactionId { get; set; }
        public string ReversalTransactionId { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public DcFieldLogs DcFieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public PoSubH PoSubH { get; set; }
        public Vendors Vendors { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
    }
}
