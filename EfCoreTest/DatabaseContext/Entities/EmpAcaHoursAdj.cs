using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EmpAcaHoursAdj
    {
        public EmpAcaHoursAdj()
        {
            EmpAcaHoursAdjValues = new HashSet<EmpAcaHoursAdjValues>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNum { get; set; }
        public string PostedFlag { get; set; }
        public int Year { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<EmpAcaHoursAdjValues> EmpAcaHoursAdjValues { get; set; }
    }
}
