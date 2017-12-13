using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContacts
    {
        public CmContacts()
        {
            CmContactInsurance = new HashSet<CmContactInsurance>();
            CmContactLocations = new HashSet<CmContactLocations>();
            CmContactPersonLocations = new HashSet<CmContactPersonLocations>();
            CmContactPersons = new HashSet<CmContactPersons>();
            ControlPm = new HashSet<ControlPm>();
            DcFieldLogOnSiteContacts = new HashSet<DcFieldLogOnSiteContacts>();
            DcFieldLogTaskContacts = new HashSet<DcFieldLogTaskContacts>();
            DcJobContacts = new HashSet<DcJobContacts>();
            DcJobCorrespondencesFromCmContactNoNavigation = new HashSet<DcJobCorrespondences>();
            DcJobCorrespondencesToCmContactNoNavigation = new HashSet<DcJobCorrespondences>();
            DcMeetingMinutesAttendees = new HashSet<DcMeetingMinutesAttendees>();
            DcMeetingMinutesTopicContacts = new HashSet<DcMeetingMinutesTopicContacts>();
            DcMiscDocCorrespondencesFromCmContactNoNavigation = new HashSet<DcMiscDocCorrespondences>();
            DcMiscDocCorrespondencesToCmContactNoNavigation = new HashSet<DcMiscDocCorrespondences>();
            DcMiscDocRecipients = new HashSet<DcMiscDocRecipients>();
            DcMiscDocsFromCmContactNoNavigation = new HashSet<DcMiscDocs>();
            DcMiscDocsToCmContactNoNavigation = new HashSet<DcMiscDocs>();
            DcPunchListItems = new HashSet<DcPunchListItems>();
            DcRfcCorrespondencesFromCmContactNoNavigation = new HashSet<DcRfcCorrespondences>();
            DcRfcCorrespondencesToCmContactNoNavigation = new HashSet<DcRfcCorrespondences>();
            DcRfcRecipients = new HashSet<DcRfcRecipients>();
            DcRfcsFromCmContactNoNavigation = new HashSet<DcRfcs>();
            DcRfcsToCmContactNoNavigation = new HashSet<DcRfcs>();
            DcRfiCorrespondencesFromCmContactNoNavigation = new HashSet<DcRfiCorrespondences>();
            DcRfiCorrespondencesToCmContactNoNavigation = new HashSet<DcRfiCorrespondences>();
            DcRfiRecipients = new HashSet<DcRfiRecipients>();
            DcRfisFromCmContactNoNavigation = new HashSet<DcRfis>();
            DcRfisToCmContactNoNavigation = new HashSet<DcRfis>();
            DcRfpActivities = new HashSet<DcRfpActivities>();
            DcRfpActivityCorrespondencesFromCmContactNoNavigation = new HashSet<DcRfpActivityCorrespondences>();
            DcRfpActivityCorrespondencesToCmContactNoNavigation = new HashSet<DcRfpActivityCorrespondences>();
            DcRfpRecipients = new HashSet<DcRfpRecipients>();
            DcRfpsFromCmContactNoNavigation = new HashSet<DcRfps>();
            DcRfpsToCmContactNoNavigation = new HashSet<DcRfps>();
            DcSubmittalCorrespondencesFromCmContactNoNavigation = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalCorrespondencesToCmContactNoNavigation = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalRecipients = new HashSet<DcSubmittalRecipients>();
            DcSubmittalsFromCmContactNoNavigation = new HashSet<DcSubmittals>();
            DcSubmittalsFwdCmContactNoNavigation = new HashSet<DcSubmittals>();
            DcSubmittalsReturnedCmContactNoNavigation = new HashSet<DcSubmittals>();
            DcSubmittalsToCmContactNoNavigation = new HashSet<DcSubmittals>();
            DcTransmittalCorrespondencesFromCmContactNoNavigation = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittalCorrespondencesToCmContactNoNavigation = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittalRecipients = new HashSet<DcTransmittalRecipients>();
            DcTransmittalsFromCmContactNoNavigation = new HashSet<DcTransmittals>();
            DcTransmittalsToCmContactNoNavigation = new HashSet<DcTransmittals>();
            JobChgCorrespondencesFromCmContactNoNavigation = new HashSet<JobChgCorrespondences>();
            JobChgCorrespondencesToCmContactNoNavigation = new HashSet<JobChgCorrespondences>();
            PoSubCorrespondencesFromCmContactNoNavigation = new HashSet<PoSubCorrespondences>();
            PoSubCorrespondencesToCmContactNoNavigation = new HashSet<PoSubCorrespondences>();
        }

        public string CmContactNo { get; set; }
        public string CompanyName { get; set; }
        public string ContactTypeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string ContactTypeId { get; set; }

        public CmContactTypes ContactTypeNoNavigation { get; set; }
        public ICollection<CmContactInsurance> CmContactInsurance { get; set; }
        public ICollection<CmContactLocations> CmContactLocations { get; set; }
        public ICollection<CmContactPersonLocations> CmContactPersonLocations { get; set; }
        public ICollection<CmContactPersons> CmContactPersons { get; set; }
        public ICollection<ControlPm> ControlPm { get; set; }
        public ICollection<DcFieldLogOnSiteContacts> DcFieldLogOnSiteContacts { get; set; }
        public ICollection<DcFieldLogTaskContacts> DcFieldLogTaskContacts { get; set; }
        public ICollection<DcJobContacts> DcJobContacts { get; set; }
        public ICollection<DcJobCorrespondences> DcJobCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcJobCorrespondences> DcJobCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcMeetingMinutesAttendees> DcMeetingMinutesAttendees { get; set; }
        public ICollection<DcMeetingMinutesTopicContacts> DcMeetingMinutesTopicContacts { get; set; }
        public ICollection<DcMiscDocCorrespondences> DcMiscDocCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcMiscDocCorrespondences> DcMiscDocCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcMiscDocRecipients> DcMiscDocRecipients { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocsFromCmContactNoNavigation { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocsToCmContactNoNavigation { get; set; }
        public ICollection<DcPunchListItems> DcPunchListItems { get; set; }
        public ICollection<DcRfcCorrespondences> DcRfcCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfcCorrespondences> DcRfcCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcRfcRecipients> DcRfcRecipients { get; set; }
        public ICollection<DcRfcs> DcRfcsFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfcs> DcRfcsToCmContactNoNavigation { get; set; }
        public ICollection<DcRfiCorrespondences> DcRfiCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfiCorrespondences> DcRfiCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcRfiRecipients> DcRfiRecipients { get; set; }
        public ICollection<DcRfis> DcRfisFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfis> DcRfisToCmContactNoNavigation { get; set; }
        public ICollection<DcRfpActivities> DcRfpActivities { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcRfpRecipients> DcRfpRecipients { get; set; }
        public ICollection<DcRfps> DcRfpsFromCmContactNoNavigation { get; set; }
        public ICollection<DcRfps> DcRfpsToCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittalRecipients> DcSubmittalRecipients { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsFromCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsFwdCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsReturnedCmContactNoNavigation { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsToCmContactNoNavigation { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<DcTransmittalRecipients> DcTransmittalRecipients { get; set; }
        public ICollection<DcTransmittals> DcTransmittalsFromCmContactNoNavigation { get; set; }
        public ICollection<DcTransmittals> DcTransmittalsToCmContactNoNavigation { get; set; }
        public ICollection<JobChgCorrespondences> JobChgCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<JobChgCorrespondences> JobChgCorrespondencesToCmContactNoNavigation { get; set; }
        public ICollection<PoSubCorrespondences> PoSubCorrespondencesFromCmContactNoNavigation { get; set; }
        public ICollection<PoSubCorrespondences> PoSubCorrespondencesToCmContactNoNavigation { get; set; }
    }
}
