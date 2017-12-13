using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Agencies
    {
        public Agencies()
        {
            AgencyItems = new HashSet<AgencyItems>();
            BidH = new HashSet<BidH>();
        }

        public int CompanyNo { get; set; }
        public string AgencyNo { get; set; }
        public string Description { get; set; }
        public string BidderReference { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string SubmitName { get; set; }
        public string AgencyId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<AgencyItems> AgencyItems { get; set; }
        public ICollection<BidH> BidH { get; set; }
    }
}
