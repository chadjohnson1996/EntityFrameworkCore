using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Module
    {
        public int? CompanyNo { get; set; }
        public string ModuleNo { get; set; }
        public string ModuleName { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string CompanyId { get; set; }
        public string ModuleId { get; set; }
    }
}
