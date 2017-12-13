using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBoundDocumentFilePart
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public Guid FsGuid { get; set; }
        public byte[] Data { get; set; }

        public DocImgBoundDocument Document { get; set; }
    }
}
