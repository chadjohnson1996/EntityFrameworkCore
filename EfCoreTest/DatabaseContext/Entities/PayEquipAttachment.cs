using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayEquipAttachment
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public string EquipmentNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string EquipmentUsageType { get; set; }
        public string TradeNo { get; set; }
        public int SequenceNo { get; set; }
        public int AttachmentLineNo { get; set; }
        public string CostClassNo { get; set; }
        public string AttachmentNo { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public decimal? GlExpenseBase { get; set; }
        public decimal? GlExpenseDivLevel1 { get; set; }
        public decimal? GlExpenseDivLevel2 { get; set; }
        public decimal? GlExpenseDivLevel3 { get; set; }
        public decimal? GlExpenseDivLevel4 { get; set; }
        public decimal? GlExpenseFull { get; set; }
        public decimal? GlCreditBase { get; set; }
        public decimal? GlCreditDivLevel1 { get; set; }
        public decimal? GlCreditDivLevel2 { get; set; }
        public decimal? GlCreditDivLevel3 { get; set; }
        public decimal? GlCreditDivLevel4 { get; set; }
        public decimal? GlCreditFull { get; set; }
        public string TimecardType { get; set; }
        public int? TransactionNo { get; set; }
        public int? LineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachmentLineId { get; set; }
        public string AttachmentId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string SequenceId { get; set; }
        public string TradeId { get; set; }
        public string TransactionId { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
    }
}
