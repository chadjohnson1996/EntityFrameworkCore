using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StorageTankWorksheetH
    {
        public StorageTankWorksheetH()
        {
            StorageTankWorksheetD = new HashSet<StorageTankWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public DateTime PostDate { get; set; }
        public string WorksheetStatus { get; set; }
        public string DefaultInitials { get; set; }
        public DateTime AsOfDate { get; set; }
        public string StorageTankNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UnitCostDefault { get; set; }
        public string CalculateAverageFlag { get; set; }
        public decimal CalculateAverageMonths { get; set; }
        public DateTime? HisStartDate { get; set; }
        public string CompanyId { get; set; }
        public string StorageTankId { get; set; }
        public string TransactionId { get; set; }

        public ICollection<StorageTankWorksheetD> StorageTankWorksheetD { get; set; }
    }
}
