using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlNotesUser
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string ShowToDoList { get; set; }
        public string MaySendInvites { get; set; }
        public string WantReminders { get; set; }
        public string DeleteAnyUserNotes { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
