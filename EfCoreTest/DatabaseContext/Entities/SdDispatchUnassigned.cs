using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchUnassigned
    {
        public int CompanyNo { get; set; }
        public string UniqueIdn { get; set; }
        public int? RequestedTech { get; set; }
        public int? RequestedTime { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string Note { get; set; }
        public string RowAddedBy { get; set; }
        public DateTime RowAddedOn { get; set; }
        public int SequenceNumber { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public SdTechnicians RequestedTechNavigation { get; set; }
        public SdDispatch SdDispatch { get; set; }
    }
}
