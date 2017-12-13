using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleResourceConflicts
    {
        public int CompanyNo { get; set; }
        public int ScheduleId { get; set; }
        public string ResourceType { get; set; }
        public string ResourceNo { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public int Duration { get; set; }
        public int Quantity { get; set; }
        public int TaskId { get; set; }
        public string JobNo { get; set; }
        public string CurrentUserId { get; set; }
        public int ConflictScheduleId { get; set; }
        public DateTime ConflictStart { get; set; }
        public DateTime ConflictStop { get; set; }
        public DateTime ConflictAddedTime { get; set; }
        public int ConflictDuration { get; set; }
        public int ConflictQuantity { get; set; }
        public int ConflictTaskId { get; set; }
        public string ConflictJobNo { get; set; }
        public string ConflictUserId { get; set; }
        public string ResolvedFlag { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ConflictJobId { get; set; }
        public string JobId { get; set; }
        public string ResourceId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
    }
}
