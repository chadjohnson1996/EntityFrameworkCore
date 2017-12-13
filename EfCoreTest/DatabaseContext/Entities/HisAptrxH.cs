using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisAptrxH
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public string VendorNo { get; set; }
        public string JobSort { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? RetainagePercentage { get; set; }
        public decimal? RetainageAmount { get; set; }
        public string PoSub { get; set; }
        public DateTime? VoucherDate { get; set; }
        public decimal? DiscBase { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? DiscountAmount { get; set; }
        public string Co { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? TaxBase { get; set; }
        public string TaxAuthority { get; set; }
        public string InvoiceDescription { get; set; }
        public string VoucherType { get; set; }
        public string PayStatus { get; set; }
        public string PayClass { get; set; }
        public decimal? GlAp { get; set; }
        public decimal? GlRet { get; set; }
        public decimal? GlDiscount { get; set; }
        public decimal? GlTax { get; set; }
        public decimal? GlCash { get; set; }
        public string CheckNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? TaxPaid { get; set; }
        public decimal? CheckAmount { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string OrgiVoucherNo { get; set; }
        public DateTime? OrigVaoucherDate { get; set; }
        public decimal? NonDiscAmount { get; set; }
        public string BeforeAfter { get; set; }
        public decimal? AddTaxAuth { get; set; }
        public string AddTaxBase { get; set; }
        public decimal? AddTaxPaid { get; set; }
        public string SecureCheck { get; set; }
        public string PoType { get; set; }
        public string MatTicketing { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? NextLineNo { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string NextLineId { get; set; }
        public string OrgiVoucherId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
    }
}
