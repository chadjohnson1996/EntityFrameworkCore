using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EarnTypes
    {
        public EarnTypes()
        {
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            EmpAccruals = new HashSet<EmpAccruals>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            Employees = new HashSet<Employees>();
            EqWoLaborD = new HashSet<EqWoLaborD>();
            HisAccrual = new HashSet<HisAccrual>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            PayAccrual = new HashSet<PayAccrual>();
            SdDispatchFixedTypes = new HashSet<SdDispatchFixedTypes>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            UnionDf = new HashSet<UnionDf>();
        }

        public int CompanyNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string EarnTypeFlag { get; set; }
        public decimal PayFactor { get; set; }
        public string FicaTaxable { get; set; }
        public string FitTaxable { get; set; }
        public string SitTaxable { get; set; }
        public string LitTaxable { get; set; }
        public string SuiTaxable { get; set; }
        public string UnionApplied { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlFringeCr { get; set; }
        public string FringeWithhold { get; set; }
        public string CostClassNo { get; set; }
        public string YtdStub { get; set; }
        public string ExtraBurden { get; set; }
        public string WorkersComp { get; set; }
        public string W217 { get; set; }
        public string W223 { get; set; }
        public string NonHourlyQty { get; set; }
        public string UpdateQuantityJc { get; set; }
        public string QuantityType { get; set; }
        public string CertifiedPayroll { get; set; }
        public string Plan401k { get; set; }
        public string FringeFicaTaxable { get; set; }
        public string FringeFitTaxable { get; set; }
        public string FringeSitTaxable { get; set; }
        public string FringeLitTaxable { get; set; }
        public string AccruedTime { get; set; }
        public decimal AccruedHours { get; set; }
        public decimal AccruedHoursWorked { get; set; }
        public string AccruedType { get; set; }
        public string AccruedEarnTypeNo { get; set; }
        public string Emp1099 { get; set; }
        public string AdvancedEic { get; set; }
        public string UnionFringeFlag { get; set; }
        public string W2Tips { get; set; }
        public string NonQualifiedPlan { get; set; }
        public string Section457 { get; set; }
        public string DependantCare { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ApplyToOvertime { get; set; }
        public string SalaryProrate { get; set; }
        public string W2BenefitType { get; set; }
        public string ReportFringeAs { get; set; }
        public string AccruedEarnTypeId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string EarnTypeId { get; set; }
        public string W2OtherType { get; set; }
        public string UseForWtAvgOt { get; set; }
        public string AccrualNo { get; set; }
        public string AccrualFlag { get; set; }
        public string ApplyPwHourlyFringeRed { get; set; }
        public string IncludeHoursPwPerPayFringeRed { get; set; }
        public string AccrualId { get; set; }
        public string UseNonHourlyOnMisc { get; set; }
        public string UseFactorWcHrly { get; set; }
        public string IncludeHoursCertified { get; set; }
        public string FutaTaxable { get; set; }
        public string CertDescriptionNyc { get; set; }
        public string IncludeInFringeBenefitGroup { get; set; }
        public string FringeBenefit401kType { get; set; }
        public string MobileDevice { get; set; }
        public string HourlyExistsForRecurring { get; set; }
        public string IncludeInLcpTrackerTravel { get; set; }
        public string UseFactorEcLcpTrk { get; set; }
        public decimal AltFactorEcLcpTrk { get; set; }
        public string ExcludeInEprWrkWage { get; set; }
        public decimal RoundPayFactor { get; set; }
        public string IncludeInMonthlyHours { get; set; }
        public string IncludeInDailyOt { get; set; }
        public string IncludeInWeeklyOt { get; set; }
        public string UseTcRate { get; set; }

        public AccrualsH AccrualsH { get; set; }
        public CostClasses Co { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<EmpAccruals> EmpAccruals { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<EqWoLaborD> EqWoLaborD { get; set; }
        public ICollection<HisAccrual> HisAccrual { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<PayAccrual> PayAccrual { get; set; }
        public ICollection<SdDispatchFixedTypes> SdDispatchFixedTypes { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<UnionDf> UnionDf { get; set; }
    }
}
