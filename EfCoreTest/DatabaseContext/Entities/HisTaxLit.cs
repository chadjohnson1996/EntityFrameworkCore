using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisTaxLit
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string State { get; set; }
        public string LocalTaxNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public decimal? Earnings { get; set; }
        public decimal? Withheld { get; set; }
        public decimal? Eligible { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LocalTaxId { get; set; }
        public string PayPeriodId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public decimal EarningsAddOn { get; set; }
        public decimal WithheldAddOn { get; set; }
        public decimal ReciprocityCredit { get; set; }
        public string AddFlag { get; set; }
        public string Residence { get; set; }
        public string HighRateLocal { get; set; }
        public decimal EmployerWithheld { get; set; }

        public Employees Employees { get; set; }
    }
}
