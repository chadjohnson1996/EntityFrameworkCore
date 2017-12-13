using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StatementCategories
    {
        public StatementCategories()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int CompanyNo { get; set; }
        public string StatementCategoryNo { get; set; }
        public string Description { get; set; }
        public string CashFlowType { get; set; }
        public string BalanceSheetType { get; set; }
        public string IncomeStatementType { get; set; }
        public int OrdinalPosition { get; set; }
        public string DebitCredit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string StatementCategoryId { get; set; }

        public ICollection<Accounts> Accounts { get; set; }
    }
}
