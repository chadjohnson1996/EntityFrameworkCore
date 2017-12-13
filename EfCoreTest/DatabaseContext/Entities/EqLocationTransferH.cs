using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqLocationTransferH
    {
        public EqLocationTransferH()
        {
            EqLocationTransferD = new HashSet<EqLocationTransferD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public string DefaultEquipmentNo { get; set; }
        public string DefaultJobNo { get; set; }
        public DateTime? DefaultDate { get; set; }
        public DateTime? DefaultTime { get; set; }
        public string DefaultTimeType { get; set; }
        public string DefaultEmployeeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DefaultEmployeeId { get; set; }
        public string DefaultEquipmentId { get; set; }
        public string DefaultJobId { get; set; }
        public string TransactionId { get; set; }

        public Employees Employees { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<EqLocationTransferD> EqLocationTransferD { get; set; }
    }
}
