using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrImpDsgDefaults
    {
        public int ReportNo { get; set; }
        public string Criteria { get; set; }
        public string DefaultValue { get; set; }

        public RptwtrImpDsg ReportNoNavigation { get; set; }
    }
}
