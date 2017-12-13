using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUnassignedFilter
    {
        public int CompanyNo { get; set; }
        public string FilterNo { get; set; }
        public string ColumnName { get; set; }
        public string ColumnGroup { get; set; }
        public string ColumnValue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FilterId { get; set; }
    }
}
