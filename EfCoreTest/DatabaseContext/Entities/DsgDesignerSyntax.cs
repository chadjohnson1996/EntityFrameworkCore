using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DsgDesignerSyntax
    {
        public int DesignNo { get; set; }
        public string DesignerNo { get; set; }
        public int SyntaxNo { get; set; }
        public int SegmentNo { get; set; }
        public string SegmentSyntax { get; set; }

        public DsgDesigners Design { get; set; }
    }
}
