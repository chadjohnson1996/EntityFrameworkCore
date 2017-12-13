using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomItems
    {
        public CustomItems()
        {
            CustomItemCompanyRestrictions = new HashSet<CustomItemCompanyRestrictions>();
            CustomItemCompanyUserRestrictions = new HashSet<CustomItemCompanyUserRestrictions>();
            CustomItemUserRestrictions = new HashSet<CustomItemUserRestrictions>();
        }

        public int InternalId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }

        public CustomDocumentItems CustomDocumentItems { get; set; }
        public CustomProgramItems CustomProgramItems { get; set; }
        public CustomReportItems CustomReportItems { get; set; }
        public ICollection<CustomItemCompanyRestrictions> CustomItemCompanyRestrictions { get; set; }
        public ICollection<CustomItemCompanyUserRestrictions> CustomItemCompanyUserRestrictions { get; set; }
        public ICollection<CustomItemUserRestrictions> CustomItemUserRestrictions { get; set; }
    }
}
