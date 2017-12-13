using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyCalendars
    {
        public int CompanyNo { get; set; }
        public int CalendarId { get; set; }

        public Calendars Calendar { get; set; }
        public Companies CompanyNoNavigation { get; set; }
    }
}
