using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BackupSet
    {
        public int Id { get; set; }
        public string BackupType { get; set; }
        public string Description { get; set; }
        public DateTime BackupDate { get; set; }
        public string BackupByUserNo { get; set; }
        public string PreviouslyRestored { get; set; }

        public TimeCardsBackupSet TimeCardsBackupSet { get; set; }
    }
}
