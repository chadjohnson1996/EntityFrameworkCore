using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ImportFields
    {
        public string ImpDsgNo { get; set; }
        public string ColumnName { get; set; }
        public string FieldDwobject { get; set; }
        public string ColumnDefinition { get; set; }
        public string Required { get; set; }
        public string CostClassNoVisible { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ImpDsgId { get; set; }
        public int? ColumnSize { get; set; }
        public int? DecimalLength { get; set; }
        public string DecimalLengthVisible { get; set; }
        public string DecimalSizeTitleVisible { get; set; }
        public int SortSequence { get; set; }
        public string Category { get; set; }
    }
}
