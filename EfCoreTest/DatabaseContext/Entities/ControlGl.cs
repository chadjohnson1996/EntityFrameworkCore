using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlGl
    {
        public int CompanyNo { get; set; }
        public string AccountFormat { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ControlDateFlag { get; set; }
        public string BasicAcctDesc { get; set; }
        public string ShowNegativeAs { get; set; }
        public string SubDiv1Active { get; set; }
        public string SubDiv2Active { get; set; }
        public string SubDiv3Active { get; set; }
        public string SubDiv4Active { get; set; }
        public string SubDiv1Desc { get; set; }
        public string SubDiv2Desc { get; set; }
        public string SubDiv3Desc { get; set; }
        public string SubDiv4Desc { get; set; }
        public string SubDiv1Abrv { get; set; }
        public string SubDiv2Abrv { get; set; }
        public string SubDiv3Abrv { get; set; }
        public string SubDiv4Abrv { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BondingReportSource { get; set; }
        public string CompanyId { get; set; }
        public string AlertOnNewAccount { get; set; }
        public string EnableCashHisEntry { get; set; }
        public string OvhdPostToPhase { get; set; }
        public string OvhdPostToCostCode { get; set; }
        public string OvhdPostToCostClass { get; set; }
        public decimal? OvhdPostToGlDebit { get; set; }
        public decimal? OvhdPostToGlCredit { get; set; }
        public string OvhdPostToGlFlag { get; set; }
        public string OvhdPostToGlJournal { get; set; }
        public decimal? OvhdPostToLevel1Div { get; set; }
        public decimal? OvhdPostToLevel2Div { get; set; }
        public decimal? OvhdPostToLevel3Div { get; set; }
        public decimal? OvhdPostToLevel4Div { get; set; }
        public string CreateGlJrnlTrxFromBankRec { get; set; }
        public string BankRecAutoPostDiffTrx { get; set; }
        public string BankRecDebit1AccountName { get; set; }
        public string BankRecDebit2AccountName { get; set; }
        public string BankRecDebit3AccountName { get; set; }
        public string BankRecDebit4AccountName { get; set; }
        public decimal? BankRecDebit1AccountNo { get; set; }
        public decimal? BankRecDebit2AccountNo { get; set; }
        public decimal? BankRecDebit3AccountNo { get; set; }
        public decimal? BankRecDebit4AccountNo { get; set; }
        public string CreateGlJrnlTrxDateDefault { get; set; }
        public string BankRecDebit1AccountId { get; set; }
        public string BankRecDebit2AccountId { get; set; }
        public string BankRecDebit3AccountId { get; set; }
        public string BankRecDebit4AccountId { get; set; }
        public string PreventJournalEntryFlag { get; set; }
        public string EntryToJrnlFlag { get; set; }
        public string MicrEnabled { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts AccountsNavigation { get; set; }
    }
}
