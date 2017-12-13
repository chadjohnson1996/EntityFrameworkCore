using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BidStatuses
    {
        public BidStatuses()
        {
            ControlPm = new HashSet<ControlPm>();
            Jobs = new HashSet<Jobs>();
        }

        public int CompanyNo { get; set; }
        public string BidStatusNo { get; set; }
        public string Description { get; set; }
        public string StatusType { get; set; }
        public string IncludeInJobdddw { get; set; }
        public string RecordStatus { get; set; }
        public string SysDefault { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BidStatusId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<ControlPm> ControlPm { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
    }
}
