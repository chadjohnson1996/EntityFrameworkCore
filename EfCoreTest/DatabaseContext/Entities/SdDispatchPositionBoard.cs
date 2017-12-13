using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchPositionBoard
    {
        public int CompanyNo { get; set; }
        public int TechnicianNo { get; set; }
        public int Position { get; set; }
        public string RowAddedBy { get; set; }
        public DateTime RowAddedOn { get; set; }
        public int? RowUniqueNo { get; set; }
        public int SequenceNumber { get; set; }
        public string RowType { get; set; }
        public string UniqueIdn { get; set; }
        public string SpecifiedNo { get; set; }
        public int? Backgroundcolor { get; set; }
        public int? Foregroundcolor { get; set; }
        public string CellNote { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public SdDispatch SdDispatch { get; set; }
        public SdUserSpecifiedDispatch SdUserSpecifiedDispatch { get; set; }
        public SdTechnicians TechnicianNoNavigation { get; set; }
    }
}
