using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class IncomeTypes
    {
        public IncomeTypes()
        {
            AiaHeader = new HashSet<AiaHeader>();
            ArInvoice = new HashSet<ArInvoice>();
            Customers = new HashSet<Customers>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
        }

        public int CompanyNo { get; set; }
        public string IncomeTypeNo { get; set; }
        public string Description { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string IncomeTypeId { get; set; }
        public string EnableServiceCharge { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public ICollection<AiaHeader> AiaHeader { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
    }
}
