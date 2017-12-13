using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CopyLog
    {
        public int CopyId { get; set; }
        public int ScheduleId { get; set; }
        public string DatabaseName { get; set; }
        public DateTime CopyDate { get; set; }
        public string Success { get; set; }
        public string FailureMessage { get; set; }

        public CopySchedule Schedule { get; set; }
    }
}
