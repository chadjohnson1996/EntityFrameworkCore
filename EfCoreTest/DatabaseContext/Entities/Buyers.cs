using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Buyers
    {
        public Buyers()
        {
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesBuyers = new HashSet<MiscDocActivities>();
            MiscDocActivitiesBuyers1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesBuyersNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsBuyers = new HashSet<MiscDocs>();
            MiscDocsBuyersNavigation = new HashSet<MiscDocs>();
            PoSubChangeH = new HashSet<PoSubChangeH>();
            PoSubH = new HashSet<PoSubH>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesBuyers = new HashSet<RfcActivities>();
            RfcActivitiesBuyers1 = new HashSet<RfcActivities>();
            RfcActivitiesBuyersNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsBuyers = new HashSet<Rfcs>();
            RfcsBuyersNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesBuyers = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesBuyers1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesBuyersNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisBuyers = new HashSet<Rfis>();
            RfisBuyersNavigation = new HashSet<Rfis>();
            RfpItemActivitiesBuyers = new HashSet<RfpItemActivities>();
            RfpItemActivitiesBuyers1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesBuyersNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsBuyers = new HashSet<Rfps>();
            RfpsBuyersNavigation = new HashSet<Rfps>();
            SubmittalItemActivitiesBuyers = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesBuyers1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesBuyersNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsBuyers = new HashSet<Submittals>();
            SubmittalsBuyersNavigation = new HashSet<Submittals>();
            TransmittalActivitiesBuyers = new HashSet<TransmittalActivities>();
            TransmittalActivitiesBuyers1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesBuyersNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsBuyers = new HashSet<Transmittals>();
            TransmittalsBuyersNavigation = new HashSet<Transmittals>();
        }

        public int CompanyNo { get; set; }
        public string BuyerNo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DefaultStatus { get; set; }
        public string BuyerId { get; set; }
        public string CompanyId { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesBuyers { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesBuyers1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesBuyersNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsBuyers { get; set; }
        public ICollection<MiscDocs> MiscDocsBuyersNavigation { get; set; }
        public ICollection<PoSubChangeH> PoSubChangeH { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesBuyers { get; set; }
        public ICollection<RfcActivities> RfcActivitiesBuyers1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesBuyersNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsBuyers { get; set; }
        public ICollection<Rfcs> RfcsBuyersNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesBuyers { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesBuyers1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesBuyersNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisBuyers { get; set; }
        public ICollection<Rfis> RfisBuyersNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesBuyers { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesBuyers1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesBuyersNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsBuyers { get; set; }
        public ICollection<Rfps> RfpsBuyersNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesBuyers { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesBuyers1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesBuyersNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsBuyers { get; set; }
        public ICollection<Submittals> SubmittalsBuyersNavigation { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesBuyers { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesBuyers1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesBuyersNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsBuyers { get; set; }
        public ICollection<Transmittals> TransmittalsBuyersNavigation { get; set; }
    }
}
