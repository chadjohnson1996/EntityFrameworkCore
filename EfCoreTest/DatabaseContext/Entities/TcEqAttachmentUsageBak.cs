using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TcEqAttachmentUsageBak
    {
        public int BackupSetId { get; set; }
        public int BackupId { get; set; }
        public int CompanyNo { get; set; }
        public string TimecardType { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public int AttachmentLineNo { get; set; }
        public string AttachmentNo { get; set; }
        public decimal Units { get; set; }
        public string UnitType { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachmentLineId { get; set; }
        public string AttachmentId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public decimal OriginalUnits { get; set; }
    }
}
