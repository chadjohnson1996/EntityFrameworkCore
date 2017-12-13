using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaForm1094cPrevElecAggAle
    {
        public int CompanyNo { get; set; }
        public int ElecTransNum { get; set; }
        public int AggregatedAleNum { get; set; }
        public string AggregatedAleName { get; set; }
        public string AggregatedAleFein { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public AcaForm109xcPrevElecTrans AcaForm109xcPrevElecTrans { get; set; }
    }
}
