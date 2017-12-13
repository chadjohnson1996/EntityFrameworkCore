using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertEmailAssigned
    {
        public int CompanyNo { get; set; }
        public int AlertNum { get; set; }
        public int AssignedEmailNum { get; set; }
        public string EmailEntityType { get; set; }
        public string EmailEntityNo { get; set; }
        public int? EmailEntityLineNum { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmailEntityId { get; set; }

        public Alerts Alerts { get; set; }
    }
}
