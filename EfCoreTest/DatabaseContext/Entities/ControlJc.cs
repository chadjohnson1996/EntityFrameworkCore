using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlJc
    {
        public ControlJc()
        {
            ReportBondingClasses = new HashSet<ReportBondingClasses>();
        }

        public int CompanyNo { get; set; }
        public string LjCostCodes { get; set; }
        public string ForceTaxGroup { get; set; }
        public string ForceDeptInJob { get; set; }
        public decimal? CoUseFlag { get; set; }
        public string ForceCoDist { get; set; }
        public string NonRecovProjClass { get; set; }
        public decimal? OverBillGl { get; set; }
        public decimal? UnderBillGl { get; set; }
        public decimal? OverUnderExpGl { get; set; }
        public string OverUnderJrnl { get; set; }
        public string UpdateGlHis { get; set; }
        public string ClosedJobEntry { get; set; }
        public string PhaseFlag { get; set; }
        public decimal? OvhdGlDebit { get; set; }
        public decimal? OvhdGlCredit { get; set; }
        public string JobTypeDefault { get; set; }
        public string CostClassLab { get; set; }
        public string CostClassMat { get; set; }
        public string CostClassSub { get; set; }
        public string CostClassOeq { get; set; }
        public string CostClassReq { get; set; }
        public string CostClassQty { get; set; }
        public string NextJobNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? UnallocatedOverheadPerc { get; set; }
        public string AsmCur1 { get; set; }
        public string AsmPrv1 { get; set; }
        public string AsmCur2 { get; set; }
        public string AsmPrv2 { get; set; }
        public string SumCur1 { get; set; }
        public string SumPrv1 { get; set; }
        public string SumCur2 { get; set; }
        public string SumPrv2 { get; set; }
        public string SumCur3 { get; set; }
        public string SumPrv3 { get; set; }
        public string RevCur1 { get; set; }
        public string RevPrv1 { get; set; }
        public string RevCur2 { get; set; }
        public string RevPrv2 { get; set; }
        public string ShowPhase { get; set; }
        public string CompanyId { get; set; }
        public string NextJobId { get; set; }
        public string ForceProjectManager { get; set; }
        public string EnableGlInterface { get; set; }
        public decimal? OvhdRate { get; set; }
        public string OvhdRateType { get; set; }
        public string OvhdPostToPhase { get; set; }
        public string OvhdPostToCostCode { get; set; }
        public string OvhdPostToCostClass { get; set; }
        public string OvhdUpdateGlHistory { get; set; }
        public string OvhdGlJournal { get; set; }
        public decimal? OvhdLevel1Div { get; set; }
        public decimal? OvhdLevel2Div { get; set; }
        public decimal? OvhdLevel3Div { get; set; }
        public decimal? OvhdLevel4Div { get; set; }
        public string BaseProjectedCostOn { get; set; }
        public string PctCmplEnableCostclass { get; set; }
        public string DefaultLienWaiverDefault { get; set; }
        public string ForceCustomer { get; set; }
        public string EnableUpdateAiaFromJcCo { get; set; }
        public string EnableUpdatePoSubFromJcCo { get; set; }
        public string DefaultCustomerAddress { get; set; }
        public string CustomerHeldEntry { get; set; }
        public decimal? OverUnderLevel1Division { get; set; }
        public decimal? OverUnderLevel2Division { get; set; }
        public decimal? OverUnderLevel3Division { get; set; }
        public decimal? OverUnderLevel4Division { get; set; }
        public string DefaultPrintDetailFlag { get; set; }
        public int JcActRptVersion { get; set; }
        public DateTime? ContractJobFilterDate { get; set; }
        public DateTime? ServiceJobFilterDate { get; set; }
        public string EnableSdSiteTech { get; set; }
        public string CcWsAllowSameDayEntry { get; set; }
        public string EnableTaxableCostClassOnJob { get; set; }
        public string ClosedPhase { get; set; }
        public string ClosedCostCode { get; set; }
        public string DefaultEndDate { get; set; }
        public string ShowClosedJobsInJobsDropdown { get; set; }
        public string DefaultPsCoDate { get; set; }
        public string CertifiedPrTag { get; set; }
        public string JobFilterNoClosedDate { get; set; }
        public string BlankVendorInDist { get; set; }
        public string EnableEstCompOnBdg { get; set; }
        public string SyncQuantityAutosave { get; set; }
        public string SyncQuantityAutopost { get; set; }
        public string BalancedCoPending { get; set; }
        public string BalancedCoRejected { get; set; }
        public string BalancedCoInternal { get; set; }
        public string DisplayLastProjCost { get; set; }
        public string ForceDivision { get; set; }
        public string FilterChgOrders { get; set; }

        public ICollection<ReportBondingClasses> ReportBondingClasses { get; set; }
    }
}
