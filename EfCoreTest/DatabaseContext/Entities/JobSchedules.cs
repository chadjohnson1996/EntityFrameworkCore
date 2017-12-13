using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobSchedules
    {
        public JobSchedules()
        {
            JobScheduleCalendarRules = new HashSet<JobScheduleCalendarRules>();
            JobScheduleTasks = new HashSet<JobScheduleTasks>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public int ScheduleId { get; set; }
        public DateTime? ScheduleStart { get; set; }
        public DateTime? ScheduleEnd { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public decimal PercComp { get; set; }
        public string BidNo { get; set; }

        public JobPhases JobPhases { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<JobScheduleCalendarRules> JobScheduleCalendarRules { get; set; }
        public ICollection<JobScheduleTasks> JobScheduleTasks { get; set; }
    }
}
