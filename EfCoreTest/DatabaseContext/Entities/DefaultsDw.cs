using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DefaultsDw
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string WindowName { get; set; }
        public string DatawindowName { get; set; }
        public string ColumnName { get; set; }
        public string OptionalKeyData { get; set; }
        public string DefaultText { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
    }
}
