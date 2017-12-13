using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobPriceLevels
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string ItemCategoryNo { get; set; }
        public string PriceLevelNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemCategoryId { get; set; }
        public string JobId { get; set; }
        public string PriceLevelId { get; set; }

        public ItemCategories ItemCategories { get; set; }
        public Jobs Jobs { get; set; }
        public PriceLevels PriceLevels { get; set; }
    }
}
