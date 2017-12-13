using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdTechnicianGroupNames
    {
        public string Company { get; set; }
        public string TechGroup1 { get; set; }
        public string TechGroup2 { get; set; }
        public string TechGroup3 { get; set; }
        public string TechGroup4 { get; set; }
        public string TechGroup5 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
    }
}
