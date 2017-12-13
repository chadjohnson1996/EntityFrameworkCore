using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdTechnicians
    {
        public SdTechnicians()
        {
            SdDispatchDailyBoard = new HashSet<SdDispatchDailyBoard>();
            SdDispatchPositionBoard = new HashSet<SdDispatchPositionBoard>();
            SdDispatchUnassigned = new HashSet<SdDispatchUnassigned>();
            SdPositionArchiveDispatch = new HashSet<SdPositionArchiveDispatch>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
        }

        public string Company { get; set; }
        public int SequenceNumber { get; set; }
        public string ServicePerson { get; set; }
        public string ServiceColumn { get; set; }
        public int? ServiceCol { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string VoicePhone { get; set; }
        public string FaxPhone { get; set; }
        public string MobilePagerPhone { get; set; }
        public decimal? BillingRate { get; set; }
        public decimal? Cost { get; set; }
        public string Mobilecarrier { get; set; }
        public string Hide { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<SdDispatchDailyBoard> SdDispatchDailyBoard { get; set; }
        public ICollection<SdDispatchPositionBoard> SdDispatchPositionBoard { get; set; }
        public ICollection<SdDispatchUnassigned> SdDispatchUnassigned { get; set; }
        public ICollection<SdPositionArchiveDispatch> SdPositionArchiveDispatch { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
    }
}
