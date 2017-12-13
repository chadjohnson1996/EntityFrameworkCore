using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DsgDesignerSequence
    {
        public int DesignNo { get; set; }
        public string DesignerNo { get; set; }
        public string SequenceNo { get; set; }
        public string ObjectNo { get; set; }
        public int OrdinalPosition { get; set; }
        public string Flag1 { get; set; }
        public string ShowInGui { get; set; }

        public DsgDesigners Design { get; set; }
    }
}
