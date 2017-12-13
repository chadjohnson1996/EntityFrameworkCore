using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AssetCategoriesBooks
    {
        public int CompanyNo { get; set; }
        public string AssetCategoryNo { get; set; }
        public int LineNo { get; set; }
        public string BookType { get; set; }
        public string MethodCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AssetCategoryId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }

        public AssetCategories AssetCategories { get; set; }
        public BookTypes BookTypes { get; set; }
        public DeprMethods DeprMethods { get; set; }
    }
}
