using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerWeeklyRecurrence
    {
        public TicklerWeeklyRecurrence()
        {
            TicklerWeeklyRecurrenceDay = new HashSet<TicklerWeeklyRecurrenceDay>();
        }

        public int Id { get; set; }
        public int TicklerId { get; set; }
        public int Recurrence { get; set; }

        public Ticklers Tickler { get; set; }
        public ICollection<TicklerWeeklyRecurrenceDay> TicklerWeeklyRecurrenceDay { get; set; }
    }
}
