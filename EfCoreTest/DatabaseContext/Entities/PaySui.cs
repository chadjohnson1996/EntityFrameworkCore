﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PaySui
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string State { get; set; }
        public string CountyNo { get; set; }
        public string PayMethod { get; set; }
        public decimal? HourlyEarnings { get; set; }
        public decimal? AdditionalEarnings { get; set; }
        public decimal? Hours { get; set; }
        public string PostFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public int ComputeSequence { get; set; }

        public Employees Employees { get; set; }
    }
}
