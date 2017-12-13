using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Crews
    {
        public Crews()
        {
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string CrewNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CrewId { get; set; }

        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
