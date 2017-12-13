using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Phases
    {
        public Phases()
        {
            AgencyItems = new HashSet<AgencyItems>();
            AiaHeader = new HashSet<AiaHeader>();
            AiaItem = new HashSet<AiaItem>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            BidD = new HashSet<BidD>();
            ControlArPhases = new HashSet<ControlAr>();
            ControlArPhases1 = new HashSet<ControlAr>();
            ControlArPhases2 = new HashSet<ControlAr>();
            ControlArPhases3 = new HashSet<ControlAr>();
            ControlArPhasesNavigation = new HashSet<ControlAr>();
            ControlEqPhases = new HashSet<ControlEq>();
            ControlEqPhasesNavigation = new HashSet<ControlEq>();
            ControlInPhases = new HashSet<ControlIn>();
            ControlInPhasesNavigation = new HashSet<ControlIn>();
            ControlTaxPhases = new HashSet<ControlTax>();
            ControlTaxPhasesNavigation = new HashSet<ControlTax>();
            CostCodes = new HashSet<CostCodes>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqUsage = new HashSet<EqUsage>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHPhases = new HashSet<InventoryJobH>();
            InventoryJobHPhasesNavigation = new HashSet<InventoryJobH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            ItemCategoriesPhases = new HashSet<ItemCategories>();
            ItemCategoriesPhasesNavigation = new HashSet<ItemCategories>();
            JobCcPercCompWsD = new HashSet<JobCcPercCompWsD>();
            JobCcQtyCompWsD = new HashSet<JobCcQtyCompWsD>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            JobPhases = new HashSet<JobPhases>();
            JobTransferFromD = new HashSet<JobTransferFromD>();
            JobTransferToD = new HashSet<JobTransferToD>();
            JobsPhases = new HashSet<Jobs>();
            JobsPhasesNavigation = new HashSet<Jobs>();
            PayEqpHis = new HashSet<PayEqpHis>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            RecurringTimecard = new HashSet<RecurringTimecard>();
            SalesTaxesPhases = new HashSet<SalesTaxes>();
            SalesTaxesPhases1 = new HashSet<SalesTaxes>();
            SalesTaxesPhasesNavigation = new HashSet<SalesTaxes>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
            StorageTanks = new HashSet<StorageTanks>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmInvoiceJc = new HashSet<TmInvoiceJc>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            TmWorksheetH = new HashSet<TmWorksheetH>();
            WarehousesPhases = new HashSet<Warehouses>();
            WarehousesPhases1 = new HashSet<Warehouses>();
            WarehousesPhasesNavigation = new HashSet<Warehouses>();
        }

        public int CompanyNo { get; set; }
        public string PhaseNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string PhaseId { get; set; }

        public ICollection<AgencyItems> AgencyItems { get; set; }
        public ICollection<AiaHeader> AiaHeader { get; set; }
        public ICollection<AiaItem> AiaItem { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<ControlAr> ControlArPhases { get; set; }
        public ICollection<ControlAr> ControlArPhases1 { get; set; }
        public ICollection<ControlAr> ControlArPhases2 { get; set; }
        public ICollection<ControlAr> ControlArPhases3 { get; set; }
        public ICollection<ControlAr> ControlArPhasesNavigation { get; set; }
        public ICollection<ControlEq> ControlEqPhases { get; set; }
        public ICollection<ControlEq> ControlEqPhasesNavigation { get; set; }
        public ICollection<ControlIn> ControlInPhases { get; set; }
        public ICollection<ControlIn> ControlInPhasesNavigation { get; set; }
        public ICollection<ControlTax> ControlTaxPhases { get; set; }
        public ICollection<ControlTax> ControlTaxPhasesNavigation { get; set; }
        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHPhases { get; set; }
        public ICollection<InventoryJobH> InventoryJobHPhasesNavigation { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<ItemCategories> ItemCategoriesPhases { get; set; }
        public ICollection<ItemCategories> ItemCategoriesPhasesNavigation { get; set; }
        public ICollection<JobCcPercCompWsD> JobCcPercCompWsD { get; set; }
        public ICollection<JobCcQtyCompWsD> JobCcQtyCompWsD { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<JobPhases> JobPhases { get; set; }
        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
        public ICollection<Jobs> JobsPhases { get; set; }
        public ICollection<Jobs> JobsPhasesNavigation { get; set; }
        public ICollection<PayEqpHis> PayEqpHis { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<RecurringTimecard> RecurringTimecard { get; set; }
        public ICollection<SalesTaxes> SalesTaxesPhases { get; set; }
        public ICollection<SalesTaxes> SalesTaxesPhases1 { get; set; }
        public ICollection<SalesTaxes> SalesTaxesPhasesNavigation { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
        public ICollection<StorageTanks> StorageTanks { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmInvoiceJc> TmInvoiceJc { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<TmWorksheetH> TmWorksheetH { get; set; }
        public ICollection<Warehouses> WarehousesPhases { get; set; }
        public ICollection<Warehouses> WarehousesPhases1 { get; set; }
        public ICollection<Warehouses> WarehousesPhasesNavigation { get; set; }
    }
}
