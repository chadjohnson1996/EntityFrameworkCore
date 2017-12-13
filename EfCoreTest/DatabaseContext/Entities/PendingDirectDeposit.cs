using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PendingDirectDeposit
    {
        public int CompanyNo { get; set; }
        public decimal AccountNo { get; set; }
        public int SequenceNum { get; set; }
        public int FirstNumber { get; set; }
        public int LastNumber { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccountId { get; set; }
        public string CompanyId { get; set; }
    }
}
