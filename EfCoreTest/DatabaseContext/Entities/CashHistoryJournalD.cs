using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CashHistoryJournalD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public decimal CashAccountNo { get; set; }
        public int LineNo { get; set; }
        public DateTime? Date { get; set; }
        public string PostedFlag { get; set; }
        public int? CheckRefNumber { get; set; }
        public decimal CheckAmount { get; set; }
        public decimal DepOtherAmount { get; set; }
        public string VendorNo { get; set; }
        public string EmployeeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CashAccountId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public string VendorId { get; set; }

        public CashHistoryJournalH CashHistoryJournalH { get; set; }
        public Employees Employees { get; set; }
        public Vendors Vendors { get; set; }
    }
}
