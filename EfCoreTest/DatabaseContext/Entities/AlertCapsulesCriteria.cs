using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertCapsulesCriteria
    {
        public int CompanyNo { get; set; }
        public int AlertNum { get; set; }
        public int CapsuleNum { get; set; }
        public int ElementNum { get; set; }
        public string Element { get; set; }
        public string ElementType { get; set; }
        public string ElementValue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public Alerts Alerts { get; set; }
    }
}
