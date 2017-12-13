﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlEq
    {
        public int CompanyNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string UpdateGl { get; set; }
        public string GlHisFlag { get; set; }
        public decimal? GlExpenseOwned { get; set; }
        public decimal? GlExpenseRented { get; set; }
        public decimal? GlExpenseLeased { get; set; }
        public decimal? GlCredit { get; set; }
        public string DefaultSeqDivExpense { get; set; }
        public string DefaultSeqDivCredit { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string EnableAttachments { get; set; }
        public string AllowAnyAttachment { get; set; }
        public string RecordDefaultAttachment { get; set; }
        public string EntryToSold { get; set; }
        public string EntryToMissing { get; set; }
        public string EntryToScrap { get; set; }
        public decimal DefaultHourlyRate { get; set; }
        public decimal DefaultDailyRate { get; set; }
        public decimal DefaultWeeklyRate { get; set; }
        public decimal DefaultMonthlyRate { get; set; }
        public decimal DefaultIdleRate { get; set; }
        public decimal DefaultDownRate { get; set; }
        public string JournalNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JournalId { get; set; }
        public string ValidateClosedWo { get; set; }
        public string ProtectEqLastService { get; set; }
        public string RemoveFrom { get; set; }
        public string FromJobNo { get; set; }
        public string FromWarehouseNo { get; set; }
        public string FromPhaseNo { get; set; }
        public string FromCostCodeNo { get; set; }
        public string FromCostClassNo { get; set; }
        public string ToJobNo { get; set; }
        public string ToPhaseNo { get; set; }
        public string ToCostCodeNo { get; set; }
        public string ToCostClassNo { get; set; }
        public string EnableGlJcDist { get; set; }
        public string RequireGl { get; set; }
        public string ExpJrnlJournalNo { get; set; }
        public decimal? GlExpJrnlDebit { get; set; }
        public decimal? GlExpJrnlCredit { get; set; }
        public string DefaultSeqExpDebit { get; set; }
        public string DefaultSeqExpCredit { get; set; }
        public string DefaultSeqExpDivDebit { get; set; }
        public int? DefaultDivExp1 { get; set; }
        public int? DefaultDivExp2 { get; set; }
        public int? DefaultDivExp3 { get; set; }
        public int? DefaultDivExp4 { get; set; }
        public string ExpJrnlJournalId { get; set; }
        public string FromCostClassId { get; set; }
        public string FromCostCodeId { get; set; }
        public string FromJobId { get; set; }
        public string FromPhaseId { get; set; }
        public string FromWarehouseId { get; set; }
        public string ToCostClassId { get; set; }
        public string ToCostCodeId { get; set; }
        public string ToJobId { get; set; }
        public string ToPhaseId { get; set; }
        public string TrackUsageBy { get; set; }
        public string EnableLocationTracking { get; set; }
        public string DefaultLocationJobNo { get; set; }
        public DateTime? DefaultStartTime { get; set; }
        public string DefaultStartTimeType { get; set; }
        public DateTime? DefaultStartTimeMilitary { get; set; }
        public string LocationUsage { get; set; }
        public string LocationTimecards { get; set; }
        public string LocationWorkOrders { get; set; }
        public string DefaultWoJobNo { get; set; }
        public string MileageEntryReduceceBalance { get; set; }
        public string LocationMeterMileage { get; set; }
        public string DefaultLocationJobId { get; set; }
        public string DefaultWoJobId { get; set; }
        public string EqLookupSortBy { get; set; }
        public string TrackEqIncomeInAr { get; set; }
        public string EntryToLicExp { get; set; }
        public string EntryToLicExpApp { get; set; }
        public int EntryToLicExpDays { get; set; }
        public string AutoCreateWo { get; set; }
        public string AutoPrintWo { get; set; }
        public string RelieveInventory { get; set; }
        public string PrAutoGenWoOption { get; set; }
        public string PrAutoGenWoDate { get; set; }
        public string ApAutoGenWoOption { get; set; }
        public string ApAutoGenWoDate { get; set; }
        public decimal DefaultEqLaborRate { get; set; }
        public string DefaultLaborRateFlag { get; set; }
        public string UsagesyncAutosave { get; set; }
        public string UsagesyncAutopost { get; set; }
        public string EqUsageDropdownFilter { get; set; }
        public string ManEqWo { get; set; }
        public string EqItemEnableFuelTrackFlag { get; set; }
        public string FuelJournalNo { get; set; }
        public string CalculateAverageFlag { get; set; }
        public string PurchaseStorageTank { get; set; }
        public string DispenseFromDefault { get; set; }
        public string EqItemFuelDefault { get; set; }
        public string EqItemConsumptionType { get; set; }
        public string DefaultUnitCostFlag { get; set; }
        public string UnitCostFieldFlag { get; set; }
        public string FuelJcMethod { get; set; }
        public decimal CalculateAverageMonths { get; set; }
        public decimal? GlExpenseFuelOwned { get; set; }
        public decimal? GlExpenseFuelRented { get; set; }
        public decimal? GlExpenseFuelLeased { get; set; }
        public int? DefaultFuelDiv1 { get; set; }
        public int? DefaultFuelDiv2 { get; set; }
        public int? DefaultFuelDiv3 { get; set; }
        public int? DefaultFuelDiv4 { get; set; }
        public string EnableFuelTrackingFlag { get; set; }
        public decimal? GlFuelAsset { get; set; }
        public decimal? GlReconciliation { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string ReconUnitCostDefault { get; set; }
        public string ReconAllowUcOverride { get; set; }
        public string GallonsExceedFlag { get; set; }
        public DateTime? HisStartDate { get; set; }
        public string FuelReceivingUnitCostVerify { get; set; }
        public string FuelReceivingGallonsVerify { get; set; }
        public string UpdateFuelGlHistory { get; set; }
        public string UpdateFuelGl { get; set; }
        public string RequireMeterMileageFlag { get; set; }
        public string PriorMeterMileageFlag { get; set; }
        public string LocationFuelUsage { get; set; }
        public string DefaultSeqFuelExp { get; set; }
        public string DefaultSeqFuelDiv { get; set; }
        public string DefaultFuelJcPhase { get; set; }
        public string DefaultFuelJcCostCode { get; set; }
        public string DefaultFuelJcCostClass { get; set; }
        public decimal? FuelGlPassThruAcct { get; set; }
        public string DefaultFuelJcJob { get; set; }
        public string AllocateFuelJcPhase { get; set; }
        public string AllocateFuelJcCostCode { get; set; }
        public string AllocateFuelJcCostClass { get; set; }
        public string FuelJournalId { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }
        public DateTime? IncludePrEqUsageAsOf { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts Accounts3 { get; set; }
        public Accounts Accounts4 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostClasses CostClassesNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public CostCodes CostCodesNavigation { get; set; }
        public GlJournals GlJournals { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs Jobs1 { get; set; }
        public Jobs Jobs2 { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}