using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlTax
    {
        public int CompanyNo { get; set; }
        public string ApTaxType { get; set; }
        public string ApAllowTaxType { get; set; }
        public string DefaultSeqApHeaderTax { get; set; }
        public string ApTaxNo { get; set; }
        public string DefaultSeqApDetailTax { get; set; }
        public decimal? GlApUseTaxExpense { get; set; }
        public decimal? GlApUseTaxPayable { get; set; }
        public string ApPhaseNo { get; set; }
        public string ApCostCodeNo { get; set; }
        public string ApCostClassNo { get; set; }
        public string RequireTaxOnJob { get; set; }
        public string PsAllowSalesTax { get; set; }
        public string DefaultSeqPsTax { get; set; }
        public decimal? GlArSalesTaxPayable { get; set; }
        public string DefaultSeqArTax { get; set; }
        public string ArTaxNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string VerifyPoTaxAuthToVendor { get; set; }
        public string DefaultPoTaxType { get; set; }
        public decimal? GlApSalesTaxExpense { get; set; }
        public string SalesTaxPhaseNo { get; set; }
        public string SalesTaxCostCodeNo { get; set; }
        public string SalesTaxCostClassNo { get; set; }
        public string ApCostClassId { get; set; }
        public string ApCostCodeId { get; set; }
        public string ApPhaseId { get; set; }
        public string ApTaxId { get; set; }
        public string ArTaxId { get; set; }
        public string CompanyId { get; set; }
        public string SalesTaxCostClassId { get; set; }
        public string SalesTaxCostCodeId { get; set; }
        public string SalesTaxPhaseId { get; set; }
        public string DefaultSeqTaxType { get; set; }
        public string RecordUseTaxOn { get; set; }
        public string PreventTaxbaseSignFlag { get; set; }
        public string TmUsetaxType { get; set; }
        public string TmDefaultSeqTaxType { get; set; }
        public string TmTaxType { get; set; }
        public string DefaultSeqTmTax { get; set; }
        public string TmTaxNo { get; set; }
        public string RoundUpTax { get; set; }
        public string EachPercSeparate { get; set; }
        public string TaxLimitsAllowed { get; set; }
        public string TmTaxId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostClasses CostClassesNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public CostCodes CostCodesNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public SalesTaxes SalesTaxesNavigation { get; set; }
    }
}
