using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleTaskPredecessors
    {
        public int TaskId { get; set; }
        public int PredecessorId { get; set; }
        public int CompanyNo { get; set; }
        public int ScheduleId { get; set; }
        public int LagTime { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public int ConnType { get; set; }
        public int LagType { get; set; }
        public decimal LagPref { get; set; }

        public JobScheduleTasks JobScheduleTasks { get; set; }
        public JobScheduleTasks JobScheduleTasksNavigation { get; set; }
    }
}
