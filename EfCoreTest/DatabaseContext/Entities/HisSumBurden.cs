using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisSumBurden
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Year { get; set; }
        public int BurdenNo { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Earnings { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BurdenId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }

        public Employees Employees { get; set; }
    }
}
