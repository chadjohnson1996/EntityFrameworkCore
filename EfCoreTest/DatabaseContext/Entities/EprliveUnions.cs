using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EprliveUnions
    {
        public EprliveUnions()
        {
            EprliveUnionTrades = new HashSet<EprliveUnionTrades>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string UnionId { get; set; }

        public ICollection<EprliveUnionTrades> EprliveUnionTrades { get; set; }
    }
}
