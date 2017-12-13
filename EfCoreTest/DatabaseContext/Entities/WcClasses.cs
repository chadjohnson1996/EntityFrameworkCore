using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WcClasses
    {
        public WcClasses()
        {
            JobWcClasses = new HashSet<JobWcClasses>();
            JobWcSplits = new HashSet<JobWcSplits>();
            WcCostcodes = new HashSet<WcCostcodes>();
            WcDepts = new HashSet<WcDepts>();
            WcTrades = new HashSet<WcTrades>();
        }

        public int CompanyNo { get; set; }
        public string WcState { get; set; }
        public string WcClassNo { get; set; }
        public decimal? MaxWeekExposure { get; set; }
        public decimal? Rate { get; set; }
        public string IncludePremium { get; set; }
        public string Description { get; set; }
        public string WcGroupNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string WcClassId { get; set; }
        public string WcGroupId { get; set; }
        public string ReportingClass { get; set; }
        public decimal? EmployeeRate { get; set; }
        public string DeductionNo { get; set; }
        public string DeductionId { get; set; }

        public Deductions Deductions { get; set; }
        public WcExpGroups WcExpGroups { get; set; }
        public WcStates WcStates { get; set; }
        public ICollection<JobWcClasses> JobWcClasses { get; set; }
        public ICollection<JobWcSplits> JobWcSplits { get; set; }
        public ICollection<WcCostcodes> WcCostcodes { get; set; }
        public ICollection<WcDepts> WcDepts { get; set; }
        public ICollection<WcTrades> WcTrades { get; set; }
    }
}
