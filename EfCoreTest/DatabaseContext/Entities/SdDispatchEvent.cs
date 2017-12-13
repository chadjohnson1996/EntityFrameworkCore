using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchEvent
    {
        public int CompanyNo { get; set; }
        public int SequenceNumber { get; set; }
        public int EventSequenceNumber { get; set; }
        public string UniqueIdn { get; set; }
        public string EventType { get; set; }
        public string DispatchType { get; set; }
        public string ReferenceUniqueIdn { get; set; }
        public string ReferenceQuoteIdn { get; set; }
        public string PAssignedServicePerson { get; set; }
        public int? PServiceCol { get; set; }
        public int? PPosition { get; set; }
        public int? PTimeCalled { get; set; }
        public DateTime? PDateCalled { get; set; }
        public string PBoardtype { get; set; }
        public string CAssignedServicePerson { get; set; }
        public int? CServiceCol { get; set; }
        public int? CPosition { get; set; }
        public int? CTimeCalled { get; set; }
        public DateTime? CDateCalled { get; set; }
        public string PStatus { get; set; }
        public string CStatus { get; set; }
        public string BillpayInvoice { get; set; }
        public string BillpayType { get; set; }
        public decimal? BillpayAmount { get; set; }
        public DateTime? BillpayDate { get; set; }
        public decimal? PBillpayAmount { get; set; }
        public DateTime? PBillpayDate { get; set; }
        public string BillpayInfo1 { get; set; }
        public string MessageReciepent { get; set; }
        public string MessageWo { get; set; }
        public string AdditionalInfo { get; set; }
        public string Notes1 { get; set; }
        public string UserNo { get; set; }
        public string Source { get; set; }
        public string EventClass { get; set; }
        public int? EventClassNo { get; set; }
        public DateTime? DateTimeStamp { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? PBilltax { get; set; }
        public decimal? Billtax { get; set; }
        public string CompanyId { get; set; }
        public string EventClassId { get; set; }
        public string UserId { get; set; }
    }
}
