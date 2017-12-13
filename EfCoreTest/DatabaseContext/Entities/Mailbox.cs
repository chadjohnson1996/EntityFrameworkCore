using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Mailbox
    {
        public string UserNo { get; set; }
        public DateTime? DateMail { get; set; }
        public DateTime? TimeMail { get; set; }
        public string Sender { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public byte[] DataMail { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UserId { get; set; }
    }
}
