using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnionPwBenefitTypes
    {
        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string BenefitTypeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BenefitTypeId { get; set; }
        public string CompanyId { get; set; }
        public string UnionId { get; set; }

        public BenefitTypes BenefitTypes { get; set; }
        public Unions Unions { get; set; }
    }
}
