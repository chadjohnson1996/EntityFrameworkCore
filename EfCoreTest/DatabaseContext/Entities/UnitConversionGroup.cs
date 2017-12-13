using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UnitConversionGroup
    {
        public UnitConversionGroup()
        {
            Items = new HashSet<Items>();
            UnitConversionDetail = new HashSet<UnitConversionDetail>();
        }

        public int CompanyNo { get; set; }
        public string UnitConversionNo { get; set; }
        public string Description { get; set; }
        public string Method { get; set; }
        public string LargestUnitNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string EachUnitNo { get; set; }
        public string CompanyId { get; set; }
        public string EachUnitId { get; set; }
        public string LargestUnitId { get; set; }
        public string UnitConversionId { get; set; }

        public Units Units { get; set; }
        public Units UnitsNavigation { get; set; }
        public ICollection<Items> Items { get; set; }
        public ICollection<UnitConversionDetail> UnitConversionDetail { get; set; }
    }
}
