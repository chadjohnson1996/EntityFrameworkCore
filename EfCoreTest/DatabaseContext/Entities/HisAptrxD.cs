using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisAptrxD
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public decimal? GlAccountCode { get; set; }
        public decimal? DistributionAmount { get; set; }
        public string JobNumber { get; set; }
        public string CostCodeNo { get; set; }
        public decimal? DistributionClass { get; set; }
        public decimal? DistributionQuantity { get; set; }
        public string DistributionCategory { get; set; }
        public string TaxAuthority { get; set; }
        public string EquipmentCode { get; set; }
        public string DistributionDescription { get; set; }
        public string DiscountQtyFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string LineId { get; set; }
        public string VoucherId { get; set; }
    }
}
