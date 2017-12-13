using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Ticklers
    {
        public Ticklers()
        {
            TicklerDailyRecurrence = new HashSet<TicklerDailyRecurrence>();
            TicklerEndByRangeRecurrence = new HashSet<TicklerEndByRangeRecurrence>();
            TicklerExactMonthlyRecurrence = new HashSet<TicklerExactMonthlyRecurrence>();
            TicklerExactYearlyRecurrence = new HashSet<TicklerExactYearlyRecurrence>();
            TicklerFixedRangeRecurrence = new HashSet<TicklerFixedRangeRecurrence>();
            TicklerOccurrences = new HashSet<TicklerOccurrences>();
            TicklerRecipients = new HashSet<TicklerRecipients>();
            TicklerRelativeMonthlyRecurrence = new HashSet<TicklerRelativeMonthlyRecurrence>();
            TicklerRelativeYearlyRecurrence = new HashSet<TicklerRelativeYearlyRecurrence>();
            TicklerWeekdayRecurrence = new HashSet<TicklerWeekdayRecurrence>();
            TicklerWeeklyRecurrence = new HashSet<TicklerWeeklyRecurrence>();
        }

        public int Id { get; set; }
        public int NoteId { get; set; }
        public string UserNo { get; set; }
        public string TicklerType { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public int? ReminderTimeInMinutes { get; set; }

        public StickyNotes Note { get; set; }
        public Users UserNoNavigation { get; set; }
        public ICollection<TicklerDailyRecurrence> TicklerDailyRecurrence { get; set; }
        public ICollection<TicklerEndByRangeRecurrence> TicklerEndByRangeRecurrence { get; set; }
        public ICollection<TicklerExactMonthlyRecurrence> TicklerExactMonthlyRecurrence { get; set; }
        public ICollection<TicklerExactYearlyRecurrence> TicklerExactYearlyRecurrence { get; set; }
        public ICollection<TicklerFixedRangeRecurrence> TicklerFixedRangeRecurrence { get; set; }
        public ICollection<TicklerOccurrences> TicklerOccurrences { get; set; }
        public ICollection<TicklerRecipients> TicklerRecipients { get; set; }
        public ICollection<TicklerRelativeMonthlyRecurrence> TicklerRelativeMonthlyRecurrence { get; set; }
        public ICollection<TicklerRelativeYearlyRecurrence> TicklerRelativeYearlyRecurrence { get; set; }
        public ICollection<TicklerWeekdayRecurrence> TicklerWeekdayRecurrence { get; set; }
        public ICollection<TicklerWeeklyRecurrence> TicklerWeeklyRecurrence { get; set; }
    }
}
