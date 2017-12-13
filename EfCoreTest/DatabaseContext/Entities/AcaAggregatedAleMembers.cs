using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaAggregatedAleMembers
    {
        public int CompanyNo { get; set; }
        public int AggregatedAleNum { get; set; }
        public string AggregatedAleName { get; set; }
        public string AggregatedAleFein { get; set; }
    }
}
