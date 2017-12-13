using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdPositionArchiveDispatch
    {
        public int CompanyNo { get; set; }
        public int TechnicianNo { get; set; }
        public string UniqueIdn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowAddedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TechnicianId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public SdTechnicians TechnicianNoNavigation { get; set; }
    }
}
