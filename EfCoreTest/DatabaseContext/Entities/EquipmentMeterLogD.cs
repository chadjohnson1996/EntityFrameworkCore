using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EquipmentMeterLogD
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int Sequence { get; set; }
        public string Source { get; set; }
        public decimal Units { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }
        public int? EqMeterTrxNo { get; set; }
        public int? EqMeterLineNo { get; set; }
        public string EqMeterLineId { get; set; }
        public string EqMeterTrxId { get; set; }

        public Equipment Equipment { get; set; }
        public Jobs Jobs { get; set; }
    }
}
