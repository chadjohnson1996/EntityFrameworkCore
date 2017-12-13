using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrCapsules
    {
        public RptwtrCapsules()
        {
            RptwtrCapsuleElements = new HashSet<RptwtrCapsuleElements>();
        }

        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public string CapsuleDataType { get; set; }
        public string Hint { get; set; }
        public int SequenceNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string SequenceId { get; set; }

        public ICollection<RptwtrCapsuleElements> RptwtrCapsuleElements { get; set; }
    }
}
