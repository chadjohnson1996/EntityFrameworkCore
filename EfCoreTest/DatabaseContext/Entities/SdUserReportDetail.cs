using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUserReportDetail
    {
        public int RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public int UniqueIdn { get; set; }
        public int? LevelNumber { get; set; }
        public int? LevelMode { get; set; }
        public string Dwname { get; set; }
        public string ColumnName { get; set; }
        public int? ColumnV { get; set; }
        public int? ColumnX { get; set; }
        public int? ColumnY { get; set; }
        public int? ColumnW { get; set; }
        public int? ColumnH { get; set; }
        public int? ColumnAlign { get; set; }
        public int? ColumnSize { get; set; }
        public int? ColumnBold { get; set; }
        public int? ColumnItalic { get; set; }
        public int? ColumnId { get; set; }
        public string LabelText { get; set; }
        public string LabelBand { get; set; }
        public int? LabelV { get; set; }
        public int? LabelX { get; set; }
        public int? LabelY { get; set; }
        public int? LabelW { get; set; }
        public int? LabelH { get; set; }
        public int? LabelAlign { get; set; }
        public int? LabelSize { get; set; }
        public int? LabelBold { get; set; }
        public int? LabelItalic { get; set; }
        public int? TotalV { get; set; }
        public int? TotalX { get; set; }
        public int? TotalY { get; set; }
        public int? TotalW { get; set; }
        public int? TotalH { get; set; }
        public int? TotalAlign { get; set; }
        public int? TotalSize { get; set; }
        public int? TotalBold { get; set; }
        public int? TotalItalic { get; set; }
        public string TableReference { get; set; }
        public string ChildValue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public string CompanyId { get; set; }
    }
}
