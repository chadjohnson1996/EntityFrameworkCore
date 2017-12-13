using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Terms
    {
        public Terms()
        {
            ApInvoiceH = new HashSet<ApInvoiceH>();
            ArInvoice = new HashSet<ArInvoice>();
            ControlAp = new HashSet<ControlAp>();
            ControlArTerms1 = new HashSet<ControlAr>();
            ControlArTermsNavigation = new HashSet<ControlAr>();
            ControlTm = new HashSet<ControlTm>();
            ControlUp = new HashSet<ControlUp>();
            Customers = new HashSet<Customers>();
            EstimatH = new HashSet<EstimatH>();
            Jobs = new HashSet<Jobs>();
            PoSubChangeH = new HashSet<PoSubChangeH>();
            PoSubH = new HashSet<PoSubH>();
            SdSites = new HashSet<SdSites>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            Vendors = new HashSet<Vendors>();
        }

        public int CompanyNo { get; set; }
        public string TermsNo { get; set; }
        public string Description { get; set; }
        public string DueDaysType { get; set; }
        public string DiscountDaysType { get; set; }
        public decimal? DueDays { get; set; }
        public decimal? DiscountDays { get; set; }
        public decimal? DueCutoff { get; set; }
        public decimal? DiscountCutoff { get; set; }
        public decimal? DiscountPercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TermsId { get; set; }

        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<ControlAp> ControlAp { get; set; }
        public ICollection<ControlAr> ControlArTerms1 { get; set; }
        public ICollection<ControlAr> ControlArTermsNavigation { get; set; }
        public ICollection<ControlTm> ControlTm { get; set; }
        public ICollection<ControlUp> ControlUp { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<EstimatH> EstimatH { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<PoSubChangeH> PoSubChangeH { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<SdSites> SdSites { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<Vendors> Vendors { get; set; }
    }
}
