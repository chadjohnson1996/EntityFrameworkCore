using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrCapsuleElements
    {
        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public string Element { get; set; }
        public string ElementDataType { get; set; }
        public string ElementInitialValue { get; set; }
        public string ElementDomain { get; set; }
        public string ElementTags { get; set; }
        public string ElementExtra { get; set; }
        public string UiType { get; set; }
        public int UiX { get; set; }
        public int UiY { get; set; }
        public int UiZ { get; set; }
        public int UiWidth { get; set; }
        public int UiHeight { get; set; }
        public string UiFilename { get; set; }
        public string UiBorder { get; set; }
        public int UiForeground { get; set; }
        public int UiBackground { get; set; }
        public string UiAlignment { get; set; }
        public string UiCursor { get; set; }
        public int UiTabSequence { get; set; }
        public string UiVisible { get; set; }
        public int? UiXExp { get; set; }
        public int? UiYExp { get; set; }
        public int? UiWidthExp { get; set; }
        public int? UiHeightExp { get; set; }
        public string UiExpandedElement { get; set; }
        public string UiFormat { get; set; }
        public string UiMask { get; set; }
        public string UiExpressions { get; set; }
        public string UiDddwObject { get; set; }
        public string UiDddwDisplayCol { get; set; }
        public string UiDddwDataCol { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }

        public RptwtrCapsules Ca { get; set; }
    }
}
