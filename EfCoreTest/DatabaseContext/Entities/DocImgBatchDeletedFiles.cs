using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBatchDeletedFiles
    {
        public int Id { get; set; }
        public int BatchId { get; set; }
        public string Filename { get; set; }

        public DocImgBatch Batch { get; set; }
    }
}
