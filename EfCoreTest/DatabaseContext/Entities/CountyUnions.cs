using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CountyUnions
    {
        public int CompanyNo { get; set; }
        public string CountyPrNo { get; set; }
        public string OldUnionNo { get; set; }
        public string NewUnionNo { get; set; }
        public string DeductionFringeFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string NewUnionId { get; set; }
        public string OldUnionId { get; set; }

        public Counties Co { get; set; }
        public Unions Unions { get; set; }
        public Unions UnionsNavigation { get; set; }
    }
}
