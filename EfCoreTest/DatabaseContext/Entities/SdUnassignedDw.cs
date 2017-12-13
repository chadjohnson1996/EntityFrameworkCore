using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUnassignedDw
    {
        public int CompanyNo { get; set; }
        public string ViewNo { get; set; }
        public string UserNo { get; set; }
        public string ViewName { get; set; }
        public string MainSyntax { get; set; }
        public int MainSegment { get; set; }
        public string Locked { get; set; }
        public string LockedSyntax { get; set; }
        public int? LockedSegment { get; set; }
        public string FilterNo { get; set; }
        public string FilterValue { get; set; }
        public string SortValue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? Versions { get; set; }
        public string Sort1 { get; set; }
        public string Sort2 { get; set; }
        public string Sort3 { get; set; }
        public string SortDir1 { get; set; }
        public string SortDir2 { get; set; }
        public string SortDir3 { get; set; }
        public string CompanyId { get; set; }
        public string FilterId { get; set; }
        public string UserId { get; set; }
        public string ViewId { get; set; }
        public string DwType { get; set; }
    }
}
