using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxGroupLocals
    {
        public int CompanyNo { get; set; }
        public string TaxPrNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public string TaxPrId { get; set; }

        public TaxGroups TaxGroups { get; set; }
    }
}
