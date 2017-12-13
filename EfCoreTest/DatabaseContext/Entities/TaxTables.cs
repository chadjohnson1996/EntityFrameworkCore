using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTables
    {
        public TaxTables()
        {
            TaxTablesAmount = new HashSet<TaxTablesAmount>();
            TaxTablesLocalMakeup = new HashSet<TaxTablesLocalMakeup>();
        }

        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public string TaxAuthority { get; set; }
        public string EmployerId { get; set; }
        public string DeductFit { get; set; }
        public decimal? GlPayable { get; set; }
        public int? NoOfTables { get; set; }
        public string Agency { get; set; }
        public string SchoolTax { get; set; }
        public string MakeupTax { get; set; }
        public string NonElig401 { get; set; }
        public string NonElig125 { get; set; }
        public string CountyPrNo { get; set; }
        public int? CommCode { get; set; }
        public string SchoolDistrict { get; set; }
        public string SutaId { get; set; }
        public string Suta401 { get; set; }
        public string Suta125 { get; set; }
        public string W2StateAbbrev { get; set; }
        public string W2LocalAbbrev { get; set; }
        public string DeductFica { get; set; }
        public string ReciprocityFlag { get; set; }
        public string UseStateEx { get; set; }
        public string ReciprocityStates { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ReportOnW2 { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string LocalTaxId { get; set; }
        public string Section125Proration { get; set; }
        public string LocalMakeupTax { get; set; }
        public string EmploymentResidencePrecedence { get; set; }
        public string IncludeInStateDropdown { get; set; }
        public string NonEligHsa { get; set; }
        public string SutaHsa { get; set; }
        public string Box14Desc { get; set; }
        public string EarnCodeTaxation { get; set; }
        public string CalculationType { get; set; }
        public string IgnoreHighRate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ZipCodePlus4 { get; set; }
        public decimal? GlEmployerPayable { get; set; }
        public decimal? GlEmployerExpense { get; set; }
        public string StateMakeupTax { get; set; }
        public string UseFedWagesReq { get; set; }
        public string LorainMuniCode { get; set; }

        public Counties Co { get; set; }
        public LocalTaxAgencies LocalTaxAgencies { get; set; }
        public ICollection<TaxTablesAmount> TaxTablesAmount { get; set; }
        public ICollection<TaxTablesLocalMakeup> TaxTablesLocalMakeup { get; set; }
    }
}
