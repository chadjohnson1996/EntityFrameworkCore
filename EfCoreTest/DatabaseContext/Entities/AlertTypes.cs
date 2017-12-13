using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AlertTypes
    {
        public AlertTypes()
        {
            Alerts = new HashSet<Alerts>();
        }

        public int AlertTypeNum { get; set; }
        public int SortOrder { get; set; }
        public string AlertModule { get; set; }
        public string AlertDescription { get; set; }
        public string AlertIcon { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }

        public ICollection<Alerts> Alerts { get; set; }
    }
}
