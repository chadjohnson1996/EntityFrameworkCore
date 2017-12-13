using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MiscContacts
    {
        public MiscContacts()
        {
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesMiscContacts = new HashSet<MiscDocActivities>();
            MiscDocActivitiesMiscContacts1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesMiscContactsNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsMiscContacts = new HashSet<MiscDocs>();
            MiscDocsMiscContactsNavigation = new HashSet<MiscDocs>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesMiscContacts = new HashSet<RfcActivities>();
            RfcActivitiesMiscContacts1 = new HashSet<RfcActivities>();
            RfcActivitiesMiscContactsNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsMiscContacts = new HashSet<Rfcs>();
            RfcsMiscContactsNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesMiscContacts = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesMiscContacts1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesMiscContactsNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisMiscContacts = new HashSet<Rfis>();
            RfisMiscContactsNavigation = new HashSet<Rfis>();
            RfpItemActivitiesMiscContacts = new HashSet<RfpItemActivities>();
            RfpItemActivitiesMiscContacts1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesMiscContactsNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsMiscContacts = new HashSet<Rfps>();
            RfpsMiscContactsNavigation = new HashSet<Rfps>();
            SubmittalItemActivitiesMiscContacts = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesMiscContacts1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesMiscContactsNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsMiscContacts = new HashSet<Submittals>();
            SubmittalsMiscContactsNavigation = new HashSet<Submittals>();
            TransmittalActivitiesMiscContacts = new HashSet<TransmittalActivities>();
            TransmittalActivitiesMiscContacts1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesMiscContactsNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsMiscContacts = new HashSet<Transmittals>();
            TransmittalsMiscContactsNavigation = new HashSet<Transmittals>();
        }

        public int CompanyNo { get; set; }
        public string MiscContactNo { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Contact { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string EmailAddress { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MiscContactId { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceCustomerNo { get; set; }
        public string ReferenceVendorNo { get; set; }
        public string ReferenceCustomerId { get; set; }
        public string ReferenceVendorId { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public string Country { get; set; }

        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesMiscContacts { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesMiscContacts1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesMiscContactsNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsMiscContacts { get; set; }
        public ICollection<MiscDocs> MiscDocsMiscContactsNavigation { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesMiscContacts { get; set; }
        public ICollection<RfcActivities> RfcActivitiesMiscContacts1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesMiscContactsNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsMiscContacts { get; set; }
        public ICollection<Rfcs> RfcsMiscContactsNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesMiscContacts { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesMiscContacts1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesMiscContactsNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisMiscContacts { get; set; }
        public ICollection<Rfis> RfisMiscContactsNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesMiscContacts { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesMiscContacts1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesMiscContactsNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsMiscContacts { get; set; }
        public ICollection<Rfps> RfpsMiscContactsNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesMiscContacts { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesMiscContacts1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesMiscContactsNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsMiscContacts { get; set; }
        public ICollection<Submittals> SubmittalsMiscContactsNavigation { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesMiscContacts { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesMiscContacts1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesMiscContactsNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsMiscContacts { get; set; }
        public ICollection<Transmittals> TransmittalsMiscContactsNavigation { get; set; }
    }
}
