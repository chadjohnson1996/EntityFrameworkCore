using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CostClasses
    {
        public CostClasses()
        {
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            ControlArCostClasses = new HashSet<ControlAr>();
            ControlArCostClasses1 = new HashSet<ControlAr>();
            ControlArCostClasses2 = new HashSet<ControlAr>();
            ControlArCostClassesNavigation = new HashSet<ControlAr>();
            ControlEqCostClasses = new HashSet<ControlEq>();
            ControlEqCostClassesNavigation = new HashSet<ControlEq>();
            ControlInCo = new HashSet<ControlIn>();
            ControlInCostClasses = new HashSet<ControlIn>();
            ControlTaxCostClasses = new HashSet<ControlTax>();
            ControlTaxCostClassesNavigation = new HashSet<ControlTax>();
            CostCodeBudgetClasses = new HashSet<CostCodeBudgetClasses>();
            CostCodes = new HashSet<CostCodes>();
            DcRfcBudgets = new HashSet<DcRfcBudgets>();
            EarnTypes = new HashSet<EarnTypes>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqUsage = new HashSet<EqUsage>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            FuelUsage = new HashSet<FuelUsage>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHCo = new HashSet<InventoryJobH>();
            InventoryJobHCostClasses = new HashSet<InventoryJobH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            ItemCategoriesCo = new HashSet<ItemCategories>();
            ItemCategoriesCostClasses = new HashSet<ItemCategories>();
            JobBudgets = new HashSet<JobBudgets>();
            JobCcPercCompWsD = new HashSet<JobCcPercCompWsD>();
            JobHistory = new HashSet<JobHistory>();
            JobTaxableCostclasses = new HashSet<JobTaxableCostclasses>();
            JobTransferFromD = new HashSet<JobTransferFromD>();
            JobTransferToD = new HashSet<JobTransferToD>();
            PayEqpHis = new HashSet<PayEqpHis>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            SalesTaxesCo = new HashSet<SalesTaxes>();
            SalesTaxesCostClasses = new HashSet<SalesTaxes>();
            SalesTaxesCostClassesNavigation = new HashSet<SalesTaxes>();
            StorageTanks = new HashSet<StorageTanks>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            WarehousesCo = new HashSet<Warehouses>();
            WarehousesCostClasses = new HashSet<Warehouses>();
            WarehousesCostClassesNavigation = new HashSet<Warehouses>();
        }

        public int CompanyNo { get; set; }
        public string CostClassNo { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public decimal AllocatedOverheadPerc { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string IncomeExpense { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string TmMarkupCategory { get; set; }
        public string TmIncludeInTaxBase { get; set; }
        public string IncludeInCostCodeBudgetSet { get; set; }
        public decimal? ApInvoiceGlExpense { get; set; }
        public string UseInJcOvhdCalc { get; set; }
        public string TmForceZeroPrice { get; set; }
        public string IncludeInPctCmplWs { get; set; }

        public Accounts Accounts { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<ControlAr> ControlArCostClasses { get; set; }
        public ICollection<ControlAr> ControlArCostClasses1 { get; set; }
        public ICollection<ControlAr> ControlArCostClasses2 { get; set; }
        public ICollection<ControlAr> ControlArCostClassesNavigation { get; set; }
        public ICollection<ControlEq> ControlEqCostClasses { get; set; }
        public ICollection<ControlEq> ControlEqCostClassesNavigation { get; set; }
        public ICollection<ControlIn> ControlInCo { get; set; }
        public ICollection<ControlIn> ControlInCostClasses { get; set; }
        public ICollection<ControlTax> ControlTaxCostClasses { get; set; }
        public ICollection<ControlTax> ControlTaxCostClassesNavigation { get; set; }
        public ICollection<CostCodeBudgetClasses> CostCodeBudgetClasses { get; set; }
        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<DcRfcBudgets> DcRfcBudgets { get; set; }
        public ICollection<EarnTypes> EarnTypes { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<FuelUsage> FuelUsage { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHCo { get; set; }
        public ICollection<InventoryJobH> InventoryJobHCostClasses { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<ItemCategories> ItemCategoriesCo { get; set; }
        public ICollection<ItemCategories> ItemCategoriesCostClasses { get; set; }
        public ICollection<JobBudgets> JobBudgets { get; set; }
        public ICollection<JobCcPercCompWsD> JobCcPercCompWsD { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobTaxableCostclasses> JobTaxableCostclasses { get; set; }
        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
        public ICollection<PayEqpHis> PayEqpHis { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCo { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCostClasses { get; set; }
        public ICollection<SalesTaxes> SalesTaxesCostClassesNavigation { get; set; }
        public ICollection<StorageTanks> StorageTanks { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<Warehouses> WarehousesCo { get; set; }
        public ICollection<Warehouses> WarehousesCostClasses { get; set; }
        public ICollection<Warehouses> WarehousesCostClassesNavigation { get; set; }
    }
}
