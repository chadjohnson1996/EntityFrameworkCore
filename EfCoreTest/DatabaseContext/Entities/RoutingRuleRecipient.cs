using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRuleRecipient
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string UserNo { get; set; }
        public string CanApprove { get; set; }
        public string CanRevise { get; set; }
        public string CanReject { get; set; }
        public string RouteOnNoVote { get; set; }

        public RoutingRule Rule { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
