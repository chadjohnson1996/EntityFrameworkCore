using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmMarkupCustomerH
    {
        public TmMarkupCustomerH()
        {
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
        }

        public int CompanyNo { get; set; }
        public string CustomerNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }

        public Customers C { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
    }
}
