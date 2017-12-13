using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class VoidMaint
    {
        public int CompanyNo { get; set; }
        public string VoidMaintType { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string EmployeeNo { get; set; }
        public int? TimecardXref { get; set; }
        public string TimeHisFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PayPeriodNo { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string CheckNoSource { get; set; }
        public string PaymentGroupNo { get; set; }
        public string PaymentGroupId { get; set; }
    }
}
