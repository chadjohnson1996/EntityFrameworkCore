using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ContactPerson
    {
        public string ContactPersonNo { get; set; }
        public string ContactNo { get; set; }
        public int CompanyNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string TimeZoneNo { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public string Phone800 { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ContactId { get; set; }
        public string ContactPersonId { get; set; }
        public string TimeZoneId { get; set; }
    }
}
