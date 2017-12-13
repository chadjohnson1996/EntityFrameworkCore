using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractBilling
    {
        public int CompanyNo { get; set; }
        public string ContractNo { get; set; }
        public int ContractRenewalNo { get; set; }
        public int BillNo { get; set; }
        public DateTime? BillingDate { get; set; }
        public decimal? Amount { get; set; }
        public string InvoiceDescription { get; set; }
        public int? InvoiceDesignNo { get; set; }
        public string Invoiced { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string InvoiceNo { get; set; }
        public string BillId { get; set; }
        public string CompanyId { get; set; }
        public string ContractId { get; set; }
        public string ContractRenewalId { get; set; }
        public string InvoiceDesignId { get; set; }
        public string InvoiceId { get; set; }
    }
}
