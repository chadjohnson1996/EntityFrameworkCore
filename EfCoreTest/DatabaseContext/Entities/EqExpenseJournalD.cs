using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqExpenseJournalD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string EquipmentNo { get; set; }
        public DateTime? DateBooked { get; set; }
        public string ServiceCodeNo { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlDebitBase { get; set; }
        public decimal? GlDebitDivLevel1 { get; set; }
        public decimal? GlDebitDivLevel2 { get; set; }
        public decimal? GlDebitDivLevel3 { get; set; }
        public decimal? GlDebitDivLevel4 { get; set; }
        public decimal? GlDebitFull { get; set; }
        public decimal? GlCreditBase { get; set; }
        public decimal? GlCreditDivLevel1 { get; set; }
        public decimal? GlCreditDivLevel2 { get; set; }
        public decimal? GlCreditDivLevel3 { get; set; }
        public decimal? GlCreditDivLevel4 { get; set; }
        public decimal? GlCreditFull { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public int? VoucherNo { get; set; }
        public int? VoucherLineNo { get; set; }
        public string TimecardType { get; set; }
        public int? TimecardTransactionNo { get; set; }
        public int? TimecardLineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string ServiceCodeId { get; set; }
        public string TimecardLineId { get; set; }
        public string TimecardTransactionId { get; set; }
        public string TransactionId { get; set; }
        public string VoucherLineId { get; set; }
        public string VoucherId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public EqExpenseJournalH EqExpenseJournalH { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
    }
}
