using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TcRecurTypes
    {
        public TcRecurTypes()
        {
            EmpTcRecurTypes = new HashSet<EmpTcRecurTypes>();
        }

        public int CompanyNo { get; set; }
        public string TcRecurTypeNo { get; set; }
        public string Description { get; set; }
        public string PaymentGroupNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string HourlyExistsForRecurring { get; set; }
        public string CompanyId { get; set; }
        public string PaymentGroupId { get; set; }
        public string TcRecurTypeId { get; set; }

        public TimecardPaymentGroup TimecardPaymentGroup { get; set; }
        public ICollection<EmpTcRecurTypes> EmpTcRecurTypes { get; set; }
    }
}
