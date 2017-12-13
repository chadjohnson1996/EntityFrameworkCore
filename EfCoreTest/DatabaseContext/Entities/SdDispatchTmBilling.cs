using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchTmBilling
    {
        public int CompanyNo { get; set; }
        public string DispatchUniqueIdn { get; set; }
        public string TmBillingNo { get; set; }
        public string TmWorksheetNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TmBillingId { get; set; }
        public string TmWorksheetId { get; set; }
    }
}
