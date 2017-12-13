using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StateReductRates
    {
        public string StateNo { get; set; }
        public int ReturnYear { get; set; }
        public decimal StateReductRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string StateId { get; set; }
    }
}
