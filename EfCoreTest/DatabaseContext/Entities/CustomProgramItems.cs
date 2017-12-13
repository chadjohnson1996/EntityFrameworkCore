using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomProgramItems
    {
        public int CustomItemId { get; set; }
        public string Path { get; set; }
        public string Parameters { get; set; }
        public int GroupId { get; set; }

        public CustomItems CustomItem { get; set; }
        public CustomProgramGroups Group { get; set; }
    }
}
