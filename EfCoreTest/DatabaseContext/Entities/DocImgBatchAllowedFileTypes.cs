using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBatchAllowedFileTypes
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Extension { get; set; }

        public DocImgBatchAllowedFileTypeCategories Category { get; set; }
    }
}
