using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingGroupRecipient
    {
        public int Id { get; set; }
        public int RouteGroupId { get; set; }
        public string UserNo { get; set; }
        public string CanApprove { get; set; }
        public string CanRevise { get; set; }
        public string CanReject { get; set; }
        public string RouteOnNoVote { get; set; }
        public string Vote { get; set; }
        public string Viewed { get; set; }
        public int? LabelId { get; set; }

        public RoutingLabel Label { get; set; }
        public RoutingGroup RouteGroup { get; set; }
    }
}
