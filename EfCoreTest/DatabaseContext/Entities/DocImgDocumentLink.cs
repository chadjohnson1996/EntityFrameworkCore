using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentLink
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string FoundationRecordType { get; set; }
        public int FoundationRowUniqueId { get; set; }

        public DocImgDocument Document { get; set; }
    }
}
