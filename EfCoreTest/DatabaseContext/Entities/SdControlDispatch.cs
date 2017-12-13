using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlDispatch
    {
        public int CompanyNo { get; set; }
        public int? DefaultDispatchEmailTemplateId { get; set; }
        public int? DefaultDispatchTextTemplateId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DefaultStatusCode { get; set; }
        public string TrackBilling { get; set; }
        public string TrackMessages { get; set; }
        public string TrackStatus { get; set; }
        public string TrackEvent { get; set; }
        public string DefaultDispatchType { get; set; }
        public string DefaultTemplate { get; set; }
        public string CompanyId { get; set; }
        public decimal? BurdenNumber { get; set; }
        public string BurdenChoice { get; set; }
        public string AllowLaborBurdenOverride { get; set; }
        public string AutoCopyFollow { get; set; }
        public string CopyTemplate { get; set; }
    }
}
