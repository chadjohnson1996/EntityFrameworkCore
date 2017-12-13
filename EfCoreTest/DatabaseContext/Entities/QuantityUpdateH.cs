using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class QuantityUpdateH
    {
        public QuantityUpdateH()
        {
            QuantityUpdateD = new HashSet<QuantityUpdateD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string BidNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PostedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string TransactionId { get; set; }

        public BidH BidH { get; set; }
        public ICollection<QuantityUpdateD> QuantityUpdateD { get; set; }
    }
}
