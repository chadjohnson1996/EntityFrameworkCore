using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserLytWindowSettings
    {
        public CompanyUserLytWindowSettings()
        {
            CompanyUserLytDatawindowSettings = new HashSet<CompanyUserLytDatawindowSettings>();
        }

        public int Id { get; set; }
        public int LayoutId { get; set; }
        public string WindowName { get; set; }
        public string LayoutName { get; set; }
        public string DefaultLayout { get; set; }

        public CompanyUserLytSettings Layout { get; set; }
        public ICollection<CompanyUserLytDatawindowSettings> CompanyUserLytDatawindowSettings { get; set; }
    }
}
