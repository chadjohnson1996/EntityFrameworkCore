using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceFilterDateRange
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public RoutingUserPrefsApInvoiceFilter Filter { get; set; }
    }
}
