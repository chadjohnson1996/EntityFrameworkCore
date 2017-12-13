using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDailydispatchcolormask
    {
        public string Company { get; set; }
        public int TypeOfRepair { get; set; }
        public string DescriptionOfRepair { get; set; }
        public int Backgroundcolor { get; set; }
        public int Foregroundcolor { get; set; }
        public int? Colorcode { get; set; }
        public string GlIncomeBranch { get; set; }
        public string GlIncomeAccount { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string ProjectManagerNo { get; set; }
        public string IncomeTypeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public decimal? FsiAccountNo { get; set; }
        public string PrPhaseNo { get; set; }
        public string PrCostCodeNo { get; set; }
        public string PriceLevelNo { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string FsiAccountId { get; set; }
        public string IncomeTypeId { get; set; }
        public string PhaseId { get; set; }
        public string PrCostCodeId { get; set; }
        public string PrPhaseId { get; set; }
        public string PriceLevelId { get; set; }
        public string ProjectManagerId { get; set; }
        public string LaborPriceLevelNo { get; set; }
        public string LaborPriceLevelId { get; set; }
        public string PriorityCode { get; set; }
    }
}
