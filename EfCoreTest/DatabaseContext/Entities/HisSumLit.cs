using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisSumLit
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Year { get; set; }
        public string State { get; set; }
        public string LocalTaxNo { get; set; }
        public decimal? Earnings { get; set; }
        public decimal? Ded { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LocalTaxId { get; set; }
        public decimal EarningsAddOn { get; set; }
        public decimal WithheldAddOn { get; set; }
        public decimal ReciprocityCredit { get; set; }

        public Employees Employees { get; set; }
    }
}
