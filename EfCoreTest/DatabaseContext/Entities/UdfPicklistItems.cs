using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UdfPicklistItems
    {
        public int TableNumber { get; set; }
        public decimal NewColSeq { get; set; }
        public string ItemValue { get; set; }
        public int OrdinalPosition { get; set; }

        public UdfNewColMap UdfNewColMap { get; set; }
    }
}
