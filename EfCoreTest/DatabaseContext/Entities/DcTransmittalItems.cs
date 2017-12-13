using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcTransmittalItems
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcTransmittalNo { get; set; }
        public int LineNo { get; set; }
        public int NbrCopies { get; set; }
        public DateTime ItemDate { get; set; }
        public string Description { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcTransmittalId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }

        public DcTransmittals DcTransmittals { get; set; }
    }
}
