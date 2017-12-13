﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpDirectDeposit
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int LineNo { get; set; }
        public string Description { get; set; }
        public string BankRoutingNo { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountType { get; set; }
        public string DistributionMethod { get; set; }
        public decimal DistributionAmount { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BankAccountId { get; set; }
        public string BankRoutingId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string PrenoteReqd { get; set; }
        public int? BankRoutingNoEid { get; set; }
        public int? BankAccountNoEid { get; set; }

        public Edata BankAccountNoE { get; set; }
        public Edata BankRoutingNoE { get; set; }
        public Employees Employees { get; set; }
    }
}
