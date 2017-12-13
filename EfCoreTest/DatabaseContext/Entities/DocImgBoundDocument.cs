using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBoundDocument
    {
        public DocImgBoundDocument()
        {
            DocImgBoundDocumentFilePart = new HashSet<DocImgBoundDocumentFilePart>();
            DocImgBoundDocumentThumbPart = new HashSet<DocImgBoundDocumentThumbPart>();
        }

        public int Id { get; set; }
        public string QualifiedSourceFileName { get; set; }
        public int SourceBatchId { get; set; }
        public int ThumbSize { get; set; }
        public int FileSize { get; set; }
        public string FileCheckSum { get; set; }
        public string ThumbCheckSum { get; set; }

        public DocImgDocument IdNavigation { get; set; }
        public ICollection<DocImgBoundDocumentFilePart> DocImgBoundDocumentFilePart { get; set; }
        public ICollection<DocImgBoundDocumentThumbPart> DocImgBoundDocumentThumbPart { get; set; }
    }
}
