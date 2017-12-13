using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmInvoiceJc
    {
        public int CompanyNo { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }

        public CostCodes Co { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public TmInvoiceH TmInvoiceH { get; set; }
    }
}
