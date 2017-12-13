using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RowsTables
    {
        public RowsTables()
        {
            RowsColumns = new HashSet<RowsColumns>();
        }

        public string TableId { get; set; }
        public string TableName { get; set; }

        public ICollection<RowsColumns> RowsColumns { get; set; }
    }
}
