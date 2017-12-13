using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class WcStates
    {
        public WcStates()
        {
            Departments = new HashSet<Departments>();
            Employees = new HashSet<Employees>();
            WcClasses = new HashSet<WcClasses>();
            WcExpGroups = new HashSet<WcExpGroups>();
        }

        public int CompanyNo { get; set; }
        public string WcState { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlPayable { get; set; }
        public string Description { get; set; }
        public string Include401 { get; set; }
        public string Include125 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ExposureBasis { get; set; }
        public string CompanyId { get; set; }
        public string IncludeHsa { get; set; }

        public ICollection<Departments> Departments { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<WcClasses> WcClasses { get; set; }
        public ICollection<WcExpGroups> WcExpGroups { get; set; }
    }
}
