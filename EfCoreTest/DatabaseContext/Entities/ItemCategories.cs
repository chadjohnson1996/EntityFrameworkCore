using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemCategories
    {
        public ItemCategories()
        {
            BuyOutH = new HashSet<BuyOutH>();
            ControlIn = new HashSet<ControlIn>();
            CustomerPriceLevels = new HashSet<CustomerPriceLevels>();
            InventoryWorksheetsD = new HashSet<InventoryWorksheetsD>();
            ItemsItemCategories = new HashSet<Items>();
            ItemsItemCategories1 = new HashSet<Items>();
            ItemsItemCategories2 = new HashSet<Items>();
            ItemsItemCategories3 = new HashSet<Items>();
            ItemsItemCategories4 = new HashSet<Items>();
            ItemsItemCategoriesNavigation = new HashSet<Items>();
            JobPriceLevels = new HashSet<JobPriceLevels>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string ItemCategoryNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemCategoryId { get; set; }
        public decimal? GlInventoryIncome { get; set; }
        public decimal? GlMaterialExpense { get; set; }
        public decimal? GlInventoryAsset { get; set; }
        public decimal? GlReconciliation { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string SubLevel { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostCodes CostCodes { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public ICollection<BuyOutH> BuyOutH { get; set; }
        public ICollection<ControlIn> ControlIn { get; set; }
        public ICollection<CustomerPriceLevels> CustomerPriceLevels { get; set; }
        public ICollection<InventoryWorksheetsD> InventoryWorksheetsD { get; set; }
        public ICollection<Items> ItemsItemCategories { get; set; }
        public ICollection<Items> ItemsItemCategories1 { get; set; }
        public ICollection<Items> ItemsItemCategories2 { get; set; }
        public ICollection<Items> ItemsItemCategories3 { get; set; }
        public ICollection<Items> ItemsItemCategories4 { get; set; }
        public ICollection<Items> ItemsItemCategoriesNavigation { get; set; }
        public ICollection<JobPriceLevels> JobPriceLevels { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
