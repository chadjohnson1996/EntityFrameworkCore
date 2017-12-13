using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class NotePriorities
    {
        public NotePriorities()
        {
            StickyNotes = new HashSet<StickyNotes>();
        }

        public int CompanyNo { get; set; }
        public string NotePriorityNo { get; set; }
        public string Description { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string NotePriorityId { get; set; }

        public ICollection<StickyNotes> StickyNotes { get; set; }
    }
}
