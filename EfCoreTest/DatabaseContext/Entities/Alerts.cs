using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Alerts
    {
        public Alerts()
        {
            AlertCapsules = new HashSet<AlertCapsules>();
            AlertCapsulesCriteria = new HashSet<AlertCapsulesCriteria>();
            AlertEmailAssigned = new HashSet<AlertEmailAssigned>();
        }

        public int CompanyNo { get; set; }
        public int AlertNum { get; set; }
        public int AlertTypeNum { get; set; }
        public string AlertName { get; set; }
        public string AlertText { get; set; }
        public string GroupAlert { get; set; }
        public string SendTestEmail { get; set; }
        public string DisabledFlag { get; set; }
        public string SuppressEmailFlag { get; set; }
        public DateTime? NextSendDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public AlertTypes AlertTypeNumNavigation { get; set; }
        public AlertFrequency AlertFrequency { get; set; }
        public ICollection<AlertCapsules> AlertCapsules { get; set; }
        public ICollection<AlertCapsulesCriteria> AlertCapsulesCriteria { get; set; }
        public ICollection<AlertEmailAssigned> AlertEmailAssigned { get; set; }
    }
}
