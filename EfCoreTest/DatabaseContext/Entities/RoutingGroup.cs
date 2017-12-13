using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingGroup
    {
        public RoutingGroup()
        {
            RoutingGroupRecipient = new HashSet<RoutingGroupRecipient>();
        }

        public int Id { get; set; }
        public int? PrecedingGroupId { get; set; }
        public int RouteId { get; set; }
        public string RoutedFromUserNo { get; set; }
        public DateTime RoutedOn { get; set; }
        public string ApprovalMode { get; set; }
        public string Outcome { get; set; }
        public string Status { get; set; }

        public Routing Route { get; set; }
        public ICollection<RoutingGroupRecipient> RoutingGroupRecipient { get; set; }
    }
}
