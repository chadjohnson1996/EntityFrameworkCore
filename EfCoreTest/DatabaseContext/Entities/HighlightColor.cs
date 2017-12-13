using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HighlightColor
    {
        public string ColorName { get; set; }
        public int? Background { get; set; }
        public int? TextColor { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
