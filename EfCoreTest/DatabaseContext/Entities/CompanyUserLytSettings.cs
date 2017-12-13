using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserLytSettings
    {
        public CompanyUserLytSettings()
        {
            CompanyUserLytWindowSettings = new HashSet<CompanyUserLytWindowSettings>();
        }

        public int Id { get; set; }
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }

        public CompanyUser CompanyUser { get; set; }
        public ICollection<CompanyUserLytWindowSettings> CompanyUserLytWindowSettings { get; set; }
    }
}
