using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgDocumentLabel
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int LabelId { get; set; }

        public DocImgDocument Document { get; set; }
    }
}
