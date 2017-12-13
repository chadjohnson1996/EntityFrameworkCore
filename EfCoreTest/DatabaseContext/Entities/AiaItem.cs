using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AiaItem
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SectionNo { get; set; }
        public string AiaItemNo { get; set; }
        public int AiaItemSubsetNo { get; set; }
        public string ItemType { get; set; }
        public DateTime? ChangeOrderDate { get; set; }
        public string Description { get; set; }
        public decimal ScheduleValue { get; set; }
        public decimal PreviousApplication { get; set; }
        public decimal WorkInPlace { get; set; }
        public decimal StoredMaterial { get; set; }
        public decimal Retainage { get; set; }
        public decimal PercentComplete { get; set; }
        public decimal WorkInPlacePercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? PostDate { get; set; }
        public decimal? GlIncome { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal RetainagePercent { get; set; }
        public decimal StoredMaterialRetainagePercent { get; set; }
        public decimal CompletedRetainage { get; set; }
        public decimal StoredRetainage { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullAccountNo { get; set; }
        public string AiaItemId { get; set; }
        public string AiaItemSubsetId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string FullAccountId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string SectionId { get; set; }
        public int OrdinalPosition { get; set; }
        public int NestingLevel { get; set; }
        public string RowType { get; set; }
        public string RowHeading { get; set; }
        public string TakeRetainage { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string AutoCreatedByJcCo { get; set; }
        public string ChangeOrderId { get; set; }

        public AiaHeader AiaHeader { get; set; }
        public CostCodes Co { get; set; }
        public JobChg JobChg { get; set; }
        public Phases Phases { get; set; }
    }
}
