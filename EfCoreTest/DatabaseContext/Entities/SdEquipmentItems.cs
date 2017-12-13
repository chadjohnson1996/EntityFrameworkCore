using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdEquipmentItems
    {
        public int CompanyNo { get; set; }
        public string EquipmentItemNo { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal? SalesAmount { get; set; }
        public int? WarrantyLength { get; set; }
        public string WarrantyUnits { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? RenewalAmount { get; set; }
        public string Notes { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Protect { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentItemId { get; set; }
    }
}
