using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqCategories
    {
        public EqCategories()
        {
            EqAttachments = new HashSet<EqAttachments>();
            EqCategoriesDivExpJrnl = new HashSet<EqCategoriesDivExpJrnl>();
            EqCategoriesDivisions = new HashSet<EqCategoriesDivisions>();
            EqCategoriesFuelDiv = new HashSet<EqCategoriesFuelDiv>();
            EqCategoriesSrv = new HashSet<EqCategoriesSrv>();
            EquipmentEqCategories = new HashSet<Equipment>();
            EquipmentEqCategoriesNavigation = new HashSet<Equipment>();
            JobScheduleTaskCategoryResources = new HashSet<JobScheduleTaskCategoryResources>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string EqCategoryNo { get; set; }
        public string Description { get; set; }
        public decimal? GlExpenseOwned { get; set; }
        public decimal? GlExpenseRented { get; set; }
        public decimal? GlExpenseLeased { get; set; }
        public decimal? GlCredit { get; set; }
        public decimal DefaultHourlyRate { get; set; }
        public decimal DefaultDailyRate { get; set; }
        public decimal DefaultWeeklyRate { get; set; }
        public decimal DefaultMonthlyRate { get; set; }
        public decimal DefaultIdleRate { get; set; }
        public decimal DefaultDownRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqCategoryId { get; set; }
        public decimal? GlExpJrnlDebit { get; set; }
        public decimal? GlExpJrnlCredit { get; set; }
        public string ConsumptionType { get; set; }
        public string FuelTypeNo { get; set; }
        public decimal? GlFuelExpense { get; set; }
        public decimal? GlFuelCredit { get; set; }
        public string FuelJobNo { get; set; }
        public string FuelPhaseNo { get; set; }
        public string FuelCostCodeNo { get; set; }
        public string FuelCostClassNo { get; set; }
        public string FuelCostClassId { get; set; }
        public string FuelCostCodeId { get; set; }
        public string FuelJobId { get; set; }
        public string FuelPhaseId { get; set; }
        public string FuelTypeId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts Accounts3 { get; set; }
        public Accounts Accounts4 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public ICollection<EqAttachments> EqAttachments { get; set; }
        public ICollection<EqCategoriesDivExpJrnl> EqCategoriesDivExpJrnl { get; set; }
        public ICollection<EqCategoriesDivisions> EqCategoriesDivisions { get; set; }
        public ICollection<EqCategoriesFuelDiv> EqCategoriesFuelDiv { get; set; }
        public ICollection<EqCategoriesSrv> EqCategoriesSrv { get; set; }
        public ICollection<Equipment> EquipmentEqCategories { get; set; }
        public ICollection<Equipment> EquipmentEqCategoriesNavigation { get; set; }
        public ICollection<JobScheduleTaskCategoryResources> JobScheduleTaskCategoryResources { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
