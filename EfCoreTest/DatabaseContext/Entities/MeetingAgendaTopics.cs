using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MeetingAgendaTopics
    {
        public int CompanyNo { get; set; }
        public string MeetingAgendaNo { get; set; }
        public int LineNo { get; set; }
        public string DocItemNo { get; set; }
        public string TopicType { get; set; }
        public string AttachedDocTypeNo { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string AttachedRfpNo { get; set; }
        public int? AttachedRfpItemLineNo { get; set; }
        public string AttachedRfiNo { get; set; }
        public int? AttachedRfiQuestionLineNo { get; set; }
        public string AttachedSubmittalNo { get; set; }
        public int? AttachedSubmittalItemLineNo { get; set; }
        public string AttachedMiscDocNo { get; set; }
        public string AttachedMeetingAgendaNo { get; set; }
        public string AttachedFieldLogNo { get; set; }
        public string AttachedPunchListNo { get; set; }
        public int? AttachedPunchListItemLineNo { get; set; }
        public string Description { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachedDocTypeId { get; set; }
        public string AttachedFieldLogId { get; set; }
        public string AttachedMeetingAgendaId { get; set; }
        public string AttachedMiscDocId { get; set; }
        public string AttachedPunchListItemLineId { get; set; }
        public string AttachedPunchListId { get; set; }
        public string AttachedRfiId { get; set; }
        public string AttachedRfiQuestionLineId { get; set; }
        public string AttachedRfpItemLineId { get; set; }
        public string AttachedRfpId { get; set; }
        public string AttachedSubmittalItemLineId { get; set; }
        public string AttachedSubmittalId { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string DocItemId { get; set; }
        public string LineId { get; set; }
        public string MeetingAgendaId { get; set; }
        public string AttachedRfcNo { get; set; }
        public string AttachedRfcId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public DocTypes DocTypes { get; set; }
        public FieldLogs FieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingAgendas MeetingAgendas { get; set; }
        public MeetingAgendas MeetingAgendasNavigation { get; set; }
        public MiscDocs MiscDocs { get; set; }
        public PunchListItems PunchListItems { get; set; }
        public PunchLists PunchLists { get; set; }
        public Rfcs Rfcs { get; set; }
        public RfiQuestions RfiQuestions { get; set; }
        public Rfis Rfis { get; set; }
        public RfpItems RfpItems { get; set; }
        public Rfps Rfps { get; set; }
        public SubmittalItems SubmittalItems { get; set; }
        public Submittals Submittals { get; set; }
        public Transmittals Transmittals { get; set; }
    }
}
