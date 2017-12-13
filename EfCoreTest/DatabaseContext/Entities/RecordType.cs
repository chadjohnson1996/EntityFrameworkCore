using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RecordType
    {
        public RecordType()
        {
            RoutingNotification = new HashSet<RoutingNotification>();
            RoutingRule = new HashSet<RoutingRule>();
            RoutingRuleRelatedRecordType = new HashSet<RoutingRuleRelatedRecordType>();
        }

        public int Id { get; set; }
        public int EntityId { get; set; }
        public string DescSingular { get; set; }
        public string DescPlural { get; set; }
        public string BaseTable { get; set; }
        public string StdKeyField { get; set; }
        public string StdKeyFieldDatatype { get; set; }
        public string StdDropdown { get; set; }

        public ICollection<RoutingNotification> RoutingNotification { get; set; }
        public ICollection<RoutingRule> RoutingRule { get; set; }
        public ICollection<RoutingRuleRelatedRecordType> RoutingRuleRelatedRecordType { get; set; }
    }
}
