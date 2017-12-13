using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsApInvoiceFilter
    {
        public RoutingUserPrefsApInvoiceFilter()
        {
            RoutingUserPrefsApInvoice = new HashSet<RoutingUserPrefsApInvoice>();
            RoutingUserPrefsApInvoiceFilterDateRange = new HashSet<RoutingUserPrefsApInvoiceFilterDateRange>();
            RoutingUserPrefsApInvoiceFilterEnteredByUser = new HashSet<RoutingUserPrefsApInvoiceFilterEnteredByUser>();
            RoutingUserPrefsApInvoiceFilterLabel = new HashSet<RoutingUserPrefsApInvoiceFilterLabel>();
            RoutingUserPrefsApInvoiceFilterOptionalStatus = new HashSet<RoutingUserPrefsApInvoiceFilterOptionalStatus>();
            RoutingUserPrefsApInvoiceFilterRequiredStatus = new HashSet<RoutingUserPrefsApInvoiceFilterRequiredStatus>();
        }

        public int Id { get; set; }
        public int PrefsApId { get; set; }
        public string Name { get; set; }
        public string FilterType { get; set; }
        public string Source { get; set; }
        public string IncludeSent { get; set; }
        public string IncludeReceived { get; set; }

        public RoutingUserPrefsApInvoice PrefsAp { get; set; }
        public ICollection<RoutingUserPrefsApInvoice> RoutingUserPrefsApInvoice { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterDateRange> RoutingUserPrefsApInvoiceFilterDateRange { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterEnteredByUser> RoutingUserPrefsApInvoiceFilterEnteredByUser { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterLabel> RoutingUserPrefsApInvoiceFilterLabel { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterOptionalStatus> RoutingUserPrefsApInvoiceFilterOptionalStatus { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterRequiredStatus> RoutingUserPrefsApInvoiceFilterRequiredStatus { get; set; }
    }
}
