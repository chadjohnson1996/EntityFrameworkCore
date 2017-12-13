using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CashAccountRecUserDefaults
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public decimal? AccountNo { get; set; }
        public DateTime? StatementDate { get; set; }
        public decimal? StatementBalance { get; set; }
        public DateTime? BeginDate { get; set; }
        public string SortOrder { get; set; }
        public string UseAuditAr { get; set; }
        public string IncludeTrxAfterEndDate { get; set; }
    }
}
