using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoice
    {
        public RoutingUserPrefsApInvoice()
        {
            RoutingUserPrefsApInvoiceFilter = new HashSet<RoutingUserPrefsApInvoiceFilter>();
            RoutingUserPrefsApInvoiceLayout = new HashSet<RoutingUserPrefsApInvoiceLayout>();
        }

        public int Id { get; set; }
        public int PrefsId { get; set; }
        public string UserRoutingDefaultOn { get; set; }
        public int? SavedFilterId { get; set; }

        public RoutingUserPrefs Prefs { get; set; }
        public RoutingUserPrefsApInvoiceFilter SavedFilter { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilter> RoutingUserPrefsApInvoiceFilter { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceLayout> RoutingUserPrefsApInvoiceLayout { get; set; }
    }
}
