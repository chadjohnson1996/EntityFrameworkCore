using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqUsage
    {
        public EqUsage()
        {
            EqAttachmentUsage = new HashSet<EqAttachmentUsage>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string EquipmentNo { get; set; }
        public DateTime DateBooked { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string Source { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
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
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string ShiftNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TimecardType { get; set; }
        public int? TimecardTransactionNo { get; set; }
        public int? TimecardLineNo { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string ShiftId { get; set; }
        public string TimecardLineId { get; set; }
        public string TimecardTransactionId { get; set; }
        public string TransactionId { get; set; }
        public string TmGathered { get; set; }
        public string TmWorksheetNo { get; set; }
        public string TmMarkupCategory { get; set; }
        public int? TmMarkupLine { get; set; }
        public int? TmInvRowUniqueId { get; set; }
        public string TmWorksheetId { get; set; }
        public decimal BillingRate { get; set; }
        public string BillingRateSource { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string DeliveryTimeType { get; set; }
        public DateTime? DeliveryTimeMilitary { get; set; }
        public DateTime? EndTime { get; set; }
        public string EndTimeType { get; set; }
        public DateTime? EndTimeMilitary { get; set; }
        public int? TimecardXref { get; set; }
        public string TradeNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int? FieldLogEqLineNo { get; set; }
        public string PrevAllocateFlag { get; set; }
        public string FuelAllocateReversedFlag { get; set; }
        public int? FuelAllocateAuditNo { get; set; }
        public int? FuelAllocateRevAuditNo { get; set; }
        public DateTime? FuelAllocatePostDate { get; set; }
        public DateTime? FuelAllocateRevPostDate { get; set; }
        public string Reversal { get; set; }
        public int? OriginalEqUsageTransactionNo { get; set; }
        public string OriginalEqUsageTransactionId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public DcFieldLogEquipment DcFieldLogEquipment { get; set; }
        public Employees Employees { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
        public PayPeriods PayPeriods { get; set; }
        public Phases Phases { get; set; }
        public Shifts Shifts { get; set; }
        public ICollection<EqAttachmentUsage> EqAttachmentUsage { get; set; }
    }
}
