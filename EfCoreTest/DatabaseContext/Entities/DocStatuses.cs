using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocStatuses
    {
        public DocStatuses()
        {
            DcMeetingMinutesTopics = new HashSet<DcMeetingMinutesTopics>();
            DcMiscDocs = new HashSet<DcMiscDocs>();
            DcPunchListItems = new HashSet<DcPunchListItems>();
            DcPunchLists = new HashSet<DcPunchLists>();
            DcRfis = new HashSet<DcRfis>();
            DcRfpActivities = new HashSet<DcRfpActivities>();
            DcRfpActivityCorrespondences = new HashSet<DcRfpActivityCorrespondences>();
            DcRfps = new HashSet<DcRfps>();
            DcSubmittalCorrespondences = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalItems = new HashSet<DcSubmittalItems>();
            DcSubmittalRevisions = new HashSet<DcSubmittalRevisions>();
            DcSubmittals = new HashSet<DcSubmittals>();
            DcTransmittals = new HashSet<DcTransmittals>();
            MiscDocs = new HashSet<MiscDocs>();
            PunchListItems = new HashSet<PunchListItems>();
            Rfcs = new HashSet<Rfcs>();
            RfiQuestions = new HashSet<RfiQuestions>();
            RfpItems = new HashSet<RfpItems>();
            SubmittalItems = new HashSet<SubmittalItems>();
        }

        public int CompanyNo { get; set; }
        public string DocStatusNo { get; set; }
        public string Description { get; set; }
        public string StatusType { get; set; }
        public string UsageNote { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocStatusId { get; set; }

        public ICollection<DcMeetingMinutesTopics> DcMeetingMinutesTopics { get; set; }
        public ICollection<DcMiscDocs> DcMiscDocs { get; set; }
        public ICollection<DcPunchListItems> DcPunchListItems { get; set; }
        public ICollection<DcPunchLists> DcPunchLists { get; set; }
        public ICollection<DcRfis> DcRfis { get; set; }
        public ICollection<DcRfpActivities> DcRfpActivities { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondences { get; set; }
        public ICollection<DcRfps> DcRfps { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondences { get; set; }
        public ICollection<DcSubmittalItems> DcSubmittalItems { get; set; }
        public ICollection<DcSubmittalRevisions> DcSubmittalRevisions { get; set; }
        public ICollection<DcSubmittals> DcSubmittals { get; set; }
        public ICollection<DcTransmittals> DcTransmittals { get; set; }
        public ICollection<MiscDocs> MiscDocs { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<Rfcs> Rfcs { get; set; }
        public ICollection<RfiQuestions> RfiQuestions { get; set; }
        public ICollection<RfpItems> RfpItems { get; set; }
        public ICollection<SubmittalItems> SubmittalItems { get; set; }
    }
}
