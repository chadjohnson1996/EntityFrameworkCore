using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SalesTaxesRates
    {
        public int CompanyNo { get; set; }
        public string TaxNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal StatePercent { get; set; }
        public decimal StateLimit { get; set; }
        public decimal LocalPercent { get; set; }
        public decimal LocalLimit { get; set; }
        public decimal OtherPercent { get; set; }
        public decimal OtherLimit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string TaxId { get; set; }
        public string Provider { get; set; }

        public SalesTaxes SalesTaxes { get; set; }
    }
}
