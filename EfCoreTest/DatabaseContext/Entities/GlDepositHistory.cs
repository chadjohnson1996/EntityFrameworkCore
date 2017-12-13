using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class GlDepositHistory
    {
        public int CompanyNo { get; set; }
        public decimal BasicAccountNo { get; set; }
        public decimal FullAccountNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public string GlType { get; set; }
        public int TransactionNo { get; set; }
        public string ModuleFrom { get; set; }
        public int SequenceNo { get; set; }
        public int? DepositNo { get; set; }
        public decimal TransactionAmount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string VendorNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Description { get; set; }
        public DateTime? DateBooked { get; set; }
        public string ArChk { get; set; }
        public string AdjustmentFlag { get; set; }
        public string ContFlag { get; set; }
        public decimal TotChk { get; set; }
        public string ApPrtChk { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? ReceiptAuditNumber { get; set; }
        public string BasicAccountId { get; set; }
        public string CompanyId { get; set; }
        public string DepositId { get; set; }
        public string EmployeeId { get; set; }
        public string FullAccountId { get; set; }
        public string SequenceId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }

        public Accounts Accounts { get; set; }
        public ArBankDeposit ArBankDeposit { get; set; }
    }
}
