using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlJc
    {
        public string Company { get; set; }
        public string SiteJob { get; set; }
        public string SiteJobOverride { get; set; }
        public string DispatchJob { get; set; }
        public string DispatchJobOverride { get; set; }
        public string SiteJobPrefix { get; set; }
        public string DispatchJobPrefix { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string DefaultEndDate { get; set; }
        public decimal? JobDiv1 { get; set; }
        public decimal? JobDiv2 { get; set; }
        public decimal? JobDiv3 { get; set; }
        public decimal? JobDiv4 { get; set; }
        public string DivSeq1 { get; set; }
        public string DivSeq2 { get; set; }
        public string CompanyId { get; set; }
        public string DefaultJobAddress { get; set; }
        public string ForceGeoAreaSite { get; set; }
        public string ContractJob { get; set; }
        public string ContractJobPrefix { get; set; }
        public string ContractJobOverride { get; set; }
        public string ContractJobDispatch { get; set; }
    }
}
