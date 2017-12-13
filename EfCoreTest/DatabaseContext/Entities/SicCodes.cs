using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SicCodes
    {
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string SicCodeNo { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string SicCodeId { get; set; }
    }
}
