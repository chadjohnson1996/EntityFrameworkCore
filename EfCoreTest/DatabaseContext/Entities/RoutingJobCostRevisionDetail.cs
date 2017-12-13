using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingJobCostRevisionDetail
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int? CompanyNo { get; set; }
        public int? OriginalLineNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal Amount { get; set; }
        public decimal? AccountNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public decimal? Units { get; set; }
        public string Description { get; set; }
        public string TaxFlag { get; set; }
        public decimal? TaxBase { get; set; }
        public string TaxNo { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? Total { get; set; }
        public string UseTax { get; set; }
        public string EqWoNo { get; set; }
        public string EquipNo { get; set; }
        public string ServiceCodeNo { get; set; }

        public RoutingJobCostRevision Parent { get; set; }
    }
}
