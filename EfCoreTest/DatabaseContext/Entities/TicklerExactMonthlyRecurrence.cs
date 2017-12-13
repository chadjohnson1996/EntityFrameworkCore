using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerExactMonthlyRecurrence
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public int SpecificDay { get; set; }
        public int RecurrenceMonth { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
