using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentPageLabel
    {
        public int Id { get; set; }
        public int PageId { get; set; }
        public int LabelId { get; set; }

        public DocImgDocumentPage Page { get; set; }
    }
}
