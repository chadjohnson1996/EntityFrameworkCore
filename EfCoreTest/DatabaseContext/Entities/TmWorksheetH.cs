using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmWorksheetH
    {
        public TmWorksheetH()
        {
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string WorksheetNo { get; set; }
        public DateTime WorksheetDate { get; set; }
        public string JobNo { get; set; }
        public string CustomerNo { get; set; }
        public string TaxNo { get; set; }
        public decimal TaxBase { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public DateTime? PostDateStart { get; set; }
        public DateTime? PostDateEnd { get; set; }
        public string PostDateFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string JobId { get; set; }
        public string TaxId { get; set; }
        public string WorksheetId { get; set; }
        public string GatheredFlag { get; set; }
        public string InconsistentFlag { get; set; }
        public string InvoiceNo { get; set; }
        public string VoidedFlag { get; set; }
        public string MarkupTable { get; set; }
        public string InvoiceId { get; set; }
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
        public string PhaseNo { get; set; }
        public string PhaseId { get; set; }
        public int? TmDesignNo { get; set; }
        public string Comments { get; set; }
        public string SectionCommentLb { get; set; }
        public string SectionCommentMt { get; set; }
        public string SectionCommentSb { get; set; }
        public string SectionCommentOe { get; set; }
        public string SectionCommentRe { get; set; }
        public string SectionCommentBr { get; set; }
        public string GeneratedByPhaseFlag { get; set; }

        public Customers C { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public DsgDesigns TmDesignNoNavigation { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
