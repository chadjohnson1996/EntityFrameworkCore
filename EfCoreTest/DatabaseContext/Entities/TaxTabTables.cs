using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTabTables
    {
        public TaxTabTables()
        {
            TaxTabBrackets = new HashSet<TaxTabBrackets>();
            TaxTabCtCredits = new HashSet<TaxTabCtCredits>();
            TaxTabCtExemptions = new HashSet<TaxTabCtExemptions>();
            TaxTabExempt = new HashSet<TaxTabExempt>();
            TaxTabWageBasedCreditPerExempt = new HashSet<TaxTabWageBasedCreditPerExempt>();
            TaxTabWageBasedPerExemption = new HashSet<TaxTabWageBasedPerExemption>();
        }

        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int TableNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? CaLowIncome { get; set; }
        public decimal? FitLimit { get; set; }
        public decimal OkExemptionPercent { get; set; }
        public decimal OkExemptionAmount { get; set; }
        public decimal OkExemptionFixed { get; set; }
        public decimal OkGrossLimit { get; set; }
        public decimal OkGrossExcess { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public string TableId { get; set; }

        public TaxTablesAmount TaxTablesAmount { get; set; }
        public ICollection<TaxTabBrackets> TaxTabBrackets { get; set; }
        public ICollection<TaxTabCtCredits> TaxTabCtCredits { get; set; }
        public ICollection<TaxTabCtExemptions> TaxTabCtExemptions { get; set; }
        public ICollection<TaxTabExempt> TaxTabExempt { get; set; }
        public ICollection<TaxTabWageBasedCreditPerExempt> TaxTabWageBasedCreditPerExempt { get; set; }
        public ICollection<TaxTabWageBasedPerExemption> TaxTabWageBasedPerExemption { get; set; }
    }
}
