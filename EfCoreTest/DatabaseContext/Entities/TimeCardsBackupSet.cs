using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimeCardsBackupSet
    {
        public int BackupSetId { get; set; }
        public int CompanyNo { get; set; }
        public string PayPeriodNo { get; set; }
        public DateTime PayPeriodStartDate { get; set; }
        public DateTime PayPeriodEndDate { get; set; }

        public BackupSet BackupSet { get; set; }
    }
}
