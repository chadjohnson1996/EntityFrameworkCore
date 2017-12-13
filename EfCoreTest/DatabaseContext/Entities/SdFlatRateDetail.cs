using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdFlatRateDetail
    {
        public int SequenceNumber { get; set; }
        public string Company { get; set; }
        public string RateNo { get; set; }
        public string Type { get; set; }
        public decimal? Quantity { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public string AssignedServicePerson { get; set; }
        public decimal? Hours { get; set; }
        public decimal? PriceOrRate { get; set; }
        public decimal? Cost { get; set; }
        public string UnitMeasure { get; set; }
        public string PriceLevelNo { get; set; }
        public string WarehouseNo { get; set; }
        public decimal? ExtendedCost { get; set; }
        public decimal? Amount { get; set; }
        public string Taxable { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public int? TechSequence { get; set; }
        public string CompanyId { get; set; }
        public string PriceLevelId { get; set; }
        public string RateId { get; set; }
        public string WarehouseId { get; set; }
        public int LineNo { get; set; }
        public string LineId { get; set; }

        public SdFlatRates SdFlatRates { get; set; }
    }
}
