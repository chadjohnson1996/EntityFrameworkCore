﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PayPwHourlyFringe
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string UnionNo { get; set; }
        public string CountyPrNo { get; set; }
        public string TradeNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public string BenefitTypeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public string PayMethod { get; set; }
        public string JobNo { get; set; }
        public decimal Amount { get; set; }
        public string DeductionFringeType { get; set; }
        public string PostFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string VoidFlag { get; set; }
        public string BenefitTypeId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string DeductionFringeId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string JobId { get; set; }
        public string PayPeriodId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public decimal ReductionAmount { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
    }
}
