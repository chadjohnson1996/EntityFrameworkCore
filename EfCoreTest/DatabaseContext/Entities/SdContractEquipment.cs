using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdContractEquipment
    {
        public int CompanyNo { get; set; }
        public string ContractNo { get; set; }
        public int ContractRenewalNo { get; set; }
        public string EquipmentNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? RenewalAmount { get; set; }
        public string CompanyId { get; set; }
        public string ContractId { get; set; }
        public string ContractRenewalId { get; set; }
        public string EquipmentId { get; set; }
    }
}
