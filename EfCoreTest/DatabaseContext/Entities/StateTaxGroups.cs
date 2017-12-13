using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StateTaxGroups
    {
        public StateTaxGroups()
        {
            SalesTaxes = new HashSet<SalesTaxes>();
        }

        public int CompanyNo { get; set; }
        public string StateTaxGroupNo { get; set; }
        public string Description { get; set; }
        public decimal TaxBasePercent { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string StateTaxGroupId { get; set; }

        public ICollection<SalesTaxes> SalesTaxes { get; set; }
    }
}
