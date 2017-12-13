using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqLocationTransferD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string EquipmentNo { get; set; }
        public string JobNo { get; set; }
        public DateTime DateBooked { get; set; }
        public DateTime DeliveryTime { get; set; }
        public string DeliveryTimeType { get; set; }
        public DateTime? DeliveryTimeMilitary { get; set; }
        public string EmployeeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Comment { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }

        public Employees Employees { get; set; }
        public EqLocationTransferH EqLocationTransferH { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
    }
}
