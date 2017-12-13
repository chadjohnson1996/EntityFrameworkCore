using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FuelUsage
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime DateBooked { get; set; }
        public string DispenseFrom { get; set; }
        public string EquipmentNo { get; set; }
        public decimal Gallons { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string FuelTypeNo { get; set; }
        public decimal HoursMeter { get; set; }
        public decimal OdometerMeter { get; set; }
        public decimal OtherMeter { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string Comments { get; set; }
        public string Source { get; set; }
        public string PrevAllocateFlag { get; set; }
        public string FuelAllocateReversedFlag { get; set; }
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
        public int? FuelAllocateAuditNo { get; set; }
        public int? FuelAllocateRevAuditNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public DateTime? FuelAllocatePostDate { get; set; }
        public DateTime? FuelAllocateRevPostDate { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EquipmentId { get; set; }
        public string FuelAllocateAuditId { get; set; }
        public string FuelAllocateRevAuditId { get; set; }
        public string FuelTypeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TransactionId { get; set; }
        public string FuelEqCategoryNo { get; set; }
        public string FuelEqCategoryId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public Equipment Equipment { get; set; }
        public FuelTypes FuelTypes { get; set; }
        public Jobs Jobs { get; set; }
    }
}
