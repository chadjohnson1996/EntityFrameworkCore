using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPayClasses
    {
        public ApPayClasses()
        {
            ApInvoiceH = new HashSet<ApInvoiceH>();
            Vendors = new HashSet<Vendors>();
        }

        public int CompanyNo { get; set; }
        public string PayClassNo { get; set; }
        public string PayClassFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string PayClassId { get; set; }

        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<Vendors> Vendors { get; set; }
    }
}
