using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertResults
    {
        public int CompanyNo { get; set; }
        public int AlertNum { get; set; }
        public int RowNum { get; set; }
        public string InvoiceNo { get; set; }
        public string FullInvoiceNo { get; set; }
        public DateTime? DueDate { get; set; }
        public string CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public decimal? Amount { get; set; }
        public string VoucherNo { get; set; }
        public string VendorNo { get; set; }
        public string VendorName { get; set; }
        public string ProjectManagerNo { get; set; }
        public string ProjectManagerDescription { get; set; }
        public string JobNo { get; set; }
        public string JobName { get; set; }
        public string DocTypeNo { get; set; }
        public string DocStatusNo { get; set; }
        public string DocumentNo { get; set; }
        public string ToCmContactNo { get; set; }
        public int? ToPersonLineNo { get; set; }
        public string FromCmContactNo { get; set; }
        public int? FromPersonLineNo { get; set; }
        public DateTime? RespondByDate { get; set; }
        public string CostChangeTypes { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string PhaseNo { get; set; }
        public decimal? ToDateCosts { get; set; }
        public decimal? EstimatedCosts { get; set; }
        public decimal? ChangeInCosts { get; set; }
        public decimal? ToDateUnits { get; set; }
        public decimal? EstimatedUnits { get; set; }
        public decimal? ChangeInUnits { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? RetainageAmount { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string CustomerId { get; set; }
        public string DocStatusId { get; set; }
        public string DocTypeId { get; set; }
        public string DocumentId { get; set; }
        public string FromCmContactId { get; set; }
        public string FromPersonLineId { get; set; }
        public string FullInvoiceId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string ProjectManagerId { get; set; }
        public string ToCmContactId { get; set; }
        public string ToPersonLineId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
    }
}
