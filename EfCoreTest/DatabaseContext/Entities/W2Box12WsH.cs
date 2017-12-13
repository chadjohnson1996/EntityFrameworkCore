using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class W2Box12WsH
    {
        public W2Box12WsH()
        {
            W2Box12WsD = new HashSet<W2Box12WsD>();
        }

        public int CompanyNo { get; set; }
        public string W2Box12CodeNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string W2Box12CodeId { get; set; }

        public W2Box12Codes W2Box12CodeNoNavigation { get; set; }
        public ICollection<W2Box12WsD> W2Box12WsD { get; set; }
    }
}
