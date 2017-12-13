using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Accounts
    {
        public Accounts()
        {
            ArBankDeposit = new HashSet<ArBankDeposit>();
            AssetCategoriesAccounts = new HashSet<AssetCategories>();
            AssetCategoriesAccountsNavigation = new HashSet<AssetCategories>();
            CashHistoryJournalH = new HashSet<CashHistoryJournalH>();
            ControlArAccounts = new HashSet<ControlAr>();
            ControlArAccounts1 = new HashSet<ControlAr>();
            ControlArAccounts10 = new HashSet<ControlAr>();
            ControlArAccounts11 = new HashSet<ControlAr>();
            ControlArAccounts12 = new HashSet<ControlAr>();
            ControlArAccounts13 = new HashSet<ControlAr>();
            ControlArAccounts14 = new HashSet<ControlAr>();
            ControlArAccounts2 = new HashSet<ControlAr>();
            ControlArAccounts3 = new HashSet<ControlAr>();
            ControlArAccounts4 = new HashSet<ControlAr>();
            ControlArAccounts5 = new HashSet<ControlAr>();
            ControlArAccounts6 = new HashSet<ControlAr>();
            ControlArAccounts7 = new HashSet<ControlAr>();
            ControlArAccounts8 = new HashSet<ControlAr>();
            ControlArAccounts9 = new HashSet<ControlAr>();
            ControlArAccountsNavigation = new HashSet<ControlAr>();
            ControlEqAccounts = new HashSet<ControlEq>();
            ControlEqAccounts1 = new HashSet<ControlEq>();
            ControlEqAccounts2 = new HashSet<ControlEq>();
            ControlEqAccounts3 = new HashSet<ControlEq>();
            ControlEqAccounts4 = new HashSet<ControlEq>();
            ControlEqAccountsNavigation = new HashSet<ControlEq>();
            ControlFaAccounts = new HashSet<ControlFa>();
            ControlFaAccountsNavigation = new HashSet<ControlFa>();
            ControlGlAccounts = new HashSet<ControlGl>();
            ControlGlAccounts1 = new HashSet<ControlGl>();
            ControlGlAccounts2 = new HashSet<ControlGl>();
            ControlGlAccountsNavigation = new HashSet<ControlGl>();
            ControlInAccounts = new HashSet<ControlIn>();
            ControlInAccounts1 = new HashSet<ControlIn>();
            ControlInAccounts2 = new HashSet<ControlIn>();
            ControlInAccounts3 = new HashSet<ControlIn>();
            ControlInAccounts4 = new HashSet<ControlIn>();
            ControlInAccounts5 = new HashSet<ControlIn>();
            ControlInAccountsNavigation = new HashSet<ControlIn>();
            ControlTaxAccounts = new HashSet<ControlTax>();
            ControlTaxAccounts1 = new HashSet<ControlTax>();
            ControlTaxAccounts2 = new HashSet<ControlTax>();
            ControlTaxAccountsNavigation = new HashSet<ControlTax>();
            ControlTmAccounts = new HashSet<ControlTm>();
            ControlTmAccounts1 = new HashSet<ControlTm>();
            ControlTmAccountsNavigation = new HashSet<ControlTm>();
            ControlUpAccounts = new HashSet<ControlUp>();
            ControlUpAccounts1 = new HashSet<ControlUp>();
            ControlUpAccountsNavigation = new HashSet<ControlUp>();
            CostClasses = new HashSet<CostClasses>();
            CostCodes = new HashSet<CostCodes>();
            CustomersAccounts = new HashSet<Customers>();
            CustomersAccounts1 = new HashSet<Customers>();
            CustomersAccounts2 = new HashSet<Customers>();
            CustomersAccounts3 = new HashSet<Customers>();
            CustomersAccounts4 = new HashSet<Customers>();
            CustomersAccountsNavigation = new HashSet<Customers>();
            DeprJournalDAccounts = new HashSet<DeprJournalD>();
            DeprJournalDAccountsNavigation = new HashSet<DeprJournalD>();
            DistributionD = new HashSet<DistributionD>();
            EqAttachmentUsageAccounts = new HashSet<EqAttachmentUsage>();
            EqAttachmentUsageAccountsNavigation = new HashSet<EqAttachmentUsage>();
            EqAttachmentsAccounts = new HashSet<EqAttachments>();
            EqAttachmentsAccountsNavigation = new HashSet<EqAttachments>();
            EqCategoriesAccounts = new HashSet<EqCategories>();
            EqCategoriesAccounts1 = new HashSet<EqCategories>();
            EqCategoriesAccounts2 = new HashSet<EqCategories>();
            EqCategoriesAccounts3 = new HashSet<EqCategories>();
            EqCategoriesAccounts4 = new HashSet<EqCategories>();
            EqCategoriesAccountsNavigation = new HashSet<EqCategories>();
            EqCategoriesSrvAccounts = new HashSet<EqCategoriesSrv>();
            EqCategoriesSrvAccountsNavigation = new HashSet<EqCategoriesSrv>();
            EqExpenseHistoryAccounts = new HashSet<EqExpenseHistory>();
            EqExpenseHistoryAccountsNavigation = new HashSet<EqExpenseHistory>();
            EqExpenseJournalDAccounts = new HashSet<EqExpenseJournalD>();
            EqExpenseJournalDAccountsNavigation = new HashSet<EqExpenseJournalD>();
            EqServiceCodesAccounts = new HashSet<EqServiceCodes>();
            EqServiceCodesAccountsNavigation = new HashSet<EqServiceCodes>();
            EqUsageAccounts = new HashSet<EqUsage>();
            EqUsageAccountsNavigation = new HashSet<EqUsage>();
            EquipmentAccounts = new HashSet<Equipment>();
            EquipmentAccounts1 = new HashSet<Equipment>();
            EquipmentAccounts2 = new HashSet<Equipment>();
            EquipmentAccountsNavigation = new HashSet<Equipment>();
            FuelUsageAccounts = new HashSet<FuelUsage>();
            FuelUsageAccountsNavigation = new HashSet<FuelUsage>();
            GlBudgetHistory = new HashSet<GlBudgetHistory>();
            GlCashHistory = new HashSet<GlCashHistory>();
            GlDepositHistory = new HashSet<GlDepositHistory>();
            GlHistory = new HashSet<GlHistory>();
            GlJournalD = new HashSet<GlJournalD>();
            IncomeTypesAccounts = new HashSet<IncomeTypes>();
            IncomeTypesAccounts1 = new HashSet<IncomeTypes>();
            IncomeTypesAccountsNavigation = new HashSet<IncomeTypes>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHAccounts = new HashSet<InventoryJobH>();
            InventoryJobHAccountsNavigation = new HashSet<InventoryJobH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            ItemCategoriesAccounts = new HashSet<ItemCategories>();
            ItemCategoriesAccounts1 = new HashSet<ItemCategories>();
            ItemCategoriesAccounts2 = new HashSet<ItemCategories>();
            ItemCategoriesAccountsNavigation = new HashSet<ItemCategories>();
            JobCostcodes = new HashSet<JobCostcodes>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            SalesTaxes = new HashSet<SalesTaxes>();
            ShipVia = new HashSet<ShipVia>();
            StorageTanksAccounts = new HashSet<StorageTanks>();
            StorageTanksAccountsNavigation = new HashSet<StorageTanks>();
            TmInvoiceGl = new HashSet<TmInvoiceGl>();
            TmInvoiceHAccounts = new HashSet<TmInvoiceH>();
            TmInvoiceHAccountsNavigation = new HashSet<TmInvoiceH>();
            WarehousesAccounts = new HashSet<Warehouses>();
            WarehousesAccounts1 = new HashSet<Warehouses>();
            WarehousesAccounts2 = new HashSet<Warehouses>();
            WarehousesAccountsNavigation = new HashSet<Warehouses>();
        }

        public int CompanyNo { get; set; }
        public decimal AccountNo { get; set; }
        public string Description { get; set; }
        public string DebitCredit { get; set; }
        public string ApplySubdivision { get; set; }
        public string IncExpType { get; set; }
        public decimal? OverheadPercent { get; set; }
        public decimal? OverheadFormulaPercent { get; set; }
        public int ForceJobCosting { get; set; }
        public string JcIncomeExpense { get; set; }
        public string CashFlag { get; set; }
        public string BondingClass { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string OvhdAllocIncomeExpense { get; set; }
        public decimal? PercentToAllocate { get; set; }
        public decimal? OverheadWeightFactor { get; set; }
        public string AccountId { get; set; }
        public string CompanyId { get; set; }
        public string DirectDepositFormat { get; set; }
        public int? DirDepExpDsgReportNo { get; set; }
        public string DirectDepositPrFile { get; set; }
        public string AchDestRoutingNum { get; set; }
        public string AchDestName { get; set; }
        public string AchOriginRoutingNum { get; set; }
        public string AchOriginName { get; set; }
        public string AchOriginReferenceCode { get; set; }
        public string AchCompanyName { get; set; }
        public string AchCompanyId { get; set; }
        public string AchPrEntryDesc { get; set; }
        public string AchPrDiscretionaryData { get; set; }
        public string AchPrEmpIdentifier { get; set; }
        public string AchPrEmpNameFormat { get; set; }
        public string DirDepExpDsgReportId { get; set; }
        public string CondenseOnCashRec { get; set; }
        public string StatementCategoryNo { get; set; }
        public string BankAccountNum { get; set; }
        public string BankAccountType { get; set; }
        public string AchBalancedFile { get; set; }
        public string StatementCategoryId { get; set; }
        public string IncludeInCannedFinancials { get; set; }
        public string AchOriginDfiId { get; set; }
        public int? PositivePayExpDsgReportNo { get; set; }
        public string PositivePayExportFile { get; set; }
        public string PositivePayExpDsgReportId { get; set; }
        public string AchUseOriginRoutingBalDfi { get; set; }
        public string AchUseDestRoutingBalDfi { get; set; }
        public string AchOriginType { get; set; }
        public string AccountType { get; set; }
        public string GlHistoryReportRollup { get; set; }
        public int? BatchNo { get; set; }
        public string DirDepExpHeader { get; set; }
        public string BatchId { get; set; }
        public string AchApEntryDesc { get; set; }
        public string AchApDiscretionaryData { get; set; }
        public string VndDirPayExpHeader { get; set; }
        public string VndDirPayExportFile { get; set; }
        public int? AchDestRoutingNumEid { get; set; }
        public int? AchOriginRoutingNumEid { get; set; }
        public int? BankAccountNumEid { get; set; }
        public int? AchOriginDfiIdEid { get; set; }
        public int? DirDepExpHeaderEid { get; set; }
        public int? VndDirPayExpHeaderEid { get; set; }
        public string CreateAddendaRecords { get; set; }
        public string MicrAccount { get; set; }
        public string IntegrationsAccountName { get; set; }

        public Edata AchDestRoutingNumE { get; set; }
        public Edata AchOriginDfiIdE { get; set; }
        public Edata AchOriginRoutingNumE { get; set; }
        public Edata BankAccountNumE { get; set; }
        public Edata DirDepExpHeaderE { get; set; }
        public JobBondingClasses JobBondingClasses { get; set; }
        public StatementCategories StatementCategories { get; set; }
        public Edata VndDirPayExpHeaderE { get; set; }
        public AccountsMicr AccountsMicr { get; set; }
        public ICollection<ArBankDeposit> ArBankDeposit { get; set; }
        public ICollection<AssetCategories> AssetCategoriesAccounts { get; set; }
        public ICollection<AssetCategories> AssetCategoriesAccountsNavigation { get; set; }
        public ICollection<CashHistoryJournalH> CashHistoryJournalH { get; set; }
        public ICollection<ControlAr> ControlArAccounts { get; set; }
        public ICollection<ControlAr> ControlArAccounts1 { get; set; }
        public ICollection<ControlAr> ControlArAccounts10 { get; set; }
        public ICollection<ControlAr> ControlArAccounts11 { get; set; }
        public ICollection<ControlAr> ControlArAccounts12 { get; set; }
        public ICollection<ControlAr> ControlArAccounts13 { get; set; }
        public ICollection<ControlAr> ControlArAccounts14 { get; set; }
        public ICollection<ControlAr> ControlArAccounts2 { get; set; }
        public ICollection<ControlAr> ControlArAccounts3 { get; set; }
        public ICollection<ControlAr> ControlArAccounts4 { get; set; }
        public ICollection<ControlAr> ControlArAccounts5 { get; set; }
        public ICollection<ControlAr> ControlArAccounts6 { get; set; }
        public ICollection<ControlAr> ControlArAccounts7 { get; set; }
        public ICollection<ControlAr> ControlArAccounts8 { get; set; }
        public ICollection<ControlAr> ControlArAccounts9 { get; set; }
        public ICollection<ControlAr> ControlArAccountsNavigation { get; set; }
        public ICollection<ControlEq> ControlEqAccounts { get; set; }
        public ICollection<ControlEq> ControlEqAccounts1 { get; set; }
        public ICollection<ControlEq> ControlEqAccounts2 { get; set; }
        public ICollection<ControlEq> ControlEqAccounts3 { get; set; }
        public ICollection<ControlEq> ControlEqAccounts4 { get; set; }
        public ICollection<ControlEq> ControlEqAccountsNavigation { get; set; }
        public ICollection<ControlFa> ControlFaAccounts { get; set; }
        public ICollection<ControlFa> ControlFaAccountsNavigation { get; set; }
        public ICollection<ControlGl> ControlGlAccounts { get; set; }
        public ICollection<ControlGl> ControlGlAccounts1 { get; set; }
        public ICollection<ControlGl> ControlGlAccounts2 { get; set; }
        public ICollection<ControlGl> ControlGlAccountsNavigation { get; set; }
        public ICollection<ControlIn> ControlInAccounts { get; set; }
        public ICollection<ControlIn> ControlInAccounts1 { get; set; }
        public ICollection<ControlIn> ControlInAccounts2 { get; set; }
        public ICollection<ControlIn> ControlInAccounts3 { get; set; }
        public ICollection<ControlIn> ControlInAccounts4 { get; set; }
        public ICollection<ControlIn> ControlInAccounts5 { get; set; }
        public ICollection<ControlIn> ControlInAccountsNavigation { get; set; }
        public ICollection<ControlTax> ControlTaxAccounts { get; set; }
        public ICollection<ControlTax> ControlTaxAccounts1 { get; set; }
        public ICollection<ControlTax> ControlTaxAccounts2 { get; set; }
        public ICollection<ControlTax> ControlTaxAccountsNavigation { get; set; }
        public ICollection<ControlTm> ControlTmAccounts { get; set; }
        public ICollection<ControlTm> ControlTmAccounts1 { get; set; }
        public ICollection<ControlTm> ControlTmAccountsNavigation { get; set; }
        public ICollection<ControlUp> ControlUpAccounts { get; set; }
        public ICollection<ControlUp> ControlUpAccounts1 { get; set; }
        public ICollection<ControlUp> ControlUpAccountsNavigation { get; set; }
        public ICollection<CostClasses> CostClasses { get; set; }
        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<Customers> CustomersAccounts { get; set; }
        public ICollection<Customers> CustomersAccounts1 { get; set; }
        public ICollection<Customers> CustomersAccounts2 { get; set; }
        public ICollection<Customers> CustomersAccounts3 { get; set; }
        public ICollection<Customers> CustomersAccounts4 { get; set; }
        public ICollection<Customers> CustomersAccountsNavigation { get; set; }
        public ICollection<DeprJournalD> DeprJournalDAccounts { get; set; }
        public ICollection<DeprJournalD> DeprJournalDAccountsNavigation { get; set; }
        public ICollection<DistributionD> DistributionD { get; set; }
        public ICollection<EqAttachmentUsage> EqAttachmentUsageAccounts { get; set; }
        public ICollection<EqAttachmentUsage> EqAttachmentUsageAccountsNavigation { get; set; }
        public ICollection<EqAttachments> EqAttachmentsAccounts { get; set; }
        public ICollection<EqAttachments> EqAttachmentsAccountsNavigation { get; set; }
        public ICollection<EqCategories> EqCategoriesAccounts { get; set; }
        public ICollection<EqCategories> EqCategoriesAccounts1 { get; set; }
        public ICollection<EqCategories> EqCategoriesAccounts2 { get; set; }
        public ICollection<EqCategories> EqCategoriesAccounts3 { get; set; }
        public ICollection<EqCategories> EqCategoriesAccounts4 { get; set; }
        public ICollection<EqCategories> EqCategoriesAccountsNavigation { get; set; }
        public ICollection<EqCategoriesSrv> EqCategoriesSrvAccounts { get; set; }
        public ICollection<EqCategoriesSrv> EqCategoriesSrvAccountsNavigation { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistoryAccounts { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistoryAccountsNavigation { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalDAccounts { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalDAccountsNavigation { get; set; }
        public ICollection<EqServiceCodes> EqServiceCodesAccounts { get; set; }
        public ICollection<EqServiceCodes> EqServiceCodesAccountsNavigation { get; set; }
        public ICollection<EqUsage> EqUsageAccounts { get; set; }
        public ICollection<EqUsage> EqUsageAccountsNavigation { get; set; }
        public ICollection<Equipment> EquipmentAccounts { get; set; }
        public ICollection<Equipment> EquipmentAccounts1 { get; set; }
        public ICollection<Equipment> EquipmentAccounts2 { get; set; }
        public ICollection<Equipment> EquipmentAccountsNavigation { get; set; }
        public ICollection<FuelUsage> FuelUsageAccounts { get; set; }
        public ICollection<FuelUsage> FuelUsageAccountsNavigation { get; set; }
        public ICollection<GlBudgetHistory> GlBudgetHistory { get; set; }
        public ICollection<GlCashHistory> GlCashHistory { get; set; }
        public ICollection<GlDepositHistory> GlDepositHistory { get; set; }
        public ICollection<GlHistory> GlHistory { get; set; }
        public ICollection<GlJournalD> GlJournalD { get; set; }
        public ICollection<IncomeTypes> IncomeTypesAccounts { get; set; }
        public ICollection<IncomeTypes> IncomeTypesAccounts1 { get; set; }
        public ICollection<IncomeTypes> IncomeTypesAccountsNavigation { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHAccounts { get; set; }
        public ICollection<InventoryJobH> InventoryJobHAccountsNavigation { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<ItemCategories> ItemCategoriesAccounts { get; set; }
        public ICollection<ItemCategories> ItemCategoriesAccounts1 { get; set; }
        public ICollection<ItemCategories> ItemCategoriesAccounts2 { get; set; }
        public ICollection<ItemCategories> ItemCategoriesAccountsNavigation { get; set; }
        public ICollection<JobCostcodes> JobCostcodes { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<SalesTaxes> SalesTaxes { get; set; }
        public ICollection<ShipVia> ShipVia { get; set; }
        public ICollection<StorageTanks> StorageTanksAccounts { get; set; }
        public ICollection<StorageTanks> StorageTanksAccountsNavigation { get; set; }
        public ICollection<TmInvoiceGl> TmInvoiceGl { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceHAccounts { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceHAccountsNavigation { get; set; }
        public ICollection<Warehouses> WarehousesAccounts { get; set; }
        public ICollection<Warehouses> WarehousesAccounts1 { get; set; }
        public ICollection<Warehouses> WarehousesAccounts2 { get; set; }
        public ICollection<Warehouses> WarehousesAccountsNavigation { get; set; }
    }
}
