using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Ap1099ReportingClasses
    {
        public int CompanyNo { get; set; }
        public string ReportingClassNo { get; set; }
        public string Description { get; set; }
        public string Form1099 { get; set; }
        public string BoxOn1099 { get; set; }
        public string CompanyId { get; set; }
        public string ReportingClassId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
    }
}
