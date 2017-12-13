using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApPreCheck
    {
        public ApPreCheck()
        {
            ApPreCheckVch = new HashSet<ApPreCheckVch>();
        }

        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public int MultiCheck { get; set; }
        public string Name { get; set; }
        public string JointName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public decimal GlCash { get; set; }
        public int? CheckNo { get; set; }
        public DateTime? CheckDate { get; set; }
        public string JobNo { get; set; }
        public string PayRetainage { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string IncludeHeldInvoice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string CheckDescription { get; set; }
        public string CheckId { get; set; }
        public string JobId { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public decimal RetainagePercent { get; set; }

        public ICollection<ApPreCheckVch> ApPreCheckVch { get; set; }
    }
}
