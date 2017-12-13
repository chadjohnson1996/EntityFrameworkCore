using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RfcAttachments
    {
        public int CompanyNo { get; set; }
        public string RfcNo { get; set; }
        public int LineNo { get; set; }
        public string AttachedDocTypeNo { get; set; }
        public string AttachedTransmittalNo { get; set; }
        public string AttachedRfpNo { get; set; }
        public string AttachedRfiNo { get; set; }
        public string AttachedSubmittalNo { get; set; }
        public string AttachedMiscDocNo { get; set; }
        public string AttachedMeetingAgendaNo { get; set; }
        public string AttachedFieldLogNo { get; set; }
        public string AttachedPunchListNo { get; set; }
        public string AttachedRfcNo { get; set; }
        public string Purpose { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachedChgOrdNo { get; set; }
        public string AttachedChgOrdId { get; set; }
        public string AttachedDocTypeId { get; set; }
        public string AttachedFieldLogId { get; set; }
        public string AttachedMeetingAgendaId { get; set; }
        public string AttachedMiscDocId { get; set; }
        public string AttachedPunchListId { get; set; }
        public string AttachedRfcId { get; set; }
        public string AttachedRfiId { get; set; }
        public string AttachedRfpId { get; set; }
        public string AttachedSubmittalId { get; set; }
        public string AttachedTransmittalId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string RfcId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public DocTypes DocTypes { get; set; }
        public FieldLogs FieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingAgendas MeetingAgendas { get; set; }
        public MiscDocs MiscDocs { get; set; }
        public PunchLists PunchLists { get; set; }
        public Rfcs Rfcs { get; set; }
        public Rfcs RfcsNavigation { get; set; }
        public Rfis Rfis { get; set; }
        public Rfps Rfps { get; set; }
        public Submittals Submittals { get; set; }
        public Transmittals Transmittals { get; set; }
    }
}
