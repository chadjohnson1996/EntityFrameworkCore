using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerOccurrences
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public DateTime NextOccurrence { get; set; }
        public DateTime? ReminderTime { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
