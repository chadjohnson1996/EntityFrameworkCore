using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Counties
    {
        public Counties()
        {
            BidH = new HashSet<BidH>();
            CountyUnions = new HashSet<CountyUnions>();
            EconAreaCounties = new HashSet<EconAreaCounties>();
            TaxGroups = new HashSet<TaxGroups>();
            TaxTables = new HashSet<TaxTables>();
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string CountyPrNo { get; set; }
        public string Description { get; set; }
        public string UnionNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string UnionId { get; set; }

        public ICollection<BidH> BidH { get; set; }
        public ICollection<CountyUnions> CountyUnions { get; set; }
        public ICollection<EconAreaCounties> EconAreaCounties { get; set; }
        public ICollection<TaxGroups> TaxGroups { get; set; }
        public ICollection<TaxTables> TaxTables { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
