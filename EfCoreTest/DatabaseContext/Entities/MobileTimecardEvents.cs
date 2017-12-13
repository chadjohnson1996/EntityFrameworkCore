using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MobileTimecardEvents
    {
        public int RowUniqueId { get; set; }
        public int RecordId { get; set; }
        public string EventArea { get; set; }
        public string EventType { get; set; }
        public string EventNote { get; set; }
        public string ModifiedType { get; set; }
        public string ModifiedFrom { get; set; }
        public string ModifiedTo { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTimeOffset EventTime { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public string RowCreatedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
    }
}
