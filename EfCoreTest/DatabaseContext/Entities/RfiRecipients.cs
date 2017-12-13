using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RfiRecipients
    {
        public int CompanyNo { get; set; }
        public string RfiNo { get; set; }
        public int LineNo { get; set; }
        public string RecipientType { get; set; }
        public string RecipientContactType { get; set; }
        public string RecipientCustomerNo { get; set; }
        public string RecipientVendorNo { get; set; }
        public string RecipientEmployeeNo { get; set; }
        public string RecipientProjectManagerNo { get; set; }
        public string RecipientBuyerNo { get; set; }
        public string RecipientMiscContactNo { get; set; }
        public string SendBy { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string RecipientBuyerId { get; set; }
        public string RecipientCustomerId { get; set; }
        public string RecipientEmployeeId { get; set; }
        public string RecipientMiscContactId { get; set; }
        public string RecipientProjectManagerId { get; set; }
        public string RecipientVendorId { get; set; }
        public string RfiId { get; set; }
        public string CreateActivity { get; set; }
        public string AutoCreated { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public Buyers Buyers { get; set; }
        public Customers Customers { get; set; }
        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public Rfis Rfis { get; set; }
        public Vendors Vendors { get; set; }
    }
}
