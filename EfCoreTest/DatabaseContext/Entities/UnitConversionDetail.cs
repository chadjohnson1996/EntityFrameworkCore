using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnitConversionDetail
    {
        public int CompanyNo { get; set; }
        public string UnitConversionNo { get; set; }
        public int LineNo { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string UnitConversionId { get; set; }
        public string UnitId { get; set; }

        public UnitConversionGroup UnitConversionGroup { get; set; }
        public Units Units { get; set; }
    }
}
