using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqServiceCodesSupercede
    {
        public int CompanyNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string SupercedeServiceCodeNo { get; set; }
        public string CompanyId { get; set; }
        public string ServiceCodeId { get; set; }
        public string SupercedeServiceCodeId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }

        public EqServiceCodes EqServiceCodes { get; set; }
    }
}
