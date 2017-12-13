using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdEquipment
    {
        public SdEquipment()
        {
            SdEquipmentDispatch = new HashSet<SdEquipmentDispatch>();
            SdEquipmentParts = new HashSet<SdEquipmentParts>();
            SdEquipmentQuote = new HashSet<SdEquipmentQuote>();
        }

        public string Company { get; set; }
        public string SiteNumber { get; set; }
        public int SequenceNumber { get; set; }
        public string ContractNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public DateTime? InstalledDate { get; set; }
        public DateTime? WarrantyExpDate { get; set; }
        public DateTime? LastInspectedDate { get; set; }
        public DateTime? NextInspectionDate { get; set; }
        public string LocationOnSite { get; set; }
        public string AccessOnSite { get; set; }
        public string Notes { get; set; }
        public string DispatchNumber { get; set; }
        public decimal SalesAmount { get; set; }
        public string UniqueIdn { get; set; }
        public string InUse { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string QuoteNo { get; set; }
        public string QuoteId { get; set; }
        public decimal? ContractAmountCurrent { get; set; }
        public decimal? ContractAmountRenew { get; set; }
        public string EquipmentTypeNo { get; set; }
        public int? ContractRenewalNo { get; set; }
        public string EqUniqueIdType { get; set; }
        public string ContractRenewalId { get; set; }
        public string EquipmentTypeId { get; set; }

        public ICollection<SdEquipmentDispatch> SdEquipmentDispatch { get; set; }
        public ICollection<SdEquipmentParts> SdEquipmentParts { get; set; }
        public ICollection<SdEquipmentQuote> SdEquipmentQuote { get; set; }
    }
}
