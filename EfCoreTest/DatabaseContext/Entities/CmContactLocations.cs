using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContactLocations
    {
        public CmContactLocations()
        {
            CmContactPersonLocations = new HashSet<CmContactPersonLocations>();
            DcJobContacts = new HashSet<DcJobContacts>();
        }

        public string CmContactNo { get; set; }
        public int LineNo { get; set; }
        public string LocationName { get; set; }
        public string LocationTypeNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public string Country { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public string EmailAddress { get; set; }
        public string WebAddress { get; set; }
        public string MainLocationFlag { get; set; }
        public string ActiveFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string LineId { get; set; }
        public string LocationTypeId { get; set; }
        public string ExtensionNum { get; set; }

        public CmContacts CmContactNoNavigation { get; set; }
        public CmLocationTypes LocationTypeNoNavigation { get; set; }
        public ICollection<CmContactPersonLocations> CmContactPersonLocations { get; set; }
        public ICollection<DcJobContacts> DcJobContacts { get; set; }
    }
}
