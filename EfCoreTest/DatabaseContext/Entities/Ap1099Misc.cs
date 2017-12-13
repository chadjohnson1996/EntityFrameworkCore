using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Ap1099Misc
    {
        public int CompanyNo { get; set; }
        public int TaxYear { get; set; }
        public string VendorNo { get; set; }
        public string OptionalAccountNo { get; set; }
        public string SecondTinNotice { get; set; }
        public decimal Rents { get; set; }
        public decimal Royalties { get; set; }
        public decimal OtherIncome { get; set; }
        public decimal FitWithheld { get; set; }
        public decimal FishingProceeds { get; set; }
        public decimal MedicalHealthPayments { get; set; }
        public decimal NonemployeeCompensation { get; set; }
        public decimal SubstitutePayments { get; set; }
        public string DirectSales { get; set; }
        public decimal CropInsuranceProceeds { get; set; }
        public decimal SitWithheld { get; set; }
        public string TaxState { get; set; }
        public decimal MiscAmount { get; set; }
        public string MiscCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string OptionalAccountId { get; set; }
        public decimal ExcessGoldenParachute { get; set; }
        public decimal GrossProceedsAttorney { get; set; }
        public decimal SitIncome { get; set; }
        public decimal SitWithheld2 { get; set; }
        public string TaxState2 { get; set; }
        public decimal SitIncome2 { get; set; }
        public decimal Section409aDeferrals { get; set; }
        public decimal Section409aIncome { get; set; }
        public decimal ForeignTaxPaid { get; set; }
        public string ForeignTaxCountry { get; set; }
        public string Fatca { get; set; }

        public Vendors Vendors { get; set; }
    }
}
