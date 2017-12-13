using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimeCards
    {
        public TimeCards()
        {
            TcEqAttachmentUsage = new HashSet<TcEqAttachmentUsage>();
        }

        public int CompanyNo { get; set; }
        public string TimecardType { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public DateTime? Dated { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Amount { get; set; }
        public string EarnTypeNo { get; set; }
        public decimal PayRate { get; set; }
        public string TradeNo { get; set; }
        public string UnionNo { get; set; }
        public string TaxPrNo { get; set; }
        public string State { get; set; }
        public string CountyNo { get; set; }
        public string ShiftNo { get; set; }
        public string DeptNo { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlPayable { get; set; }
        public decimal? GlBurdenExpense { get; set; }
        public string EquipmentNo { get; set; }
        public decimal? EquipBillRate { get; set; }
        public string EquipOwnership { get; set; }
        public string EquipUsageType { get; set; }
        public string SutaState { get; set; }
        public string PayCode { get; set; }
        public decimal? GlEquipExpense { get; set; }
        public decimal? GlEquipCr { get; set; }
        public string CountyPrNo { get; set; }
        public string CostCodeCert { get; set; }
        public string AddEquip { get; set; }
        public string CrewNo { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }
        public string UserNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? DesignType { get; set; }
        public string EquipUnitType { get; set; }
        public decimal JcQuantity { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string CountyId { get; set; }
        public string CountyPrId { get; set; }
        public string CrewId { get; set; }
        public string DeptId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string PhaseId { get; set; }
        public string ShiftId { get; set; }
        public string TaxPrId { get; set; }
        public string TradeId { get; set; }
        public string TransactionId { get; set; }
        public string UnionId { get; set; }
        public string UserId { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string EqWoId { get; set; }
        public string ServiceCodeId { get; set; }
        public string Description { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string DeliveryTimeType { get; set; }
        public DateTime? DeliveryTimeMilitary { get; set; }
        public DateTime? EndTime { get; set; }
        public string EndTimeType { get; set; }
        public DateTime? EndTimeMilitary { get; set; }
        public string TmPrGathered { get; set; }
        public string TmPrWorksheetNo { get; set; }
        public string TmPrWorksheetId { get; set; }
        public string TmPrMarkupCategory { get; set; }
        public int? TmPrMarkupLine { get; set; }
        public int? TmPrInvRowUniqueId { get; set; }
        public string TmEqGathered { get; set; }
        public string TmEqWorksheetNo { get; set; }
        public string TmEqWorksheetId { get; set; }
        public string TmEqMarkupCategory { get; set; }
        public int? TmEqMarkupLine { get; set; }
        public int? TmEqInvRowUniqueId { get; set; }
        public string PaymentGroupNo { get; set; }
        public string CrewNoHdr { get; set; }
        public string PaymentGroupId { get; set; }
        public decimal RateDifference { get; set; }
        public int GroupRow { get; set; }
        public DateTime? OriginalPayPeriodStartDate { get; set; }
        public DateTime? OriginalPayPeriodEndDate { get; set; }
        public int? VoidTimecardXref { get; set; }
        public string Source { get; set; }
        public string TcRecurTypeNo { get; set; }
        public string TcRecurTypeId { get; set; }
        public string OtRateRounded { get; set; }
        public string UserChgRounded { get; set; }

        public Crews C { get; set; }
        public CostClasses Co { get; set; }
        public Counties Co1 { get; set; }
        public CostCodes CoNavigation { get; set; }
        public Departments Departments { get; set; }
        public TimecardTypes DesignTypeNavigation { get; set; }
        public Employees Employees { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public EqWo EqWo { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public Shifts Shifts { get; set; }
        public TaxGroups TaxGroups { get; set; }
        public TimecardPaymentGroup TimecardPaymentGroup { get; set; }
        public Trades Trades { get; set; }
        public Unions Unions { get; set; }
        public ICollection<TcEqAttachmentUsage> TcEqAttachmentUsage { get; set; }
    }
}
