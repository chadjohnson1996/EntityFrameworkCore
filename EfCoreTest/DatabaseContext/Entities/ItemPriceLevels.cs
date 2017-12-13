using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemPriceLevels
    {
        public int CompanyNo { get; set; }
        public string ItemNo { get; set; }
        public string PriceLevelNo { get; set; }
        public string Base { get; set; }
        public string Operation { get; set; }
        public decimal Amount { get; set; }
        public string DefaultFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string PriceLevelId { get; set; }

        public Items Items { get; set; }
        public PriceLevels PriceLevels { get; set; }
    }
}
