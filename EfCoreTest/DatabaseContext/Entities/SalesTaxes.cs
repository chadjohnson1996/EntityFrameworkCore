using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SalesTaxes
    {
        public SalesTaxes()
        {
            ApInvoiceH = new HashSet<ApInvoiceH>();
            ApShipTo = new HashSet<ApShipTo>();
            ArHistory = new HashSet<ArHistory>();
            ArInvoice = new HashSet<ArInvoice>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            ControlAr = new HashSet<ControlAr>();
            ControlTaxSalesTaxes = new HashSet<ControlTax>();
            ControlTaxSalesTaxesNavigation = new HashSet<ControlTax>();
            Customers = new HashSet<Customers>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobH = new HashSet<InventoryJobH>();
            JobTransferFromD = new HashSet<JobTransferFromD>();
            JobTransferToD = new HashSet<JobTransferToD>();
            Jobs = new HashSet<Jobs>();
            PoSubH = new HashSet<PoSubH>();
            SalesTaxesRates = new HashSet<SalesTaxesRates>();
            ShipTo = new HashSet<ShipTo>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmWorksheetH = new HashSet<TmWorksheetH>();
            Vendors = new HashSet<Vendors>();
            Warehouses = new HashSet<Warehouses>();
        }

        public int CompanyNo { get; set; }
        public string TaxNo { get; set; }
        public string Description { get; set; }
        public string ForcePay { get; set; }
        public decimal? Rate { get; set; }
        public decimal? GlTaxPayable { get; set; }
        public decimal? GlUseTaxExpense { get; set; }
        public decimal? GlUseTaxAccrued { get; set; }
        public decimal? MiscTaxable { get; set; }
        public decimal? FreightTaxable { get; set; }
        public string UseTaxFlag { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string PhaseId { get; set; }
        public string TaxId { get; set; }
        public string StateTaxGroupNo { get; set; }
        public decimal StatePercent { get; set; }
        public decimal CountyPercent { get; set; }
        public decimal OtherPercent { get; set; }
        public string ArUseTaxFlag { get; set; }
        public decimal? ArGlUseTaxExpense { get; set; }
        public decimal? ArGlUseTaxAccrued { get; set; }
        public string ArPhaseNo { get; set; }
        public string ArCostCodeNo { get; set; }
        public string ArCostClassNo { get; set; }
        public decimal? GlSalesTaxExpense { get; set; }
        public string ApSalesPhaseNo { get; set; }
        public string ApSalesCostCodeNo { get; set; }
        public string ApSalesCostClassNo { get; set; }
        public string ApSalesCostClassId { get; set; }
        public string ApSalesCostCodeId { get; set; }
        public string ApSalesPhaseId { get; set; }
        public string ArCostClassId { get; set; }
        public string ArCostCodeId { get; set; }
        public string ArPhaseId { get; set; }
        public string StateTaxGroupId { get; set; }
        public string AllowNegativeAdjUseTax { get; set; }
        public string Provider { get; set; }

        public Accounts Accounts { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostClasses CostClassesNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public CostCodes CostCodesNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases Phases1 { get; set; }
        public Phases PhasesNavigation { get; set; }
        public StateTaxGroups StateTaxGroups { get; set; }
        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<ApShipTo> ApShipTo { get; set; }
        public ICollection<ArHistory> ArHistory { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<ControlAr> ControlAr { get; set; }
        public ICollection<ControlTax> ControlTaxSalesTaxes { get; set; }
        public ICollection<ControlTax> ControlTaxSalesTaxesNavigation { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobH { get; set; }
        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<SalesTaxesRates> SalesTaxesRates { get; set; }
        public ICollection<ShipTo> ShipTo { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmWorksheetH> TmWorksheetH { get; set; }
        public ICollection<Vendors> Vendors { get; set; }
        public ICollection<Warehouses> Warehouses { get; set; }
    }
}
