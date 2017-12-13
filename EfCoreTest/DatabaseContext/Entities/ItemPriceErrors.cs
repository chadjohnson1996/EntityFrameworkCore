using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ItemPriceErrors
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string ChangeSymbol { get; set; }
        public string ItemNo { get; set; }
        public string UpcNo { get; set; }
        public int LineNo { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string DeliveryUnitNo { get; set; }
        public string Source { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeliveryUnitId { get; set; }
        public string ItemId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public string UpcId { get; set; }

        public Items Items { get; set; }
    }
}
