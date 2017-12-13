using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlAr
    {
        public string Company { get; set; }
        public string FutureRecurring { get; set; }
        public string FutureInvoiceDate { get; set; }
        public string SeparateSdArFlag { get; set; }
        public string NextCustomerFlag { get; set; }
        public int? DefaultInvoiceDesign { get; set; }
        public int? DefaultWoDesign { get; set; }
        public string CompletionDateFlag { get; set; }
        public string FlatRateDetailFlag { get; set; }
        public string DivSeq1 { get; set; }
        public string DivSeq2 { get; set; }
        public string DivSeq3 { get; set; }
        public string ForceJobDiv1 { get; set; }
        public string ForceJobDiv2 { get; set; }
        public string ForceJobDiv3 { get; set; }
        public string ForceJobDiv4 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string WoItemSequence1 { get; set; }
        public string WoItemSequence2 { get; set; }
        public string WoItemSequence3 { get; set; }
        public string ForceJobDiv { get; set; }
        public string CompanyId { get; set; }
        public int? DefaultTmDesign { get; set; }
        public string GenContractBillAutosave { get; set; }
        public string GenContractBillAutopost { get; set; }
        public string ContractCustomerFlag { get; set; }
        public string AllowNextDateEdit { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string TmWsDesignId { get; set; }
    }
}
