using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlJournals
    {
        public GlJournals()
        {
            ControlEq = new HashSet<ControlEq>();
            ControlFa = new HashSet<ControlFa>();
            ControlIn = new HashSet<ControlIn>();
            DistributionH = new HashSet<DistributionH>();
            GlBudgetHistory = new HashSet<GlBudgetHistory>();
            GlHistory = new HashSet<GlHistory>();
            GlJournalH = new HashSet<GlJournalH>();
        }

        public int CompanyNo { get; set; }
        public string JournalNo { get; set; }
        public string Description { get; set; }
        public string JournalType { get; set; }
        public string JobDistribution { get; set; }
        public decimal? NextNo { get; set; }
        public string PreventUnbalanced { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JournalId { get; set; }
        public string NextId { get; set; }
        public string ShowCreditAs { get; set; }
        public string ShowCreditCardAs { get; set; }
        public string ConsolidatedGl { get; set; }

        public ICollection<ControlEq> ControlEq { get; set; }
        public ICollection<ControlFa> ControlFa { get; set; }
        public ICollection<ControlIn> ControlIn { get; set; }
        public ICollection<DistributionH> DistributionH { get; set; }
        public ICollection<GlBudgetHistory> GlBudgetHistory { get; set; }
        public ICollection<GlHistory> GlHistory { get; set; }
        public ICollection<GlJournalH> GlJournalH { get; set; }
    }
}
