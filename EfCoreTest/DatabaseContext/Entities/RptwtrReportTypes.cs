using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrReportTypes
    {
        public RptwtrReportTypes()
        {
            RptwtrExpDsg = new HashSet<RptwtrExpDsg>();
            RptwtrImpDsg = new HashSet<RptwtrImpDsg>();
            RptwtrReports = new HashSet<RptwtrReports>();
        }

        public string ReportType { get; set; }
        public string Description { get; set; }
        public string CriteriaDatawindow { get; set; }
        public string SecondCriteriaDatawindow { get; set; }
        public string HiddenCriteriaDatawindow { get; set; }
        public string BusinessRule { get; set; }
        public string RptwtrObject { get; set; }
        public string ThirdCriteriaDatawindow { get; set; }

        public ICollection<RptwtrExpDsg> RptwtrExpDsg { get; set; }
        public ICollection<RptwtrImpDsg> RptwtrImpDsg { get; set; }
        public ICollection<RptwtrReports> RptwtrReports { get; set; }
    }
}
