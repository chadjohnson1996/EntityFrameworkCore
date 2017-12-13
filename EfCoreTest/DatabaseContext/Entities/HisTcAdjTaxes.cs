using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisTcAdjTaxes
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public int SequenceNo { get; set; }
        public string TcAdjType { get; set; }
        public int LineNo { get; set; }
        public string State { get; set; }
        public string TaxPrNo { get; set; }
        public decimal? Earnings { get; set; }
        public decimal? Withheld { get; set; }
        public decimal? Eligible { get; set; }
        public decimal? FutaSuta { get; set; }
        public string TaxAuthorityType { get; set; }
        public decimal EarningsAddOn { get; set; }
        public decimal WithheldAddOn { get; set; }
        public decimal ReciprocityCredit { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string SequenceId { get; set; }
        public string TaxPrId { get; set; }
        public string Residence { get; set; }
        public decimal EmployerWithheld { get; set; }
    }
}
