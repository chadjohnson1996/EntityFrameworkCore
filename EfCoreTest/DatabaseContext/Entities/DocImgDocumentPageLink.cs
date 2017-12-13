using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentPageLink
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public string FoundationRecordType { get; set; }
        public int FoundationRowUniqueId { get; set; }

        public DocImgDocumentPage Page { get; set; }
    }
}
