using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PriceLevels
    {
        public PriceLevels()
        {
            ArInvoiceFrmD = new HashSet<ArInvoiceFrmD>();
            ControlAr = new HashSet<ControlAr>();
            CustomerPriceLevels = new HashSet<CustomerPriceLevels>();
            CustomersPriceLevels = new HashSet<Customers>();
            CustomersPriceLevelsNavigation = new HashSet<Customers>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHPriceLevels = new HashSet<InventoryJobH>();
            InventoryJobHPriceLevelsNavigation = new HashSet<InventoryJobH>();
            ItemPriceLevels = new HashSet<ItemPriceLevels>();
            JobHistory = new HashSet<JobHistory>();
            JobPriceLevels = new HashSet<JobPriceLevels>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string PriceLevelNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string PriceLevelId { get; set; }
        public string Base { get; set; }
        public string Operation { get; set; }
        public decimal Amount { get; set; }

        public ICollection<ArInvoiceFrmD> ArInvoiceFrmD { get; set; }
        public ICollection<ControlAr> ControlAr { get; set; }
        public ICollection<CustomerPriceLevels> CustomerPriceLevels { get; set; }
        public ICollection<Customers> CustomersPriceLevels { get; set; }
        public ICollection<Customers> CustomersPriceLevelsNavigation { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHPriceLevels { get; set; }
        public ICollection<InventoryJobH> InventoryJobHPriceLevelsNavigation { get; set; }
        public ICollection<ItemPriceLevels> ItemPriceLevels { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobPriceLevels> JobPriceLevels { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
