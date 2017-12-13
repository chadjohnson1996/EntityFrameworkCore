using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BuyOutD
    {
        public int CompanyNo { get; set; }
        public int BuyOutNo { get; set; }
        public int SequenceNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public decimal UnitCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BuyOutId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public string SequenceId { get; set; }
        public string UnitId { get; set; }

        public BuyOutH BuyOutH { get; set; }
        public Items Items { get; set; }
        public Units Units { get; set; }
    }
}
