using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MenuItems
    {
        public int InternalId { get; set; }
        public string ItemType { get; set; }
        public string FullMenuPath { get; set; }
    }
}
