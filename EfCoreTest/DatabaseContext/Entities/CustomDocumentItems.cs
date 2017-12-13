using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomDocumentItems
    {
        public int CustomItemId { get; set; }
        public string Path { get; set; }
        public string Action { get; set; }
        public string DocType { get; set; }
        public int GroupId { get; set; }

        public CustomItems CustomItem { get; set; }
        public CustomDocumentGroups Group { get; set; }
    }
}
