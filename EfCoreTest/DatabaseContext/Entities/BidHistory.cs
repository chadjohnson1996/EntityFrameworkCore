using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BidHistory
    {
        public int CompanyNo { get; set; }
        public string BidJobNo { get; set; }
        public int LineNo { get; set; }
        public DateTime Date { get; set; }
        public string HistoryType { get; set; }
        public string BidStatusNo { get; set; }
        public decimal Value { get; set; }
        public string UserNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BidJobId { get; set; }
        public string BidStatusId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string UserId { get; set; }

        public Jobs Jobs { get; set; }
    }
}
