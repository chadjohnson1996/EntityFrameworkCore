using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerUserSettings
    {
        public TicklerUserSettings()
        {
            TicklerUserSettingsColumns = new HashSet<TicklerUserSettingsColumns>();
            TicklerUserSettingsCustomFilter = new HashSet<TicklerUserSettingsCustomFilter>();
            TicklerUserSettingsPredefinedFilter = new HashSet<TicklerUserSettingsPredefinedFilter>();
        }

        public int Id { get; set; }
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }

        public Users UserNoNavigation { get; set; }
        public ICollection<TicklerUserSettingsColumns> TicklerUserSettingsColumns { get; set; }
        public ICollection<TicklerUserSettingsCustomFilter> TicklerUserSettingsCustomFilter { get; set; }
        public ICollection<TicklerUserSettingsPredefinedFilter> TicklerUserSettingsPredefinedFilter { get; set; }
    }
}
