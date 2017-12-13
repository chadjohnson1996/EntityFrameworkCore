using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcJobContacts
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public int LineNo { get; set; }
        public string CmContactNo { get; set; }
        public int CmPersonLineNo { get; set; }
        public int? CmLocationLineNo { get; set; }
        public string JobContactTypeNo { get; set; }
        public string Descripton { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string CmLocationLineId { get; set; }
        public string CmPersonLineId { get; set; }
        public string CompanyId { get; set; }
        public string JobContactTypeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }

        public CmContactLocations Cm { get; set; }
        public CmContacts CmContactNoNavigation { get; set; }
        public CmContactPersons CmNavigation { get; set; }
        public CmContactTypes JobContactTypeNoNavigation { get; set; }
        public Jobs Jobs { get; set; }
    }
}
