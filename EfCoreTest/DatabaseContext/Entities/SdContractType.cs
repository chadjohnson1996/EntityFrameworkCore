using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractType
    {
        public string Company { get; set; }
        public string ContractType { get; set; }
        public string Description { get; set; }
        public string PriceLevel { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public int? DesignNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public decimal? ContractAmount { get; set; }
        public string EquipmentDetailFlag { get; set; }
        public string SalesPersonNo { get; set; }
        public string BillingFrequency { get; set; }
        public int? BillEveryValue { get; set; }
        public string BillEveryFrequency { get; set; }
        public int? InvoiceDesignNo { get; set; }
        public int? NumberOfBillings { get; set; }
        public string InvoiceDescription { get; set; }
        public string JobNo { get; set; }
        public string TaxAuthorityNo { get; set; }
        public string IncomeTypeNo { get; set; }
        public string BillShipToNo { get; set; }
        public string ArPhaseNo { get; set; }
        public string ArCostCodeNo { get; set; }
        public int? ContractTerm { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string AllowRenewalFlag { get; set; }
        public int? RenewalDesignNo { get; set; }
        public string RenewWithPrice { get; set; }
        public string RenewContractTypePrice { get; set; }
        public string RenewBasedOn { get; set; }
        public string RenewEqDetail { get; set; }
        public decimal? RenewalPriceAmount { get; set; }
        public decimal? RenewalPricePercent { get; set; }
        public string RenewalPricePercentOption { get; set; }
        public string AutoApproveRenewalFlag { get; set; }
        public string DispatchStatusCodeNo { get; set; }
        public int? TypeOfRepairNo { get; set; }
        public string LaborPriceLevelNo { get; set; }
        public string Notes { get; set; }
        public string Terms { get; set; }
        public int? NumberOfDispatches { get; set; }
        public string DispatchFrequency { get; set; }
        public string DispatchEveryFrequency { get; set; }
        public int? DispatchEveryValue { get; set; }
        public string DefaultNote { get; set; }
        public string DefaultWorkRequested { get; set; }
        public int? DefaultTech { get; set; }
        public int? DefaultWo { get; set; }
        public string DefaulTerms { get; set; }
        public string BillingType { get; set; }
        public decimal? HourlyBillingRate { get; set; }
        public string DefaultTerms { get; set; }
        public string DefaultPriorityCode { get; set; }
        public string ArCostCodeId { get; set; }
        public string ArPhaseId { get; set; }
        public string BillShipToId { get; set; }
        public string DesignId { get; set; }
        public string DispatchStatusCodeId { get; set; }
        public string IncomeTypeId { get; set; }
        public string InvoiceDesignId { get; set; }
        public string JobId { get; set; }
        public string LaborPriceLevelId { get; set; }
        public string RenewalDesignId { get; set; }
        public string SalesPersonId { get; set; }
        public string TaxAuthorityId { get; set; }
        public string TypeOfRepairId { get; set; }
    }
}
