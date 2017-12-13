using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlDivisions
    {
        public GlDivisions()
        {
            AiaHeaderDivision = new HashSet<AiaHeaderDivision>();
            AssetCategoriesDiv = new HashSet<AssetCategoriesDiv>();
            BidDivisions = new HashSet<BidDivisions>();
            DepartmentDivisions = new HashSet<DepartmentDivisions>();
            EmployeeDivisions = new HashSet<EmployeeDivisions>();
            EqAttachmentsDivisions = new HashSet<EqAttachmentsDivisions>();
            EqCategoriesDivExpJrnl = new HashSet<EqCategoriesDivExpJrnl>();
            EqCategoriesDivisions = new HashSet<EqCategoriesDivisions>();
            EqCategoriesFuelDiv = new HashSet<EqCategoriesFuelDiv>();
            EqSrvCodesDivExpJrnl = new HashSet<EqSrvCodesDivExpJrnl>();
            EquipmentDivisions = new HashSet<EquipmentDivisions>();
            EquipmentFuelDivisions = new HashSet<EquipmentFuelDivisions>();
            ItemCategoryDivisions = new HashSet<ItemCategoryDivisions>();
            JobDivisions = new HashSet<JobDivisions>();
            VendorDivisions = new HashSet<VendorDivisions>();
            WarehouseDivisions = new HashSet<WarehouseDivisions>();
        }

        public int CompanyNo { get; set; }
        public decimal DivisionNo { get; set; }
        public decimal DivisionAccountNo { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ShortDesc { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DivisionAccountId { get; set; }
        public string DivisionId { get; set; }

        public ICollection<AiaHeaderDivision> AiaHeaderDivision { get; set; }
        public ICollection<AssetCategoriesDiv> AssetCategoriesDiv { get; set; }
        public ICollection<BidDivisions> BidDivisions { get; set; }
        public ICollection<DepartmentDivisions> DepartmentDivisions { get; set; }
        public ICollection<EmployeeDivisions> EmployeeDivisions { get; set; }
        public ICollection<EqAttachmentsDivisions> EqAttachmentsDivisions { get; set; }
        public ICollection<EqCategoriesDivExpJrnl> EqCategoriesDivExpJrnl { get; set; }
        public ICollection<EqCategoriesDivisions> EqCategoriesDivisions { get; set; }
        public ICollection<EqCategoriesFuelDiv> EqCategoriesFuelDiv { get; set; }
        public ICollection<EqSrvCodesDivExpJrnl> EqSrvCodesDivExpJrnl { get; set; }
        public ICollection<EquipmentDivisions> EquipmentDivisions { get; set; }
        public ICollection<EquipmentFuelDivisions> EquipmentFuelDivisions { get; set; }
        public ICollection<ItemCategoryDivisions> ItemCategoryDivisions { get; set; }
        public ICollection<JobDivisions> JobDivisions { get; set; }
        public ICollection<VendorDivisions> VendorDivisions { get; set; }
        public ICollection<WarehouseDivisions> WarehouseDivisions { get; set; }
    }
}
