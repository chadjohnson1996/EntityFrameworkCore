using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertSentHistory
    {
        public int CompanyNo { get; set; }
        public DateTime AlertSentDate { get; set; }
        public int AlertDateNumber { get; set; }
        public string AlertStatus { get; set; }
        public string AlertSentType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
    }
}
