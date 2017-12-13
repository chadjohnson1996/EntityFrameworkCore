using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CopySchedule
    {
        public CopySchedule()
        {
            CopyLog = new HashSet<CopyLog>();
        }

        public int ScheduleId { get; set; }
        public string DatabaseName { get; set; }
        public string Sunday { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string CopyTime { get; set; }

        public ICollection<CopyLog> CopyLog { get; set; }
    }
}
