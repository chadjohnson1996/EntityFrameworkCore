using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserQuickLinks
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string LinkType { get; set; }
        public int LinkId { get; set; }
        public int OrdinalPosition { get; set; }
        public int CategoryId { get; set; }
        public string Criteria { get; set; }
        public int Id { get; set; }

        public CompanyUserQuickLinkCategories Category { get; set; }
        public CompanyUser CompanyUser { get; set; }
    }
}
