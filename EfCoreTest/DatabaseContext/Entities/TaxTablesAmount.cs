using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTablesAmount
    {
        public TaxTablesAmount()
        {
            TaxExemptions = new HashSet<TaxExemptions>();
            TaxTabStatus = new HashSet<TaxTabStatus>();
            TaxTabTables = new HashSet<TaxTabTables>();
        }

        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? SuiLimit { get; set; }
        public decimal? FitLimit { get; set; }
        public decimal? TaxableLimit { get; set; }
        public decimal? ReciprocityPercent { get; set; }
        public decimal? SutaRate { get; set; }
        public decimal? WiZeroExempt { get; set; }
        public decimal? MaxCreditPercent { get; set; }
        public decimal? DeductFicaLimit { get; set; }
        public decimal? SutaLimit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Single1 { get; set; }
        public string Single2 { get; set; }
        public string Single3 { get; set; }
        public string Single4 { get; set; }
        public string MarriedJoint1 { get; set; }
        public string MarriedJoint2 { get; set; }
        public string MarriedJoint3 { get; set; }
        public string MarriedJoint4 { get; set; }
        public string MarriedSingle1 { get; set; }
        public string MarriedSingle2 { get; set; }
        public string MarriedSingle3 { get; set; }
        public string MarriedSingle4 { get; set; }
        public string Household1 { get; set; }
        public string Household2 { get; set; }
        public string Household3 { get; set; }
        public string Household4 { get; set; }
        public decimal? CaAddAllowAmount { get; set; }
        public string RoundWithholding { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public decimal AnnualWithholdingMinimum { get; set; }
        public decimal? FutaRateOverride { get; set; }
        public decimal? FixedRate { get; set; }
        public string AccrualPeriod { get; set; }
        public decimal? MinimumAmount { get; set; }
        public string WithholdOption { get; set; }
        public string RoundOption { get; set; }
        public decimal? DependentCredit { get; set; }
        public decimal EmployerFixedRate { get; set; }

        public TaxTables TaxTables { get; set; }
        public ICollection<TaxExemptions> TaxExemptions { get; set; }
        public ICollection<TaxTabStatus> TaxTabStatus { get; set; }
        public ICollection<TaxTabTables> TaxTabTables { get; set; }
    }
}
