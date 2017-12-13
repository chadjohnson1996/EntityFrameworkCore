using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContracts
    {
        public string Company { get; set; }
        public string SiteNumber { get; set; }
        public int SequenceNumber { get; set; }
        public string ContractNumber { get; set; }
        public string ContractType { get; set; }
        public string Description { get; set; }
        public DateTime? ContractEffective { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? HourlyBillingRate { get; set; }
        public decimal? MaterialDiscount { get; set; }
        public decimal? LaborDiscount { get; set; }
        public string CoPurchaser1 { get; set; }
        public string CoPurchaser2 { get; set; }
        public string SalesPerson { get; set; }
        public string CompletedFlag { get; set; }
        public string CancelledFlag { get; set; }
        public DateTime? CancelledDate { get; set; }
        public DateTime? PaymentsBeginDate { get; set; }
        public decimal? DurationForPayments { get; set; }
        public decimal? DownPayment { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string Frequency { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? LateCharge { get; set; }
        public decimal? AnniversaryCredit { get; set; }
        public string DispatchNumber { get; set; }
        public string UniqueIdn { get; set; }
        public string PriceLevel { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string QuoteNo { get; set; }
        public string QuoteId { get; set; }
        public string LaborPriceLevelNo { get; set; }
        public string LaborPriceLevelId { get; set; }
        public string Converted { get; set; }
    }
}
