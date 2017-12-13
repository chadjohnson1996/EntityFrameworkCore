using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StorageTankWorksheetD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string PostedFlag { get; set; }
        public string StorageTankNo { get; set; }
        public decimal ComputerLevel { get; set; }
        public decimal ActualLevel { get; set; }
        public string PhysicalCountType { get; set; }
        public decimal? GlReconciliation { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string ZeroFlag { get; set; }
        public string CounterInitials { get; set; }
        public string Comments { get; set; }
        public decimal CostAdjustment { get; set; }
        public decimal UnitCost { get; set; }
        public decimal LevelAdjustment { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int LineNo { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }
        public string StorageTankId { get; set; }
        public string TransactionId { get; set; }

        public StorageTankWorksheetH StorageTankWorksheetH { get; set; }
        public StorageTanks StorageTanks { get; set; }
    }
}
