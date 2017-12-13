using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlPr
    {
        public string Company { get; set; }
        public string EarnCode { get; set; }
        public string ContractJobEarnCode { get; set; }
        public string LunchEarnCode { get; set; }
        public string TravelEarnCode { get; set; }
        public string UserDefinedEarnCode { get; set; }
        public string VacationEarnCode { get; set; }
        public string DefaultPhaseNo { get; set; }
        public string DefaultCostCodeNo { get; set; }
        public string AutoCalcHours { get; set; }
        public string RoundAutoHours { get; set; }
        public int RoundingCutoff { get; set; }
        public string DefaultBillingHours { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string IllnessEarnCode { get; set; }
        public string CompanyId { get; set; }
        public string DefaultCostCodeId { get; set; }
        public string DefaultPhaseId { get; set; }
    }
}
