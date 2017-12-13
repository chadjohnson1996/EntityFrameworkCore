using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRule
    {
        public RoutingRule()
        {
            RoutingRuleActivity = new HashSet<RoutingRuleActivity>();
            RoutingRuleEnteredBy = new HashSet<RoutingRuleEnteredBy>();
            RoutingRuleRecipient = new HashSet<RoutingRuleRecipient>();
            RoutingRuleRelatedRecordType = new HashSet<RoutingRuleRelatedRecordType>();
            RoutingRuleRelatedRecordValue = new HashSet<RoutingRuleRelatedRecordValue>();
        }

        public int Id { get; set; }
        public int CompanyNo { get; set; }
        public int RecordTypeId { get; set; }
        public int Position { get; set; }
        public string ApprovalMode { get; set; }
        public string Enabled { get; set; }
        public string Name { get; set; }

        public RecordType RecordType { get; set; }
        public ICollection<RoutingRuleActivity> RoutingRuleActivity { get; set; }
        public ICollection<RoutingRuleEnteredBy> RoutingRuleEnteredBy { get; set; }
        public ICollection<RoutingRuleRecipient> RoutingRuleRecipient { get; set; }
        public ICollection<RoutingRuleRelatedRecordType> RoutingRuleRelatedRecordType { get; set; }
        public ICollection<RoutingRuleRelatedRecordValue> RoutingRuleRelatedRecordValue { get; set; }
    }
}
