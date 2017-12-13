using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerEndByRangeRecurrence
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public DateTime EndBy { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
