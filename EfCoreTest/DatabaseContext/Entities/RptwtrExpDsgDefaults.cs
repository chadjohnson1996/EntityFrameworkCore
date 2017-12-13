using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrExpDsgDefaults
    {
        public int ReportNo { get; set; }
        public string Criteria { get; set; }
        public string DefaultValue { get; set; }

        public RptwtrExpDsg ReportNoNavigation { get; set; }
    }
}
