﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcRfpRecipients
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcRfpNo { get; set; }
        public int LineNo { get; set; }
        public string RecipientType { get; set; }
        public string RecipientCmContactNo { get; set; }
        public int RecipientPersonLineNo { get; set; }
        public int? NbrCopies { get; set; }
        public string Notes { get; set; }
        public string SendType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcRfpId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string RecipientCmContactId { get; set; }
        public string RecipientPersonLineId { get; set; }

        public DcRfps DcRfps { get; set; }
        public CmContactPersons Recipient { get; set; }
        public CmContacts RecipientCmContactNoNavigation { get; set; }
    }
}