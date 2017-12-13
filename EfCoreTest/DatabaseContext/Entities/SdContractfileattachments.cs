using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractfileattachments
    {
        public int SequenceNumber { get; set; }
        public string Company { get; set; }
        public string ContractNumber { get; set; }
        public string FilePath { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public int? RenewalNo { get; set; }
        public string RenewalId { get; set; }
    }
}
