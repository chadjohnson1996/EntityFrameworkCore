using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserLytDatawindowSettings
    {
        public CompanyUserLytDatawindowSettings()
        {
            CompanyUserLytColumnSettings = new HashSet<CompanyUserLytColumnSettings>();
        }

        public int Id { get; set; }
        public int WindowId { get; set; }
        public string DatawindowName { get; set; }
        public string LayoutName { get; set; }
        public string DefaultLayout { get; set; }
        public string LockedColumnsOnLeft { get; set; }

        public CompanyUserLytWindowSettings Window { get; set; }
        public ICollection<CompanyUserLytColumnSettings> CompanyUserLytColumnSettings { get; set; }
    }
}
