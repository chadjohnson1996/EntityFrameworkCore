using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Items
    {
        public Items()
        {
            ArInvoiceFrmD = new HashSet<ArInvoiceFrmD>();
            BuyOutD = new HashSet<BuyOutD>();
            DcSubmittalItems = new HashSet<DcSubmittalItems>();
            EqServiceCodesItems = new HashSet<EqServiceCodesItems>();
            EqWoItems = new HashSet<EqWoItems>();
            EqWoJournalItems = new HashSet<EqWoJournalItems>();
            EquipmentServiceItems = new HashSet<EquipmentServiceItems>();
            FieldLogMaterials = new HashSet<FieldLogMaterials>();
            InventoryActivityD = new HashSet<InventoryActivityD>();
            InventoryMatRecD = new HashSet<InventoryMatRecD>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            InventoryWorksheetsD = new HashSet<InventoryWorksheetsD>();
            ItemPriceErrors = new HashSet<ItemPriceErrors>();
            ItemPriceHistory = new HashSet<ItemPriceHistory>();
            ItemPriceLevels = new HashSet<ItemPriceLevels>();
            ItemVendors = new HashSet<ItemVendors>();
            JobHistory = new HashSet<JobHistory>();
            JobScheduleTaskItemResources = new HashSet<JobScheduleTaskItemResources>();
            JobTrx = new HashSet<JobTrx>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubItemD = new HashSet<PoSubItemD>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public decimal StandardPrice { get; set; }
        public decimal StandardCost { get; set; }
        public string PurchasingUnitNo { get; set; }
        public string StockingUnitNo { get; set; }
        public string PrimaryItemCategoryNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string PrimaryItemCategoryId { get; set; }
        public string PurchasingUnitId { get; set; }
        public string StockingUnitId { get; set; }
        public string DeliveryUnitNo { get; set; }
        public string UnitConversionNo { get; set; }
        public string CalculateUnitCost { get; set; }
        public string Base { get; set; }
        public string Operation { get; set; }
        public decimal Amount { get; set; }
        public decimal OnHandAverageCost { get; set; }
        public decimal LastCost { get; set; }
        public DateTime? LastDatePurchased { get; set; }
        public string Item2CategoryNo { get; set; }
        public string Item3CategoryNo { get; set; }
        public string Item4CategoryNo { get; set; }
        public string Item5CategoryNo { get; set; }
        public string Item6CategoryNo { get; set; }
        public string DciAlternate { get; set; }
        public string Upc { get; set; }
        public string ApTaxable { get; set; }
        public string ArTaxable { get; set; }
        public string PriceServiceDescription { get; set; }
        public string DeliveryUnitId { get; set; }
        public string Item2CategoryId { get; set; }
        public string Item3CategoryId { get; set; }
        public string Item4CategoryId { get; set; }
        public string Item5CategoryId { get; set; }
        public string Item6CategoryId { get; set; }
        public string UnitConversionId { get; set; }
        public string BinLocationNo { get; set; }
        public string BinLocationId { get; set; }
        public string DefaultCostCode { get; set; }
        public string DefaultCostClass { get; set; }
        public string DefaultPhase { get; set; }
        public decimal ReorderPoint { get; set; }
        public decimal MaxStockingQty { get; set; }
        public decimal? GlIncome { get; set; }
        public string LastModifiedSource { get; set; }

        public BinLocations BinLocations { get; set; }
        public ItemCategories ItemCategories { get; set; }
        public ItemCategories ItemCategories1 { get; set; }
        public ItemCategories ItemCategories2 { get; set; }
        public ItemCategories ItemCategories3 { get; set; }
        public ItemCategories ItemCategories4 { get; set; }
        public ItemCategories ItemCategoriesNavigation { get; set; }
        public UnitConversionGroup UnitConversionGroup { get; set; }
        public Units Units { get; set; }
        public Units Units1 { get; set; }
        public Units UnitsNavigation { get; set; }
        public ICollection<ArInvoiceFrmD> ArInvoiceFrmD { get; set; }
        public ICollection<BuyOutD> BuyOutD { get; set; }
        public ICollection<DcSubmittalItems> DcSubmittalItems { get; set; }
        public ICollection<EqServiceCodesItems> EqServiceCodesItems { get; set; }
        public ICollection<EqWoItems> EqWoItems { get; set; }
        public ICollection<EqWoJournalItems> EqWoJournalItems { get; set; }
        public ICollection<EquipmentServiceItems> EquipmentServiceItems { get; set; }
        public ICollection<FieldLogMaterials> FieldLogMaterials { get; set; }
        public ICollection<InventoryActivityD> InventoryActivityD { get; set; }
        public ICollection<InventoryMatRecD> InventoryMatRecD { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<InventoryWorksheetsD> InventoryWorksheetsD { get; set; }
        public ICollection<ItemPriceErrors> ItemPriceErrors { get; set; }
        public ICollection<ItemPriceHistory> ItemPriceHistory { get; set; }
        public ICollection<ItemPriceLevels> ItemPriceLevels { get; set; }
        public ICollection<ItemVendors> ItemVendors { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobScheduleTaskItemResources> JobScheduleTaskItemResources { get; set; }
        public ICollection<JobTrx> JobTrx { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
