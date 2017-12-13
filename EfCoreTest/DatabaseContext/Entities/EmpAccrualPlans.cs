using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpAccrualPlans
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string AccrualNo { get; set; }
        public int PlanNo { get; set; }
        public decimal HoursToAccrue { get; set; }
        public decimal ForEvery { get; set; }
        public string Frequency { get; set; }
        public DateTime? StartingDate { get; set; }
        public string UnlimitedDuration { get; set; }
        public decimal DurationMonths { get; set; }
        public string DisableFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AccrualId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PlanId { get; set; }
        public string JobAccrualJoin { get; set; }

        public AccrualsD AccrualsD { get; set; }
        public AccrualsH AccrualsH { get; set; }
        public Employees Employees { get; set; }
    }
}
