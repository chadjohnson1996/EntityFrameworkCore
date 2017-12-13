using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Calendars
    {
        public Calendars()
        {
            CalendarRules = new HashSet<CalendarRules>();
            CompanyCalendars = new HashSet<CompanyCalendars>();
        }

        public int InternalId { get; set; }
        public int CompanyNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }

        public ICollection<CalendarRules> CalendarRules { get; set; }
        public ICollection<CompanyCalendars> CompanyCalendars { get; set; }
    }
}
