using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArAreas
    {
        public ArAreas()
        {
            CustomerAreas = new HashSet<CustomerAreas>();
        }

        public int CompanyNo { get; set; }
        public string AreaNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AreaId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<CustomerAreas> CustomerAreas { get; set; }
    }
}
