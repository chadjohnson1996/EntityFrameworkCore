using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class LienWaiverHistory
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string VendorNo { get; set; }
        public int SeqNo { get; set; }
        public string PoSubNo { get; set; }
        public string FinalPartialFlag { get; set; }
        public DateTime? WaiverDate { get; set; }
        public DateTime? CheckDate { get; set; }
        public int CheckNo { get; set; }
        public decimal CheckAmount { get; set; }
        public DateTime? PrintedDate { get; set; }
        public string ReturnedFlag { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string PoSubId { get; set; }
        public string SeqId { get; set; }
        public string VendorId { get; set; }
    }
}
