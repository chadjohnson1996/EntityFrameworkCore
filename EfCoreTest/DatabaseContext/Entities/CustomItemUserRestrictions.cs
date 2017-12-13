using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomItemUserRestrictions
    {
        public int CustomItemId { get; set; }
        public string UserNo { get; set; }

        public CustomItems CustomItem { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
