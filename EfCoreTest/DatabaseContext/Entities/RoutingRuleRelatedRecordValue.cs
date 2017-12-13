using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRuleRelatedRecordValue
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string Value { get; set; }

        public RoutingRule Rule { get; set; }
    }
}
