using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgBatch
    {
        public DocImgBatch()
        {
            DocImgBatchAllowedFileTypeCategories = new HashSet<DocImgBatchAllowedFileTypeCategories>();
            DocImgBatchDeletedFiles = new HashSet<DocImgBatchDeletedFiles>();
            DocImgBatchRemainingFiles = new HashSet<DocImgBatchRemainingFiles>();
            DocImgBatchUsedFiles = new HashSet<DocImgBatchUsedFiles>();
        }

        public int Id { get; set; }
        public string UserNo { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public string SourceFolder { get; set; }
        public string Notes { get; set; }
        public int? CompanyNo { get; set; }

        public ICollection<DocImgBatchAllowedFileTypeCategories> DocImgBatchAllowedFileTypeCategories { get; set; }
        public ICollection<DocImgBatchDeletedFiles> DocImgBatchDeletedFiles { get; set; }
        public ICollection<DocImgBatchRemainingFiles> DocImgBatchRemainingFiles { get; set; }
        public ICollection<DocImgBatchUsedFiles> DocImgBatchUsedFiles { get; set; }
    }
}
