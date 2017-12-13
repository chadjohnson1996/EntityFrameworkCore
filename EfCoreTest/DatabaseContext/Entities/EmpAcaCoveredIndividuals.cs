using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpAcaCoveredIndividuals
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int Year { get; set; }
        public int CoveredIndNum { get; set; }
        public string CoveredIndSsNo { get; set; }
        public DateTime? CoveredIndDob { get; set; }
        public string Covered12mos { get; set; }
        public string CoveredJan { get; set; }
        public string CoveredFeb { get; set; }
        public string CoveredMar { get; set; }
        public string CoveredApr { get; set; }
        public string CoveredMay { get; set; }
        public string CoveredJun { get; set; }
        public string CoveredJul { get; set; }
        public string CoveredAug { get; set; }
        public string CoveredSep { get; set; }
        public string CoveredOct { get; set; }
        public string CoveredNov { get; set; }
        public string CoveredDec { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CoveredIndSsNoEid { get; set; }
        public string CoveredIndFirstName { get; set; }
        public string CoveredIndMiddleInitial { get; set; }
        public string CoveredIndLastName { get; set; }
        public string CoveredIndSuffix { get; set; }
        public string CompanyId { get; set; }
        public string CoveredIndSsId { get; set; }
        public string EmployeeId { get; set; }

        public Edata CoveredIndSsNoE { get; set; }
        public Employees Employees { get; set; }
    }
}
