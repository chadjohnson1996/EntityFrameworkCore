using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomReportItems
    {
        public int CustomItemId { get; set; }
        public string ReportIdentifier { get; set; }
        public DateTime? ReportDateTimeModified { get; set; }
        public string ReportSyntax { get; set; }
        public string CriteriaSyntax { get; set; }
        public int GroupId { get; set; }

        public CustomItems CustomItem { get; set; }
        public CustomReportGroups Group { get; set; }
    }
}
