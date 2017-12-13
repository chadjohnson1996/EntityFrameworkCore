using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeprPercents
    {
        public int CompanyNo { get; set; }
        public string DeprCode { get; set; }
        public int LineNo { get; set; }
        public decimal Year { get; set; }
        public decimal Percentage { get; set; }
        public decimal Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }

        public DeprMethods DeprMethods { get; set; }
    }
}
