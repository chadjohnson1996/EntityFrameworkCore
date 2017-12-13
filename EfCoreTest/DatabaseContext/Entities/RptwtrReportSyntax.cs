using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrReportSyntax
    {
        public int ReportNo { get; set; }
        public int SegmentNo { get; set; }
        public string SyntaxSegment { get; set; }

        public RptwtrReports ReportNoNavigation { get; set; }
    }
}
