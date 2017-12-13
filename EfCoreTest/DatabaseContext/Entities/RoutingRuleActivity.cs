using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRuleActivity
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string ActivityCode { get; set; }

        public RoutingRule Rule { get; set; }
    }
}
