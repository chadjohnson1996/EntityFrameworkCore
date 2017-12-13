using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CustomProgramGroups
    {
        public CustomProgramGroups()
        {
            CustomProgramItems = new HashSet<CustomProgramItems>();
        }

        public int InternalId { get; set; }
        public string Name { get; set; }

        public ICollection<CustomProgramItems> CustomProgramItems { get; set; }
    }
}
