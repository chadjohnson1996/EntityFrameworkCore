using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchbillings
    {
        public string Company { get; set; }
        public int SequenceNumber { get; set; }
        public string DispatchNumber { get; set; }
        public string UniqueIdn { get; set; }
        public string Type { get; set; }
        public decimal? Quantity { get; set; }
        public string Location { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public int? AssignedServicePerson { get; set; }
        public decimal? Hours { get; set; }
        public decimal? PriceOrRate { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? PostingDate { get; set; }
        public string EnteredBy { get; set; }
        public string TaxCode { get; set; }
        public string TaxBranch { get; set; }
        public string TaxAccount { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxBase { get; set; }
        public decimal? TaxAmount { get; set; }
        public string SalesCode { get; set; }
        public string SalesBranch { get; set; }
        public string SalesAccount { get; set; }
        public string UnitMeasure { get; set; }
        public string PriceLevelNo { get; set; }
        public string WarehouseNo { get; set; }
        public decimal? ExtendedCost { get; set; }
        public decimal? Amount { get; set; }
        public string FlatRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string EarnCode { get; set; }
        public decimal PrHours { get; set; }
        public decimal PrAmount { get; set; }
        public string PayrollImported { get; set; }
        public DateTime? PrDate { get; set; }
        public string PrPhaseNo { get; set; }
        public string PrCostCodeNo { get; set; }
        public string AdditionalEarnCode { get; set; }
        public string EquipmentNo { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string PrCostCodeId { get; set; }
        public string PrPhaseId { get; set; }
        public string PriceLevelId { get; set; }
        public string WarehouseId { get; set; }
        public string QuoteNo { get; set; }
        public DateTime? BillingDate { get; set; }
        public int? OrdinalPosition { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? StateTaxableLimit { get; set; }
        public decimal? StateTaxAmount { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? LocalTaxableLimit { get; set; }
        public decimal? LocalTaxAmount { get; set; }
        public decimal? OtherTaxPercent { get; set; }
        public decimal? OtherTaxableLimit { get; set; }
        public decimal? OtherTaxAmount { get; set; }
        public string QuoteId { get; set; }
        public int? FlatRateControl { get; set; }
        public string ShiftNo { get; set; }
        public int? TimeCardsRowUniqueId { get; set; }
        public string ShiftId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? StartTimeMilitary { get; set; }
        public string StartTimeType { get; set; }
        public DateTime? EndTimeMilitary { get; set; }
        public string EndTimeType { get; set; }
        public int? EqPartsRow { get; set; }
        public string Converted { get; set; }
    }
}
