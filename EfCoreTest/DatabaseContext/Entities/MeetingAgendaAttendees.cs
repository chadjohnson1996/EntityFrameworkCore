using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class MeetingAgendaAttendees
    {
        public int CompanyNo { get; set; }
        public string MeetingAgendaNo { get; set; }
        public int LineNo { get; set; }
        public string AttendingContactType { get; set; }
        public string AttendingCustomerNo { get; set; }
        public string AttendingVendorNo { get; set; }
        public string AttendingEmployeeNo { get; set; }
        public string AttendingProjectManagerNo { get; set; }
        public string AttendingBuyerNo { get; set; }
        public string AttendingMiscContactNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AttendingBuyerId { get; set; }
        public string AttendingCustomerId { get; set; }
        public string AttendingEmployeeId { get; set; }
        public string AttendingMiscContactId { get; set; }
        public string AttendingProjectManagerId { get; set; }
        public string AttendingVendorId { get; set; }
        public string CompanyId { get; set; }
        public string LineId { get; set; }
        public string MeetingAgendaId { get; set; }
        public string JobNo { get; set; }
        public string JobId { get; set; }

        public Buyers Buyers { get; set; }
        public Customers Customers { get; set; }
        public Employees Employees { get; set; }
        public Jobs Jobs { get; set; }
        public MeetingAgendas MeetingAgendas { get; set; }
        public MiscContacts MiscContacts { get; set; }
        public ProjectManagers ProjectManagers { get; set; }
        public Vendors Vendors { get; set; }
    }
}
