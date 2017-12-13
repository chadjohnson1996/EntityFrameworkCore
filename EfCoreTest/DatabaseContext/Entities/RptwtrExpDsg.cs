using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrExpDsg
    {
        public RptwtrExpDsg()
        {
            RptwtrExpDsgColumns = new HashSet<RptwtrExpDsgColumns>();
            RptwtrExpDsgDefaults = new HashSet<RptwtrExpDsgDefaults>();
        }

        public int ReportNo { get; set; }
        public string ReportType { get; set; }
        public string Description { get; set; }
        public string IconFilename { get; set; }
        public string ExportFormat { get; set; }
        public int? Delimiter { get; set; }
        public int? NumericPadCharacter { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? Version { get; set; }
        public string ReportId { get; set; }
        public string SortOrder { get; set; }

        public RptwtrReportTypes ReportTypeNavigation { get; set; }
        public ICollection<RptwtrExpDsgColumns> RptwtrExpDsgColumns { get; set; }
        public ICollection<RptwtrExpDsgDefaults> RptwtrExpDsgDefaults { get; set; }
    }
}
