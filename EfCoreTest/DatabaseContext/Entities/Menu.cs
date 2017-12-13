using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Menu
    {
        public int MenuNo { get; set; }
        public int? Parent { get; set; }
        public string Name { get; set; }
        public int? TypeMenu { get; set; }
        public string Window { get; set; }
        public int? WindowType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string MenuId { get; set; }
    }
}
