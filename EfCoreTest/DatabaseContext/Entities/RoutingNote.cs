using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingNote
    {
        public RoutingNote()
        {
            InverseParent = new HashSet<RoutingNote>();
        }

        public int Id { get; set; }
        public int RouteId { get; set; }
        public int? ParentId { get; set; }
        public string Subject { get; set; }
        public string UserNo { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Message { get; set; }

        public RoutingNote Parent { get; set; }
        public Routing Route { get; set; }
        public ICollection<RoutingNote> InverseParent { get; set; }
    }
}
