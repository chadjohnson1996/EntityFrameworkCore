using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmLocationTypes
    {
        public CmLocationTypes()
        {
            CmContactLocations = new HashSet<CmContactLocations>();
        }

        public string LocationTypeNo { get; set; }
        public string LocationTypeDesc { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string LocationTypeId { get; set; }

        public ICollection<CmContactLocations> CmContactLocations { get; set; }
    }
}
