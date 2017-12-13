using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Tickler
    {
        public decimal TicklerId { get; set; }
        public int CompanyNo { get; set; }
        public string TableName { get; set; }
        public int RowNo { get; set; }
        public string ColumnName { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string DisplayDescription { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string UserNo { get; set; }
        public DateTime DueDateTime { get; set; }
    }
}
