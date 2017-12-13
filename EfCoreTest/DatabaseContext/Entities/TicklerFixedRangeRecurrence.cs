using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerFixedRangeRecurrence
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public int Occurrences { get; set; }
        public int RemainingOccurrences { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
