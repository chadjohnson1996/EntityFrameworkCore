using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleTasks
    {
        public JobScheduleTasks()
        {
            JobScheduleTaskCategoryResources = new HashSet<JobScheduleTaskCategoryResources>();
            JobScheduleTaskEmployeeResources = new HashSet<JobScheduleTaskEmployeeResources>();
            JobScheduleTaskEquipmentResources = new HashSet<JobScheduleTaskEquipmentResources>();
            JobScheduleTaskItemResources = new HashSet<JobScheduleTaskItemResources>();
            JobScheduleTaskPredecessorsJobScheduleTasks = new HashSet<JobScheduleTaskPredecessors>();
            JobScheduleTaskPredecessorsJobScheduleTasksNavigation = new HashSet<JobScheduleTaskPredecessors>();
            JobScheduleTaskTradeResources = new HashSet<JobScheduleTaskTradeResources>();
            JobScheduleTaskVendorResources = new HashSet<JobScheduleTaskVendorResources>();
        }

        public int InternalId { get; set; }
        public int ScheduleId { get; set; }
        public int ParentId { get; set; }
        public int TaskNo { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? StopTime { get; set; }
        public decimal Duration { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public int OrdinalPosition { get; set; }
        public decimal PercComp { get; set; }
        public int CompanyNo { get; set; }
        public string TaskNote { get; set; }
        public string TaskUdfNo { get; set; }
        public string BarType { get; set; }
        public string MilestoneTitle { get; set; }
        public int MilestoneImage { get; set; }
        public string BidNo { get; set; }
        public int SequenceNo { get; set; }

        public JobSchedules JobSchedules { get; set; }
        public ICollection<JobScheduleTaskCategoryResources> JobScheduleTaskCategoryResources { get; set; }
        public ICollection<JobScheduleTaskEmployeeResources> JobScheduleTaskEmployeeResources { get; set; }
        public ICollection<JobScheduleTaskEquipmentResources> JobScheduleTaskEquipmentResources { get; set; }
        public ICollection<JobScheduleTaskItemResources> JobScheduleTaskItemResources { get; set; }
        public ICollection<JobScheduleTaskPredecessors> JobScheduleTaskPredecessorsJobScheduleTasks { get; set; }
        public ICollection<JobScheduleTaskPredecessors> JobScheduleTaskPredecessorsJobScheduleTasksNavigation { get; set; }
        public ICollection<JobScheduleTaskTradeResources> JobScheduleTaskTradeResources { get; set; }
        public ICollection<JobScheduleTaskVendorResources> JobScheduleTaskVendorResources { get; set; }
    }
}
