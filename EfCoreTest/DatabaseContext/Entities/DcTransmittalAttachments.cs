using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcTransmittalAttachments
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcTransmittalNo { get; set; }
        public int LineNo { get; set; }
        public string AttachedDocTypeNo { get; set; }
        public string AttachedDcTransmittalNo { get; set; }
        public string AttachedDcRfpNo { get; set; }
        public string AttachedDcRfiNo { get; set; }
        public string AttachedDcRfcNo { get; set; }
        public string AttachedDcSubmittalNo { get; set; }
        public string AttachedDcMiscDocNo { get; set; }
        public string AttachedDcMeetingMinutesNo { get; set; }
        public string AttachedDcFieldLogNo { get; set; }
        public string AttachedDcPunchListNo { get; set; }
        public string AttachedMeetingTypeNo { get; set; }
        public string Purpose { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachedDcFieldLogId { get; set; }
        public string AttachedDcMeetingMinutesId { get; set; }
        public string AttachedDcMiscDocId { get; set; }
        public string AttachedDcPunchListId { get; set; }
        public string AttachedDcRfcId { get; set; }
        public string AttachedDcRfiId { get; set; }
        public string AttachedDcRfpId { get; set; }
        public string AttachedDcSubmittalId { get; set; }
        public string AttachedDcTransmittalId { get; set; }
        public string AttachedDocTypeId { get; set; }
        public string AttachedMeetingTypeId { get; set; }
        public string CompanyId { get; set; }
        public string DcTransmittalId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }

        public DcFieldLogs DcFieldLogs { get; set; }
        public DcMeetingMinutes DcMeetingMinutes { get; set; }
        public DcMiscDocs DcMiscDocs { get; set; }
        public DcPunchLists DcPunchLists { get; set; }
        public DcRfcs DcRfcs { get; set; }
        public DcRfis DcRfis { get; set; }
        public DcRfps DcRfps { get; set; }
        public DcSubmittals DcSubmittals { get; set; }
        public DcTransmittals DcTransmittals { get; set; }
        public DcTransmittals DcTransmittalsNavigation { get; set; }
        public DocTypes DocTypes { get; set; }
        public Jobs Jobs { get; set; }
    }
}
