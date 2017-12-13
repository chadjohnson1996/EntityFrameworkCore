using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpTaxes
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string TaxAuthorityType { get; set; }
        public string TaxState { get; set; }
        public string LocalTaxNo { get; set; }
        public decimal? Exemptions { get; set; }
        public decimal? ExtraAmount { get; set; }
        public decimal? ExtraPercent { get; set; }
        public string WithCode { get; set; }
        public string AddFlag { get; set; }
        public string ResidFlag { get; set; }
        public int? LineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string LocalTaxId { get; set; }
        public string UseLocalMakeupTax { get; set; }

        public Employees Employees { get; set; }
    }
}
