using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RowsColumns
    {
        public string ColumnId { get; set; }
        public string TableId { get; set; }
        public string ColumnName { get; set; }

        public RowsTables Table { get; set; }
    }
}
