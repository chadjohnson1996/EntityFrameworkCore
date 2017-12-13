using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdTechniciansAttachedGroups
    {
        public string Company { get; set; }
        public int TechSequence { get; set; }
        public int GroupLevel { get; set; }
        public string GroupNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string GroupId { get; set; }
    }
}
