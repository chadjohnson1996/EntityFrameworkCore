using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefsDocSearchCriteria
    {
        public RoutingUserPrefsDocSearchCriteria()
        {
            RoutingUserPrefs = new HashSet<RoutingUserPrefs>();
        }

        public int Id { get; set; }
        public int PrefsId { get; set; }
        public string Name { get; set; }
        public string Criteria { get; set; }
        public int Version { get; set; }
        public int CompanyNo { get; set; }

        public RoutingUserPrefs Prefs { get; set; }
        public ICollection<RoutingUserPrefs> RoutingUserPrefs { get; set; }
    }
}
