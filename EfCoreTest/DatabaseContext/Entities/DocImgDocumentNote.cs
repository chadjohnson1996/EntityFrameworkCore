using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentNote
    {
        public DocImgDocumentNote()
        {
            InverseParent = new HashSet<DocImgDocumentNote>();
        }

        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int? ParentId { get; set; }
        public string Subject { get; set; }
        public string UserNo { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Message { get; set; }

        public DocImgDocument Document { get; set; }
        public DocImgDocumentNote Parent { get; set; }
        public ICollection<DocImgDocumentNote> InverseParent { get; set; }
    }
}
