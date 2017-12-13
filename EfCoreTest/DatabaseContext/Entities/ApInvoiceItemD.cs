using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApInvoiceItemD
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public int ReceiptTransactionNo { get; set; }
        public int ReceiptLineNo { get; set; }
        public string PostedFlag { get; set; }
        public string VoucherSource { get; set; }
        public string AdjustmentFlag { get; set; }
        public int? AdjustmentNo { get; set; }
        public decimal InvoicedQuantity { get; set; }
        public decimal InvoicedUnitCost { get; set; }
        public decimal StockingQuantity { get; set; }
        public decimal StockingUnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TaxFlag { get; set; }
        public decimal TaxBase { get; set; }
        public decimal SalesTaxAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlSalesTaxExpense { get; set; }
        public string SalesTaxJobNo { get; set; }
        public string SalesTaxPhaseNo { get; set; }
        public string SalesTaxCostCodeNo { get; set; }
        public string SalesTaxCostClassNo { get; set; }
        public decimal? SalesTaxDivLevel1 { get; set; }
        public decimal? SalesTaxDivLevel2 { get; set; }
        public decimal? SalesTaxDivLevel3 { get; set; }
        public decimal? SalesTaxDivLevel4 { get; set; }
        public decimal? GlSalesTaxExpFull { get; set; }
        public string AdjustmentId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string ReceiptLineId { get; set; }
        public string ReceiptTransactionId { get; set; }
        public string SalesTaxCostClassId { get; set; }
        public string SalesTaxCostCodeId { get; set; }
        public string SalesTaxJobId { get; set; }
        public string SalesTaxPhaseId { get; set; }
        public string VoucherId { get; set; }
        public string AdjUseTax { get; set; }
        public string TaxNo { get; set; }
        public decimal UseTaxAmount { get; set; }
        public string TaxId { get; set; }
        public string EquipmentNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public decimal? StateLimitApplied { get; set; }
        public decimal? LocalLimitApplied { get; set; }
        public decimal? OtherLimitApplied { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public InventoryReceiptsD InventoryReceiptsD { get; set; }
    }
}
