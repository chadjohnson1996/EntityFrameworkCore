using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdFlatRates
    {
        public SdFlatRates()
        {
            SdFlatRateDetail = new HashSet<SdFlatRateDetail>();
        }

        public string Company { get; set; }
        public string RateNo { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string RateId { get; set; }

        public ICollection<SdFlatRateDetail> SdFlatRateDetail { get; set; }
    }
}
