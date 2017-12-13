using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AccrualsH
    {
        public AccrualsH()
        {
            AccrualsD = new HashSet<AccrualsD>();
            EarnTypes = new HashSet<EarnTypes>();
            EmpAccrualPlans = new HashSet<EmpAccrualPlans>();
            HisAccrual = new HashSet<HisAccrual>();
            JobAccrualPlans = new HashSet<JobAccrualPlans>();
            PayAccrual = new HashSet<PayAccrual>();
        }

        public int CompanyNo { get; set; }
        public string AccrualNo { get; set; }
        public string Description { get; set; }
        public string YearBasis { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ShortDescription { get; set; }
        public string AccrualId { get; set; }
        public string CompanyId { get; set; }
        public string AccrualType { get; set; }
        public string TransferAccrualNo { get; set; }
        public string ShowOnStub { get; set; }
        public string TransferAccrualId { get; set; }
        public string ShowZeroBalOnStub { get; set; }
        public string ShowUnlimited { get; set; }
        public string AccrualMethod { get; set; }

        public ICollection<AccrualsD> AccrualsD { get; set; }
        public ICollection<EarnTypes> EarnTypes { get; set; }
        public ICollection<EmpAccrualPlans> EmpAccrualPlans { get; set; }
        public ICollection<HisAccrual> HisAccrual { get; set; }
        public ICollection<JobAccrualPlans> JobAccrualPlans { get; set; }
        public ICollection<PayAccrual> PayAccrual { get; set; }
    }
}
