using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ProjectManagers
    {
        public ProjectManagers()
        {
            CompanyUserProjMgr = new HashSet<CompanyUserProjMgr>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            Jobs = new HashSet<Jobs>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesProjectManagers = new HashSet<MiscDocActivities>();
            MiscDocActivitiesProjectManagers1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesProjectManagersNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsProjectManagers = new HashSet<MiscDocs>();
            MiscDocsProjectManagersNavigation = new HashSet<MiscDocs>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesProjectManagers = new HashSet<RfcActivities>();
            RfcActivitiesProjectManagers1 = new HashSet<RfcActivities>();
            RfcActivitiesProjectManagersNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsProjectManagers = new HashSet<Rfcs>();
            RfcsProjectManagersNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesProjectManagers = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesProjectManagers1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesProjectManagersNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisProjectManagers = new HashSet<Rfis>();
            RfisProjectManagersNavigation = new HashSet<Rfis>();
            RfpItemActivitiesProjectManagers = new HashSet<RfpItemActivities>();
            RfpItemActivitiesProjectManagers1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesProjectManagersNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsProjectManagers = new HashSet<Rfps>();
            RfpsProjectManagersNavigation = new HashSet<Rfps>();
            SubmittalItemActivitiesProjectManagers = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesProjectManagers1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesProjectManagersNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsProjectManagers = new HashSet<Submittals>();
            SubmittalsProjectManagersNavigation = new HashSet<Submittals>();
            TransmittalActivitiesProjectManagers = new HashSet<TransmittalActivities>();
            TransmittalActivitiesProjectManagers1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesProjectManagersNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsProjectManagers = new HashSet<Transmittals>();
            TransmittalsProjectManagersNavigation = new HashSet<Transmittals>();
        }

        public int CompanyNo { get; set; }
        public string ProjectManagerNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ProjectManagerId { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<CompanyUserProjMgr> CompanyUserProjMgr { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesProjectManagers { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesProjectManagers1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesProjectManagersNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsProjectManagers { get; set; }
        public ICollection<MiscDocs> MiscDocsProjectManagersNavigation { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesProjectManagers { get; set; }
        public ICollection<RfcActivities> RfcActivitiesProjectManagers1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesProjectManagersNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsProjectManagers { get; set; }
        public ICollection<Rfcs> RfcsProjectManagersNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesProjectManagers { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesProjectManagers1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesProjectManagersNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisProjectManagers { get; set; }
        public ICollection<Rfis> RfisProjectManagersNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesProjectManagers { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesProjectManagers1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesProjectManagersNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsProjectManagers { get; set; }
        public ICollection<Rfps> RfpsProjectManagersNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesProjectManagers { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesProjectManagers1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesProjectManagersNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsProjectManagers { get; set; }
        public ICollection<Submittals> SubmittalsProjectManagersNavigation { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesProjectManagers { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesProjectManagers1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesProjectManagersNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsProjectManagers { get; set; }
        public ICollection<Transmittals> TransmittalsProjectManagersNavigation { get; set; }
    }
}
