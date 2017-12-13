using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MagW2
    {
        public int CompanyNo { get; set; }
        public string W2Type { get; set; }
        public int TaxYear { get; set; }
        public int EntryNo { get; set; }
        public string RecordType { get; set; }
        public int LineNo { get; set; }
        public string Record { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EntryId { get; set; }
        public string LineId { get; set; }
        public string StateFormat { get; set; }
        public string LocalFormat { get; set; }
        public string EmployeeNo { get; set; }
        public string Edata { get; set; }
        public string EmployeeId { get; set; }
    }
}
