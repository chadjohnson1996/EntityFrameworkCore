using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HighlightBuilder
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string WindowName { get; set; }
        public string DatawindowObject { get; set; }
        public int DatawindowX { get; set; }
        public int DatawindowY { get; set; }
        public int BuilderNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string FindString { get; set; }
        public string Findtext { get; set; }
        public string MatchCase { get; set; }
        public string WholeWordsOnly { get; set; }
        public string UseWildcards { get; set; }
        public string MatchPrefix { get; set; }
        public string MatchSuffix { get; set; }
        public string IgnorePunctuation { get; set; }
        public string IgnoreWhiteSpace { get; set; }
        public string ColumnsUser { get; set; }
        public string Columns { get; set; }
        public string ColumnsType { get; set; }
        public string ColorName { get; set; }
        public int? Background { get; set; }
        public int? TextColor { get; set; }
        public string Bold { get; set; }
        public string Italic { get; set; }
        public int DisplayOrder { get; set; }
        public string BuilderId { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
    }
}
