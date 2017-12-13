using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FedTaxBrackets
    {
        public int CompanyNo { get; set; }
        public string FilingStatus { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Bracket { get; set; }
        public decimal? Fixed { get; set; }
        public decimal? AdditionalPercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public FedTaxAmounts FedTaxAmounts { get; set; }
    }
}
