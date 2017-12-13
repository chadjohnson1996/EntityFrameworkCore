using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FieldLogTasks
    {
        public FieldLogTasks()
        {
            FieldLogTaskDelays = new HashSet<FieldLogTaskDelays>();
        }

        public int CompanyNo { get; set; }
        public string FieldLogNo { get; set; }
        public int LineNo { get; set; }
        public string DcTaskNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string Description { get; set; }
        public string PerformingContactType { get; set; }
        public string PerformingCustomerNo { get; set; }
        public string PerformingVendorNo { get; set; }
        public string PerformingEmployeeNo { get; set; }
        public string PerformingProjectManagerNo { get; set; }
        public string PerformingBuyerNo { get; set; }
        public string PerformingMiscContactNo { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcTaskId { get; set; }
        public string FieldLogId { get; set; }
        public string LineId { get; set; }
        public string PerformingBuyerId { get; set; }
        public string PerformingCustomerId { get; set; }
        public string PerformingEmployeeId { get; set; }
        public string PerformingMiscContactId { get; set; }
        public string PerformingProjectManagerId { get; set; }
        public string PerformingVendorId { get; set; }
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
        public ICollection<FieldLogTaskDelays> FieldLogTaskDelays { get; set; }
    }
}
