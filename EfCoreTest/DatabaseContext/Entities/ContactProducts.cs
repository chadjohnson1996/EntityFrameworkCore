using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ContactProducts
    {
        public string ContactNo { get; set; }
        public string ProductNo { get; set; }
        public int CompanyNo { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? Quantity { get; set; }
        public string Description { get; set; }
        public decimal? ContractPrice { get; set; }
        public string CompetitorNo { get; set; }
        public string CompanyId { get; set; }
        public string CompetitorId { get; set; }
        public string ContactId { get; set; }
        public string ProductId { get; set; }
    }
}
