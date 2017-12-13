using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocActivities
    {
        public DocActivities()
        {
            DcPunchListItemActivities = new HashSet<DcPunchListItemActivities>();
            DcSubmittalItems = new HashSet<DcSubmittalItems>();
            MiscDocActivitiesDocActivities = new HashSet<MiscDocActivities>();
            MiscDocActivitiesDocActivitiesNavigation = new HashSet<MiscDocActivities>();
            PunchListItemActivities = new HashSet<PunchListItemActivities>();
            RfcActivitiesDocActivities = new HashSet<RfcActivities>();
            RfcActivitiesDocActivitiesNavigation = new HashSet<RfcActivities>();
            RfiQuestionActivitiesDocActivities = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesDocActivitiesNavigation = new HashSet<RfiQuestionActivities>();
            RfpItemActivitiesDocActivities = new HashSet<RfpItemActivities>();
            RfpItemActivitiesDocActivitiesNavigation = new HashSet<RfpItemActivities>();
            SubmittalItemActivitiesDocActivities = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesDocActivitiesNavigation = new HashSet<SubmittalItemActivities>();
            TransmittalActivitiesDocActivities = new HashSet<TransmittalActivities>();
            TransmittalActivitiesDocActivitiesNavigation = new HashSet<TransmittalActivities>();
        }

        public int CompanyNo { get; set; }
        public string DocActivityNo { get; set; }
        public string Description { get; set; }
        public string UsageNote { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocActivityId { get; set; }

        public ICollection<DcPunchListItemActivities> DcPunchListItemActivities { get; set; }
        public ICollection<DcSubmittalItems> DcSubmittalItems { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesDocActivities { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesDocActivitiesNavigation { get; set; }
        public ICollection<PunchListItemActivities> PunchListItemActivities { get; set; }
        public ICollection<RfcActivities> RfcActivitiesDocActivities { get; set; }
        public ICollection<RfcActivities> RfcActivitiesDocActivitiesNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesDocActivities { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesDocActivitiesNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesDocActivities { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesDocActivitiesNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesDocActivities { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesDocActivitiesNavigation { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesDocActivities { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesDocActivitiesNavigation { get; set; }
    }
}
