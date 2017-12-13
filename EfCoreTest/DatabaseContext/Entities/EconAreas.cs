using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EconAreas
    {
        public EconAreas()
        {
            EconAreaCounties = new HashSet<EconAreaCounties>();
        }

        public int CompanyNo { get; set; }
        public string EconomicAreaNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EconomicAreaId { get; set; }

        public ICollection<EconAreaCounties> EconAreaCounties { get; set; }
    }
}
