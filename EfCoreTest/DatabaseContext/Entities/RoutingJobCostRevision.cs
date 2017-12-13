using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingJobCostRevision
    {
        public RoutingJobCostRevision()
        {
            RoutingJobCostRevisionDetail = new HashSet<RoutingJobCostRevisionDetail>();
        }

        public int Id { get; set; }
        public int RouteId { get; set; }
        public string RevisingUserNo { get; set; }
        public DateTime DateRevised { get; set; }

        public ICollection<RoutingJobCostRevisionDetail> RoutingJobCostRevisionDetail { get; set; }
    }
}
