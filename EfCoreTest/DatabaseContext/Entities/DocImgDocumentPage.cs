using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentPage
    {
        public DocImgDocumentPage()
        {
            DocImgDocumentPageFilePart = new HashSet<DocImgDocumentPageFilePart>();
            DocImgDocumentPageLabel = new HashSet<DocImgDocumentPageLabel>();
            DocImgDocumentPageLink = new HashSet<DocImgDocumentPageLink>();
            DocImgDocumentPageNote = new HashSet<DocImgDocumentPageNote>();
            DocImgDocumentPageThumbPart = new HashSet<DocImgDocumentPageThumbPart>();
        }

        public int Id { get; set; }
        public int DocumentId { get; set; }
        public string QualifiedSourceFileName { get; set; }
        public int SourceBatchId { get; set; }
        public DateTime DateAdded { get; set; }
        public int PageNumber { get; set; }
        public int ThumbSize { get; set; }
        public int FileSize { get; set; }
        public string Caption { get; set; }
        public string FileCheckSum { get; set; }
        public string ThumbCheckSum { get; set; }

        public DocImgDocument Document { get; set; }
        public ICollection<DocImgDocumentPageFilePart> DocImgDocumentPageFilePart { get; set; }
        public ICollection<DocImgDocumentPageLabel> DocImgDocumentPageLabel { get; set; }
        public ICollection<DocImgDocumentPageLink> DocImgDocumentPageLink { get; set; }
        public ICollection<DocImgDocumentPageNote> DocImgDocumentPageNote { get; set; }
        public ICollection<DocImgDocumentPageThumbPart> DocImgDocumentPageThumbPart { get; set; }
    }
}
