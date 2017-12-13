using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContactTypes
    {
        public CmContactTypes()
        {
            CmContacts = new HashSet<CmContacts>();
            DcJobContacts = new HashSet<DcJobContacts>();
        }

        public string ContactTypeNo { get; set; }
        public string ContactTypeDesc { get; set; }
        public string GroupType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ContactTypeId { get; set; }

        public ICollection<CmContacts> CmContacts { get; set; }
        public ICollection<DcJobContacts> DcJobContacts { get; set; }
    }
}
