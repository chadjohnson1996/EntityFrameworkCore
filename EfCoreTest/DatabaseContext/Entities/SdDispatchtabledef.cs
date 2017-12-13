using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchtabledef
    {
        public string Company { get; set; }
        public int SequenceNumber { get; set; }
        public string Bccorfoundation { get; set; }
        public string Tablename { get; set; }
        public string Varname { get; set; }
        public string Varinitvalue { get; set; }
        public string Varnameonlist { get; set; }
        public int? Varwidthonlist { get; set; }
        public int? Orderonthelist { get; set; }
        public string Varrequired { get; set; }
        public string Varwhere { get; set; }
        public string Varsort { get; set; }
        public string Vareditmask { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
    }
}
