using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AgencyItems
    {
        public int CompanyNo { get; set; }
        public string AgencyNo { get; set; }
        public int SequenceNo { get; set; }
        public string ItemReference { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AgencyId { get; set; }
        public string CompanyId { get; set; }
        public string SequenceId { get; set; }
        public string UnitId { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostCodeId { get; set; }
        public string PhaseId { get; set; }
        public int OrdinalPosition { get; set; }
        public decimal? DefaultUnitPrice { get; set; }

        public Agencies Agencies { get; set; }
        public CostCodes Co { get; set; }
        public Phases Phases { get; set; }
        public Units Units { get; set; }
    }
}
