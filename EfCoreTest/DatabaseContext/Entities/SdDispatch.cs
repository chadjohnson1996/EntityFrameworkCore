using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatch
    {
        public SdDispatch()
        {
            SdDispatchDailyBoard = new HashSet<SdDispatchDailyBoard>();
            SdDispatchPositionBoard = new HashSet<SdDispatchPositionBoard>();
        }

        public string Company { get; set; }
        public int SequenceNumber { get; set; }
        public string DispatchNumber { get; set; }
        public DateTime? DateCalled { get; set; }
        public int? TimeCalled { get; set; }
        public int? ServiceCol { get; set; }
        public string WhoCalled { get; set; }
        public string VoicePhone { get; set; }
        public string WorkAddress { get; set; }
        public string WorkCity { get; set; }
        public string WorkRequested { get; set; }
        public int? TypeOfRepair { get; set; }
        public string SiteNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string ContractNumber { get; set; }
        public string JobNumber { get; set; }
        public string AssignedServicePerson { get; set; }
        public string Notes { get; set; }
        public string PurchaseOrder { get; set; }
        public string Warranty { get; set; }
        public string Billed { get; set; }
        public string Completed { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string DescriptionOfRepair { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public decimal? InvoiceSalestax { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public string SalesPerson { get; set; }
        public decimal? SalesCommission { get; set; }
        public string CheckNumber1 { get; set; }
        public string CheckNumber2 { get; set; }
        public string CheckNumber3 { get; set; }
        public string CheckNumber4 { get; set; }
        public DateTime? CheckDate1 { get; set; }
        public DateTime? CheckDate2 { get; set; }
        public DateTime? CheckDate3 { get; set; }
        public DateTime? CheckDate4 { get; set; }
        public decimal? CheckAmount1 { get; set; }
        public decimal? CheckAmount2 { get; set; }
        public decimal? CheckAmount3 { get; set; }
        public decimal? CheckAmount4 { get; set; }
        public DateTime? TimeOfCall { get; set; }
        public DateTime? DateOfArrival { get; set; }
        public DateTime? TimeOfArrival { get; set; }
        public DateTime? TimeOfDeparture { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public decimal? StraightHours { get; set; }
        public decimal? OvertimeHours { get; set; }
        public decimal? DoubleHours { get; set; }
        public string EnteredBy { get; set; }
        public string UniqueIdn { get; set; }
        public string PaymentType1 { get; set; }
        public string PaymentType2 { get; set; }
        public string PaymentType3 { get; set; }
        public string PaymentType4 { get; set; }
        public decimal? CellWidth { get; set; }
        public DateTime? DateOfCall { get; set; }
        public string Recurring { get; set; }
        public string OrigRecurringDispatch { get; set; }
        public int? RecurringOccurrence { get; set; }
        public string UserDefinedText { get; set; }
        public string MultipleTechs { get; set; }
        public string RecordStatus { get; set; }
        public int? WoDesign { get; set; }
        public string Printed { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public string PayrollComplete { get; set; }
        public int? Position { get; set; }
        public string PoStatus { get; set; }
        public string CompanyId { get; set; }
        public string QuoteNo { get; set; }
        public int? DefaultTmDesign { get; set; }
        public string QuoteId { get; set; }
        public string ShipToNo { get; set; }
        public string ShipToId { get; set; }
        public string StatusCodeNo { get; set; }
        public string LockContract { get; set; }
        public string StatusCodeId { get; set; }
        public int? ContractRenewalNo { get; set; }
        public string FollowupUnique { get; set; }
        public string PriorityCode { get; set; }
        public string WorkAddress2 { get; set; }
        public string WorkState { get; set; }
        public string WorkZipcode { get; set; }
        public DateTime? EstimatedDate { get; set; }
        public int? LeadTechSeq { get; set; }
        public string MobileStatus { get; set; }
        public int? ContractVisitEst { get; set; }
        public string ContractRenewalId { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string TmWsDesignId { get; set; }
        public string Converted { get; set; }

        public SdDispatchUnassigned SdDispatchUnassigned { get; set; }
        public ICollection<SdDispatchDailyBoard> SdDispatchDailyBoard { get; set; }
        public ICollection<SdDispatchPositionBoard> SdDispatchPositionBoard { get; set; }
    }
}
