using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EquipmentAttachments
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string AttachmentNo { get; set; }
        public string DefaultAttachment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttachmentId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }

        public EqAttachments EqAttachments { get; set; }
        public Equipment Equipment { get; set; }
    }
}
