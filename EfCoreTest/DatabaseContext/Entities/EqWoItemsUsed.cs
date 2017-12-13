using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoItemsUsed
    {
        public EqWoItemsUsed()
        {
            EqWoItemsD = new HashSet<EqWoItemsD>();
        }

        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public int LineNo { get; set; }
        public int UsedLineNo { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public string UsedFlag { get; set; }
        public decimal UsedQuantity { get; set; }
        public decimal UsedUnitCost { get; set; }
        public decimal UsedExtCost { get; set; }
        public int? ReceiptLineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? ReceiptTrxNo { get; set; }
        public string CompanyId { get; set; }
        public string EqWoId { get; set; }
        public string LineId { get; set; }
        public string ReceiptLineId { get; set; }
        public string ReceiptTrxId { get; set; }
        public string UsedLineId { get; set; }

        public EqWo EqWo { get; set; }
        public EqWoItems EqWoItems { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
    }
}
