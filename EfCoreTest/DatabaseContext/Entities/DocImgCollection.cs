using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgCollection
    {
        public DocImgCollection()
        {
            DocImgCollectionLink = new HashSet<DocImgCollectionLink>();
            DocImgDocument = new HashSet<DocImgDocument>();
        }

        public int Id { get; set; }
        public string FoundationRecordType { get; set; }
        public int? FoundationRowUniqueId { get; set; }

        public ICollection<DocImgCollectionLink> DocImgCollectionLink { get; set; }
        public ICollection<DocImgDocument> DocImgDocument { get; set; }
    }
}
