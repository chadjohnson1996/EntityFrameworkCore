using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTabExempt
    {
        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public int TableNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int SequenceNo { get; set; }
        public string Used { get; set; }
        public decimal? ExemptionsStart { get; set; }
        public decimal? ExemptionsEnd { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Fixed { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? Maximum { get; set; }
        public decimal? Credit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public string SequenceId { get; set; }
        public string TableId { get; set; }

        public TaxTabTables TaxTabTables { get; set; }
    }
}
