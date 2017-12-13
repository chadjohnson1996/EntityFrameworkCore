using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomReportGroups
    {
        public CustomReportGroups()
        {
            CustomReportItems = new HashSet<CustomReportItems>();
        }

        public int InternalId { get; set; }
        public string Name { get; set; }

        public ICollection<CustomReportItems> CustomReportItems { get; set; }
    }
}
