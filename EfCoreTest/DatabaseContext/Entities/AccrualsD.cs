using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AccrualsD
    {
        public AccrualsD()
        {
            EmpAccrualPlans = new HashSet<EmpAccrualPlans>();
            HisAccrual = new HashSet<HisAccrual>();
            JobAccrualPlans = new HashSet<JobAccrualPlans>();
            PayAccrual = new HashSet<PayAccrual>();
        }

        public int CompanyNo { get; set; }
        public string AccrualNo { get; set; }
        public int PlanNo { get; set; }
        public string Description { get; set; }
        public string AccrualType { get; set; }
        public decimal HoursToAccrue { get; set; }
        public decimal ForEvery { get; set; }
        public string Frequency { get; set; }
        public decimal AnnualMax { get; set; }
        public decimal TotalMax { get; set; }
        public DateTime? StartingDate { get; set; }
        public string UnlimitedDuration { get; set; }
        public decimal DurationMonths { get; set; }
        public string CarryoverType { get; set; }
        public decimal CarryoverLimit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccrualId { get; set; }
        public string CompanyId { get; set; }
        public string PlanId { get; set; }

        public AccrualsH AccrualsH { get; set; }
        public ICollection<EmpAccrualPlans> EmpAccrualPlans { get; set; }
        public ICollection<HisAccrual> HisAccrual { get; set; }
        public ICollection<JobAccrualPlans> JobAccrualPlans { get; set; }
        public ICollection<PayAccrual> PayAccrual { get; set; }
    }
}
