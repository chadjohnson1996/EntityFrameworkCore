using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUserSpecifiedDispatch
    {
        public SdUserSpecifiedDispatch()
        {
            SdDispatchDailyBoard = new HashSet<SdDispatchDailyBoard>();
            SdDispatchPositionBoard = new HashSet<SdDispatchPositionBoard>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
        }

        public int CompanyNo { get; set; }
        public string SpecifiedNo { get; set; }
        public string Description { get; set; }
        public string FixedTypeNo { get; set; }
        public string JobNumber { get; set; }
        public string PayrollComplete { get; set; }
        public string DispatchComplete { get; set; }
        public string ProtectDescription { get; set; }
        public string RecordStatus { get; set; }
        public string RowAddedBy { get; set; }
        public DateTime RowAddedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DispatchNumber { get; set; }
        public int? Backgroundcolor { get; set; }
        public int? Foregroundcolor { get; set; }
        public string Note { get; set; }
        public DateTime? DateEntered { get; set; }
        public string ShowJob { get; set; }
        public string Converted { get; set; }
        public string CompanyId { get; set; }
        public string FixedTypeId { get; set; }
        public string SpecifiedId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public SdDispatchFixedTypes SdDispatchFixedTypes { get; set; }
        public ICollection<SdDispatchDailyBoard> SdDispatchDailyBoard { get; set; }
        public ICollection<SdDispatchPositionBoard> SdDispatchPositionBoard { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
    }
}
