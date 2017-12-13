using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContactInsurance
    {
        public string CmContactNo { get; set; }
        public int LineNo { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNumber { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public decimal? InsuredAmt { get; set; }
        public string PolicyCarrier { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Received { get; set; }
        public string AlertUponExp { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string LineId { get; set; }

        public CmContacts CmContactNoNavigation { get; set; }
    }
}
