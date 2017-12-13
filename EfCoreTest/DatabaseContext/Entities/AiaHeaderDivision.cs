using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AiaHeaderDivision
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SectionNo { get; set; }
        public decimal DivisionNo { get; set; }
        public decimal? DivisionAccountNo { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DivisionAccountId { get; set; }
        public string DivisionId { get; set; }
        public string JobId { get; set; }
        public string SectionId { get; set; }

        public AiaHeader AiaHeader { get; set; }
        public GlDivisions GlDivisions { get; set; }
    }
}
