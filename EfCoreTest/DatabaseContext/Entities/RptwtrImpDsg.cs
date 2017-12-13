using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrImpDsg
    {
        public RptwtrImpDsg()
        {
            RptwtrImpDsgColumns = new HashSet<RptwtrImpDsgColumns>();
            RptwtrImpDsgDefaults = new HashSet<RptwtrImpDsgDefaults>();
        }

        public int ReportNo { get; set; }
        public string ReportType { get; set; }
        public string Description { get; set; }
        public string TableForSelectedColumns { get; set; }
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

        public RptwtrReportTypes ReportTypeNavigation { get; set; }
        public ICollection<RptwtrImpDsgColumns> RptwtrImpDsgColumns { get; set; }
        public ICollection<RptwtrImpDsgDefaults> RptwtrImpDsgDefaults { get; set; }
    }
}
