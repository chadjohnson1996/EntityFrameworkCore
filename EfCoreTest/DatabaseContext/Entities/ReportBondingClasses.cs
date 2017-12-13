using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ReportBondingClasses
    {
        public int CompanyNo { get; set; }
        public string ReportAbbreviation { get; set; }
        public string ReportHeading { get; set; }
        public string BondingClass { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public ControlJc CompanyNoNavigation { get; set; }
    }
}
