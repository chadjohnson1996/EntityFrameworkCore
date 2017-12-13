using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CostCodes
    {
        public CostCodes()
        {
            AgencyItems = new HashSet<AgencyItems>();
            AiaHeader = new HashSet<AiaHeader>();
            AiaItem = new HashSet<AiaItem>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            BidD = new HashSet<BidD>();
            ControlArCostCodes = new HashSet<ControlAr>();
            ControlArCostCodes1 = new HashSet<ControlAr>();
            ControlArCostCodes2 = new HashSet<ControlAr>();
            ControlArCostCodes3 = new HashSet<ControlAr>();
            ControlArCostCodesNavigation = new HashSet<ControlAr>();
            ControlEqCostCodes = new HashSet<ControlEq>();
            ControlEqCostCodesNavigation = new HashSet<ControlEq>();
            ControlInCoNavigation = new HashSet<ControlIn>();
            ControlInCostCodes = new HashSet<ControlIn>();
            ControlTaxCostCodes = new HashSet<ControlTax>();
            ControlTaxCostCodesNavigation = new HashSet<ControlTax>();
            CostCodeBurdens = new HashSet<CostCodeBurdens>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            Employees = new HashSet<Employees>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqUsage = new HashSet<EqUsage>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            FuelUsage = new HashSet<FuelUsage>();
            HisTimecard = new HashSet<HisTimecard>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHCoNavigation = new HashSet<InventoryJobH>();
            InventoryJobHCostCodes = new HashSet<InventoryJobH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            ItemCategoriesCoNavigation = new HashSet<ItemCategories>();
            ItemCategoriesCostCodes = new HashSet<ItemCategories>();
            JobCcPercCompWsD = new HashSet<JobCcPercCompWsD>();
            JobCcQtyCompWsD = new HashSet<JobCcQtyCompWsD>();
            JobCostcodes = new HashSet<JobCostcodes>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            JobTransferFromD = new HashSet<JobTransferFromD>();
            JobTransferToD = new HashSet<JobTransferToD>();
            Jobs = new HashSet<Jobs>();
            PayEqpHis = new HashSet<PayEqpHis>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            RecurringTimecard = new HashSet<RecurringTimecard>();
            SalesTaxesCoNavigation = new HashSet<SalesTaxes>();
            SalesTaxesCostCodes = new HashSet<SalesTaxes>();
            SalesTaxesCostCodesNavigation = new HashSet<SalesTaxes>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
            StorageTanks = new HashSet<StorageTanks>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmInvoiceJc = new HashSet<TmInvoiceJc>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            WarehousesCoNavigation = new HashSet<Warehouses>();
            WarehousesCostCodes = new HashSet<Warehouses>();
            WarehousesCostCodesNavigation = new HashSet<Warehouses>();
            WcCostcodes = new HashSet<WcCostcodes>();
        }

        public int CompanyNo { get; set; }
        public string CostCodeNo { get; set; }
        public string Description { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ProductionMethod { get; set; }
        public string CostBasis { get; set; }
        public string ComputeVariance { get; set; }
        public string Archive { get; set; }
        public string CostClassNo { get; set; }
        public string CertifiedPayroll { get; set; }
        public string IgnoreHomeJob { get; set; }
        public string WcClassNo { get; set; }
        public decimal? GlExpense { get; set; }
        public string DefaultPhaseNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CostCodeGroupNo { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeGroupId { get; set; }
        public string CostCodeId { get; set; }
        public string DefaultPhaseId { get; set; }
        public string WcClassId { get; set; }
        public string EquipmentServiceRepair { get; set; }
        public string DeptNo { get; set; }
        public decimal? ApInvoiceGlExpense { get; set; }
        public string UseInJcOvhdCalc { get; set; }
        public decimal? OvhdRate { get; set; }
        public string DeptId { get; set; }

        public Accounts Accounts { get; set; }
        public CostClasses Co { get; set; }
        public CostCodeGroups CoNavigation { get; set; }
        public Departments Departments { get; set; }
        public Phases Phases { get; set; }
        public Units Units { get; set; }
        public ICollection<AgencyItems> AgencyItems { get; set; }
        public ICollection<AiaHeader> AiaHeader { get; set; }
        public ICollection<AiaItem> AiaItem { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<ControlAr> ControlArCostCodes { get; set; }
        public ICollection<ControlAr> ControlArCostCodes1 { get; set; }
        public ICollection<ControlAr> ControlArCostCodes2 { get; set; }
        public ICollection<ControlAr> ControlArCostCodes3 { get; set; }
        public ICollection<ControlAr> ControlArCostCodesNavigation { get; set; }
        public ICollection<ControlEq> ControlEqCostCodes { get; set; }
        public ICollection<ControlEq> ControlEqCostCodesNavigation { get; set; }
        public ICollection<ControlIn> ControlInCoNavigation { get; set; }
        public ICollection<ControlIn> ControlInCostCodes { get; set; }
        public ICollection<ControlTax> ControlTaxCostCodes { get; set; }
        public ICollection<ControlTax> ControlTaxCostCodesNavigation { get; set; }
        public ICollection<CostCodeBurdens> CostCodeBurdens { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<FuelUsage> FuelUsage { get; set; }
        public ICollection<HisTimecard> HisTimecard { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHCoNavigation { get; set; }
        public ICollection<InventoryJobH> InventoryJobHCostCodes { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<ItemCategories> ItemCategoriesCoNavigation { get; set; }
        public ICollection<ItemCategories> ItemCategoriesCostCodes { get; set; }
        public ICollection<JobCcPercCompWsD> JobCcPercCompWsD { get; set; }
        public ICollection<JobCcQtyCompWsD> JobCcQtyCompWsD { get; set; }
        public ICollection<JobCostcodes> JobCostcodes { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<PayEqpHis> PayEqpHis { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<RecurringTimecard> RecurringTimecard { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCoNavigation { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCostCodes { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCostCodesNavigation { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
        public ICollection<StorageTanks> StorageTanks { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmInvoiceJc> TmInvoiceJc { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<Warehouses> WarehousesCoNavigation { get; set; }
        public ICollection<Warehouses> WarehousesCostCodes { get; set; }
        public ICollection<Warehouses> WarehousesCostCodesNavigation { get; set; }
        public ICollection<WcCostcodes> WcCostcodes { get; set; }
    }
}
