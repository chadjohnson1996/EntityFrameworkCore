using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentPageFilePart
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public Guid FsGuid { get; set; }
        public byte[] Data { get; set; }

        public DocImgDocumentPage Page { get; set; }
    }
}
