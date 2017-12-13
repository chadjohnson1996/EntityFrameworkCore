using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Shifts
    {
        public Shifts()
        {
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            EqUsage = new HashSet<EqUsage>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string ShiftNo { get; set; }
        public string Description { get; set; }
        public decimal Increment { get; set; }
        public string IncrementType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ShiftId { get; set; }

        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
