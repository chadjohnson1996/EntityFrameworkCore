using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InterestedModule
    {
        public int? CompanyNo { get; set; }
        public string ModuleNo { get; set; }
        public string ContactNo { get; set; }
        public int ProposalNo { get; set; }
        public string ProContactNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string RecordStatus { get; set; }
        public string CompanyId { get; set; }
        public string ContactId { get; set; }
        public string ModuleId { get; set; }
        public string ProContactId { get; set; }
        public string ProposalId { get; set; }
    }
}
