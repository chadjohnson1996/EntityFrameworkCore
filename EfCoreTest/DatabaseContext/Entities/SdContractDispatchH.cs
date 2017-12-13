using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractDispatchH
    {
        public int CompanyNo { get; set; }
        public string ContractNo { get; set; }
        public int RenewalNo { get; set; }
        public int VisitEstimate { get; set; }
        public DateTime? EstimatedDate { get; set; }
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
        public int? DispatchesGenerated { get; set; }
        public string CreatedUnique { get; set; }
        public string WhoCalled { get; set; }
        public string VoicePhone { get; set; }
        public string WorkAddress { get; set; }
        public string WorkAddress2 { get; set; }
        public string WorkCity { get; set; }
        public string WorkState { get; set; }
        public string WorkZipcode { get; set; }
        public string SiteNo { get; set; }
        public string CustomerNo { get; set; }
        public string JobNo { get; set; }
        public string CompanyId { get; set; }
        public string ContractId { get; set; }
        public string CustomerId { get; set; }
        public string JobId { get; set; }
        public string RenewalId { get; set; }
        public string SiteId { get; set; }
        public string StatusCodeId { get; set; }
        public string TechId { get; set; }
    }
}
