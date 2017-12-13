using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Proposal
    {
        public int? CompanyNo { get; set; }
        public int ProposalNo { get; set; }
        public string ContactNo { get; set; }
        public DateTime? ProposalDate { get; set; }
        public DateTime? PriceDate { get; set; }
        public decimal? SystemCost { get; set; }
        public string CustomProgramming { get; set; }
        public decimal? Maintenance { get; set; }
        public decimal? NumberOfUsers { get; set; }
        public int? TrainingOptionNo { get; set; }
        public decimal? ClientSiteHrs { get; set; }
        public int? ClientSiteVisits { get; set; }
        public decimal? ModemHrs { get; set; }
        public decimal? ClassroomDays { get; set; }
        public int? ContractOptionNo { get; set; }
        public decimal? DepositPercentage { get; set; }
        public decimal? InstallationPercentage { get; set; }
        public decimal? ThirtyDaysPercentage { get; set; }
        public decimal? SixtyDaysPercentage { get; set; }
        public decimal? BuyoutDollars { get; set; }
        public int? FirstInstallmentMonth { get; set; }
        public int? SecondInstallmentMonth { get; set; }
        public decimal? FirstInstallmentAmount { get; set; }
        public decimal? SecondInstallmentAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public decimal? Disount { get; set; }
        public decimal? Deposit { get; set; }
        public string CompanyId { get; set; }
        public string ContactId { get; set; }
        public string ContractOptionId { get; set; }
        public string ProposalId { get; set; }
        public string TrainingOptionId { get; set; }
    }
}
