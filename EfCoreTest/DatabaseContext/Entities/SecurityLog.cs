using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SecurityLog
    {
        public decimal LogNo { get; set; }
        public string Object { get; set; }
        public string Description { get; set; }
        public string UserNo { get; set; }
        public int? CompanyNo { get; set; }
        public string Function { get; set; }
        public DateTime? RowModifiedOn { get; set; }
    }
}
