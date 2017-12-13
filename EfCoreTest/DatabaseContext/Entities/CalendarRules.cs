using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CalendarRules
    {
        public int InternalId { get; set; }
        public int CalendarId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
        public string WorkingTime { get; set; }
        public int RecurrenceCount { get; set; }
        public DateTime RangeStart { get; set; }
        public DateTime RangeEnd { get; set; }
        public int Occurrences { get; set; }

        public Calendars Calendar { get; set; }
    }
}
