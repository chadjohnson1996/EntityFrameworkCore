using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FieldLogOnSiteContacts
    {
        public int CompanyNo { get; set; }
        public string FieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string OnSiteContactType { get; set; }
        public string OnSiteCustomerNo { get; set; }
        public string OnSiteVendorNo { get; set; }
        public string OnSiteEmployeeNo { get; set; }
        public string OnSiteProjectManagerNo { get; set; }
        public string OnSiteBuyerNo { get; set; }
        public string OnSiteMiscContactNo { get; set; }
        public int Staff { get; set; }
        public string Notes { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string FieldLogId { get; set; }
        public string LineId { get; set; }
        public string OnSiteBuyerId { get; set; }
        public string OnSiteCustomerId { get; set; }
        public string OnSiteEmployeeId { get; set; }
        public string OnSiteMiscContactId { get; set; }
        public string OnSiteProjectManagerId { get; set; }
        public string OnSiteVendorId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public Buyers Buyers { get; set; }
        public Customers Customers { get; set; }
        public Employees Employees { get; set; }
        public FieldLogs FieldLogs { get; set; }
        public Jobs Jobs { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public Vendors Vendors { get; set; }
    }
}
