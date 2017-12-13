using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceFilterEnteredByUser
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public string UserNo { get; set; }

        public RoutingUserPrefsApInvoiceFilter Filter { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
