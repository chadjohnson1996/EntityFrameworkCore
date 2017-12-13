using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Gl941Postdate
    {
        public int CompanyNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? DateBooked { get; set; }
        public int? TransactionNo { get; set; }
        public string JournalNo { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JournalId { get; set; }
        public string TransactionId { get; set; }
    }
}
