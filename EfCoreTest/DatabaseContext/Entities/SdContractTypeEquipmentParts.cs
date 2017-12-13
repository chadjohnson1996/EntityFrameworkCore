using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractTypeEquipmentParts
    {
        public int CompanyNo { get; set; }
        public int ContractTypeLineNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string PartNo { get; set; }
        public decimal? Quantity { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ContractType { get; set; }
        public string EquipmentUnique { get; set; }
        public string CompanyId { get; set; }
        public string ContractTypeLineId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string PartId { get; set; }
    }
}
