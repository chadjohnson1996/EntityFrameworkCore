using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PoSubH
    {
        public PoSubH()
        {
            ApInvoiceH = new HashSet<ApInvoiceH>();
            DcFieldLogMaterials = new HashSet<DcFieldLogMaterials>();
            InventoryReceiptsH = new HashSet<InventoryReceiptsH>();
            PoSubBasicD = new HashSet<PoSubBasicD>();
            PoSubChangeD = new HashSet<PoSubChangeD>();
            PoSubChangeH = new HashSet<PoSubChangeH>();
            PoSubCorrespondences = new HashSet<PoSubCorrespondences>();
            PoSubD = new HashSet<PoSubD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            PoSubSubtierVendors = new HashSet<PoSubSubtierVendors>();
        }

        public int CompanyNo { get; set; }
        public string PoSubNo { get; set; }
        public string Type { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string VendorNo { get; set; }
        public string JobNo { get; set; }
        public string Description { get; set; }
        public decimal? RetainagePercent { get; set; }
        public decimal? GlExpense { get; set; }
        public string Status { get; set; }
        public string VerifyDistributionTotals { get; set; }
        public string PrintedFlag { get; set; }
        public string BuyerNo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string ShipToNo { get; set; }
        public string TermsNo { get; set; }
        public string ShipViaNo { get; set; }
        public string Fob { get; set; }
        public string InvoiceChgOrdAgainst { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ManualClose { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BuyerId { get; set; }
        public string JobId { get; set; }
        public string ShipToId { get; set; }
        public string ShipViaId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string PoSubId { get; set; }
        public string TermsId { get; set; }
        public string LienWaiverFlag { get; set; }
        public string WaiverDescription { get; set; }
        public string WaiverTradeWork { get; set; }
        public string WaiverTitle { get; set; }
        public string WaiverSignatureName { get; set; }
        public string WaiverJobOwner { get; set; }
        public string WaiverJobAddress1 { get; set; }
        public string WaiverJobAddress2 { get; set; }
        public string WaiverJobCity { get; set; }
        public string WaiverJobState { get; set; }
        public string WaiverJobZipCode { get; set; }
        public string WaiverJobCounty { get; set; }
        public string PrintableFlag { get; set; }
        public string HeaderFormat { get; set; }
        public string BodyFormat { get; set; }
        public string Instructions { get; set; }
        public string ShiptoAddressFlag { get; set; }
        public string OtherContact { get; set; }
        public string OtherAddress1 { get; set; }
        public string OtherAddress2 { get; set; }
        public string OtherCity { get; set; }
        public string OtherState { get; set; }
        public string OtherZipCode { get; set; }
        public string ShiptoJob { get; set; }
        public string ForceFinalWaiverFlag { get; set; }
        public string CalculateSalesTaxFlag { get; set; }
        public string TaxExempt { get; set; }
        public string TaxExemptCert { get; set; }
        public string TaxNo { get; set; }
        public decimal TaxBase { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public string OldFlag { get; set; }
        public string VerifyInvoiceAmount { get; set; }
        public string VerifyDistributions { get; set; }
        public string TaxId { get; set; }
        public string Format { get; set; }
        public int? DesignNo { get; set; }
        public string DesignId { get; set; }
        public int? InternalBatchNumber { get; set; }
        public string InsCertificate { get; set; }
        public DateTime? InsDateExpires { get; set; }
        public decimal AllowPoExceedInvoicePercent { get; set; }
        public string JobChangeOrderNo { get; set; }
        public int JobChangeOrderSeq { get; set; }
        public string JobChangeOrderId { get; set; }
        public string LienWaiverFormatAp { get; set; }
        public string HeaderOnFirstPage { get; set; }
        public string FooterComment { get; set; }
        public string DispatchNo { get; set; }
        public string PreviewFloatSummary { get; set; }
        public string PreviewPrintTitle { get; set; }
        public string DispatchId { get; set; }
        public string TaxType { get; set; }
        public string LienWaiverFormatType { get; set; }
        public int? LienWaiverDesignNoAp { get; set; }
        public int? WpDesignNo { get; set; }
        public string WarehouseOrJobTransfer { get; set; }
        public string DefaultWarehouseNo { get; set; }
        public string DefaultWarehouseId { get; set; }
        public string WpDesignId { get; set; }
        public string FuelPayableFlag { get; set; }

        public ApShipTo ApShipTo { get; set; }
        public Buyers Buyers { get; set; }
        public Jobs Jobs { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public ShipVia ShipVia { get; set; }
        public Terms Terms { get; set; }
        public Vendors Vendors { get; set; }
        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<DcFieldLogMaterials> DcFieldLogMaterials { get; set; }
        public ICollection<InventoryReceiptsH> InventoryReceiptsH { get; set; }
        public ICollection<PoSubBasicD> PoSubBasicD { get; set; }
        public ICollection<PoSubChangeD> PoSubChangeD { get; set; }
        public ICollection<PoSubChangeH> PoSubChangeH { get; set; }
        public ICollection<PoSubCorrespondences> PoSubCorrespondences { get; set; }
        public ICollection<PoSubD> PoSubD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<PoSubSubtierVendors> PoSubSubtierVendors { get; set; }
    }
}
