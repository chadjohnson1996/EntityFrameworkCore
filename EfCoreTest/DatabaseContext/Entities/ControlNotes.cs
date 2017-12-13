using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlNotes
    {
        public int CompanyNo { get; set; }
        public string ShowToDoList { get; set; }
        public string MaySendInvites { get; set; }
        public string WantReminders { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TicklersEnabled { get; set; }
        public string DeleteAnyUserNotes { get; set; }
        public string CompanyId { get; set; }
    }
}
