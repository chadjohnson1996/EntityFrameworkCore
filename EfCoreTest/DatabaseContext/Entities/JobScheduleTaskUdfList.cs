using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleTaskUdfList
    {
        public int CompanyNo { get; set; }
        public string TaskUdfNo { get; set; }
        public string TaskName { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TaskUdfId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
    }
}
