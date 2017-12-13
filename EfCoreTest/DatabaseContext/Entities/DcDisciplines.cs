using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcDisciplines
    {
        public DcDisciplines()
        {
            DcRfis = new HashSet<DcRfis>();
            DcSubmittals = new HashSet<DcSubmittals>();
        }

        public int CompanyNo { get; set; }
        public string DcDisciplineNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcDisciplineId { get; set; }

        public ICollection<DcRfis> DcRfis { get; set; }
        public ICollection<DcSubmittals> DcSubmittals { get; set; }
    }
}
