using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StorageTanks
    {
        public StorageTanks()
        {
            StorageTankWorksheetD = new HashSet<StorageTankWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string StorageTankNo { get; set; }
        public string Description { get; set; }
        public string FuelTypeNo { get; set; }
        public decimal Capacity { get; set; }
        public decimal? GlFuelExpense { get; set; }
        public decimal? GlReconciliation { get; set; }
        public string ReconJobNo { get; set; }
        public string ReconPhaseNo { get; set; }
        public string ReconCostCodeNo { get; set; }
        public string ReconCostClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FuelTypeId { get; set; }
        public string ReconCostClassId { get; set; }
        public string ReconCostCodeId { get; set; }
        public string ReconJobId { get; set; }
        public string ReconPhaseId { get; set; }
        public string StorageTankId { get; set; }
        public decimal? GlFuelAsset { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public CostClasses CostClasses { get; set; }
        public CostCodes CostCodes { get; set; }
        public FuelTypes FuelTypes { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public ICollection<StorageTankWorksheetD> StorageTankWorksheetD { get; set; }
    }
}
