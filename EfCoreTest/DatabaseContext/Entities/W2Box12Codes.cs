using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class W2Box12Codes
    {
        public W2Box12Codes()
        {
            W2Box12WsH = new HashSet<W2Box12WsH>();
        }

        public string W2Box12CodeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string W2Box12CodeId { get; set; }

        public ICollection<W2Box12WsH> W2Box12WsH { get; set; }
    }
}
