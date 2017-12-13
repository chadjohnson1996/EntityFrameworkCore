using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class NoteIt
    {
        public decimal NoteId { get; set; }
        public int CompanyNo { get; set; }
        public string TableName { get; set; }
        public int RowNo { get; set; }
        public string ColumnName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string NoteText { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public DateTime? TimeCreated { get; set; }
        public string Subject { get; set; }
    }
}
