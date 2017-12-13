using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserQuickLinkCategories
    {
        public CompanyUserQuickLinkCategories()
        {
            CompanyUser = new HashSet<CompanyUser>();
            CompanyUserQuickLinks = new HashSet<CompanyUserQuickLinks>();
        }

        public int Id { get; set; }
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string Description { get; set; }
        public string Wizard { get; set; }

        public CompanyUser CompanyUserNavigation { get; set; }
        public ICollection<CompanyUser> CompanyUser { get; set; }
        public ICollection<CompanyUserQuickLinks> CompanyUserQuickLinks { get; set; }
    }
}
