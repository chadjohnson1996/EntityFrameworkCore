using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TabOrderObjectOrder
    {
        public int Id { get; set; }
        public int TabOrderNo { get; set; }
        public string Name { get; set; }
        public string ParentName { get; set; }
        public string Path { get; set; }
        public string Tab { get; set; }
        public int SequenceId { get; set; }

        public TabOrderSequence Sequence { get; set; }
    }
}
