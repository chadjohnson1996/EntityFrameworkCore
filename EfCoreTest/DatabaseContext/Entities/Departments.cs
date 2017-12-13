using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Departments
    {
        public Departments()
        {
            CostCodes = new HashSet<CostCodes>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            Department401k = new HashSet<Department401k>();
            DepartmentDivisions = new HashSet<DepartmentDivisions>();
            DeptBurdens = new HashSet<DeptBurdens>();
            DeptEarnCodes = new HashSet<DeptEarnCodes>();
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
            Employees = new HashSet<Employees>();
            JobCostcodes = new HashSet<JobCostcodes>();
            JobHistory = new HashSet<JobHistory>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            WcDepts = new HashSet<WcDepts>();
        }

        public int CompanyNo { get; set; }
        public string DeptNo { get; set; }
        public string Description { get; set; }
        public decimal? GlUnionFringeExp { get; set; }
        public decimal? GlWcExp { get; set; }
        public decimal? GlFutaExp { get; set; }
        public decimal? GlSutaExp { get; set; }
        public decimal? GlFicaExp { get; set; }
        public decimal? GlBurdenExp { get; set; }
        public string WcState { get; set; }
        public string TaxPrNo { get; set; }
        public string CertifiedPayroll { get; set; }
        public string WcClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string TaxPrId { get; set; }
        public string WcClassId { get; set; }
        public string EquipmentServiceRepair { get; set; }
        public string SuiStateOverride { get; set; }

        public TaxGroups TaxGroups { get; set; }
        public WcStates WcStates { get; set; }
        public ICollection<CostCodes> CostCodes { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<Department401k> Department401k { get; set; }
        public ICollection<DepartmentDivisions> DepartmentDivisions { get; set; }
        public ICollection<DeptBurdens> DeptBurdens { get; set; }
        public ICollection<DeptEarnCodes> DeptEarnCodes { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<JobCostcodes> JobCostcodes { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<WcDepts> WcDepts { get; set; }
    }
}
