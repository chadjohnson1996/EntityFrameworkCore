using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRuleEnteredBy
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public string UserNo { get; set; }
        public string ViewRoutingDialog { get; set; }
        public string ViewRecipients { get; set; }
        public string RemoveRecipients { get; set; }
        public string AddRecipients { get; set; }
        public string AddedRecipientsViewOnly { get; set; }
        public string AddNotes { get; set; }
        public string RequireNotes { get; set; }

        public RoutingRule Rule { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
