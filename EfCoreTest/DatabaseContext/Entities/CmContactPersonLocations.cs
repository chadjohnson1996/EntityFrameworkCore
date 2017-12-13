using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CmContactPersonLocations
    {
        public string CmContactNo { get; set; }
        public int PersonLineNo { get; set; }
        public int LineNo { get; set; }
        public int LocationLineNo { get; set; }
        public string MainLocationFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string LineId { get; set; }
        public string LocationLineId { get; set; }
        public string PersonLineId { get; set; }

        public CmContactLocations CmContactLocations { get; set; }
        public CmContacts CmContactNoNavigation { get; set; }
        public CmContactPersons CmContactPersons { get; set; }
    }
}
