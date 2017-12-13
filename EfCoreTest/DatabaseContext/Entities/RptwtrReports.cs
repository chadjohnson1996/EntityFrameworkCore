using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrReports
    {
        public RptwtrReports()
        {
            RptwtrColumnsLinkedReportNoNavigation = new HashSet<RptwtrColumns>();
            RptwtrColumnsReportNoNavigation = new HashSet<RptwtrColumns>();
            RptwtrDefaults = new HashSet<RptwtrDefaults>();
            RptwtrRatios = new HashSet<RptwtrRatios>();
            RptwtrReportSyntax = new HashSet<RptwtrReportSyntax>();
            RptwtrRows = new HashSet<RptwtrRows>();
        }

        public int ReportNo { get; set; }
        public string ReportType { get; set; }
        public string Description { get; set; }
        public string HeadingLine1 { get; set; }
        public string HeadingLine2 { get; set; }
        public string HeadingLine3 { get; set; }
        public string IconFilename { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? Version { get; set; }
        public string ReportId { get; set; }
        public string ResetPageCount { get; set; }
        public string InJcactivityDddw { get; set; }

        public RptwtrReportTypes ReportTypeNavigation { get; set; }
        public ICollection<RptwtrColumns> RptwtrColumnsLinkedReportNoNavigation { get; set; }
        public ICollection<RptwtrColumns> RptwtrColumnsReportNoNavigation { get; set; }
        public ICollection<RptwtrDefaults> RptwtrDefaults { get; set; }
        public ICollection<RptwtrRatios> RptwtrRatios { get; set; }
        public ICollection<RptwtrReportSyntax> RptwtrReportSyntax { get; set; }
        public ICollection<RptwtrRows> RptwtrRows { get; set; }
    }
}
