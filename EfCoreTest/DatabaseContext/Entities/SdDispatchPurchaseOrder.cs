using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchPurchaseOrder
    {
        public int CompanyNo { get; set; }
        public string UniqueIdn { get; set; }
        public int RowNumber { get; set; }
        public string PoNumber { get; set; }
        public string PoStatus { get; set; }
    }
}
