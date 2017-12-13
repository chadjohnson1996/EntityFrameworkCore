using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerUserSettingsPredefinedFilter
    {
        public int Id { get; set; }
        public int SettingId { get; set; }
        public int FilterType { get; set; }

        public TicklerUserSettings Setting { get; set; }
    }
}
