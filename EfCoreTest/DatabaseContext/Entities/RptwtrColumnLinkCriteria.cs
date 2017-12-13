using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrColumnLinkCriteria
    {
        public int ReportNo { get; set; }
        public int ColumnNo { get; set; }
        public string CriteriaName { get; set; }
        public string DefaultValue { get; set; }

        public RptwtrColumns RptwtrColumns { get; set; }
    }
}
