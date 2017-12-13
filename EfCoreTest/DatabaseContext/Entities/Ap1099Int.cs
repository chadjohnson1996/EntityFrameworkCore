using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Ap1099Int
    {
        public int CompanyNo { get; set; }
        public int TaxYear { get; set; }
        public string VendorNo { get; set; }
        public string OptionalAccountNo { get; set; }
        public string SecondTinNotice { get; set; }
        public decimal InterestIncome { get; set; }
        public decimal EarlyWithPenalty { get; set; }
        public decimal InterestBondsTreas { get; set; }
        public decimal FitWithheld { get; set; }
        public decimal InvestmentExpenses { get; set; }
        public decimal ForeignTaxPaid { get; set; }
        public string ForeignCountry { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string OptionalAccountId { get; set; }
        public string VendorId { get; set; }
        public decimal TaxExemptInt { get; set; }
        public decimal PrivateBondInt { get; set; }
        public string CusipNo { get; set; }
        public string StateNo { get; set; }
        public decimal StateTaxWithheld { get; set; }
        public string StateIdNo { get; set; }
        public string StateId { get; set; }
        public string StateIdId { get; set; }
        public string CusipId { get; set; }
        public string StateNoLine2 { get; set; }
        public string StateIdNoLine2 { get; set; }
        public decimal StateTaxWithheldLine2 { get; set; }
        public decimal MarketDiscount { get; set; }
        public decimal BondPremium { get; set; }
        public string Fatca { get; set; }
        public decimal BondPremiumTaxExempt { get; set; }
        public decimal BondPremiumTreasuryObligations { get; set; }

        public Vendors Vendors { get; set; }
    }
}
