using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApCheck
    {
        public ApCheck()
        {
            ApCheckVch = new HashSet<ApCheckVch>();
        }

        public int CompanyNo { get; set; }
        public decimal GlCash { get; set; }
        public int CheckNo { get; set; }
        public string VoidFlag { get; set; }
        public string VendorNo { get; set; }
        public int? MultiCheck { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CheckType { get; set; }
        public int? FirstCheckInSet { get; set; }
        public int? LastCheckInSet { get; set; }
        public string Name { get; set; }
        public string JointName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Country { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string Source { get; set; }
        public string Type { get; set; }
        public string CheckDescription { get; set; }
        public int? AuditNumber { get; set; }
        public string UseAltReturnAddress { get; set; }
        public string AltReturnAddress1 { get; set; }
        public string AltReturnAddress2 { get; set; }
        public string AltReturnAddress3 { get; set; }
        public string AltReturnAddress4 { get; set; }
        public string AltReturnAddress5 { get; set; }

        public ICollection<ApCheckVch> ApCheckVch { get; set; }
    }
}
