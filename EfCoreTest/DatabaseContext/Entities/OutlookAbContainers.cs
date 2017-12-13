using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class OutlookAbContainers
    {
        public Guid Entryid { get; set; }
        public int Depth { get; set; }
        public string AbHierarchyPath { get; set; }
    }
}
