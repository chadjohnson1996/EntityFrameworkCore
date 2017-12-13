using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerRecipients
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public string UserNo { get; set; }

        public Ticklers Tickler { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
