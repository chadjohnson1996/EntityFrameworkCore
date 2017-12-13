using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchPriorityCodes
    {
        public int CompanyNo { get; set; }
        public int SequenceNumber { get; set; }
        public int? OrdinalPosition { get; set; }
        public string Description { get; set; }
        public string DefaultValue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PriorityCodeNo { get; set; }
        public string CompanyId { get; set; }
        public string PriorityCodeId { get; set; }
    }
}
