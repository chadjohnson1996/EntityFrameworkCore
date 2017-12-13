using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrColumnSortCriteria
    {
        public int ReportNo { get; set; }
        public int SequenceNo { get; set; }
        public int ColumnNo { get; set; }
        public string ColumnAlias { get; set; }
        public string SortOption { get; set; }
        public string SortOrder { get; set; }
        public string Subtotal { get; set; }
        public string NewPage { get; set; }
        public string ResetPageCount { get; set; }
        public string HeaderLegend { get; set; }
        public string TrailerLegend { get; set; }

        public RptwtrColumns RptwtrColumns { get; set; }
    }
}
