using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlSystemColor
    {
        public ControlSystemColor()
        {
            ControlSystem = new HashSet<ControlSystem>();
        }

        public int RowUniqueId { get; set; }
        public int ColorNo { get; set; }
        public string ColorName { get; set; }
        public long BackgroundRgb { get; set; }
        public long TextRgb { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public string ColorId { get; set; }

        public ICollection<ControlSystem> ControlSystem { get; set; }
    }
}
