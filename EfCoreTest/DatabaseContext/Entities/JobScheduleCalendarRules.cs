using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleCalendarRules
    {
        public int CompanyNo { get; set; }
        public int ScheduleId { get; set; }
        public string WorkingTime { get; set; }
        public int TimeMode { get; set; }
        public string RecurringPeriod { get; set; }
        public int DayFrom { get; set; }
        public int DayTo { get; set; }
        public int HoursFrom { get; set; }
        public int HoursTo { get; set; }
        public string RuleName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int? TimeColor { get; set; }
        public int RecurringOption { get; set; }
        public int RangeOption { get; set; }
        public int CategoryOrder { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public JobSchedules JobSchedules { get; set; }
    }
}
