using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Jobs
    {
        public Jobs()
        {
            AiaHeader = new HashSet<AiaHeader>();
            ApInvoiceH = new HashSet<ApInvoiceH>();
            ArInvoice = new HashSet<ArInvoice>();
            ArInvoiceFrmItemsD = new HashSet<ArInvoiceFrmItemsD>();
            BidD = new HashSet<BidD>();
            BidH = new HashSet<BidH>();
            BidHistory = new HashSet<BidHistory>();
            BuyOutH = new HashSet<BuyOutH>();
            ControlArJobs = new HashSet<ControlAr>();
            ControlArJobsNavigation = new HashSet<ControlAr>();
            ControlEqJobs = new HashSet<ControlEq>();
            ControlEqJobs1 = new HashSet<ControlEq>();
            ControlEqJobs2 = new HashSet<ControlEq>();
            ControlEqJobsNavigation = new HashSet<ControlEq>();
            ControlInJobs = new HashSet<ControlIn>();
            ControlInJobsNavigation = new HashSet<ControlIn>();
            DcFieldLogEquipment = new HashSet<DcFieldLogEquipment>();
            DcFieldLogMaterials = new HashSet<DcFieldLogMaterials>();
            DcFieldLogOnSiteContacts = new HashSet<DcFieldLogOnSiteContacts>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            DcFieldLogTaskContacts = new HashSet<DcFieldLogTaskContacts>();
            DcFieldLogTaskDelays = new HashSet<DcFieldLogTaskDelays>();
            DcFieldLogTasks = new HashSet<DcFieldLogTasks>();
            DcFieldLogWeather = new HashSet<DcFieldLogWeather>();
            DcFieldLogs = new HashSet<DcFieldLogs>();
            DcJobContacts = new HashSet<DcJobContacts>();
            DcMeetingMinutes = new HashSet<DcMeetingMinutes>();
            DcMeetingMinutesAttendees = new HashSet<DcMeetingMinutesAttendees>();
            DcMeetingMinutesTopicContacts = new HashSet<DcMeetingMinutesTopicContacts>();
            DcMeetingMinutesTopics = new HashSet<DcMeetingMinutesTopics>();
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcMiscDocs = new HashSet<DcMiscDocs>();
            DcPunchListItemActivities = new HashSet<DcPunchListItemActivities>();
            DcPunchListItems = new HashSet<DcPunchListItems>();
            DcPunchLists = new HashSet<DcPunchLists>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfcs = new HashSet<DcRfcs>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfis = new HashSet<DcRfis>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcRfps = new HashSet<DcRfps>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcSubmittals = new HashSet<DcSubmittals>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
            DcTransmittalCorrespondences = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittals = new HashSet<DcTransmittals>();
            DistributionD = new HashSet<DistributionD>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqJobUsageRatesDetail = new HashSet<EqJobUsageRatesDetail>();
            EqLocationTransferD = new HashSet<EqLocationTransferD>();
            EqLocationTransferH = new HashSet<EqLocationTransferH>();
            EqMeterJournalD = new HashSet<EqMeterJournalD>();
            EqUsage = new HashSet<EqUsage>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoJournalItemsD = new HashSet<EqWoJournalItemsD>();
            EquipmentJobs = new HashSet<Equipment>();
            EquipmentJobsNavigation = new HashSet<Equipment>();
            EquipmentLocations = new HashSet<EquipmentLocations>();
            EquipmentMeterLogD = new HashSet<EquipmentMeterLogD>();
            FieldLogEquipment = new HashSet<FieldLogEquipment>();
            FieldLogMaterials = new HashSet<FieldLogMaterials>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTaskDelays = new HashSet<FieldLogTaskDelays>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            FieldLogs = new HashSet<FieldLogs>();
            FuelUsage = new HashSet<FuelUsage>();
            GlBudgetHistory = new HashSet<GlBudgetHistory>();
            GlHistory = new HashSet<GlHistory>();
            GlJournalD = new HashSet<GlJournalD>();
            HisJob = new HashSet<HisJob>();
            HisTimecard = new HashSet<HisTimecard>();
            HisWorkComp = new HashSet<HisWorkComp>();
            InventoryActivityTransferD = new HashSet<InventoryActivityTransferD>();
            InventoryJobD = new HashSet<InventoryJobD>();
            InventoryJobHJobs = new HashSet<InventoryJobH>();
            InventoryJobHJobsNavigation = new HashSet<InventoryJobH>();
            InventoryJobMatD = new HashSet<InventoryJobMatD>();
            InventoryJobMatH = new HashSet<InventoryJobMatH>();
            InventoryMatRecH = new HashSet<InventoryMatRecH>();
            InventoryReceiptsD = new HashSet<InventoryReceiptsD>();
            InventoryReceiptsH = new HashSet<InventoryReceiptsH>();
            ItemCategoriesJobs = new HashSet<ItemCategories>();
            ItemCategoriesJobsNavigation = new HashSet<ItemCategories>();
            JobAccrualPlans = new HashSet<JobAccrualPlans>();
            JobAddAmounts = new HashSet<JobAddAmounts>();
            JobBurdens = new HashSet<JobBurdens>();
            JobCcPercCompWsD = new HashSet<JobCcPercCompWsD>();
            JobCcPercCompWsH = new HashSet<JobCcPercCompWsH>();
            JobCcQtyCompWsD = new HashSet<JobCcQtyCompWsD>();
            JobCcQtyCompWsH = new HashSet<JobCcQtyCompWsH>();
            JobChg = new HashSet<JobChg>();
            JobDivisions = new HashSet<JobDivisions>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            JobPercComp = new HashSet<JobPercComp>();
            JobPercCompWsD = new HashSet<JobPercCompWsD>();
            JobPhases = new HashSet<JobPhases>();
            JobPriceLevels = new HashSet<JobPriceLevels>();
            JobSchedules = new HashSet<JobSchedules>();
            JobTaxableCostclasses = new HashSet<JobTaxableCostclasses>();
            JobTrades = new HashSet<JobTrades>();
            JobTransferFromD = new HashSet<JobTransferFromD>();
            JobTransferToD = new HashSet<JobTransferToD>();
            JobTrx = new HashSet<JobTrx>();
            JobUnions = new HashSet<JobUnions>();
            JobWcClasses = new HashSet<JobWcClasses>();
            JobWcSplits = new HashSet<JobWcSplits>();
            JobWeather = new HashSet<JobWeather>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MeetingAgendas = new HashSet<MeetingAgendas>();
            MinorityCompliance = new HashSet<MinorityCompliance>();
            MiscDocActivities = new HashSet<MiscDocActivities>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocs = new HashSet<MiscDocs>();
            PayEqpHis = new HashSet<PayEqpHis>();
            PoSubChangeItemD = new HashSet<PoSubChangeItemD>();
            PoSubH = new HashSet<PoSubH>();
            PoSubItemD = new HashSet<PoSubItemD>();
            PunchListItemActivities = new HashSet<PunchListItemActivities>();
            PunchListItems = new HashSet<PunchListItems>();
            RecurringTimecard = new HashSet<RecurringTimecard>();
            RfcActivities = new HashSet<RfcActivities>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfcPrintable = new HashSet<RfcPrintable>();
            RfcRecipients = new HashSet<RfcRecipients>();
            Rfcs = new HashSet<Rfcs>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfiQuestionActivities = new HashSet<RfiQuestionActivities>();
            RfiQuestions = new HashSet<RfiQuestions>();
            RfiRecipients = new HashSet<RfiRecipients>();
            Rfis = new HashSet<Rfis>();
            RfpAttachments = new HashSet<RfpAttachments>();
            RfpItemActivities = new HashSet<RfpItemActivities>();
            RfpItems = new HashSet<RfpItems>();
            RfpRecipients = new HashSet<RfpRecipients>();
            Rfps = new HashSet<Rfps>();
            SdDispatchFixedTypes = new HashSet<SdDispatchFixedTypes>();
            SdUserSpecifiedDispatch = new HashSet<SdUserSpecifiedDispatch>();
            StorageTanks = new HashSet<StorageTanks>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            SubmittalItemActivities = new HashSet<SubmittalItemActivities>();
            SubmittalItems = new HashSet<SubmittalItems>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            Submittals = new HashSet<Submittals>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmInvoiceJc = new HashSet<TmInvoiceJc>();
            TmWorksheetH = new HashSet<TmWorksheetH>();
            TransmittalActivities = new HashSet<TransmittalActivities>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            Transmittals = new HashSet<Transmittals>();
            WarehousesJobs = new HashSet<Warehouses>();
            WarehousesJobs1 = new HashSet<Warehouses>();
            WarehousesJobsNavigation = new HashSet<Warehouses>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string Description { get; set; }
        public string CostCodeMethod { get; set; }
        public string CostBasis { get; set; }
        public string CertifiedPayroll { get; set; }
        public string JobStatus { get; set; }
        public decimal? OverheadPercent { get; set; }
        public string CountyNo { get; set; }
        public string TaxPrNo { get; set; }
        public string CustomerNo { get; set; }
        public string ProjectManagerNo { get; set; }
        public string GeoAreaNo { get; set; }
        public string ProjectClassNo { get; set; }
        public decimal? OriginalContract { get; set; }
        public decimal? TotalChangeOrders { get; set; }
        public decimal? IncomeIncurred { get; set; }
        public string TaxApNo { get; set; }
        public decimal? OriginalCost { get; set; }
        public decimal? TotChangeOrderCost { get; set; }
        public decimal? TotPercentComplete { get; set; }
        public DateTime? CertifiedLastPaidDate { get; set; }
        public decimal? RetainagePercent { get; set; }
        public int? PayWeeks { get; set; }
        public string SutaState { get; set; }
        public string ShortDesc { get; set; }
        public DateTime? JobStartDate { get; set; }
        public string TaxArNo { get; set; }
        public string DeptNo { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? CertifiedStartDate { get; set; }
        public string WorkersCompState { get; set; }
        public string NonUnion { get; set; }
        public string OverrideUnion { get; set; }
        public string CustomerOrderNo { get; set; }
        public string CustomerJobNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string AttentionOf { get; set; }
        public string TermsNo { get; set; }
        public string OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerContact { get; set; }
        public string JobContact { get; set; }
        public string ShipViaNo { get; set; }
        public string PrevailingWageUnion { get; set; }
        public string OverheadRateFlag { get; set; }
        public string ApplyPhases { get; set; }
        public string CountyPrNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string JobLocation { get; set; }
        public string TypeOfWork { get; set; }
        public string ProjectNo { get; set; }
        public string JobNumber { get; set; }
        public string FederalNo { get; set; }
        public string EmploymentStatus { get; set; }
        public string District { get; set; }
        public DateTime? EstCompletionDate { get; set; }
        public int? WorkDaysRemaining { get; set; }
        public string ContractType { get; set; }
        public string SecurityCodeNo { get; set; }
        public string Comments { get; set; }
        public string PriceLevelNo { get; set; }
        public decimal? DefaultPriceLevel { get; set; }
        public decimal? OverheadRate { get; set; }
        public decimal? ManDayRate { get; set; }
        public string Contract { get; set; }
        public string GenPhase { get; set; }
        public string MaterialEntered { get; set; }
        public string ApplyShiftDifferential { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? StoredMatRetainagePerc { get; set; }
        public string WcProrationBasis { get; set; }
        public string JobId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerOrderId { get; set; }
        public string CustomerJobId { get; set; }
        public string CountyId { get; set; }
        public string CountyPrId { get; set; }
        public string DeptId { get; set; }
        public string FederalId { get; set; }
        public string GeoAreaId { get; set; }
        public string ProjectId { get; set; }
        public string ProjectClassId { get; set; }
        public string ProjectManagerId { get; set; }
        public string PriceLevelId { get; set; }
        public string ShipViaId { get; set; }
        public string SecurityCodeId { get; set; }
        public string TermsId { get; set; }
        public string TaxApId { get; set; }
        public string TaxArId { get; set; }
        public string TaxPrId { get; set; }
        public string DefaultIncomeCostCode { get; set; }
        public string EquipmentServiceRepair { get; set; }
        public int? TmBillingDesignNo { get; set; }
        public string DefaultIncomePhaseNo { get; set; }
        public string TmOverrideIncomePhaseNo { get; set; }
        public string TmOverrideIncomeCostCodeNo { get; set; }
        public decimal TmRetainagePercent { get; set; }
        public string TmTaxNo { get; set; }
        public string TmSalesTaxBaseDefault { get; set; }
        public string TmTaxLabor { get; set; }
        public string TmTaxMaterial { get; set; }
        public string TmTaxSubcontract { get; set; }
        public string TmTaxOwnedEquipment { get; set; }
        public string TmTaxRentedEquipment { get; set; }
        public string TmTaxBurdenMisc { get; set; }
        public string TmTaxOverhead { get; set; }
        public string DefaultIncomePhaseId { get; set; }
        public string TmBillingDesignId { get; set; }
        public string TmOverrideIncomeCostCodeId { get; set; }
        public string TmOverrideIncomePhaseId { get; set; }
        public string TmTaxId { get; set; }
        public string WaiverOwner { get; set; }
        public string WaiverCounty { get; set; }
        public string LienWaiverDefault { get; set; }
        public string ApTaxExempt { get; set; }
        public string ApTaxExemptCert { get; set; }
        public string InvUsageMarkup { get; set; }
        public string FederalProjectId { get; set; }
        public string StateProjectId { get; set; }
        public string IncludeJobInTm { get; set; }
        public string DefaultTaxType { get; set; }
        public string AwardingAuthority { get; set; }
        public string LienWaiverDefaultAr { get; set; }
        public string LienWaiverFormatAr { get; set; }
        public string LienWaiverFormatAp { get; set; }
        public string DescriptionOfServices { get; set; }
        public string LienWaiverOwnerAddress1 { get; set; }
        public string LienWaiverOwnerAddress2 { get; set; }
        public string LienWaiverOwnerCity { get; set; }
        public string LienWaiverOwnerState { get; set; }
        public string LienWaiverOwnerZip { get; set; }
        public string PreLienRequired { get; set; }
        public string PreLienFormat { get; set; }
        public string PreLienTrustFundVendor { get; set; }
        public DateTime? PreLienPrinted { get; set; }
        public string PreLienContractorName { get; set; }
        public string PreLienContractorAddress1 { get; set; }
        public string PreLienContractorAddress2 { get; set; }
        public string PreLienContractorCity { get; set; }
        public string PreLienContractorState { get; set; }
        public string PreLienContractorZip { get; set; }
        public string PreLienConLenderName { get; set; }
        public string PreLienConLenderAddress1 { get; set; }
        public string PreLienConLenderAddress2 { get; set; }
        public string PreLienConLenderCity { get; set; }
        public string PreLienConLenderState { get; set; }
        public string PreLienConLenderZip { get; set; }
        public string OvhdPostToJob { get; set; }
        public decimal? OvhdRate { get; set; }
        public string OvhdGetValuesFrom { get; set; }
        public string OvhdPostToPhase { get; set; }
        public string OvhdPostToCostCode { get; set; }
        public string OvhdPostToCostClass { get; set; }
        public string TypeOfWorkPr { get; set; }
        public string DavisBaconPayrate { get; set; }
        public DateTime? DateOfLetting { get; set; }
        public string Zone { get; set; }
        public string ProjectSerialNum { get; set; }
        public string Route { get; set; }
        public string Section { get; set; }
        public string IncomeTypeNo { get; set; }
        public string IncludeOnMinorityCompliance { get; set; }
        public string IncomeTypeId { get; set; }
        public string Provider { get; set; }
        public string JobCountry { get; set; }
        public string ShipToNo { get; set; }
        public string VerifyBudgetVsPosubDist { get; set; }
        public string ShipToId { get; set; }
        public string CityProjectNo { get; set; }
        public DateTime? ContractAwardedDate { get; set; }
        public string CityContractNo { get; set; }
        public string KcCertPrLocalTaxNo { get; set; }
        public string LienWaiverOwnerUseFlag { get; set; }
        public string CityContractId { get; set; }
        public string CityProjectId { get; set; }
        public string KcCertPrLocalTaxId { get; set; }
        public string SdFlag { get; set; }
        public string SdSite { get; set; }
        public int? SdTech { get; set; }
        public int? ImportBatchNo { get; set; }
        public string ImportBatchId { get; set; }
        public DateTime? PrevailingWageDate { get; set; }
        public string AwardingAuthProjectNum { get; set; }
        public string TmUsetaxTaxBaseDefault { get; set; }
        public string TmUsetaxLabor { get; set; }
        public string TmUsetaxMaterial { get; set; }
        public string TmUsetaxSubcontract { get; set; }
        public string TmUsetaxOwnedEquipment { get; set; }
        public string TmUsetaxRentedEquipment { get; set; }
        public string TmUsetaxBurden { get; set; }
        public string TmUsetaxOverhead { get; set; }
        public string TmTaxType { get; set; }
        public string QbLaborAccountName { get; set; }
        public string QbLaborAccountN { get; set; }
        public string QbBurdenAccountName { get; set; }
        public string QbBurdenAccountN { get; set; }
        public string QbFicaAccountName { get; set; }
        public string QbFicaAccountN { get; set; }
        public string QbUnemploymentAccountName { get; set; }
        public string QbUnemploymentAccountN { get; set; }
        public string QbWcAccountName { get; set; }
        public string QbWcAccountN { get; set; }
        public string QbFringeAccountName { get; set; }
        public string QbFringeAccountN { get; set; }
        public string Qb401kAccountName { get; set; }
        public string Qb401kAccountN { get; set; }
        public string QbExtraBurdenAccountName { get; set; }
        public string QbExtraBurdenAccountN { get; set; }
        public string QbJob { get; set; }
        public string PreLienContractorTitle { get; set; }
        public string LienWaiverOwnerTitle { get; set; }
        public string PreLienConLenderTitle { get; set; }
        public string LienWaiverFormatType { get; set; }
        public int? LienWaiverDesignNoAp { get; set; }
        public string EqJobUsageRatesComment { get; set; }
        public int? AiaCompanyNameNo { get; set; }
        public string AiaCompanyNameId { get; set; }
        public string ExcludeInEprWrkWage { get; set; }
        public string ForeignFlag { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string CalcDailyOtBasedOn { get; set; }
        public decimal OtDayLimit { get; set; }
        public string ApplySatSunOtRules { get; set; }
        public string TmWsDesignId { get; set; }
        public decimal DtDayLimit { get; set; }
        public string SatAllOt { get; set; }
        public decimal SatDtAfter { get; set; }
        public string SunAllDt { get; set; }
        public string AwardingAuthorityAddress { get; set; }
        public string AwardingAuthorityCity { get; set; }
        public string AwardingAuthorityState { get; set; }
        public string AwardingAuthorityZip { get; set; }
        public string AwardingAuthorityPhone { get; set; }
        public DateTime? BidDate { get; set; }
        public DateTime? BidDueDate { get; set; }
        public string BidStatusNo { get; set; }
        public DateTime? BidClosedDate { get; set; }
        public string EstimatorNo { get; set; }
        public string SalespersonNo { get; set; }
        public string OriginalBidNo { get; set; }
        public string ProestEstimateCode { get; set; }
        public string BidStatusId { get; set; }
        public string EstimatorId { get; set; }
        public string OriginalBidId { get; set; }
        public string SalespersonId { get; set; }

        public BidStatuses BidStatuses { get; set; }
        public Customers C { get; set; }
        public CostCodes CostCodes { get; set; }
        public Employees Employees { get; set; }
        public Employees EmployeesNavigation { get; set; }
        public GeographicAreas GeographicAreas { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public ProjectClasses ProjectClasses { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public SecurityCodes SecurityCodes { get; set; }
        public ShipVia ShipVia { get; set; }
        public Terms Terms { get; set; }
        public DsgDesigns TmBillingDesignNoNavigation { get; set; }
        public JobAreasH JobAreasH { get; set; }
        public TmMarkupJobH TmMarkupJobH { get; set; }
        public ICollection<AiaHeader> AiaHeader { get; set; }
        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<ArInvoiceFrmItemsD> ArInvoiceFrmItemsD { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<BidH> BidH { get; set; }
        public ICollection<BidHistory> BidHistory { get; set; }
        public ICollection<BuyOutH> BuyOutH { get; set; }
        public ICollection<ControlAr> ControlArJobs { get; set; }
        public ICollection<ControlAr> ControlArJobsNavigation { get; set; }
        public ICollection<ControlEq> ControlEqJobs { get; set; }
        public ICollection<ControlEq> ControlEqJobs1 { get; set; }
        public ICollection<ControlEq> ControlEqJobs2 { get; set; }
        public ICollection<ControlEq> ControlEqJobsNavigation { get; set; }
        public ICollection<ControlIn> ControlInJobs { get; set; }
        public ICollection<ControlIn> ControlInJobsNavigation { get; set; }
        public ICollection<DcFieldLogEquipment> DcFieldLogEquipment { get; set; }
        public ICollection<DcFieldLogMaterials> DcFieldLogMaterials { get; set; }
        public ICollection<DcFieldLogOnSiteContacts> DcFieldLogOnSiteContacts { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<DcFieldLogTaskContacts> DcFieldLogTaskContacts { get; set; }
        public ICollection<DcFieldLogTaskDelays> DcFieldLogTaskDelays { get; set; }
        public ICollection<DcFieldLogTasks> DcFieldLogTasks { get; set; }
        public ICollection<DcFieldLogWeather> DcFieldLogWeather { get; set; }
        public ICollection<DcFieldLogs> DcFieldLogs { get; set; }
        public ICollection<DcJobContacts> DcJobContacts { get; set; }
        public ICollection<DcMeetingMinutes> DcMeetingMinutes { get; set; }
        public ICollection<DcMeetingMinutesAttendees> DcMeetingMinutesAttendees { get; set; }
        public ICollection<DcMeetingMinutesTopicContacts> DcMeetingMinutesTopicContacts { get; set; }
        public ICollection<DcMeetingMinutesTopics> DcMeetingMinutesTopics { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocs { get; set; }
        public ICollection<DcPunchListItemActivities> DcPunchListItemActivities { get; set; }
        public ICollection<DcPunchListItems> DcPunchListItems { get; set; }
        public ICollection<DcPunchLists> DcPunchLists { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfcs> DcRfcs { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfis> DcRfis { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcRfps> DcRfps { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcSubmittals> DcSubmittals { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondences { get; set; }
        public ICollection<DcTransmittals> DcTransmittals { get; set; }
        public ICollection<DistributionD> DistributionD { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqJobUsageRatesDetail> EqJobUsageRatesDetail { get; set; }
        public ICollection<EqLocationTransferD> EqLocationTransferD { get; set; }
        public ICollection<EqLocationTransferH> EqLocationTransferH { get; set; }
        public ICollection<EqMeterJournalD> EqMeterJournalD { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoJournalItemsD> EqWoJournalItemsD { get; set; }
        public ICollection<Equipment> EquipmentJobs { get; set; }
        public ICollection<Equipment> EquipmentJobsNavigation { get; set; }
        public ICollection<EquipmentLocations> EquipmentLocations { get; set; }
        public ICollection<EquipmentMeterLogD> EquipmentMeterLogD { get; set; }
        public ICollection<FieldLogEquipment> FieldLogEquipment { get; set; }
        public ICollection<FieldLogMaterials> FieldLogMaterials { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTaskDelays> FieldLogTaskDelays { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<FieldLogs> FieldLogs { get; set; }
        public ICollection<FuelUsage> FuelUsage { get; set; }
        public ICollection<GlBudgetHistory> GlBudgetHistory { get; set; }
        public ICollection<GlHistory> GlHistory { get; set; }
        public ICollection<GlJournalD> GlJournalD { get; set; }
        public ICollection<HisJob> HisJob { get; set; }
        public ICollection<HisTimecard> HisTimecard { get; set; }
        public ICollection<HisWorkComp> HisWorkComp { get; set; }
        public ICollection<InventoryActivityTransferD> InventoryActivityTransferD { get; set; }
        public ICollection<InventoryJobD> InventoryJobD { get; set; }
        public ICollection<InventoryJobH> InventoryJobHJobs { get; set; }
        public ICollection<InventoryJobH> InventoryJobHJobsNavigation { get; set; }
        public ICollection<InventoryJobMatD> InventoryJobMatD { get; set; }
        public ICollection<InventoryJobMatH> InventoryJobMatH { get; set; }
        public ICollection<InventoryMatRecH> InventoryMatRecH { get; set; }
        public ICollection<InventoryReceiptsD> InventoryReceiptsD { get; set; }
        public ICollection<InventoryReceiptsH> InventoryReceiptsH { get; set; }
        public ICollection<ItemCategories> ItemCategoriesJobs { get; set; }
        public ICollection<ItemCategories> ItemCategoriesJobsNavigation { get; set; }
        public ICollection<JobAccrualPlans> JobAccrualPlans { get; set; }
        public ICollection<JobAddAmounts> JobAddAmounts { get; set; }
        public ICollection<JobBurdens> JobBurdens { get; set; }
        public ICollection<JobCcPercCompWsD> JobCcPercCompWsD { get; set; }
        public ICollection<JobCcPercCompWsH> JobCcPercCompWsH { get; set; }
        public ICollection<JobCcQtyCompWsD> JobCcQtyCompWsD { get; set; }
        public ICollection<JobCcQtyCompWsH> JobCcQtyCompWsH { get; set; }
        public ICollection<JobChg> JobChg { get; set; }
        public ICollection<JobDivisions> JobDivisions { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<JobPercComp> JobPercComp { get; set; }
        public ICollection<JobPercCompWsD> JobPercCompWsD { get; set; }
        public ICollection<JobPhases> JobPhases { get; set; }
        public ICollection<JobPriceLevels> JobPriceLevels { get; set; }
        public ICollection<JobSchedules> JobSchedules { get; set; }
        public ICollection<JobTaxableCostclasses> JobTaxableCostclasses { get; set; }
        public ICollection<JobTrades> JobTrades { get; set; }
        public ICollection<JobTransferFromD> JobTransferFromD { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
        public ICollection<JobTrx> JobTrx { get; set; }
        public ICollection<JobUnions> JobUnions { get; set; }
        public ICollection<JobWcClasses> JobWcClasses { get; set; }
        public ICollection<JobWcSplits> JobWcSplits { get; set; }
        public ICollection<JobWeather> JobWeather { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MeetingAgendas> MeetingAgendas { get; set; }
        public ICollection<MinorityCompliance> MinorityCompliance { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivities { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocs { get; set; }
        public ICollection<PayEqpHis> PayEqpHis { get; set; }
        public ICollection<PoSubChangeItemD> PoSubChangeItemD { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<PoSubItemD> PoSubItemD { get; set; }
        public ICollection<PunchListItemActivities> PunchListItemActivities { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RecurringTimecard> RecurringTimecard { get; set; }
        public ICollection<RfcActivities> RfcActivities { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfcPrintable> RfcPrintable { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> Rfcs { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivities { get; set; }
        public ICollection<RfiQuestions> RfiQuestions { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> Rfis { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivities { get; set; }
        public ICollection<RfpItems> RfpItems { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> Rfps { get; set; }
        public ICollection<SdDispatchFixedTypes> SdDispatchFixedTypes { get; set; }
        public ICollection<SdUserSpecifiedDispatch> SdUserSpecifiedDispatch { get; set; }
        public ICollection<StorageTanks> StorageTanks { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivities { get; set; }
        public ICollection<SubmittalItems> SubmittalItems { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> Submittals { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmInvoiceJc> TmInvoiceJc { get; set; }
        public ICollection<TmWorksheetH> TmWorksheetH { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivities { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> Transmittals { get; set; }
        public ICollection<Warehouses> WarehousesJobs { get; set; }
        public ICollection<Warehouses> WarehousesJobs1 { get; set; }
        public ICollection<Warehouses> WarehousesJobsNavigation { get; set; }
    }
}
