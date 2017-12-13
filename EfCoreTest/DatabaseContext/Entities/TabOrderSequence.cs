using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TabOrderSequence
    {
        public TabOrderSequence()
        {
            TabOrderObjectOrder = new HashSet<TabOrderObjectOrder>();
        }

        public int Id { get; set; }
        public int SequenceNo { get; set; }
        public string Cycle { get; set; }
        public int WindowId { get; set; }

        public TabOrderWindow Window { get; set; }
        public ICollection<TabOrderObjectOrder> TabOrderObjectOrder { get; set; }
    }
}
