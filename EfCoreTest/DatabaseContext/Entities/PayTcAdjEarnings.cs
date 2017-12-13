﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayTcAdjEarnings
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public int ComputeSequence { get; set; }
        public string PayMethod { get; set; }
        public int SequenceNo { get; set; }
        public string TcAdjType { get; set; }
        public int LineNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string EarnTypeFlag { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Amount { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlCredit { get; set; }
        public string FitTaxable { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string PayPeriodId { get; set; }
        public string SequenceId { get; set; }
    }
}