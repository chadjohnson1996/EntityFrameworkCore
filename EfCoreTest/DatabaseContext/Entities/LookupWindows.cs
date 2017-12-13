using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class LookupWindows
    {
        public string TableName { get; set; }
        public string WindowName { get; set; }
        public int InternalId { get; set; }
        public string ColumnName { get; set; }
    }
}
