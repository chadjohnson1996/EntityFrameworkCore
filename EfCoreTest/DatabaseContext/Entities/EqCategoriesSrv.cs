using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqCategoriesSrv
    {
        public int CompanyNo { get; set; }
        public string EqCategoryNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public decimal? GlExpJrnlDebit { get; set; }
        public decimal? GlExpJrnlCredit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqCategoryId { get; set; }
        public string ServiceCodeId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public EqCategories EqCategories { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
    }
}
