using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PollTable
    {
        public int PollId { get; set; }
        public string TableName { get; set; }
        public string Activity { get; set; }
        public DateTime Period { get; set; }
        public int RowNo { get; set; }
        public int CompanyNo { get; set; }
    }
}
