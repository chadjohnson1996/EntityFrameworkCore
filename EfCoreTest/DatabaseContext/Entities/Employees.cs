using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Employees
    {
        public Employees()
        {
            AdjustTc = new HashSet<AdjustTc>();
            CashHistoryJournalD = new HashSet<CashHistoryJournalD>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            Emp401k = new HashSet<Emp401k>();
            EmpAca1095cValues = new HashSet<EmpAca1095cValues>();
            EmpAcaCoveredIndividuals = new HashSet<EmpAcaCoveredIndividuals>();
            EmpAcaCoveredYears = new HashSet<EmpAcaCoveredYears>();
            EmpAcaHoursAdjValues = new HashSet<EmpAcaHoursAdjValues>();
            EmpAccrualPlans = new HashSet<EmpAccrualPlans>();
            EmpAccruals = new HashSet<EmpAccruals>();
            EmpBrd = new HashSet<EmpBrd>();
            EmpDed = new HashSet<EmpDed>();
            EmpDirectDeposit = new HashSet<EmpDirectDeposit>();
            EmpEmploymentActionChanges = new HashSet<EmpEmploymentActionChanges>();
            EmpPayPeriods = new HashSet<EmpPayPeriods>();
            EmpPwHourlyFringe = new HashSet<EmpPwHourlyFringe>();
            EmpPwPerPayFringe = new HashSet<EmpPwPerPayFringe>();
            EmpRateChanges = new HashSet<EmpRateChanges>();
            EmpTaxes = new HashSet<EmpTaxes>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            EmpUnionTrade = new HashSet<EmpUnionTrade>();
            EmployeeDivisions = new HashSet<EmployeeDivisions>();
            EqLocationTransferD = new HashSet<EqLocationTransferD>();
            EqLocationTransferH = new HashSet<EqLocationTransferH>();
            EqUsage = new HashSet<EqUsage>();
            EqWo = new HashSet<EqWo>();
            EqWoLabor = new HashSet<EqWoLabor>();
            EqWoLaborD = new HashSet<EqWoLaborD>();
            EquipmentLocations = new HashSet<EquipmentLocations>();
            EquipmentService = new HashSet<EquipmentService>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            HisAccrual = new HashSet<HisAccrual>();
            HisBurden = new HashSet<HisBurden>();
            HisChkStub1 = new HashSet<HisChkStub1>();
            HisChkStub4 = new HashSet<HisChkStub4>();
            HisChkStubCroell = new HashSet<HisChkStubCroell>();
            HisChkStubExtended = new HashSet<HisChkStubExtended>();
            HisEarnAdditional = new HashSet<HisEarnAdditional>();
            HisEarnHours = new HashSet<HisEarnHours>();
            HisEmpAcaMeasGroups = new HashSet<HisEmpAcaMeasGroups>();
            HisJob = new HashSet<HisJob>();
            HisMisc = new HashSet<HisMisc>();
            HisPwHourlyFringe = new HashSet<HisPwHourlyFringe>();
            HisPwPerPayFringe = new HashSet<HisPwPerPayFringe>();
            HisSumBurden = new HashSet<HisSumBurden>();
            HisSumEarn = new HashSet<HisSumEarn>();
            HisSumGeneral = new HashSet<HisSumGeneral>();
            HisSumLit = new HashSet<HisSumLit>();
            HisSumMisc = new HashSet<HisSumMisc>();
            HisSumSit = new HashSet<HisSumSit>();
            HisSumSuta = new HashSet<HisSumSuta>();
            HisSumUnionDed = new HashSet<HisSumUnionDed>();
            HisTaxFica = new HashSet<HisTaxFica>();
            HisTaxFit = new HashSet<HisTaxFit>();
            HisTaxFuta = new HashSet<HisTaxFuta>();
            HisTaxLit = new HashSet<HisTaxLit>();
            HisTaxSit = new HashSet<HisTaxSit>();
            HisTaxSui = new HashSet<HisTaxSui>();
            HisTaxSuta = new HashSet<HisTaxSuta>();
            HisTcAdj = new HashSet<HisTcAdj>();
            HisTimecard = new HashSet<HisTimecard>();
            HisUniDeductions = new HashSet<HisUniDeductions>();
            HisUniEarnings = new HashSet<HisUniEarnings>();
            HisUniFringeRate = new HashSet<HisUniFringeRate>();
            HisUniFringes = new HashSet<HisUniFringes>();
            HisWorkComp = new HashSet<HisWorkComp>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            JobScheduleTaskEmployeeResources = new HashSet<JobScheduleTaskEmployeeResources>();
            JobsEmployees = new HashSet<Jobs>();
            JobsEmployeesNavigation = new HashSet<Jobs>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesEmployees = new HashSet<MiscDocActivities>();
            MiscDocActivitiesEmployees1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesEmployeesNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsEmployees = new HashSet<MiscDocs>();
            MiscDocsEmployeesNavigation = new HashSet<MiscDocs>();
            PayAccrual = new HashSet<PayAccrual>();
            PayAdd = new HashSet<PayAdd>();
            PayChkReg = new HashSet<PayChkReg>();
            PayChkStub1 = new HashSet<PayChkStub1>();
            PayChkStub4 = new HashSet<PayChkStub4>();
            PayChkStubCroell = new HashSet<PayChkStubCroell>();
            PayChkStubExtended = new HashSet<PayChkStubExtended>();
            PayCrt = new HashSet<PayCrt>();
            PayEqpHis = new HashSet<PayEqpHis>();
            PayEquip = new HashSet<PayEquip>();
            PayEquipAttachment = new HashSet<PayEquipAttachment>();
            PayExBrd = new HashSet<PayExBrd>();
            PayFica = new HashSet<PayFica>();
            PayFit = new HashSet<PayFit>();
            PayFuta = new HashSet<PayFuta>();
            PayGen = new HashSet<PayGen>();
            PayGl = new HashSet<PayGl>();
            PayHrs = new HashSet<PayHrs>();
            PayJcQuantity = new HashSet<PayJcQuantity>();
            PayJob = new HashSet<PayJob>();
            PayJobBurden = new HashSet<PayJobBurden>();
            PayJobP401kMatch = new HashSet<PayJobP401kMatch>();
            PayLit = new HashSet<PayLit>();
            PayMisc = new HashSet<PayMisc>();
            PayPwHourlyFringe = new HashSet<PayPwHourlyFringe>();
            PayPwPerPayFringe = new HashSet<PayPwPerPayFringe>();
            PaySit = new HashSet<PaySit>();
            PaySui = new HashSet<PaySui>();
            PaySummary = new HashSet<PaySummary>();
            PaySuta = new HashSet<PaySuta>();
            PayTcAdj = new HashSet<PayTcAdj>();
            PayTime = new HashSet<PayTime>();
            PayUniDed = new HashSet<PayUniDed>();
            PayUniEarn = new HashSet<PayUniEarn>();
            PayUniFringe = new HashSet<PayUniFringe>();
            PayUniFringeRate = new HashSet<PayUniFringeRate>();
            PayWorkComp = new HashSet<PayWorkComp>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesEmployees = new HashSet<RfcActivities>();
            RfcActivitiesEmployees1 = new HashSet<RfcActivities>();
            RfcActivitiesEmployeesNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsEmployees = new HashSet<Rfcs>();
            RfcsEmployeesNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesEmployees = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesEmployees1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesEmployeesNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisEmployees = new HashSet<Rfis>();
            RfisEmployeesNavigation = new HashSet<Rfis>();
            RfpItemActivitiesEmployees = new HashSet<RfpItemActivities>();
            RfpItemActivitiesEmployees1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesEmployeesNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsEmployees = new HashSet<Rfps>();
            RfpsEmployeesNavigation = new HashSet<Rfps>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
            SubmittalItemActivitiesEmployees = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesEmployees1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesEmployeesNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsEmployees = new HashSet<Submittals>();
            SubmittalsEmployeesNavigation = new HashSet<Submittals>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            TransmittalActivitiesEmployees = new HashSet<TransmittalActivities>();
            TransmittalActivitiesEmployees1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesEmployeesNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsEmployees = new HashSet<Transmittals>();
            TransmittalsEmployeesNavigation = new HashSet<Transmittals>();
            W2Box12WsD = new HashSet<W2Box12WsD>();
        }

        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string SsNo { get; set; }
        public string Sex { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateHired { get; set; }
        public DateTime? DateTerminated { get; set; }
        public DateTime? DateRehired { get; set; }
        public string TerminationReason { get; set; }
        public DateTime? DateLastWorked { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string MinorityNo { get; set; }
        public string TaxPrNo { get; set; }
        public string FedFilingStatus { get; set; }
        public string StateFilingStatus { get; set; }
        public string CertifiedPayroll { get; set; }
        public string DirectDeposit { get; set; }
        public string DirectDepositNumber { get; set; }
        public string PayPeriodNo { get; set; }
        public string Deceased { get; set; }
        public string FutaSuta { get; set; }
        public string SecurityAccess { get; set; }
        public string HourlyOrSalary { get; set; }
        public decimal? PayRate { get; set; }
        public decimal PayPeriodsPerYear { get; set; }
        public string EarnTypeNo { get; set; }
        public string Comments { get; set; }
        public string DeptNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal OverrideFor941 { get; set; }
        public string WcState { get; set; }
        public string WcClassNo { get; set; }
        public string SuiStateOverride { get; set; }
        public string HrsReqSalFlag { get; set; }
        public decimal WcMaxWeekExposure { get; set; }
        public string Pension { get; set; }
        public string AlFileStatus { get; set; }
        public decimal MsExemption { get; set; }
        public string ResidenceTax { get; set; }
        public string Veteran { get; set; }
        public string AccruedTimeFlag { get; set; }
        public decimal PrevailingRate { get; set; }
        public string PrevailingFringeNo { get; set; }
        public string DriverLicenseNumber { get; set; }
        public string DriverLicenseState { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string EmailAddress { get; set; }
        public decimal PrevReductionFactor { get; set; }
        public decimal? AzPercOfFederal { get; set; }
        public decimal? CaAddAllowances { get; set; }
        public string CtApplyExemptCredits { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string MinorityId { get; set; }
        public string PayPeriodId { get; set; }
        public string PrevailingFringeId { get; set; }
        public string SsId { get; set; }
        public string TaxPrId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public string WcClassId { get; set; }
        public string StateOfHire { get; set; }
        public string Suffix { get; set; }
        public decimal PrevReductionPerPay { get; set; }
        public string CorporateOfficerFlag { get; set; }
        public decimal SutaAvgHrsPerWeek { get; set; }
        public decimal? InDepExemptions { get; set; }
        public string CountyPrNo { get; set; }
        public string CountyPrId { get; set; }
        public string Statutory { get; set; }
        public string MiFamilyStatus { get; set; }
        public string Provider { get; set; }
        public string NonresidentAlien { get; set; }
        public string CrewNo { get; set; }
        public string CellPhoneNo { get; set; }
        public string CellPhoneId { get; set; }
        public string CrewId { get; set; }
        public string SsnAppliedFor { get; set; }
        public string OhsaLevel { get; set; }
        public string OhsaCertNum { get; set; }
        public string DefaultShift { get; set; }
        public string KcResident { get; set; }
        public int? ExperienceLevel { get; set; }
        public string Multiracial { get; set; }
        public DateTime? HireActStartDate { get; set; }
        public decimal? LaDepExemptions { get; set; }
        public string TrnsGrad { get; set; }
        public string EquipmentNo { get; set; }
        public string EquipmentId { get; set; }
        public string UnionIdNum { get; set; }
        public string OhsaTradeLicense { get; set; }
        public string SwacTwicId { get; set; }
        public string AllowRecurringTimecards { get; set; }
        public string AttachmentNo { get; set; }
        public int? DriverLicenseNumberEid { get; set; }
        public int? OhsaTradeLicenseEid { get; set; }
        public int? OhsaCertNumEid { get; set; }
        public int? UnionIdNumEid { get; set; }
        public int? SwacTwicIdEid { get; set; }
        public int? SsNoEid { get; set; }
        public string EmpStatus { get; set; }
        public decimal EmpApprenticeRate { get; set; }
        public decimal EmpOjtRate { get; set; }
        public string AttachmentId { get; set; }
        public string DcOwnerRelationship { get; set; }
        public DateTime? StartDate { get; set; }
        public string AcaExempt { get; set; }
        public string MeasurementGroupNo { get; set; }
        public string SocCode { get; set; }
        public decimal UnemploymentPayRate { get; set; }
        public string GeographicCode { get; set; }
        public string MeasurementGroupId { get; set; }
        public string UseJobBasedAccruals { get; set; }
        public string ApprenticeLevel { get; set; }
        public string OwnerOperator { get; set; }
        public string I9Verified { get; set; }
        public string ApprenticeCode { get; set; }
        public int? ApprenticeCodeEid { get; set; }

        public AcaMeasurementGroups AcaMeasurementGroups { get; set; }
        public Edata ApprenticeCodeE { get; set; }
        public CostCodes Co { get; set; }
        public Departments Departments { get; set; }
        public Edata DriverLicenseNumberE { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public EqAttachments EqAttachments { get; set; }
        public Minorities Minorities { get; set; }
        public Edata OhsaCertNumE { get; set; }
        public Edata OhsaTradeLicenseE { get; set; }
        public Edata SsNoE { get; set; }
        public Edata SwacTwicIdE { get; set; }
        public TaxGroups TaxGroups { get; set; }
        public Trades Trades { get; set; }
        public Edata UnionIdNumE { get; set; }
        public Unions Unions { get; set; }
        public WcStates WcStates { get; set; }
        public ICollection<AdjustTc> AdjustTc { get; set; }
        public ICollection<CashHistoryJournalD> CashHistoryJournalD { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<Emp401k> Emp401k { get; set; }
        public ICollection<EmpAca1095cValues> EmpAca1095cValues { get; set; }
        public ICollection<EmpAcaCoveredIndividuals> EmpAcaCoveredIndividuals { get; set; }
        public ICollection<EmpAcaCoveredYears> EmpAcaCoveredYears { get; set; }
        public ICollection<EmpAcaHoursAdjValues> EmpAcaHoursAdjValues { get; set; }
        public ICollection<EmpAccrualPlans> EmpAccrualPlans { get; set; }
        public ICollection<EmpAccruals> EmpAccruals { get; set; }
        public ICollection<EmpBrd> EmpBrd { get; set; }
        public ICollection<EmpDed> EmpDed { get; set; }
        public ICollection<EmpDirectDeposit> EmpDirectDeposit { get; set; }
        public ICollection<EmpEmploymentActionChanges> EmpEmploymentActionChanges { get; set; }
        public ICollection<EmpPayPeriods> EmpPayPeriods { get; set; }
        public ICollection<EmpPwHourlyFringe> EmpPwHourlyFringe { get; set; }
        public ICollection<EmpPwPerPayFringe> EmpPwPerPayFringe { get; set; }
        public ICollection<EmpRateChanges> EmpRateChanges { get; set; }
        public ICollection<EmpTaxes> EmpTaxes { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<EmpUnionTrade> EmpUnionTrade { get; set; }
        public ICollection<EmployeeDivisions> EmployeeDivisions { get; set; }
        public ICollection<EqLocationTransferD> EqLocationTransferD { get; set; }
        public ICollection<EqLocationTransferH> EqLocationTransferH { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWo> EqWo { get; set; }
        public ICollection<EqWoLabor> EqWoLabor { get; set; }
        public ICollection<EqWoLaborD> EqWoLaborD { get; set; }
        public ICollection<EquipmentLocations> EquipmentLocations { get; set; }
        public ICollection<EquipmentService> EquipmentService { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<HisAccrual> HisAccrual { get; set; }
        public ICollection<HisBurden> HisBurden { get; set; }
        public ICollection<HisChkStub1> HisChkStub1 { get; set; }
        public ICollection<HisChkStub4> HisChkStub4 { get; set; }
        public ICollection<HisChkStubCroell> HisChkStubCroell { get; set; }
        public ICollection<HisChkStubExtended> HisChkStubExtended { get; set; }
        public ICollection<HisEarnAdditional> HisEarnAdditional { get; set; }
        public ICollection<HisEarnHours> HisEarnHours { get; set; }
        public ICollection<HisEmpAcaMeasGroups> HisEmpAcaMeasGroups { get; set; }
        public ICollection<HisJob> HisJob { get; set; }
        public ICollection<HisMisc> HisMisc { get; set; }
        public ICollection<HisPwHourlyFringe> HisPwHourlyFringe { get; set; }
        public ICollection<HisPwPerPayFringe> HisPwPerPayFringe { get; set; }
        public ICollection<HisSumBurden> HisSumBurden { get; set; }
        public ICollection<HisSumEarn> HisSumEarn { get; set; }
        public ICollection<HisSumGeneral> HisSumGeneral { get; set; }
        public ICollection<HisSumLit> HisSumLit { get; set; }
        public ICollection<HisSumMisc> HisSumMisc { get; set; }
        public ICollection<HisSumSit> HisSumSit { get; set; }
        public ICollection<HisSumSuta> HisSumSuta { get; set; }
        public ICollection<HisSumUnionDed> HisSumUnionDed { get; set; }
        public ICollection<HisTaxFica> HisTaxFica { get; set; }
        public ICollection<HisTaxFit> HisTaxFit { get; set; }
        public ICollection<HisTaxFuta> HisTaxFuta { get; set; }
        public ICollection<HisTaxLit> HisTaxLit { get; set; }
        public ICollection<HisTaxSit> HisTaxSit { get; set; }
        public ICollection<HisTaxSui> HisTaxSui { get; set; }
        public ICollection<HisTaxSuta> HisTaxSuta { get; set; }
        public ICollection<HisTcAdj> HisTcAdj { get; set; }
        public ICollection<HisTimecard> HisTimecard { get; set; }
        public ICollection<HisUniDeductions> HisUniDeductions { get; set; }
        public ICollection<HisUniEarnings> HisUniEarnings { get; set; }
        public ICollection<HisUniFringeRate> HisUniFringeRate { get; set; }
        public ICollection<HisUniFringes> HisUniFringes { get; set; }
        public ICollection<HisWorkComp> HisWorkComp { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<JobScheduleTaskEmployeeResources> JobScheduleTaskEmployeeResources { get; set; }
        public ICollection<Jobs> JobsEmployees { get; set; }
        public ICollection<Jobs> JobsEmployeesNavigation { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesEmployees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesEmployees1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesEmployeesNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsEmployees { get; set; }
        public ICollection<MiscDocs> MiscDocsEmployeesNavigation { get; set; }
        public ICollection<PayAccrual> PayAccrual { get; set; }
        public ICollection<PayAdd> PayAdd { get; set; }
        public ICollection<PayChkReg> PayChkReg { get; set; }
        public ICollection<PayChkStub1> PayChkStub1 { get; set; }
        public ICollection<PayChkStub4> PayChkStub4 { get; set; }
        public ICollection<PayChkStubCroell> PayChkStubCroell { get; set; }
        public ICollection<PayChkStubExtended> PayChkStubExtended { get; set; }
        public ICollection<PayCrt> PayCrt { get; set; }
        public ICollection<PayEqpHis> PayEqpHis { get; set; }
        public ICollection<PayEquip> PayEquip { get; set; }
        public ICollection<PayEquipAttachment> PayEquipAttachment { get; set; }
        public ICollection<PayExBrd> PayExBrd { get; set; }
        public ICollection<PayFica> PayFica { get; set; }
        public ICollection<PayFit> PayFit { get; set; }
        public ICollection<PayFuta> PayFuta { get; set; }
        public ICollection<PayGen> PayGen { get; set; }
        public ICollection<PayGl> PayGl { get; set; }
        public ICollection<PayHrs> PayHrs { get; set; }
        public ICollection<PayJcQuantity> PayJcQuantity { get; set; }
        public ICollection<PayJob> PayJob { get; set; }
        public ICollection<PayJobBurden> PayJobBurden { get; set; }
        public ICollection<PayJobP401kMatch> PayJobP401kMatch { get; set; }
        public ICollection<PayLit> PayLit { get; set; }
        public ICollection<PayMisc> PayMisc { get; set; }
        public ICollection<PayPwHourlyFringe> PayPwHourlyFringe { get; set; }
        public ICollection<PayPwPerPayFringe> PayPwPerPayFringe { get; set; }
        public ICollection<PaySit> PaySit { get; set; }
        public ICollection<PaySui> PaySui { get; set; }
        public ICollection<PaySummary> PaySummary { get; set; }
        public ICollection<PaySuta> PaySuta { get; set; }
        public ICollection<PayTcAdj> PayTcAdj { get; set; }
        public ICollection<PayTime> PayTime { get; set; }
        public ICollection<PayUniDed> PayUniDed { get; set; }
        public ICollection<PayUniEarn> PayUniEarn { get; set; }
        public ICollection<PayUniFringe> PayUniFringe { get; set; }
        public ICollection<PayUniFringeRate> PayUniFringeRate { get; set; }
        public ICollection<PayWorkComp> PayWorkComp { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesEmployees { get; set; }
        public ICollection<RfcActivities> RfcActivitiesEmployees1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesEmployeesNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsEmployees { get; set; }
        public ICollection<Rfcs> RfcsEmployeesNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesEmployees { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesEmployees1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesEmployeesNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisEmployees { get; set; }
        public ICollection<Rfis> RfisEmployeesNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesEmployees { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesEmployees1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesEmployeesNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsEmployees { get; set; }
        public ICollection<Rfps> RfpsEmployeesNavigation { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesEmployees { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesEmployees1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesEmployeesNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsEmployees { get; set; }
        public ICollection<Submittals> SubmittalsEmployeesNavigation { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesEmployees { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesEmployees1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesEmployeesNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsEmployees { get; set; }
        public ICollection<Transmittals> TransmittalsEmployeesNavigation { get; set; }
        public ICollection<W2Box12WsD> W2Box12WsD { get; set; }
    }
}
