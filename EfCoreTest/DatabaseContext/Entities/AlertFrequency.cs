using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertFrequency
    {
        public int CompanyNo { get; set; }
        public int AlertNum { get; set; }
        public string RecurFrequency { get; set; }
        public string RecurSun { get; set; }
        public string RecurMon { get; set; }
        public string RecurTue { get; set; }
        public string RecurWed { get; set; }
        public string RecurThu { get; set; }
        public string RecurFri { get; set; }
        public string RecurSat { get; set; }
        public byte? RecurDayOfMonth { get; set; }
        public string RecurEndType { get; set; }
        public DateTime? RecurEndDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public Alerts Alerts { get; set; }
    }
}
