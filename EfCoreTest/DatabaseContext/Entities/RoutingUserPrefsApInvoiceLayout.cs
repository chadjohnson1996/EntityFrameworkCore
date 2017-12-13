using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceLayout
    {
        public int Id { get; set; }
        public int PrefsApId { get; set; }
        public string LayoutType { get; set; }
        public byte[] LayoutData { get; set; }

        public RoutingUserPrefsApInvoice PrefsAp { get; set; }
    }
}
