using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdVersion
    {
        public decimal VersionNo { get; set; }
        public int BuildNo { get; set; }
        public int SchemaNo { get; set; }
        public int MajorRevision { get; set; }
        public int MinorRevision { get; set; }
        public string CdKey { get; set; }
        public string Merged { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BuildId { get; set; }
        public string SchemaId { get; set; }
        public string VersionId { get; set; }
    }
}
