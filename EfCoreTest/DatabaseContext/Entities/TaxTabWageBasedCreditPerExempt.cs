using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTabWageBasedCreditPerExempt
    {
        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public int TableNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Base { get; set; }
        public decimal PerExemptionCreditAmt { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public string TableId { get; set; }

        public TaxTabTables TaxTabTables { get; set; }
    }
}
