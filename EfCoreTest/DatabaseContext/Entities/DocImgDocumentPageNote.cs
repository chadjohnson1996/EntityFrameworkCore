using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentPageNote
    {
        public DocImgDocumentPageNote()
        {
            InverseParent = new HashSet<DocImgDocumentPageNote>();
        }

        public int Id { get; set; }
        public int PageId { get; set; }
        public int? ParentId { get; set; }
        public string Subject { get; set; }
        public string UserNo { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Message { get; set; }

        public DocImgDocumentPage Page { get; set; }
        public DocImgDocumentPageNote Parent { get; set; }
        public ICollection<DocImgDocumentPageNote> InverseParent { get; set; }
    }
}
