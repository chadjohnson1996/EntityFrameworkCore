using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRuleRelatedRecordType
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public int RelatedRecordTypeId { get; set; }

        public RecordType RelatedRecordType { get; set; }
        public RoutingRule Rule { get; set; }
    }
}
