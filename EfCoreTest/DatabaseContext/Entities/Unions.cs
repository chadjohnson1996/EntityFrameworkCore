using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Unions
    {
        public Unions()
        {
            CountyUnionsUnions = new HashSet<CountyUnions>();
            CountyUnionsUnionsNavigation = new HashSet<CountyUnions>();
            EmpUnionTrade = new HashSet<EmpUnionTrade>();
            Employees = new HashSet<Employees>();
            JobUnionsUnions = new HashSet<JobUnions>();
            JobUnionsUnionsNavigation = new HashSet<JobUnions>();
            TimeCards = new HashSet<TimeCards>();
            UnionEprliveDf = new HashSet<UnionEprliveDf>();
            UnionEprliveMd = new HashSet<UnionEprliveMd>();
            UnionPwBenefitTypes = new HashSet<UnionPwBenefitTypes>();
            UnionShiftRt = new HashSet<UnionShiftRt>();
            UnionSplit = new HashSet<UnionSplit>();
            UnionTrade = new HashSet<UnionTrade>();
            UnionTradesBrdHdr = new HashSet<UnionTradesBrdHdr>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string Description { get; set; }
        public decimal? GlTaxableFringePay { get; set; }
        public decimal? GlTaxableFringeExp { get; set; }
        public decimal? GlNonFringePay { get; set; }
        public decimal? GlNonFringeExp { get; set; }
        public decimal? GlDeductionPayable { get; set; }
        public string ReportNoActivity { get; set; }
        public string AllTradesTheSame { get; set; }
        public string VendorNo { get; set; }
        public DateTime? DateExpires { get; set; }
        public string SelectCode { get; set; }
        public string AdditionalFringeFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ApplyPrevReductionFactor { get; set; }
        public string FringeDedWholeHours { get; set; }
        public string CompanyId { get; set; }
        public string UnionId { get; set; }
        public string VendorId { get; set; }
        public string UseHighestPackage { get; set; }
        public string WholeHoursByEarn { get; set; }
        public string EprReportOvtSep { get; set; }
        public string EprOvt15 { get; set; }
        public string EprOvt20 { get; set; }
        public string EprOvt15Desc { get; set; }
        public string EprOvt20Desc { get; set; }
        public string EprReportGrossAs { get; set; }
        public string EprFileName { get; set; }
        public string EprReportHrsPaid { get; set; }
        public string EprHrsPaidDesc { get; set; }
        public string EprReportWorkWages { get; set; }
        public string EprWorkWageDesc { get; set; }
        public string EprReportPayRate { get; set; }
        public string EprPayRateDesc { get; set; }
        public string EprDedFrgNo1 { get; set; }
        public string EprDedFrgNo2 { get; set; }
        public string EprDedFrgNo3 { get; set; }
        public string EprDedFrgNo4 { get; set; }
        public string EprDedFrgNo5 { get; set; }
        public string EprDedFrgNo6 { get; set; }
        public string EprDedFrgNo7 { get; set; }
        public string EprDedFrgNo8 { get; set; }
        public string EprDedFrgNo9 { get; set; }
        public string EprDedFrgNo10 { get; set; }
        public string EprReportRegHrsSep { get; set; }
        public string EprRegHrsDesc { get; set; }
        public string EprliveDesc { get; set; }
        public string EprReportEmpAddress { get; set; }
        public string EprEmpAddressDesc { get; set; }
        public string EprReportEmpCity { get; set; }
        public string EprEmpCityDesc { get; set; }
        public string EprReportEmpDob { get; set; }
        public string EprEmpDobDesc { get; set; }
        public string EprReportEmpEmail { get; set; }
        public string EprEmpEmailDesc { get; set; }
        public string EprReportEmpGender { get; set; }
        public string EprEmpGenderDesc { get; set; }
        public string EprReportEmpHomeUnion { get; set; }
        public string EprEmpHomeUnionDesc { get; set; }
        public string EprReportEmpPhone { get; set; }
        public string EprEmpPhoneDesc { get; set; }
        public string EprReportEmpState { get; set; }
        public string EprEmpStateDesc { get; set; }
        public string EprReportEmpUnionIdNum { get; set; }
        public string EprEmpUnionIdNumDesc { get; set; }
        public string EprReportEmpZipCode { get; set; }
        public string EprEmpZipCodeDesc { get; set; }

        public ICollection<CountyUnions> CountyUnionsUnions { get; set; }
        public ICollection<CountyUnions> CountyUnionsUnionsNavigation { get; set; }
        public ICollection<EmpUnionTrade> EmpUnionTrade { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<JobUnions> JobUnionsUnions { get; set; }
        public ICollection<JobUnions> JobUnionsUnionsNavigation { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<UnionEprliveDf> UnionEprliveDf { get; set; }
        public ICollection<UnionEprliveMd> UnionEprliveMd { get; set; }
        public ICollection<UnionPwBenefitTypes> UnionPwBenefitTypes { get; set; }
        public ICollection<UnionShiftRt> UnionShiftRt { get; set; }
        public ICollection<UnionSplit> UnionSplit { get; set; }
        public ICollection<UnionTrade> UnionTrade { get; set; }
        public ICollection<UnionTradesBrdHdr> UnionTradesBrdHdr { get; set; }
    }
}
