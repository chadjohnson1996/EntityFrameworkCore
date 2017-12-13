using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobAddCosts
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string CostClassNo { get; set; }
        public decimal Costs { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string JobId { get; set; }

        public JobAddAmounts JobAddAmounts { get; set; }
    }
}
