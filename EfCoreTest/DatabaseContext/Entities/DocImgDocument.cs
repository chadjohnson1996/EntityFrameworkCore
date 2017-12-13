using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocument
    {
        public DocImgDocument()
        {
            DocImgDocumentLabel = new HashSet<DocImgDocumentLabel>();
            DocImgDocumentLink = new HashSet<DocImgDocumentLink>();
            DocImgDocumentNote = new HashSet<DocImgDocumentNote>();
            DocImgDocumentPage = new HashSet<DocImgDocumentPage>();
        }

        public int Id { get; set; }
        public int CollectionId { get; set; }
        public string Caption { get; set; }
        public DateTime DateCreated { get; set; }
        public int DocumentPosition { get; set; }

        public DocImgCollection Collection { get; set; }
        public DocImgBoundDocument DocImgBoundDocument { get; set; }
        public ICollection<DocImgDocumentLabel> DocImgDocumentLabel { get; set; }
        public ICollection<DocImgDocumentLink> DocImgDocumentLink { get; set; }
        public ICollection<DocImgDocumentNote> DocImgDocumentNote { get; set; }
        public ICollection<DocImgDocumentPage> DocImgDocumentPage { get; set; }
    }
}
