using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmInvoiceH
    {
        public TmInvoiceH()
        {
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmInvoiceEq = new HashSet<TmInvoiceEq>();
            TmInvoiceGl = new HashSet<TmInvoiceGl>();
            TmInvoiceJc = new HashSet<TmInvoiceJc>();
        }

        public int CompanyNo { get; set; }
        public string InvoiceNo { get; set; }
        public int TmDesignNo { get; set; }
        public string PostedFlag { get; set; }
        public string WorksheetNo { get; set; }
        public DateTime? WorksheetDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Description { get; set; }
        public string JobNo { get; set; }
        public string CustomerNo { get; set; }
        public string TaxNo { get; set; }
        public decimal TaxBase { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime? BillingStart { get; set; }
        public DateTime? BillingEnd { get; set; }
        public decimal InvoiceAmount { get; set; }
        public decimal Deposit { get; set; }
        public decimal AmountDue { get; set; }
        public decimal RetainagePercent { get; set; }
        public decimal RetainageAmount { get; set; }
        public string UseRetainage { get; set; }
        public string Comments { get; set; }
        public string IncomeTypeNo { get; set; }
        public string TermsNo { get; set; }
        public string TermsDescription { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public string CustomerOrderNo { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerJobNo { get; set; }
        public string CustomerJobContact { get; set; }
        public string AttentionOf { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ShipViaNo { get; set; }
        public string ReversedFlag { get; set; }
        public decimal GlAr { get; set; }
        public decimal GlRetainage { get; set; }
        public string SectionCommentLb { get; set; }
        public string SectionCommentMt { get; set; }
        public string SectionCommentSb { get; set; }
        public string SectionCommentOe { get; set; }
        public string SectionCommentRe { get; set; }
        public string SectionCommentBr { get; set; }
        public string GatheredFlag { get; set; }
        public string PrintedFlag { get; set; }
        public string MarkupTable { get; set; }
        public string InconsistentFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerJobId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerOrderId { get; set; }
        public string IncomeTypeId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string ShipViaId { get; set; }
        public string TaxId { get; set; }
        public string TermsId { get; set; }
        public string TmDesignId { get; set; }
        public string WorksheetId { get; set; }
        public string JobCountry { get; set; }
        public string IncludeInArPercentComplete { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public string HiddenSalesTax { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public decimal? UseTaxBase { get; set; }
        public string DispatchUniqueIdn { get; set; }
        public string CopiedFromInvoice { get; set; }
        public string PhaseNo { get; set; }
        public string PhaseId { get; set; }
        public string GeneratedByPhaseFlag { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public Customers C { get; set; }
        public IncomeTypes IncomeTypes { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public ShipVia ShipVia { get; set; }
        public Terms Terms { get; set; }
        public DsgDesigns TmDesignNoNavigation { get; set; }
        public TmWorksheetH TmWorksheetH { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmInvoiceEq> TmInvoiceEq { get; set; }
        public ICollection<TmInvoiceGl> TmInvoiceGl { get; set; }
        public ICollection<TmInvoiceJc> TmInvoiceJc { get; set; }
    }
}
