using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobAreasD
    {
        public JobAreasD()
        {
            DcPunchLists = new HashSet<DcPunchLists>();
            PunchLists = new HashSet<PunchLists>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public int LineNo { get; set; }
        public string JobAreaNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobAreaId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }

        public JobAreasH JobAreasH { get; set; }
        public ICollection<DcPunchLists> DcPunchLists { get; set; }
        public ICollection<PunchLists> PunchLists { get; set; }
    }
}
