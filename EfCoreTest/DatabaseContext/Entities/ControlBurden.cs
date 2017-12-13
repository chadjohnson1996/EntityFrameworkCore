using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlBurden
    {
        public int CompanyNo { get; set; }
        public string CostClassNo { get; set; }
        public string CostCodeNo { get; set; }
        public string WcCostClassNo { get; set; }
        public string WcCostCodeNo { get; set; }
        public string SfCostClassNo { get; set; }
        public string SfCostCodeNo { get; set; }
        public string SutaFutaDetail { get; set; }
        public decimal? GlSutaPayable { get; set; }
        public decimal? GlSutaExpense { get; set; }
        public decimal? GlFutaPayable { get; set; }
        public decimal? GlFutaExpense { get; set; }
        public string Default1 { get; set; }
        public string Default2 { get; set; }
        public string Default3 { get; set; }
        public string Default4 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Default5 { get; set; }
        public string WcProrationBasis { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string SfCostClassId { get; set; }
        public string SfCostCodeId { get; set; }
        public string WcCostClassId { get; set; }
        public string WcCostCodeId { get; set; }
        public string Default6 { get; set; }
        public string Default7 { get; set; }
    }
}
