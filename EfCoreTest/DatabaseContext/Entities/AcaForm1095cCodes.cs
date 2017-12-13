using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaForm1095cCodes
    {
        public string CodeNo { get; set; }
        public string Description { get; set; }
        public byte CodeLine { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CodeId { get; set; }
    }
}
