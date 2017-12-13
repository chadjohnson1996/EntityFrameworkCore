using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceFilterRequiredStatus
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public string StatusCode { get; set; }

        public RoutingUserPrefsApInvoiceFilter Filter { get; set; }
    }
}
