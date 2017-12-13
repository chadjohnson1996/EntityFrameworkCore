using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoService
    {
        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string Description { get; set; }
        public int LineNo { get; set; }
        public string Comments { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqWoId { get; set; }
        public string LineId { get; set; }
        public string ServiceCodeId { get; set; }

        public EqServiceCodes EqServiceCodes { get; set; }
        public EqWo EqWo { get; set; }
    }
}
