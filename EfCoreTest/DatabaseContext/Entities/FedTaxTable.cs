using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FedTaxTable
    {
        public FedTaxTable()
        {
            FedTaxAmounts = new HashSet<FedTaxAmounts>();
        }

        public int CompanyNo { get; set; }
        public string EmployerId { get; set; }
        public decimal? GlTaxPayable { get; set; }
        public decimal? GlFicaPayableEr { get; set; }
        public decimal? GlFicaExpense { get; set; }
        public decimal? GlMedPayable { get; set; }
        public decimal? GlMedPayableEe { get; set; }
        public decimal? GlFicaPayableEe { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JournalNo { get; set; }
        public decimal? Gl941Cash { get; set; }
        public string Description941Trx { get; set; }
        public string Date941Default { get; set; }
        public string Date941Flag { get; set; }
        public string HireActExpenseCredit { get; set; }
        public string HireActAccrueCredit { get; set; }
        public decimal? GlHireActCredit { get; set; }
        public string JournalId { get; set; }
        public string Journal940No { get; set; }
        public decimal? Gl940Cash { get; set; }
        public string Description940Trx { get; set; }
        public string Date940Default { get; set; }
        public string Date940Flag { get; set; }
        public string Journal940Id { get; set; }

        public ICollection<FedTaxAmounts> FedTaxAmounts { get; set; }
    }
}
