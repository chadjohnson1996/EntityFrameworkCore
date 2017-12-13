using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractTypeDispatchH
    {
        public int CompanyNo { get; set; }
        public string ContractType { get; set; }
        public int VisitEstimate { get; set; }
        public string WorkRequested { get; set; }
        public string Notes { get; set; }
        public string StatusCodeNo { get; set; }
        public int? WoDesign { get; set; }
        public int? TypeOfRepair { get; set; }
        public int? TechNo { get; set; }
        public int DispatchUnique { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DefaultPriorityCode { get; set; }
        public string CompanyId { get; set; }
        public string StatusCodeId { get; set; }
        public string TechId { get; set; }
    }
}
