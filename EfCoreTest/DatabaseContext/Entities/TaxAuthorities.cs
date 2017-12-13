using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxAuthorities
    {
        public int CompanyNo { get; set; }
        public string TaxCode { get; set; }
        public string Description { get; set; }
        public string ForcePay { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? GlTaxPayableAr { get; set; }
        public decimal? TaxableMisc { get; set; }
        public decimal? TaxableFreight { get; set; }
        public decimal? UseGlTaxExpense { get; set; }
        public decimal? UseGlTaxAcrual { get; set; }
        public string UseGlTaxPostFlag { get; set; }
        public string UseCostCodeNo { get; set; }
        public string UseCostClassNo { get; set; }
        public string Distribution { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string UseCostClassId { get; set; }
        public string UseCostCodeId { get; set; }
    }
}
