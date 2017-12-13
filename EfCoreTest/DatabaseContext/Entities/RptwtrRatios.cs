using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrRatios
    {
        public int ReportNo { get; set; }
        public int RatioNo { get; set; }
        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public string Definition { get; set; }
        public int WizardSequenceNo { get; set; }

        public RptwtrReports ReportNoNavigation { get; set; }
    }
}
