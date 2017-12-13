using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArInvoiceFrmD
    {
        public ArInvoiceFrmD()
        {
            ArInvoiceFrmDUdf = new HashSet<ArInvoiceFrmDUdf>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
        }

        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ExtendedPrice { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string RecordStatus { get; set; }
        public string Comment { get; set; }
        public int OrdinalPosition { get; set; }
        public string ItemNo { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string StockingUnitNo { get; set; }
        public decimal StockingUnitCost { get; set; }
        public string PriceLevelNo { get; set; }
        public string ReversalFlag { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string PriceLevelId { get; set; }
        public string StockingUnitId { get; set; }
        public decimal? GlIncome { get; set; }
        public int? DivLevel1 { get; set; }
        public int? DivLevel2 { get; set; }
        public int? DivLevel3 { get; set; }
        public int? DivLevel4 { get; set; }
        public string SdFlatRateNo { get; set; }
        public string SdBillingType { get; set; }
        public string SdFlatRateId { get; set; }
        public DateTime? BillingDate { get; set; }
        public string UpdateInventory { get; set; }
        public string FromWhseNo { get; set; }
        public string FromWhseId { get; set; }
        public string TaxFlag { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string PhaseId { get; set; }

        public ArInvoiceFrmH ArInvoiceFrmH { get; set; }
        public Items Items { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public ICollection<ArInvoiceFrmDUdf> ArInvoiceFrmDUdf { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
    }
}
