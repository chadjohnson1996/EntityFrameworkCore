using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgSessionSettings
    {
        public int Id { get; set; }
        public string UserNo { get; set; }
        public string CurrentBatchFolder { get; set; }
        public int? CurrentBatchNumber { get; set; }
    }
}
