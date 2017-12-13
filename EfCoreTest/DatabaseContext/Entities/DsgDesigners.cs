using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DsgDesigners
    {
        public DsgDesigners()
        {
            DsgDesignerObjects = new HashSet<DsgDesignerObjects>();
            DsgDesignerSequence = new HashSet<DsgDesignerSequence>();
            DsgDesignerSyntax = new HashSet<DsgDesignerSyntax>();
        }

        public int DesignNo { get; set; }
        public string DesignerNo { get; set; }
        public string PrintOrientation { get; set; }
        public int? PrintMarginLeft { get; set; }
        public int? PrintMarginRight { get; set; }
        public int? PrintMarginTop { get; set; }
        public int? PrintMarginBottom { get; set; }
        public int? PrintPaperSource { get; set; }
        public int? PrintPaperSize { get; set; }
        public int? Color { get; set; }

        public DsgDesigns DesignNoNavigation { get; set; }
        public ICollection<DsgDesignerObjects> DsgDesignerObjects { get; set; }
        public ICollection<DsgDesignerSequence> DsgDesignerSequence { get; set; }
        public ICollection<DsgDesignerSyntax> DsgDesignerSyntax { get; set; }
    }
}
