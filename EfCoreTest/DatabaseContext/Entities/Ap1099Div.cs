using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Ap1099Div
    {
        public int CompanyNo { get; set; }
        public int TaxYear { get; set; }
        public string VendorNo { get; set; }
        public string OptionalAccountNo { get; set; }
        public string SecondTinNotice { get; set; }
        public decimal OrdinaryDividends { get; set; }
        public decimal QualifiedDividends { get; set; }
        public decimal TotalCapitalGain { get; set; }
        public decimal PostMay5CapitalGain { get; set; }
        public decimal Qualified5YearGain { get; set; }
        public decimal UnrecapSec1250Gain { get; set; }
        public decimal Section1202Gain { get; set; }
        public decimal CollectiblesGain { get; set; }
        public decimal NontaxableDistributions { get; set; }
        public decimal FitWithheld { get; set; }
        public decimal InvestmentExpenses { get; set; }
        public decimal ForeignTaxPaid { get; set; }
        public string ForeignCountry { get; set; }
        public decimal CashLiquidation { get; set; }
        public decimal NoncashLiquidation { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string OptionalAccountId { get; set; }
        public string VendorId { get; set; }
        public decimal ExemptIntDiv { get; set; }
        public decimal BondIntDiv { get; set; }
        public string StateNo { get; set; }
        public decimal StateTaxWithheld { get; set; }
        public string StateIdNo { get; set; }
        public string StateId { get; set; }
        public string StateIdId { get; set; }
        public decimal StateTaxWithheldLine2 { get; set; }
        public string StateIdNoLine2 { get; set; }
        public string StateNoLine2 { get; set; }
        public string Fatca { get; set; }

        public Vendors Vendors { get; set; }
    }
}
