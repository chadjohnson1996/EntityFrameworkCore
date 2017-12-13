using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBatchAllowedFileTypeCategories
    {
        public DocImgBatchAllowedFileTypeCategories()
        {
            DocImgBatchAllowedFileTypes = new HashSet<DocImgBatchAllowedFileTypes>();
        }

        public int Id { get; set; }
        public int BatchId { get; set; }
        public string ClassName { get; set; }
        public string InclusionRule { get; set; }

        public DocImgBatch Batch { get; set; }
        public ICollection<DocImgBatchAllowedFileTypes> DocImgBatchAllowedFileTypes { get; set; }
    }
}
