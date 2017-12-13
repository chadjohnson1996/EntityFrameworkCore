using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StateRating
    {
        public string Description { get; set; }
        public int RowUniqueId { get; set; }
        public string StateRatingNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int? CompanyNo { get; set; }
        public string RecordStatus { get; set; }
        public string CompanyId { get; set; }
        public string StateRatingId { get; set; }
    }
}
