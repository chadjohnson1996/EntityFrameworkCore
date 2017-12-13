using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerUserSettingsCustomFilter
    {
        public int Id { get; set; }
        public int SettingId { get; set; }
        public string ColumnName { get; set; }
        public string ColumnValue { get; set; }

        public TicklerUserSettings Setting { get; set; }
    }
}
