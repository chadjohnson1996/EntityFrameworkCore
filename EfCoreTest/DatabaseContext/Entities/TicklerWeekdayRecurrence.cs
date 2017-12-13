using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerWeekdayRecurrence
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
