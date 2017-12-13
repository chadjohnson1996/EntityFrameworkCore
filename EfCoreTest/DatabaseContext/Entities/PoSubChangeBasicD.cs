using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PoSubChangeBasicD
    {
        public int CompanyNo { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int SequenceNo { get; set; }
        public int OrdinalPosition { get; set; }
        public string Description { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string PoSubId { get; set; }
        public string SequenceId { get; set; }

        public PoSubChangeH PoSubChangeH { get; set; }
    }
}
