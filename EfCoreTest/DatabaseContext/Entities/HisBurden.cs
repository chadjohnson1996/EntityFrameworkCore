using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisBurden
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int BurdenNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Earnings { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BurdenId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }

        public Employees Employees { get; set; }
    }
}
