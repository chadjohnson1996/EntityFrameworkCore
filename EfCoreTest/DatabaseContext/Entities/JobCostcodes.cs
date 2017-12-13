using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobCostcodes
    {
        public JobCostcodes()
        {
            DcRfcCostCodes = new HashSet<DcRfcCostCodes>();
            JobBudgets = new HashSet<JobBudgets>();
            JobChgCostCodes = new HashSet<JobChgCostCodes>();
            JobCostcodeBurdens = new HashSet<JobCostcodeBurdens>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string Description { get; set; }
        public string CostBasis { get; set; }
        public string CostCodeStatus { get; set; }
        public string ComputeVariance { get; set; }
        public string UmNo { get; set; }
        public string ProductionMethod { get; set; }
        public string Archive { get; set; }
        public decimal? OriginalQuantity { get; set; }
        public decimal? AdjustingQuantity { get; set; }
        public decimal? BidAmount { get; set; }
        public string CertifiedPayroll { get; set; }
        public string IgnoreHomeJob { get; set; }
        public string WcClassNo { get; set; }
        public string CostCodeMethod { get; set; }
        public decimal? GlExpense { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string UmId { get; set; }
        public string WcClassId { get; set; }
        public string EquipmentServiceRepair { get; set; }
        public string DeptNo { get; set; }
        public decimal? ApInvoiceGlExpense { get; set; }
        public string DeptId { get; set; }

        public Accounts Accounts { get; set; }
        public CostCodes Co { get; set; }
        public Departments Departments { get; set; }
        public JobPhases JobPhases { get; set; }
        public Units Units { get; set; }
        public ICollection<DcRfcCostCodes> DcRfcCostCodes { get; set; }
        public ICollection<JobBudgets> JobBudgets { get; set; }
        public ICollection<JobChgCostCodes> JobChgCostCodes { get; set; }
        public ICollection<JobCostcodeBurdens> JobCostcodeBurdens { get; set; }
    }
}
