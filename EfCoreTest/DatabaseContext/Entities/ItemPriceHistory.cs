using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemPriceHistory
    {
        public int CompanyNo { get; set; }
        public string ItemNo { get; set; }
        public int LineNo { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryUnitNo { get; set; }
        public decimal ListPrice { get; set; }
        public decimal Price1 { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }
        public decimal SuggestedRetail { get; set; }
        public string Source { get; set; }
        public string UpdatedCost { get; set; }
        public string UpdatedPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? TransactionNo { get; set; }
        public DateTime? UpdatedCostDate { get; set; }
        public DateTime? UpdatedPriceDate { get; set; }
        public string CompanyId { get; set; }
        public string DeliveryUnitId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }

        public Items Items { get; set; }
        public Units Units { get; set; }
    }
}
