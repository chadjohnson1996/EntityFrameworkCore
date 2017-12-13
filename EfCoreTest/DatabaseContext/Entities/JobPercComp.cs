using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobPercComp
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public double PercentComplete { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public int? TransactionNo { get; set; }
        public string TransactionId { get; set; }

        public Jobs Jobs { get; set; }
    }
}
