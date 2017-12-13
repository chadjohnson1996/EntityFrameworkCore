using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpAcaHoursAdjValues
    {
        public int CompanyNo { get; set; }
        public int TransactionNum { get; set; }
        public string EmployeeNo { get; set; }
        public decimal? HoursAdjJan { get; set; }
        public decimal? HoursAdjFeb { get; set; }
        public decimal? HoursAdjMar { get; set; }
        public decimal? HoursAdjApr { get; set; }
        public decimal? HoursAdjMay { get; set; }
        public decimal? HoursAdjJun { get; set; }
        public decimal? HoursAdjJul { get; set; }
        public decimal? HoursAdjAug { get; set; }
        public decimal? HoursAdjSep { get; set; }
        public decimal? HoursAdjOct { get; set; }
        public decimal? HoursAdjNov { get; set; }
        public decimal? HoursAdjDec { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }

        public EmpAcaHoursAdj EmpAcaHoursAdj { get; set; }
        public Employees Employees { get; set; }
    }
}
