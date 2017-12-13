using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDailydispatchtimemask
    {
        public SdDailydispatchtimemask()
        {
            SdDispatchDailyBoard = new HashSet<SdDispatchDailyBoard>();
        }

        public string Company { get; set; }
        public int TimeCalled { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public string CompanyId { get; set; }

        public ICollection<SdDispatchDailyBoard> SdDispatchDailyBoard { get; set; }
    }
}
