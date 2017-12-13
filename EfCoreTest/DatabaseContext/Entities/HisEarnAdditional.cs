using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisEarnAdditional
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public decimal? AdditionalDollars { get; set; }
        public string EarnTypeFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }

        public Employees Employees { get; set; }
    }
}
