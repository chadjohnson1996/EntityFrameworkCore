using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PoSubChangeD
    {
        public int CompanyNo { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderLineNo { get; set; }
        public decimal? GlExpense { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string ManualClose { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderLineId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string PoSubId { get; set; }
        public decimal GoodsServiceAmount { get; set; }
        public string TaxFlag { get; set; }
        public decimal TaxBase { get; set; }
        public decimal TaxAmount { get; set; }
        public string InventoryPayableFlag { get; set; }
        public string EquipmentNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public int? InternalBatchNumber { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public decimal? StateLimitApplied { get; set; }
        public decimal? LocalLimitApplied { get; set; }
        public decimal? OtherLimitApplied { get; set; }
        public string FuelPayableFlag { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? FullGlExpense { get; set; }

        public PoSubChangeH PoSubChangeH { get; set; }
        public PoSubH PoSubH { get; set; }
    }
}
