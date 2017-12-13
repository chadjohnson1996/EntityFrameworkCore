using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CostCodeGroups
    {
        public CostCodeGroups()
        {
            CostCodes = new HashSet<CostCodes>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
        }

        public int CompanyNo { get; set; }
        public string CostCodeGroupNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeGroupId { get; set; }

        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
    }
}
