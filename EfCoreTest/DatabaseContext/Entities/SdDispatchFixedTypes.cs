using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchFixedTypes
    {
        public SdDispatchFixedTypes()
        {
            SdUserSpecifiedDispatch = new HashSet<SdUserSpecifiedDispatch>();
        }

        public int CompanyNo { get; set; }
        public string FixedTypeNo { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string DefaultJob { get; set; }
        public string EarnCode { get; set; }
        public string EntireRowFlag { get; set; }
        public string ProtectDescription { get; set; }
        public int Foregroundcolor { get; set; }
        public int Backgroundcolor { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string SystemFixed { get; set; }
        public string AutoOpen { get; set; }
        public string ShowJob { get; set; }
        public string CompanyId { get; set; }
        public string FixedTypeId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<SdUserSpecifiedDispatch> SdUserSpecifiedDispatch { get; set; }
    }
}
