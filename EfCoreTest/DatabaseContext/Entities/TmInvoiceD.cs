using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmInvoiceD
    {
        public int CompanyNo { get; set; }
        public string InvoiceNo { get; set; }
        public string MarkupCategory { get; set; }
        public int MarkupLine { get; set; }
        public string PostedFlag { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string VendorNo { get; set; }
        public string VendorName { get; set; }
        public int? VoucherNo { get; set; }
        public DateTime? VoucherDate { get; set; }
        public string EqCategoryNo { get; set; }
        public string EqCategoryDescription { get; set; }
        public string EquipmentNo { get; set; }
        public string EquipmentDescription { get; set; }
        public string ItemCategoryNo { get; set; }
        public string ItemCategoryDescription { get; set; }
        public string ItemNo { get; set; }
        public string ItemDescription { get; set; }
        public string CostClassNo { get; set; }
        public string CostClassDescription { get; set; }
        public string TradeNo { get; set; }
        public string TradeDescription { get; set; }
        public string DeptNo { get; set; }
        public string DeptDescription { get; set; }
        public string EarnTypeNo { get; set; }
        public string EarnTypeDescription { get; set; }
        public string EqUnitType { get; set; }
        public string PhaseNo { get; set; }
        public string PhaseDescription { get; set; }
        public string CostCodeNo { get; set; }
        public string CostCodeDescription { get; set; }
        public string CostCodeGroupNo { get; set; }
        public string CostCodeGroupDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public DateTime? DateBooked { get; set; }
        public string Comment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int OrdinalPosition { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeGroupId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EqCategoryId { get; set; }
        public string EquipmentId { get; set; }
        public string InvoiceId { get; set; }
        public string ItemCategoryId { get; set; }
        public string ItemId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public string ApInvoiceNo { get; set; }
        public DateTime? ApInvoiceDate { get; set; }
        public string TimecardDescription { get; set; }
        public string PriceLevelNo { get; set; }
        public string PriceLevelDescription { get; set; }
        public string ApInvoiceId { get; set; }
        public string PriceLevelId { get; set; }
        public string ApInvoiceDesc { get; set; }
        public string UnitOfMeasure { get; set; }
        public string InventoryUsageComment { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string DeliveryTimeType { get; set; }
        public DateTime? DeliveryTimeMilitary { get; set; }
        public DateTime? EndTime { get; set; }
        public string EndTimeType { get; set; }
        public DateTime? EndTimeMilitary { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes Co1 { get; set; }
        public CostCodeGroups CoNavigation { get; set; }
        public Departments Departments { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public EqCategories EqCategories { get; set; }
        public Equipment Equipment { get; set; }
        public ItemCategories ItemCategories { get; set; }
        public Items Items { get; set; }
        public Phases Phases { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public TmInvoiceH TmInvoiceH { get; set; }
        public Trades Trades { get; set; }
        public Vendors Vendors { get; set; }
    }
}
