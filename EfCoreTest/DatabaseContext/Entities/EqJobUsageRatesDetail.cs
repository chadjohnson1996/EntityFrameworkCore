using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqJobUsageRatesDetail
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string EquipmentNo { get; set; }
        public decimal? JobHourlyRate { get; set; }
        public decimal? JobDailyRate { get; set; }
        public decimal? JobWeeklyRate { get; set; }
        public decimal? JobMonthlyRate { get; set; }
        public decimal? JobIdleRate { get; set; }
        public decimal? JobIdleDown { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }

        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
    }
}
