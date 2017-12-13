using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmMarkupCompanyD
    {
        public int CompanyNo { get; set; }
        public string MarkupCategory { get; set; }
        public int MarkupLine { get; set; }
        public string MarkupBy { get; set; }
        public string EmployeeNo { get; set; }
        public string VendorNo { get; set; }
        public string EqCategoryNo { get; set; }
        public string EquipmentNo { get; set; }
        public string ItemCategoryNo { get; set; }
        public string ItemNo { get; set; }
        public string CostClassNo { get; set; }
        public string TradeNo { get; set; }
        public string DeptNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string EqUnitType { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EqCategoryId { get; set; }
        public string EquipmentId { get; set; }
        public string ItemCategoryId { get; set; }
        public string ItemId { get; set; }
        public string PhaseId { get; set; }
        public string TradeId { get; set; }
        public string VendorId { get; set; }
        public int OrdinalPosition { get; set; }
        public string PriceLevelNo { get; set; }
        public string PriceLevelId { get; set; }

        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public TmMarkupCompanyH CompanyNoNavigation { get; set; }
        public Departments Departments { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public EqCategories EqCategories { get; set; }
        public Equipment Equipment { get; set; }
        public ItemCategories ItemCategories { get; set; }
        public Items Items { get; set; }
        public Phases Phases { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public Trades Trades { get; set; }
        public Vendors Vendors { get; set; }
    }
}
