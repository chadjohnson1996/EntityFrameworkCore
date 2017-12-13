using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgCollectionLink
    {
        public int Id { get; set; }
        public int CollectionId { get; set; }
        public string FoundationRecordType { get; set; }
        public int FoundationRowUniqueId { get; set; }

        public DocImgCollection Collection { get; set; }
    }
}
