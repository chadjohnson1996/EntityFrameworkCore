using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcSubmittalRecipients
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SubmittalPackageNo { get; set; }
        public string DcSubmittalNo { get; set; }
        public int LineNo { get; set; }
        public string RecipientType { get; set; }
        public string RecipientCmContactNo { get; set; }
        public int? NbrCopies { get; set; }
        public string Notes { get; set; }
        public string SendType { get; set; }
        public string SendForwardFlag { get; set; }
        public int RecipientPersonLineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcSubmittalId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string RecipientCmContactId { get; set; }
        public string RecipientPersonLineId { get; set; }
        public string SubmittalPackageId { get; set; }

        public DcSubmittals DcSubmittals { get; set; }
        public CmContactPersons Recipient { get; set; }
        public CmContacts RecipientCmContactNoNavigation { get; set; }
    }
}
