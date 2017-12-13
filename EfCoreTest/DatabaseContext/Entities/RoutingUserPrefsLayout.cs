using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsLayout
    {
        public int Id { get; set; }
        public int PrefsId { get; set; }
        public string LayoutType { get; set; }
        public byte[] LayoutData { get; set; }

        public RoutingUserPrefs Prefs { get; set; }
    }
}
