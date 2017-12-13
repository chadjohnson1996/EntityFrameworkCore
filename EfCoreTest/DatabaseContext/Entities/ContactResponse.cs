using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ContactResponse
    {
        public string ContactNo { get; set; }
        public string ResponseNo { get; set; }
        public int CompanyNo { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string ReferredBy { get; set; }
        public int LineNo { get; set; }
        public string CompanyId { get; set; }
        public string ContactId { get; set; }
        public string LineId { get; set; }
        public string ResponseId { get; set; }
    }
}
