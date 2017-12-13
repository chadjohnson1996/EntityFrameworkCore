using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmPersonTypes
    {
        public CmPersonTypes()
        {
            CmContactPersons = new HashSet<CmContactPersons>();
        }

        public string PersonTypeNo { get; set; }
        public string PersonTypeDesc { get; set; }
        public string GroupType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PersonTypeId { get; set; }

        public ICollection<CmContactPersons> CmContactPersons { get; set; }
    }
}
