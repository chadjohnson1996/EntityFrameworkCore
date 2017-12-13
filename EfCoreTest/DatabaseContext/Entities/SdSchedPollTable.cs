using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdSchedPollTable
    {
        public int PollId { get; set; }
        public string Activity { get; set; }
        public DateTime Period { get; set; }
        public int SequenceNo { get; set; }
        public int CompanyNo { get; set; }
    }
}
