using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomDocumentGroups
    {
        public CustomDocumentGroups()
        {
            CustomDocumentItems = new HashSet<CustomDocumentItems>();
        }

        public int InternalId { get; set; }
        public string Name { get; set; }

        public ICollection<CustomDocumentItems> CustomDocumentItems { get; set; }
    }
}
