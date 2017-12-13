using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Companies
    {
        public Companies()
        {
            AcaForm1095cSelectedEmployees = new HashSet<AcaForm1095cSelectedEmployees>();
            CompanyCalendars = new HashSet<CompanyCalendars>();
            CompanyUser = new HashSet<CompanyUser>();
            JobScheduleCompanyCalendar = new HashSet<JobScheduleCompanyCalendar>();
            JobScheduleLayout = new HashSet<JobScheduleLayout>();
            JobScheduleResourceConflicts = new HashSet<JobScheduleResourceConflicts>();
            JobScheduleTaskUdfList = new HashSet<JobScheduleTaskUdfList>();
            SdDispatchDailyBoard = new HashSet<SdDispatchDailyBoard>();
            SdDispatchFixedTypes = new HashSet<SdDispatchFixedTypes>();
            SdDispatchPositionBoard = new HashSet<SdDispatchPositionBoard>();
            SdDispatchUnassigned = new HashSet<SdDispatchUnassigned>();
            SdPositionArchiveDispatch = new HashSet<SdPositionArchiveDispatch>();
            SdUserSpecifiedDispatch = new HashSet<SdUserSpecifiedDispatch>();
            SdUserSpecifiedDispatchPrBillings = new HashSet<SdUserSpecifiedDispatchPrBillings>();
        }

        public int CompanyNo { get; set; }
        public string Name { get; set; }
        public string AbbrevName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string LogFlag { get; set; }
        public string LogInserts { get; set; }
        public string LogDeletes { get; set; }
        public string LogUpdates { get; set; }
        public string Secured { get; set; }
        public string EmailAddress { get; set; }
        public string CompanyId { get; set; }
        public string ConsolidatedGl { get; set; }
        public string ServiceType { get; set; }
        public string TaxOnly { get; set; }
        public string PrLockFlag { get; set; }
        public DateTime? PrLockDate { get; set; }
        public string PrintToPdf { get; set; }
        public string OverrideName { get; set; }
        public string PiracleAccountNo { get; set; }
        public string UseProcessorStub { get; set; }
        public string CheckStubFormat { get; set; }
        public string AccessToken { get; set; }
        public string PiracleAccountId { get; set; }
        public string Eac { get; set; }
        public byte[] Logo { get; set; }
        public string PrLockPrevent { get; set; }

        public ICollection<AcaForm1095cSelectedEmployees> AcaForm1095cSelectedEmployees { get; set; }
        public ICollection<CompanyCalendars> CompanyCalendars { get; set; }
        public ICollection<CompanyUser> CompanyUser { get; set; }
        public ICollection<JobScheduleCompanyCalendar> JobScheduleCompanyCalendar { get; set; }
        public ICollection<JobScheduleLayout> JobScheduleLayout { get; set; }
        public ICollection<JobScheduleResourceConflicts> JobScheduleResourceConflicts { get; set; }
        public ICollection<JobScheduleTaskUdfList> JobScheduleTaskUdfList { get; set; }
        public ICollection<SdDispatchDailyBoard> SdDispatchDailyBoard { get; set; }
        public ICollection<SdDispatchFixedTypes> SdDispatchFixedTypes { get; set; }
        public ICollection<SdDispatchPositionBoard> SdDispatchPositionBoard { get; set; }
        public ICollection<SdDispatchUnassigned> SdDispatchUnassigned { get; set; }
        public ICollection<SdPositionArchiveDispatch> SdPositionArchiveDispatch { get; set; }
        public ICollection<SdUserSpecifiedDispatch> SdUserSpecifiedDispatch { get; set; }
        public ICollection<SdUserSpecifiedDispatchPrBillings> SdUserSpecifiedDispatchPrBillings { get; set; }
    }
}
