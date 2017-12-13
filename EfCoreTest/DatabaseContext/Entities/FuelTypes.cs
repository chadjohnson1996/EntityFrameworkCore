using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FuelTypes
    {
        public FuelTypes()
        {
            Equipment = new HashSet<Equipment>();
            FuelUsage = new HashSet<FuelUsage>();
            StorageTanks = new HashSet<StorageTanks>();
        }

        public int CompanyNo { get; set; }
        public string FuelTypeNo { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FuelTypeId { get; set; }
        public string UnitId { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
        public ICollection<FuelUsage> FuelUsage { get; set; }
        public ICollection<StorageTanks> StorageTanks { get; set; }
    }
}
