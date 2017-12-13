using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WcExpGroups
    {
        public WcExpGroups()
        {
            WcClasses = new HashSet<WcClasses>();
        }

        public int CompanyNo { get; set; }
        public string WcState { get; set; }
        public string WcGroupNo { get; set; }
        public string Description { get; set; }
        public decimal? MaximumExposure { get; set; }
        public string ExposurePeriod { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string WcGroupId { get; set; }

        public WcStates WcStates { get; set; }
        public ICollection<WcClasses> WcClasses { get; set; }
    }
}
