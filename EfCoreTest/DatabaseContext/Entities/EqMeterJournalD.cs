using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqMeterJournalD
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string EquipmentNo { get; set; }
        public DateTime DateBooked { get; set; }
        public decimal HoursMeter { get; set; }
        public decimal OdometerMeter { get; set; }
        public decimal OtherMeter { get; set; }
        public string JobNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string TransactionId { get; set; }
        public decimal? Gallons { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? Amount { get; set; }

        public EqMeterJournalH EqMeterJournalH { get; set; }
        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
    }
}
