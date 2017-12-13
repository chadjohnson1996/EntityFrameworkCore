using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArBillingCycles
    {
        public ArBillingCycles()
        {
            Customers = new HashSet<Customers>();
        }

        public int CompanyNo { get; set; }
        public string ArBillingCycleNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ArBillingCycleId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<Customers> Customers { get; set; }
    }
}
