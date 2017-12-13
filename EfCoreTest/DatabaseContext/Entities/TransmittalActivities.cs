using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TransmittalActivities
    {
        public int CompanyNo { get; set; }
        public string TransmittalNo { get; set; }
        public int LineNo { get; set; }
        public string DocActivityNo { get; set; }
        public string Description { get; set; }
        public string PerformingContactType { get; set; }
        public string PerformingCustomerNo { get; set; }
        public string PerformingVendorNo { get; set; }
        public string PerformingEmployeeNo { get; set; }
        public string PerformingProjectManagerNo { get; set; }
        public string PerformingBuyerNo { get; set; }
        public string PerformingMiscContactNo { get; set; }
        public DateTime ActivityDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DocActivityId { get; set; }
        public string LineId { get; set; }
        public string PerformingBuyerId { get; set; }
        public string PerformingCustomerId { get; set; }
        public string PerformingEmployeeId { get; set; }
        public string PerformingMiscContactId { get; set; }
        public string PerformingProjectManagerId { get; set; }
        public string PerformingVendorId { get; set; }
        public string TransmittalId { get; set; }
        public string ActionType { get; set; }
        public string SendContactType { get; set; }
        public string SendCustomerNo { get; set; }
        public string SendVendorNo { get; set; }
        public string SendEmployeeNo { get; set; }
        public string SendProjectManagerNo { get; set; }
        public string SendBuyerNo { get; set; }
        public string SendMiscContactNo { get; set; }
        public string NextActionType { get; set; }
        public string NextActionActivityNo { get; set; }
        public string NextActionContactType { get; set; }
        public string NextActionCustomerNo { get; set; }
        public string NextActionVendorNo { get; set; }
        public string NextActionEmployeeNo { get; set; }
        public string NextActionProjectManagerNo { get; set; }
        public string NextActionBuyerNo { get; set; }
        public string NextActionMiscContactNo { get; set; }
        public DateTime? NextActionDueDate { get; set; }
        public string NextActionComplete { get; set; }
        public string AutoCreated { get; set; }
        public string NextActionActivityId { get; set; }
        public string NextActionBuyerId { get; set; }
        public string NextActionCustomerId { get; set; }
        public string NextActionEmployeeId { get; set; }
        public string NextActionMiscContactId { get; set; }
        public string NextActionProjectManagerId { get; set; }
        public string NextActionVendorId { get; set; }
        public string SendBuyerId { get; set; }
        public string SendCustomerId { get; set; }
        public string SendEmployeeId { get; set; }
        public string SendMiscContactId { get; set; }
        public string SendProjectManagerId { get; set; }
        public string SendVendorId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public Buyers Buyers { get; set; }
        public Buyers Buyers1 { get; set; }
        public Buyers BuyersNavigation { get; set; }
        public Customers Customers { get; set; }
        public Customers Customers1 { get; set; }
        public Customers CustomersNavigation { get; set; }
        public DocActivities DocActivities { get; set; }
        public DocActivities DocActivitiesNavigation { get; set; }
        public Employees Employees { get; set; }
        public Employees Employees1 { get; set; }
        public Employees EmployeesNavigation { get; set; }
        public Jobs Jobs { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public MiscContacts MiscContacts1 { get; set; }
        public MiscContacts MiscContactsNavigation { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public ProjectManagers ProjectManagers1 { get; set; }
        public ProjectManagers ProjectManagersNavigation { get; set; }
        public Transmittals Transmittals { get; set; }
        public Vendors Vendors { get; set; }
        public Vendors Vendors1 { get; set; }
        public Vendors VendorsNavigation { get; set; }
    }
}
