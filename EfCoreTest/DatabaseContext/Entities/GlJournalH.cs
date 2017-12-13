using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlJournalH
    {
        public GlJournalH()
        {
            GlJournalD = new HashSet<GlJournalD>();
        }

        public int CompanyNo { get; set; }
        public string JournalNo { get; set; }
        public int TransactionNo { get; set; }
        public DateTime? DateBooked { get; set; }
        public string Description { get; set; }
        public string VendorNo { get; set; }
        public int? VoucherNo { get; set; }
        public string ModuleFrom { get; set; }
        public int? AuditNumber { get; set; }
        public string ItemNo { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public string CustomerNo { get; set; }
        public string ArInvoiceNo { get; set; }
        public string OpInvoiceNo { get; set; }
        public string TmInvoiceNo { get; set; }
        public int? CashTrxNo { get; set; }
        public int? JobTrxNo { get; set; }
        public int? EqpTrxNo { get; set; }
        public string PostFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? NextLineNo { get; set; }
        public string ArInvoiceId { get; set; }
        public string CashTrxId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string EqpTrxId { get; set; }
        public string ItemId { get; set; }
        public string JobTrxId { get; set; }
        public string JournalId { get; set; }
        public string NextLineId { get; set; }
        public string OpInvoiceId { get; set; }
        public string TmInvoiceId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public int? InvActTrxNo { get; set; }
        public int? InvRcptTrxNo { get; set; }
        public string EquipmentNo { get; set; }
        public int? EqpExpJrnlTrxNo { get; set; }
        public int? EqpExpJrnlLineNo { get; set; }
        public int? EqpExpJrnlSeqNo { get; set; }
        public string EqpExpJrnlLineId { get; set; }
        public string EqpExpJrnlSeqId { get; set; }
        public string EqpExpJrnlTrxId { get; set; }
        public string EquipmentId { get; set; }
        public string InvActTrxId { get; set; }
        public string InvRcptTrxId { get; set; }
        public int? FaDeprJrnlTrxNo { get; set; }
        public string FaDeprJrnlTrxId { get; set; }
        public int? FuelTrxNo { get; set; }
        public string FuelTrxId { get; set; }

        public GlJournals GlJournals { get; set; }
        public ICollection<GlJournalD> GlJournalD { get; set; }
    }
}
