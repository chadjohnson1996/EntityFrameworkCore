using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Class
    {
        public string Name { get; set; }
        public string Parent { get; set; }
        public string Description { get; set; }
        public int? KeyCode { get; set; }
        public int? KeyFlags { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
    }
}
