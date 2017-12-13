using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionShiftRt
    {
        public UnionShiftRt()
        {
            UnionTradesRates = new HashSet<UnionTradesRates>();
        }

        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string ShiftNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ShiftId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }

        public Unions Unions { get; set; }
        public ICollection<UnionTradesRates> UnionTradesRates { get; set; }
    }
}
