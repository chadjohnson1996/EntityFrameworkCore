using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceFilterLabel
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public int LabelId { get; set; }

        public RoutingUserPrefsApInvoiceFilter Filter { get; set; }
        public RoutingLabel Label { get; set; }
    }
}
