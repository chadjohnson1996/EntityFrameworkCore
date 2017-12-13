using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Routing
    {
        public Routing()
        {
            RoutingGroup = new HashSet<RoutingGroup>();
            RoutingNote = new HashSet<RoutingNote>();
        }

        public int Id { get; set; }
        public string TableName { get; set; }
        public int RowNo { get; set; }
        public int CompanyNo { get; set; }
        public string StartedByUserNo { get; set; }

        public ICollection<RoutingGroup> RoutingGroup { get; set; }
        public ICollection<RoutingNote> RoutingNote { get; set; }
    }
}
