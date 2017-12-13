using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApInvoiceD
    {
        public ApInvoiceD()
        {
            ApCheckVch = new HashSet<ApCheckVch>();
            ApPmtVch = new HashSet<ApPmtVch>();
            ApPreCheckVch = new HashSet<ApPreCheckVch>();
            ApPrePmtVch = new HashSet<ApPrePmtVch>();
        }

        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal AccountNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string TaxNo { get; set; }
        public string EquipNo { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public decimal? Units { get; set; }
        public string VoucherSource { get; set; }
        public string AdjustmentFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? RetainageAmount { get; set; }
        public int? AdjustmentNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullAccountNo { get; set; }
        public string UseTax { get; set; }
        public string AccountId { get; set; }
        public string AdjustmentId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EquipId { get; set; }
        public string FullAccountId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TaxId { get; set; }
        public string VoucherId { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string ServiceCodeId { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public string TaxFlag { get; set; }
        public decimal TaxBase { get; set; }
        public decimal SalesTaxAmount { get; set; }
        public decimal UseTaxAmount { get; set; }
        public decimal TaxRate { get; set; }
        public string SalesTaxAmtChanged { get; set; }
        public string InventoryPayableFlag { get; set; }
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
        public string SalesTaxCostClassId { get; set; }
        public string SalesTaxCostCodeId { get; set; }
        public string SalesTaxJobId { get; set; }
        public string SalesTaxPhaseId { get; set; }
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
        public string FuelPayableFlag { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public EqWo EqWo { get; set; }
        public ICollection<ApCheckVch> ApCheckVch { get; set; }
        public ICollection<ApPmtVch> ApPmtVch { get; set; }
        public ICollection<ApPreCheckVch> ApPreCheckVch { get; set; }
        public ICollection<ApPrePmtVch> ApPrePmtVch { get; set; }
    }
}
