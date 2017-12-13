using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContactPersons
    {
        public CmContactPersons()
        {
            CmContactPersonLocations = new HashSet<CmContactPersonLocations>();
            DcFieldLogOnSiteContacts = new HashSet<DcFieldLogOnSiteContacts>();
            DcFieldLogTaskContacts = new HashSet<DcFieldLogTaskContacts>();
            DcJobContacts = new HashSet<DcJobContacts>();
            DcJobCorrespondencesFrom = new HashSet<DcJobCorrespondences>();
            DcJobCorrespondencesTo = new HashSet<DcJobCorrespondences>();
            DcMeetingMinutesAttendees = new HashSet<DcMeetingMinutesAttendees>();
            DcMeetingMinutesTopicContacts = new HashSet<DcMeetingMinutesTopicContacts>();
            DcMiscDocCorrespondencesFrom = new HashSet<DcMiscDocCorrespondences>();
            DcMiscDocCorrespondencesTo = new HashSet<DcMiscDocCorrespondences>();
            DcMiscDocRecipients = new HashSet<DcMiscDocRecipients>();
            DcMiscDocsFrom = new HashSet<DcMiscDocs>();
            DcMiscDocsTo = new HashSet<DcMiscDocs>();
            DcPunchListItems = new HashSet<DcPunchListItems>();
            DcRfcCorrespondencesFrom = new HashSet<DcRfcCorrespondences>();
            DcRfcCorrespondencesTo = new HashSet<DcRfcCorrespondences>();
            DcRfcRecipients = new HashSet<DcRfcRecipients>();
            DcRfcsFrom = new HashSet<DcRfcs>();
            DcRfcsTo = new HashSet<DcRfcs>();
            DcRfiCorrespondencesFrom = new HashSet<DcRfiCorrespondences>();
            DcRfiCorrespondencesTo = new HashSet<DcRfiCorrespondences>();
            DcRfiRecipients = new HashSet<DcRfiRecipients>();
            DcRfisFrom = new HashSet<DcRfis>();
            DcRfisTo = new HashSet<DcRfis>();
            DcRfpActivities = new HashSet<DcRfpActivities>();
            DcRfpActivityCorrespondencesFrom = new HashSet<DcRfpActivityCorrespondences>();
            DcRfpActivityCorrespondencesTo = new HashSet<DcRfpActivityCorrespondences>();
            DcRfpRecipients = new HashSet<DcRfpRecipients>();
            DcRfpsFrom = new HashSet<DcRfps>();
            DcRfpsTo = new HashSet<DcRfps>();
            DcSubmittalCorrespondencesFrom = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalCorrespondencesTo = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalRecipients = new HashSet<DcSubmittalRecipients>();
            DcSubmittalsFrom = new HashSet<DcSubmittals>();
            DcSubmittalsFwd = new HashSet<DcSubmittals>();
            DcSubmittalsReturned = new HashSet<DcSubmittals>();
            DcSubmittalsTo = new HashSet<DcSubmittals>();
            DcTransmittalCorrespondencesFrom = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittalCorrespondencesTo = new HashSet<DcTransmittalCorrespondences>();
            DcTransmittalRecipients = new HashSet<DcTransmittalRecipients>();
            DcTransmittalsFrom = new HashSet<DcTransmittals>();
            DcTransmittalsTo = new HashSet<DcTransmittals>();
            JobChgCorrespondencesFrom = new HashSet<JobChgCorrespondences>();
            JobChgCorrespondencesTo = new HashSet<JobChgCorrespondences>();
            PoSubCorrespondencesFrom = new HashSet<PoSubCorrespondences>();
            PoSubCorrespondencesTo = new HashSet<PoSubCorrespondences>();
        }

        public string CmContactNo { get; set; }
        public int LineNo { get; set; }
        public string PersonTypeNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string PhoneVoice { get; set; }
        public string EmailAddress { get; set; }
        public string MainPersonFlag { get; set; }
        public string ActiveFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string LineId { get; set; }
        public string PersonTypeId { get; set; }
        public string PhoneCell { get; set; }
        public string ExtensionNum { get; set; }

        public CmContacts CmContactNoNavigation { get; set; }
        public CmPersonTypes PersonTypeNoNavigation { get; set; }
        public ICollection<CmContactPersonLocations> CmContactPersonLocations { get; set; }
        public ICollection<DcFieldLogOnSiteContacts> DcFieldLogOnSiteContacts { get; set; }
        public ICollection<DcFieldLogTaskContacts> DcFieldLogTaskContacts { get; set; }
        public ICollection<DcJobContacts> DcJobContacts { get; set; }
        public ICollection<DcJobCorrespondences> DcJobCorrespondencesFrom { get; set; }
        public ICollection<DcJobCorrespondences> DcJobCorrespondencesTo { get; set; }
        public ICollection<DcMeetingMinutesAttendees> DcMeetingMinutesAttendees { get; set; }
        public ICollection<DcMeetingMinutesTopicContacts> DcMeetingMinutesTopicContacts { get; set; }
        public ICollection<DcMiscDocCorrespondences> DcMiscDocCorrespondencesFrom { get; set; }
        public ICollection<DcMiscDocCorrespondences> DcMiscDocCorrespondencesTo { get; set; }
        public ICollection<DcMiscDocRecipients> DcMiscDocRecipients { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocsFrom { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocsTo { get; set; }
        public ICollection<DcPunchListItems> DcPunchListItems { get; set; }
        public ICollection<DcRfcCorrespondences> DcRfcCorrespondencesFrom { get; set; }
        public ICollection<DcRfcCorrespondences> DcRfcCorrespondencesTo { get; set; }
        public ICollection<DcRfcRecipients> DcRfcRecipients { get; set; }
        public ICollection<DcRfcs> DcRfcsFrom { get; set; }
        public ICollection<DcRfcs> DcRfcsTo { get; set; }
        public ICollection<DcRfiCorrespondences> DcRfiCorrespondencesFrom { get; set; }
        public ICollection<DcRfiCorrespondences> DcRfiCorrespondencesTo { get; set; }
        public ICollection<DcRfiRecipients> DcRfiRecipients { get; set; }
        public ICollection<DcRfis> DcRfisFrom { get; set; }
        public ICollection<DcRfis> DcRfisTo { get; set; }
        public ICollection<DcRfpActivities> DcRfpActivities { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondencesFrom { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondencesTo { get; set; }
        public ICollection<DcRfpRecipients> DcRfpRecipients { get; set; }
        public ICollection<DcRfps> DcRfpsFrom { get; set; }
        public ICollection<DcRfps> DcRfpsTo { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondencesFrom { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondencesTo { get; set; }
        public ICollection<DcSubmittalRecipients> DcSubmittalRecipients { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsFrom { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsFwd { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsReturned { get; set; }
        public ICollection<DcSubmittals> DcSubmittalsTo { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondencesFrom { get; set; }
        public ICollection<DcTransmittalCorrespondences> DcTransmittalCorrespondencesTo { get; set; }
        public ICollection<DcTransmittalRecipients> DcTransmittalRecipients { get; set; }
        public ICollection<DcTransmittals> DcTransmittalsFrom { get; set; }
        public ICollection<DcTransmittals> DcTransmittalsTo { get; set; }
        public ICollection<JobChgCorrespondences> JobChgCorrespondencesFrom { get; set; }
        public ICollection<JobChgCorrespondences> JobChgCorrespondencesTo { get; set; }
        public ICollection<PoSubCorrespondences> PoSubCorrespondencesFrom { get; set; }
        public ICollection<PoSubCorrespondences> PoSubCorrespondencesTo { get; set; }
    }
}
