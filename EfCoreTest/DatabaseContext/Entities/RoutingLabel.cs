using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingLabel
    {
        public RoutingLabel()
        {
            RoutingGroupRecipient = new HashSet<RoutingGroupRecipient>();
            RoutingUserPrefsApInvoiceFilterLabel = new HashSet<RoutingUserPrefsApInvoiceFilterLabel>();
        }

        public int Id { get; set; }
        public int ImageIndex { get; set; }
        public string Caption { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<RoutingGroupRecipient> RoutingGroupRecipient { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterLabel> RoutingUserPrefsApInvoiceFilterLabel { get; set; }
    }
}
