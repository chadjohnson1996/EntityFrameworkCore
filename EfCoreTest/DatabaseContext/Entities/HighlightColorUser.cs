using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HighlightColorUser
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public int ColorNo { get; set; }
        public string ColorName { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? Background { get; set; }
        public int? TextColor { get; set; }
        public string Bold { get; set; }
        public string Italic { get; set; }
        public int DisplayOrder { get; set; }
        public string ColorId { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
    }
}
