using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerWeeklyRecurrenceDay
    {
        public int Id { get; set; }
        public int WeeklyId { get; set; }
        public int DayOfWeek { get; set; }

        public TicklerWeeklyRecurrence Weekly { get; set; }
    }
}
