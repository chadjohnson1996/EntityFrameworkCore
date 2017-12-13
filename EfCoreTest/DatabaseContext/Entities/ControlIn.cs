﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlIn
    {
        public int CompanyNo { get; set; }
        public string ItemCategoryNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ItemCategoryId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string WarehouseNo { get; set; }
        public string CalculateAverageFlag { get; set; }
        public decimal CalculateAverageMonths { get; set; }
        public string ItemVendorSort { get; set; }
        public string UsageShowUnitCost { get; set; }
        public string UsageUnitCostDefault { get; set; }
        public string NegativeOnHandQty { get; set; }
        public string ReceivingShowUnitCost { get; set; }
        public string ReceivingUnitCostVerify { get; set; }
        public string ReceivingUnitCostDefault { get; set; }
        public string ReceivingQtyVerify { get; set; }
        public string ApInvoiceUnitCostVerify { get; set; }
        public string InventoryMethod { get; set; }
        public string GlHisFlag { get; set; }
        public string JournalNo { get; set; }
        public decimal? GlInventoryPayable { get; set; }
        public decimal? GlRounding { get; set; }
        public decimal? GlInventoryIncome { get; set; }
        public decimal? GlMaterialExpense { get; set; }
        public decimal? GlInventoryAsset { get; set; }
        public decimal? GlReconciliation { get; set; }
        public decimal? GlPassThrough { get; set; }
        public string DefaultSeqGlInventoryIncome { get; set; }
        public string DefaultSeqGlMaterialExpense { get; set; }
        public string DefaultSeqGlInventoryAsset { get; set; }
        public string DefaultSeqGlReconciliation { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string DefaultSeqDivExpense { get; set; }
        public string DefaultSeqDivCredit { get; set; }
        public string PurchasingDistributionDefault { get; set; }
        public string ReceivingDistributionDefault { get; set; }
        public string UsageDistributionDefault { get; set; }
        public string ReceivingAutopostJournal { get; set; }
        public string ReceiptFlag { get; set; }
        public string UsageShowUnitNo { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string JournalId { get; set; }
        public string PhaseId { get; set; }
        public string UsageShowUnitId { get; set; }
        public string WarehouseId { get; set; }
        public DateTime? HisStartDate { get; set; }
        public string ZeroUnitCostVerify { get; set; }
        public string ReconPrintStatus { get; set; }
        public string ReconShowCompCntWk { get; set; }
        public string ReconShowCompCnt { get; set; }
        public string ReconDefaultCompCnt { get; set; }
        public string ReconShowValuation { get; set; }
        public string ReconUnitCostDefault { get; set; }
        public string ReconAllowUcOverride { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string NegOnHandQtyBy { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }
        public string ArAutopostTrf { get; set; }
        public string UseArIncomeGl { get; set; }
        public string PrimaryReceivUnitCostDef { get; set; }
        public string RcptToJobInLastCost { get; set; }
        public string ImportInventroyReceipts { get; set; }
        public string HoldFlag { get; set; }
        public string PrimaryPurchasingUnitCostDef { get; set; }
        public string SecondaryPurchasingUnitCostDef { get; set; }
        public string UseArDivision { get; set; }
        public string RequireCommentOnReceipt { get; set; }
        public string ImpApplyPriceLevel { get; set; }
        public string ImpApplyStdCost { get; set; }
        public string ImpIncludeCompany { get; set; }
        public string ReceiveInventoryThroughAp { get; set; }
        public string DisplayInvTransferGlSummary { get; set; }
        public string SecondaryUsageUnitCostDefault { get; set; }
        public string WarehouseJobTransferDefault { get; set; }
        public string AvgCostWhenRecvToJob { get; set; }
        public string SyncReceiptAutosave { get; set; }
        public string SyncReceiptAutopost { get; set; }
        public string SyncTransferAutosave { get; set; }
        public string SyncTransferAutopost { get; set; }
        public int InvsummRptVersion { get; set; }
        public string InvreceiptsDefaultDate { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts Accounts3 { get; set; }
        public Accounts Accounts4 { get; set; }
        public Accounts Accounts5 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostCodes CostCodes { get; set; }
        public GlJournals GlJournals { get; set; }
        public ItemCategories ItemCategories { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs JobsNavigation { get; set; }
        public Phases Phases { get; set; }
        public Phases PhasesNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}
