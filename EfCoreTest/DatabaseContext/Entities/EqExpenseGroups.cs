using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqExpenseGroups
    {
        public EqExpenseGroups()
        {
            EqServiceCodes = new HashSet<EqServiceCodes>();
        }

        public int CompanyNo { get; set; }
        public string ExpenseGroupNo { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string ExpenseGroupId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }

        public ICollection<EqServiceCodes> EqServiceCodes { get; set; }
    }
}
