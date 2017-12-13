using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PoSubChangeH
    {
        public PoSubChangeH()
        {
            ApInvoiceH = new HashSet<ApInvoiceH>();
            PoSubChangeBasicD = new HashSet<PoSubChangeBasicD>();
            PoSubChangeD = new HashSet<PoSubChangeD>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
        }

        public int CompanyNo { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string VendorNo { get; set; }
        public string Description { get; set; }
        public decimal? RetainagePercent { get; set; }
        public string Status { get; set; }
        public string VerifyDistributionTotals { get; set; }
        public string PrintedFlag { get; set; }
        public string BuyerNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ShipToNo { get; set; }
        public string TermsNo { get; set; }
        public string ShipViaNo { get; set; }
        public string Fob { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ManualClose { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BuyerId { get; set; }
        public string ShipToId { get; set; }
        public string ShipViaId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string PoSubId { get; set; }
        public string ChangeOrderId { get; set; }
        public string TermsId { get; set; }
        public string PrintableFlag { get; set; }
        public string HeaderFormat { get; set; }
        public string BodyFormat { get; set; }
        public string JobNo { get; set; }
        public decimal? GlExpense { get; set; }
        public string Instructions { get; set; }
        public string ShiptoAddressFlag { get; set; }
        public string OtherContact { get; set; }
        public string OtherAddress1 { get; set; }
        public string OtherAddress2 { get; set; }
        public string OtherCity { get; set; }
        public string OtherState { get; set; }
        public string OtherZipCode { get; set; }
        public string ShiptoJob { get; set; }
        public decimal TaxBase { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string JobId { get; set; }
        public string Format { get; set; }
        public int? DesignNo { get; set; }
        public string DesignId { get; set; }
        public string InsCertificate { get; set; }
        public DateTime? InsDateExpires { get; set; }
        public string JobChangeOrderNo { get; set; }
        public int JobChangeOrderSeq { get; set; }
        public string JobChangeOrderId { get; set; }
        public int? InternalBatchNumber { get; set; }
        public string HeaderOnFirstPage { get; set; }
        public string FooterComment { get; set; }
        public string PreviewFloatSummary { get; set; }
        public string PreviewPrintTitle { get; set; }
        public int? WpDesignNo { get; set; }
        public string WpDesignId { get; set; }
        public string FuelPayableFlag { get; set; }

        public ApShipTo ApShipTo { get; set; }
        public Buyers Buyers { get; set; }
        public PoSubH PoSubH { get; set; }
        public ShipVia ShipVia { get; set; }
        public Terms Terms { get; set; }
        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<PoSubChangeBasicD> PoSubChangeBasicD { get; set; }
        public ICollection<PoSubChangeD> PoSubChangeD { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
    }
}
