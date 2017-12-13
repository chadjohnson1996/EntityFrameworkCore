using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdEquipmentQuote
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string QuoteNo { get; set; }
        public string Note { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string QuoteId { get; set; }

        public SdEquipment SdEquipment { get; set; }
    }
}
