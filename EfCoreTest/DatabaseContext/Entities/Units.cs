using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Units
    {
        public Units()
        {
            AgencyItems = new HashSet<AgencyItems>();
            ArInvoiceFrmDUnits = new HashSet<ArInvoiceFrmD>();
            ArInvoiceFrmDUnitsNavigation = new HashSet<ArInvoiceFrmD>();
            BidD = new HashSet<BidD>();
            BuyOutD = new HashSet<BuyOutD>();
            CostCodes = new HashSet<CostCodes>();
            EqServiceCodesItems = new HashSet<EqServiceCodesItems>();
            EqServiceCodesNonInv = new HashSet<EqServiceCodesNonInv>();
            EqWoItems = new HashSet<EqWoItems>();
            EqWoJournalItemsUnits = new HashSet<EqWoJournalItems>();
            EqWoJournalItemsUnitsNavigation = new HashSet<EqWoJournalItems>();
            EqWoJournalNonInv = new HashSet<EqWoJournalNonInv>();
            EqWoNonInv = new HashSet<EqWoNonInv>();
            EquipmentServiceItems = new HashSet<EquipmentServiceItems>();
            EquipmentServiceNonInv = new HashSet<EquipmentServiceNonInv>();
            FieldLogMaterials = new HashSet<FieldLogMaterials>();
            InventoryActivityDUnits = new HashSet<InventoryActivityD>();
            InventoryActivityDUnitsNavigation = new HashSet<InventoryActivityD>();
            InventoryJobMatD = new HashSet<InventoryJobMatD>();
            InventoryReceiptsDUnits = new HashSet<InventoryReceiptsD>();
            InventoryReceiptsDUnitsNavigation = new HashSet<InventoryReceiptsD>();
            InventoryWorksheetsD = new HashSet<InventoryWorksheetsD>();
            ItemPriceHistory = new HashSet<ItemPriceHistory>();
            ItemVendorsUnits = new HashSet<ItemVendors>();
            ItemVendorsUnitsNavigation = new HashSet<ItemVendors>();
            ItemsUnits = new HashSet<Items>();
            ItemsUnits1 = new HashSet<Items>();
            ItemsUnitsNavigation = new HashSet<Items>();
            JobCostcodes = new HashSet<JobCostcodes>();
            JobHistory = new HashSet<JobHistory>();
            JobTrx = new HashSet<JobTrx>();
            PoSubChangeItemDUnits = new HashSet<PoSubChangeItemD>();
            PoSubChangeItemDUnits1 = new HashSet<PoSubChangeItemD>();
            PoSubChangeItemDUnitsNavigation = new HashSet<PoSubChangeItemD>();
            PoSubItemDUnits = new HashSet<PoSubItemD>();
            PoSubItemDUnits1 = new HashSet<PoSubItemD>();
            PoSubItemDUnitsNavigation = new HashSet<PoSubItemD>();
            UnitConversionDetail = new HashSet<UnitConversionDetail>();
            UnitConversionGroupUnits = new HashSet<UnitConversionGroup>();
            UnitConversionGroupUnitsNavigation = new HashSet<UnitConversionGroup>();
        }

        public int CompanyNo { get; set; }
        public string UnitNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string UnitId { get; set; }
        public string LumpSum { get; set; }

        public ICollection<AgencyItems> AgencyItems { get; set; }
        public ICollection<ArInvoiceFrmD> ArInvoiceFrmDUnits { get; set; }
        public ICollection<ArInvoiceFrmD> ArInvoiceFrmDUnitsNavigation { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<BuyOutD> BuyOutD { get; set; }
        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<EqServiceCodesItems> EqServiceCodesItems { get; set; }
        public ICollection<EqServiceCodesNonInv> EqServiceCodesNonInv { get; set; }
        public ICollection<EqWoItems> EqWoItems { get; set; }
        public ICollection<EqWoJournalItems> EqWoJournalItemsUnits { get; set; }
        public ICollection<EqWoJournalItems> EqWoJournalItemsUnitsNavigation { get; set; }
        public ICollection<EqWoJournalNonInv> EqWoJournalNonInv { get; set; }
        public ICollection<EqWoNonInv> EqWoNonInv { get; set; }
        public ICollection<EquipmentServiceItems> EquipmentServiceItems { get; set; }
        public ICollection<EquipmentServiceNonInv> EquipmentServiceNonInv { get; set; }
        public ICollection<FieldLogMaterials> FieldLogMaterials { get; set; }
        public ICollection<InventoryActivityD> InventoryActivityDUnits { get; set; }
        public ICollection<InventoryActivityD> InventoryActivityDUnitsNavigation { get; set; }
        public ICollection<InventoryJobMatD> InventoryJobMatD { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsDUnits { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsDUnitsNavigation { get; set; }
        public ICollection<InventoryWorksheetsD> InventoryWorksheetsD { get; set; }
        public ICollection<ItemPriceHistory> ItemPriceHistory { get; set; }
        public ICollection<ItemVendors> ItemVendorsUnits { get; set; }
        public ICollection<ItemVendors> ItemVendorsUnitsNavigation { get; set; }
        public ICollection<Items> ItemsUnits { get; set; }
        public ICollection<Items> ItemsUnits1 { get; set; }
        public ICollection<Items> ItemsUnitsNavigation { get; set; }
        public ICollection<JobCostcodes> JobCostcodes { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobTrx> JobTrx { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemDUnits { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemDUnits1 { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemDUnitsNavigation { get; set; }
        public ICollection<PoSubItemD> PoSubItemDUnits { get; set; }
        public ICollection<PoSubItemD> PoSubItemDUnits1 { get; set; }
        public ICollection<PoSubItemD> PoSubItemDUnitsNavigation { get; set; }
        public ICollection<UnitConversionDetail> UnitConversionDetail { get; set; }
        public ICollection<UnitConversionGroup> UnitConversionGroupUnits { get; set; }
        public ICollection<UnitConversionGroup> UnitConversionGroupUnitsNavigation { get; set; }
    }
}
