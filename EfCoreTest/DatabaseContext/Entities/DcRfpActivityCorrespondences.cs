using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcRfpActivityCorrespondences
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcRfpNo { get; set; }
        public int ActLineNo { get; set; }
        public int LineNo { get; set; }
        public DateTime CorrDate { get; set; }
        public string FromCmContactNo { get; set; }
        public int? FromPersonLineNo { get; set; }
        public string ToCmContactNo { get; set; }
        public int? ToPersonLineNo { get; set; }
        public string Description { get; set; }
        public DateTime? RespondByDate { get; set; }
        public string DocStatusNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string OriginalRecipientList { get; set; }
        public string ActLineId { get; set; }
        public string CompanyId { get; set; }
        public string DcRfpId { get; set; }
        public string DocStatusId { get; set; }
        public string FromCmContactId { get; set; }
        public string FromPersonLineId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string ToCmContactId { get; set; }
        public string ToPersonLineId { get; set; }

        public DcRfpActivities DcRfpActivities { get; set; }
        public DcRfps DcRfps { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public CmContactPersons From { get; set; }
        public CmContacts FromCmContactNoNavigation { get; set; }
        public CmContactPersons To { get; set; }
        public CmContacts ToCmContactNoNavigation { get; set; }
    }
}
