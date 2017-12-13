using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class InventoryMatRecH
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string DistributeTo { get; set; }
        public string JobNo { get; set; }
        public string WarehouseNo { get; set; }
        public string PrintStatus { get; set; }
        public DateTime TransferDate { get; set; }
        public DateTime? AsOfDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartItemNo { get; set; }
        public string EndItemNo { get; set; }
        public string StartVendorNo { get; set; }
        public string EndVendorNo { get; set; }
        public string StartJobNo { get; set; }
        public string EndJobNo { get; set; }
        public string StartWarehouseNo { get; set; }
        public string EndWarehouseNo { get; set; }
        public string StartPhaseNo { get; set; }
        public string EndPhaseNo { get; set; }
        public string StartCostCodeNo { get; set; }
        public string EndCostCodeNo { get; set; }
        public string SortOrder1 { get; set; }
        public string SortOrder2 { get; set; }
        public string SortOrder3 { get; set; }
        public string MatrecStatus { get; set; }
        public string DefaultInitials { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string SourceUs { get; set; }
        public string SourceEq { get; set; }
        public string SourceAr { get; set; }
        public string SourceAp { get; set; }
        public string SourceRc { get; set; }
        public string SourceJu { get; set; }
        public string SourcePh { get; set; }
        public string SourceMr { get; set; }
        public string CompanyId { get; set; }
        public string EndCostCodeId { get; set; }
        public string EndItemId { get; set; }
        public string EndJobId { get; set; }
        public string EndPhaseId { get; set; }
        public string EndVendorId { get; set; }
        public string EndWarehouseId { get; set; }
        public string JobId { get; set; }
        public string StartCostCodeId { get; set; }
        public string StartItemId { get; set; }
        public string StartJobId { get; set; }
        public string StartPhaseId { get; set; }
        public string StartVendorId { get; set; }
        public string StartWarehouseId { get; set; }
        public string TransactionId { get; set; }
        public string WarehouseId { get; set; }

        public Jobs Jobs { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}
