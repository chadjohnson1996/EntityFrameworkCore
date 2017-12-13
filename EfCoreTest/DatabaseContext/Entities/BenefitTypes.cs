using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BenefitTypes
    {
        public BenefitTypes()
        {
            EmpPwHourlyFringe = new HashSet<EmpPwHourlyFringe>();
            EmpPwPerPayFringe = new HashSet<EmpPwPerPayFringe>();
            UnionPwBenefitTypes = new HashSet<UnionPwBenefitTypes>();
        }

        public int CompanyNo { get; set; }
        public string BenefitTypeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BenefitTypeId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<EmpPwHourlyFringe> EmpPwHourlyFringe { get; set; }
        public ICollection<EmpPwPerPayFringe> EmpPwPerPayFringe { get; set; }
        public ICollection<UnionPwBenefitTypes> UnionPwBenefitTypes { get; set; }
    }
}
