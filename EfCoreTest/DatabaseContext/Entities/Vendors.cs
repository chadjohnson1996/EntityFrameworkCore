using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Vendors
    {
        public Vendors()
        {
            Ap1099Div = new HashSet<Ap1099Div>();
            Ap1099Int = new HashSet<Ap1099Int>();
            Ap1099Misc = new HashSet<Ap1099Misc>();
            ApInvoiceH = new HashSet<ApInvoiceH>();
            ApInvoiceSubtierVendors = new HashSet<ApInvoiceSubtierVendors>();
            BidD = new HashSet<BidD>();
            BuyOutH = new HashSet<BuyOutH>();
            CashHistoryJournalD = new HashSet<CashHistoryJournalD>();
            DcFieldLogMaterials = new HashSet<DcFieldLogMaterials>();
            DcRfcBudgets = new HashSet<DcRfcBudgets>();
            Deductions = new HashSet<Deductions>();
            EmpDed = new HashSet<EmpDed>();
            FieldLogMaterials = new HashSet<FieldLogMaterials>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            HisMisc = new HashSet<HisMisc>();
            InventoryReceiptsH = new HashSet<InventoryReceiptsH>();
            ItemVendors = new HashSet<ItemVendors>();
            JobChgBudgets = new HashSet<JobChgBudgets>();
            JobScheduleTaskVendorResources = new HashSet<JobScheduleTaskVendorResources>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesVendors = new HashSet<MiscDocActivities>();
            MiscDocActivitiesVendors1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesVendorsNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsVendors = new HashSet<MiscDocs>();
            MiscDocsVendorsNavigation = new HashSet<MiscDocs>();
            PayMisc = new HashSet<PayMisc>();
            PoSubH = new HashSet<PoSubH>();
            PoSubSubtierVendors = new HashSet<PoSubSubtierVendors>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesVendors = new HashSet<RfcActivities>();
            RfcActivitiesVendors1 = new HashSet<RfcActivities>();
            RfcActivitiesVendorsNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsVendors = new HashSet<Rfcs>();
            RfcsVendorsNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesVendors = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesVendors1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesVendorsNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisVendors = new HashSet<Rfis>();
            RfisVendorsNavigation = new HashSet<Rfis>();
            RfpItemActivitiesVendors = new HashSet<RfpItemActivities>();
            RfpItemActivitiesVendors1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesVendorsNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsVendors = new HashSet<Rfps>();
            RfpsVendorsNavigation = new HashSet<Rfps>();
            SubmittalItemActivitiesVendors = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesVendors1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesVendorsNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsVendors = new HashSet<Submittals>();
            SubmittalsVendorsNavigation = new HashSet<Submittals>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            TransmittalActivitiesVendors = new HashSet<TransmittalActivities>();
            TransmittalActivitiesVendors1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesVendorsNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsVendors = new HashSet<Transmittals>();
            TransmittalsVendorsNavigation = new HashSet<Transmittals>();
            VendorAreas = new HashSet<VendorAreas>();
            VendorDirectPayments = new HashSet<VendorDirectPayments>();
            VendorDivisions = new HashSet<VendorDivisions>();
            VendorSupplies = new HashSet<VendorSupplies>();
        }

        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EmailAddress { get; set; }
        public string Contact { get; set; }
        public decimal? CreditLimit { get; set; }
        public DateTime? VendorSince { get; set; }
        public string Minority { get; set; }
        public string ShipToNo { get; set; }
        public string TermsNo { get; set; }
        public string Print1099 { get; set; }
        public string FederalId { get; set; }
        public string HoldPayment { get; set; }
        public decimal? DefaultGlAccount { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string TaxNo { get; set; }
        public string RequirePo { get; set; }
        public decimal? RetainagePercent { get; set; }
        public string PayClassNo { get; set; }
        public string InsCertificate { get; set; }
        public DateTime? InsDateExpires { get; set; }
        public string WcCertificate { get; set; }
        public DateTime? WcDateExpires { get; set; }
        public string CheckDescription { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CheckDescPrintMethod { get; set; }
        public string MiscFlag { get; set; }
        public string ReportingClassNo { get; set; }
        public string FaxId { get; set; }
        public string PhoneId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string CostCodeId { get; set; }
        public string CostClassId { get; set; }
        public string PhaseId { get; set; }
        public string PayClassId { get; set; }
        public string ShipToId { get; set; }
        public string TaxId { get; set; }
        public string TermsId { get; set; }
        public string ReportingClassId { get; set; }
        public string LienWaiverDefault { get; set; }
        public string WaiverDescription { get; set; }
        public string WaiverTradeWork { get; set; }
        public string WaiverTitle { get; set; }
        public string WaiverSignatureName { get; set; }
        public string VendorName1099 { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public string Provider { get; set; }
        public string NameControl1099 { get; set; }
        public string FederalIdType { get; set; }
        public string VendorName10992 { get; set; }
        public string Name2 { get; set; }
        public string Certificate1 { get; set; }
        public DateTime? CertificateDateExpires1 { get; set; }
        public string Certificate2 { get; set; }
        public DateTime? CertificateDateExpires2 { get; set; }
        public string Certificate3 { get; set; }
        public DateTime? CertificateDateExpires3 { get; set; }
        public string Certificate4 { get; set; }
        public DateTime? CertificateDateExpires4 { get; set; }
        public string Certificate5 { get; set; }
        public DateTime? CertificateDateExpires5 { get; set; }
        public string Address11099 { get; set; }
        public string Address21099 { get; set; }
        public string City1099 { get; set; }
        public string State1099 { get; set; }
        public string Country1099 { get; set; }
        public string ZipCode1099 { get; set; }
        public string PostalCodeFlag1099 { get; set; }
        public string ForeignPostalCode1099 { get; set; }
        public string Use1099Address { get; set; }
        public string DefaultTaxType { get; set; }
        public string DirectPayment { get; set; }
        public int? FederalIdEid { get; set; }
        public string DefaultFuelPo { get; set; }
        public string ExtensionNum { get; set; }

        public ApPayClasses ApPayClasses { get; set; }
        public ApShipTo ApShipTo { get; set; }
        public Edata FederalIdE { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Terms Terms { get; set; }
        public ICollection<Ap1099Div> Ap1099Div { get; set; }
        public ICollection<Ap1099Int> Ap1099Int { get; set; }
        public ICollection<Ap1099Misc> Ap1099Misc { get; set; }
        public ICollection<ApInvoiceH> ApInvoiceH { get; set; }
        public ICollection<ApInvoiceSubtierVendors> ApInvoiceSubtierVendors { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<BuyOutH> BuyOutH { get; set; }
        public ICollection<CashHistoryJournalD> CashHistoryJournalD { get; set; }
        public ICollection<DcFieldLogMaterials> DcFieldLogMaterials { get; set; }
        public ICollection<DcRfcBudgets> DcRfcBudgets { get; set; }
        public ICollection<Deductions> Deductions { get; set; }
        public ICollection<EmpDed> EmpDed { get; set; }
        public ICollection<FieldLogMaterials> FieldLogMaterials { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<HisMisc> HisMisc { get; set; }
        public ICollection<InventoryReceiptsH> InventoryReceiptsH { get; set; }
        public ICollection<ItemVendors> ItemVendors { get; set; }
        public ICollection<JobChgBudgets> JobChgBudgets { get; set; }
        public ICollection<JobScheduleTaskVendorResources> JobScheduleTaskVendorResources { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesVendors { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesVendors1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesVendorsNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsVendors { get; set; }
        public ICollection<MiscDocs> MiscDocsVendorsNavigation { get; set; }
        public ICollection<PayMisc> PayMisc { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<PoSubSubtierVendors> PoSubSubtierVendors { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesVendors { get; set; }
        public ICollection<RfcActivities> RfcActivitiesVendors1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesVendorsNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsVendors { get; set; }
        public ICollection<Rfcs> RfcsVendorsNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesVendors { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesVendors1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesVendorsNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisVendors { get; set; }
        public ICollection<Rfis> RfisVendorsNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesVendors { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesVendors1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesVendorsNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsVendors { get; set; }
        public ICollection<Rfps> RfpsVendorsNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesVendors { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesVendors1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesVendorsNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsVendors { get; set; }
        public ICollection<Submittals> SubmittalsVendorsNavigation { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesVendors { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesVendors1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesVendorsNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsVendors { get; set; }
        public ICollection<Transmittals> TransmittalsVendorsNavigation { get; set; }
        public ICollection<VendorAreas> VendorAreas { get; set; }
        public ICollection<VendorDirectPayments> VendorDirectPayments { get; set; }
        public ICollection<VendorDivisions> VendorDivisions { get; set; }
        public ICollection<VendorSupplies> VendorSupplies { get; set; }
    }
}
