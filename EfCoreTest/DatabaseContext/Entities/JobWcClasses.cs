using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobWcClasses
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string WcState { get; set; }
        public string WcClassNo { get; set; }
        public decimal? MaxWeekExposure { get; set; }
        public decimal? Rate { get; set; }
        public string IncludePremium { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
        public string WcGroupNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string WcClassId { get; set; }
        public string WcGroupId { get; set; }

        public Jobs Jobs { get; set; }
        public WcClasses WcClasses { get; set; }
    }
}
