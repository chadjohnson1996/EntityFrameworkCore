using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUserReportGeneral
    {
        public int RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public int UniqueIdn { get; set; }
        public int? LevelNumber { get; set; }
        public string Level1Dwname { get; set; }
        public string Level2Dwname { get; set; }
        public string Level3Dwname { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title3 { get; set; }
        public string Level1Ref { get; set; }
        public string Level2Ref { get; set; }
        public string Level3Ref { get; set; }
        public string ReportName { get; set; }
        public int? UserVersion { get; set; }
        public int? InternalVersion { get; set; }
        public string RecordStatus { get; set; }
        public int? CompanyId { get; set; }
        public string UniqueIdnNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public string UniqueIdnId { get; set; }
    }
}
