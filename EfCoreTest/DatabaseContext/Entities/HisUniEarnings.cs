﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisUniEarnings
    {
        public int CompanyNo { get; set; }
        public string UnionNo { get; set; }
        public string CountyPrNo { get; set; }
        public string EmployeeNo { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Dollars { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string JobNo { get; set; }
        public string PrevailFlag { get; set; }
        public string JobId { get; set; }
        public string OtRateRounded { get; set; }
        public string HomeUnionNo { get; set; }
        public string HomeUnionId { get; set; }

        public Employees Employees { get; set; }
    }
}
