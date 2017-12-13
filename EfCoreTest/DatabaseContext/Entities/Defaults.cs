using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Defaults
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string WindowNameNo { get; set; }
        public string ColumnNameNo { get; set; }
        public string DefaultText { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DatawindowNameNo { get; set; }
        public string ColumnNameId { get; set; }
        public string CompanyId { get; set; }
        public string DatawindowNameId { get; set; }
        public string UserId { get; set; }
        public string WindowNameId { get; set; }
    }
}
