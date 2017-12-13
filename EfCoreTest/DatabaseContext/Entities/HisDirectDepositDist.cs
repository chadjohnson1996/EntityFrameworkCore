using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisDirectDepositDist
    {
        public int CompanyNo { get; set; }
        public int TimecardXref { get; set; }
        public int OrdinalPosition { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string CheckNoSource { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public string BankRoutingNo { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountType { get; set; }
        public string DistributionMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateBooked { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateExported { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BankAccountId { get; set; }
        public string BankRoutingId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public int? BankRoutingNoEid { get; set; }
        public int? BankAccountNoEid { get; set; }

        public Edata BankAccountNoE { get; set; }
        public Edata BankRoutingNoE { get; set; }
    }
}
