using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserLytColumnSettings
    {
        public int Id { get; set; }
        public int DatawindowId { get; set; }
        public string ColumnName { get; set; }
        public string Locked { get; set; }
        public string Section { get; set; }
        public int ScrollingPosition { get; set; }
        public int LockedPosition { get; set; }

        public CompanyUserLytDatawindowSettings Datawindow { get; set; }
    }
}
