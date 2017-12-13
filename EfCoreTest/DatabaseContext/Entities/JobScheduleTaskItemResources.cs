﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleTaskItemResources
    {
        public int TaskId { get; set; }
        public int CompanyNo { get; set; }
        public string ItemNo { get; set; }
        public decimal Quantity { get; set; }
        public int ScheduleId { get; set; }
        public DateTime StartTime { get; set; }
        public decimal Duration { get; set; }
        public DateTime? RowAddedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemId { get; set; }
        public DateTime ResourceDurationDate { get; set; }

        public Items Items { get; set; }
        public JobScheduleTasks JobScheduleTasks { get; set; }
    }
}