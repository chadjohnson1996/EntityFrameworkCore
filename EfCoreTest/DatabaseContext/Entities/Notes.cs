using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Notes
    {
        public int CompanyNo { get; set; }
        public string TableNameNo { get; set; }
        public string PrimaryKeyNo { get; set; }
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public DateTime? DateCreated { get; set; }
        public string ReadFlag { get; set; }
        public string PrivateFlag { get; set; }
        public string Text { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string PrimaryKeyId { get; set; }
        public string TableNameId { get; set; }
    }
}
