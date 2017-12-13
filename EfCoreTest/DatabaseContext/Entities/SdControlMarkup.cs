using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlMarkup
    {
        public string Company { get; set; }
        public string LaborPriceLevel { get; set; }
        public string InventoryPriceLevel { get; set; }
        public string OtherPriceLevel { get; set; }
        public string ExcludeLabor { get; set; }
        public string PriceLevelSequence1 { get; set; }
        public string PriceLevelSequence2 { get; set; }
        public string PriceLevelSequence3 { get; set; }
        public string PriceLevelSequence4 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string PriceLevelSequence5 { get; set; }
        public string CompanyId { get; set; }
        public string PriceLevelSequence6 { get; set; }
    }
}
