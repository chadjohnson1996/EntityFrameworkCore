using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class QuantityUpdateD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int SequenceNo { get; set; }
        public string BidNo { get; set; }
        public string PostedFlag { get; set; }
        public decimal Quantity { get; set; }
        public decimal Percentage { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string SequenceId { get; set; }
        public string TransactionId { get; set; }
        public string DetDescription { get; set; }

        public BidD BidD { get; set; }
        public BidH BidH { get; set; }
        public QuantityUpdateH QuantityUpdateH { get; set; }
    }
}
