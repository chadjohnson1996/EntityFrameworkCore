using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ResponseType
    {
        public string ResponseType1 { get; set; }
        public string Description { get; set; }
        public int CompanyNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string CompanyId { get; set; }
    }
}
