using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class OutlookDlistMembers
    {
        public int Id { get; set; }
        public Guid Entryid { get; set; }
        public Guid MemberEntryid { get; set; }
        public int EmailId { get; set; }
    }
}
