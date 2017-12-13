using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AssetCategories
    {
        public AssetCategories()
        {
            AssetCategoriesBooks = new HashSet<AssetCategoriesBooks>();
            AssetCategoriesDiv = new HashSet<AssetCategoriesDiv>();
            Equipment = new HashSet<Equipment>();
        }

        public int CompanyNo { get; set; }
        public string AssetCategoryNo { get; set; }
        public string Description { get; set; }
        public decimal? GlAccumDepr { get; set; }
        public decimal? GlDeprExpense { get; set; }
        public string PptPercentCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AssetCategoryId { get; set; }
        public string CompanyId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public DeprMethods DeprMethods { get; set; }
        public ICollection<AssetCategoriesBooks> AssetCategoriesBooks { get; set; }
        public ICollection<AssetCategoriesDiv> AssetCategoriesDiv { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
