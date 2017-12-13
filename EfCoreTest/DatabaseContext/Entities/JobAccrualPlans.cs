using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobAccrualPlans
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string AccrualNo { get; set; }
        public int PlanNo { get; set; }
        public string DisableFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccrualId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string PlanId { get; set; }

        public AccrualsD AccrualsD { get; set; }
        public AccrualsH AccrualsH { get; set; }
        public Jobs Jobs { get; set; }
    }
}
