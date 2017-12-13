using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimeCardsSavedState
    {
        public int CompanyNo { get; set; }
        public string LastEmployeeNo { get; set; }
        public string LastJobNo { get; set; }
    }
}
