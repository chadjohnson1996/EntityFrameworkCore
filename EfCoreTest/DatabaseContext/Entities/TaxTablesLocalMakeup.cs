using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxTablesLocalMakeup
    {
        public int CompanyNo { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public string TaxTableType { get; set; }
        public string SelectedTaxState { get; set; }
        public string SelectedLocalTaxNo { get; set; }
        public string SelectedTaxTableType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LocalTaxId { get; set; }
        public string SelectedLocalTaxId { get; set; }

        public TaxTables TaxTables { get; set; }
    }
}
