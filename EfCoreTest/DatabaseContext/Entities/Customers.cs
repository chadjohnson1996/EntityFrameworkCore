using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            AiaHeader = new HashSet<AiaHeader>();
            ArCash = new HashSet<ArCash>();
            ArInvoice = new HashSet<ArInvoice>();
            BidH = new HashSet<BidH>();
            CustomerAreas = new HashSet<CustomerAreas>();
            CustomerCategories = new HashSet<CustomerCategories>();
            CustomerPriceLevels = new HashSet<CustomerPriceLevels>();
            CustomerSupplies = new HashSet<CustomerSupplies>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            Jobs = new HashSet<Jobs>();
            MeetingAgendaAttendees = new HashSet<MeetingAgendaAttendees>();
            MiscDocActivitiesCustomers = new HashSet<MiscDocActivities>();
            MiscDocActivitiesCustomers1 = new HashSet<MiscDocActivities>();
            MiscDocActivitiesCustomersNavigation = new HashSet<MiscDocActivities>();
            MiscDocRecipients = new HashSet<MiscDocRecipients>();
            MiscDocsCustomers = new HashSet<MiscDocs>();
            MiscDocsCustomersNavigation = new HashSet<MiscDocs>();
            PunchListItems = new HashSet<PunchListItems>();
            RfcActivitiesCustomers = new HashSet<RfcActivities>();
            RfcActivitiesCustomers1 = new HashSet<RfcActivities>();
            RfcActivitiesCustomersNavigation = new HashSet<RfcActivities>();
            RfcRecipients = new HashSet<RfcRecipients>();
            RfcsCustomers = new HashSet<Rfcs>();
            RfcsCustomersNavigation = new HashSet<Rfcs>();
            RfiQuestionActivitiesCustomers = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesCustomers1 = new HashSet<RfiQuestionActivities>();
            RfiQuestionActivitiesCustomersNavigation = new HashSet<RfiQuestionActivities>();
            RfiRecipients = new HashSet<RfiRecipients>();
            RfisCustomers = new HashSet<Rfis>();
            RfisCustomersNavigation = new HashSet<Rfis>();
            RfpItemActivitiesCustomers = new HashSet<RfpItemActivities>();
            RfpItemActivitiesCustomers1 = new HashSet<RfpItemActivities>();
            RfpItemActivitiesCustomersNavigation = new HashSet<RfpItemActivities>();
            RfpRecipients = new HashSet<RfpRecipients>();
            RfpsCustomers = new HashSet<Rfps>();
            RfpsCustomersNavigation = new HashSet<Rfps>();
            SubmittalItemActivitiesCustomers = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesCustomers1 = new HashSet<SubmittalItemActivities>();
            SubmittalItemActivitiesCustomersNavigation = new HashSet<SubmittalItemActivities>();
            SubmittalRecipients = new HashSet<SubmittalRecipients>();
            SubmittalsCustomers = new HashSet<Submittals>();
            SubmittalsCustomersNavigation = new HashSet<Submittals>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmWorksheetH = new HashSet<TmWorksheetH>();
            TransmittalActivitiesCustomers = new HashSet<TransmittalActivities>();
            TransmittalActivitiesCustomers1 = new HashSet<TransmittalActivities>();
            TransmittalActivitiesCustomersNavigation = new HashSet<TransmittalActivities>();
            TransmittalRecipients = new HashSet<TransmittalRecipients>();
            TransmittalsCustomers = new HashSet<Transmittals>();
            TransmittalsCustomersNavigation = new HashSet<Transmittals>();
        }

        public int CompanyNo { get; set; }
        public string CustomerNo { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public string CustomerType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Contact { get; set; }
        public string PhoneVoice { get; set; }
        public string PhoneFax { get; set; }
        public string PhoneData { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal? GlCash { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public decimal? GlTax { get; set; }
        public string ForceJob { get; set; }
        public string OnAccount { get; set; }
        public decimal? GlServiceInc { get; set; }
        public string OrderStatus { get; set; }
        public string ShipToNo { get; set; }
        public string TaxNo { get; set; }
        public string TermsNo { get; set; }
        public string ShipViaNo { get; set; }
        public string WarehouseNo { get; set; }
        public string InvoiceFreight { get; set; }
        public string SbPriceLevelNo { get; set; }
        public decimal? BillingRate { get; set; }
        public decimal? MileageRate { get; set; }
        public string BillingCycleNo { get; set; }
        public string BypassServiceCharge { get; set; }
        public string TaxPrNo { get; set; }
        public string PriceLevelNo { get; set; }
        public string TmIncomeTypeNo { get; set; }
        public string RentShowClosed { get; set; }
        public decimal? RentNumberDays { get; set; }
        public DateTime? ClientSince { get; set; }
        public decimal? CreditLimit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string EmailAddress { get; set; }
        public string ProjectManagerNo { get; set; }
        public string GeoAreaNo { get; set; }
        public string ProjectClassNo { get; set; }
        public string Provider { get; set; }
        public string BillingCycleId { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string GeoAreaId { get; set; }
        public string PriceLevelId { get; set; }
        public string ProjectClassId { get; set; }
        public string ProjectManagerId { get; set; }
        public string SbPriceLevelId { get; set; }
        public string ShipToId { get; set; }
        public string ShipViaId { get; set; }
        public string TaxId { get; set; }
        public string TaxPrId { get; set; }
        public string TermsId { get; set; }
        public string TmIncomeTypeId { get; set; }
        public string WarehouseId { get; set; }
        public int? TmBillingDesignNo { get; set; }
        public string TmBillingDesignId { get; set; }
        public string InvUsageMarkup { get; set; }
        public string TmRounding { get; set; }
        public string DefaultTaxType { get; set; }
        public string EnableServiceCharge { get; set; }
        public string SrvChrgUseCustomer { get; set; }
        public decimal SrvChrgPercent { get; set; }
        public decimal SrvChrgPastDue { get; set; }
        public string SrvChrgPercDollar { get; set; }
        public string SrvChrgInvAcct { get; set; }
        public string CertifiedLicense { get; set; }
        public string IncomeTypeNo { get; set; }
        public string IncomeTypeId { get; set; }
        public string ForeignFlag { get; set; }
        public string Country { get; set; }
        public int? InvoiceDesignNo { get; set; }
        public string InvoiceDesignId { get; set; }
        public string HoldFlag { get; set; }
        public string AiaRounding { get; set; }
        public string AiaWholeDollars { get; set; }
        public string TmTaxNo { get; set; }
        public string TmTaxType { get; set; }
        public string TmTaxId { get; set; }
        public string IncludeInStatements { get; set; }
        public int? TmWsDesignNo { get; set; }
        public string TmWsDesignId { get; set; }
        public string ExtensionNum { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts Accounts3 { get; set; }
        public Accounts Accounts4 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public ArBillingCycles ArBillingCycles { get; set; }
        public IncomeTypes IncomeTypes { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public PriceLevels PriceLevelsNavigation { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public ShipTo ShipTo { get; set; }
        public ShipVia ShipVia { get; set; }
        public TaxGroups TaxGroups { get; set; }
        public Terms Terms { get; set; }
        public DsgDesigns TmBillingDesignNoNavigation { get; set; }
        public Warehouses Warehouses { get; set; }
        public TmMarkupCustomerH TmMarkupCustomerH { get; set; }
        public ICollection<AiaHeader> AiaHeader { get; set; }
        public ICollection<ArCash> ArCash { get; set; }
        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<BidH> BidH { get; set; }
        public ICollection<CustomerAreas> CustomerAreas { get; set; }
        public ICollection<CustomerCategories> CustomerCategories { get; set; }
        public ICollection<CustomerPriceLevels> CustomerPriceLevels { get; set; }
        public ICollection<CustomerSupplies> CustomerSupplies { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<MeetingAgendaAttendees> MeetingAgendaAttendees { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesCustomers { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesCustomers1 { get; set; }
        public ICollection<MiscDocActivities> MiscDocActivitiesCustomersNavigation { get; set; }
        public ICollection<MiscDocRecipients> MiscDocRecipients { get; set; }
        public ICollection<MiscDocs> MiscDocsCustomers { get; set; }
        public ICollection<MiscDocs> MiscDocsCustomersNavigation { get; set; }
        public ICollection<PunchListItems> PunchListItems { get; set; }
        public ICollection<RfcActivities> RfcActivitiesCustomers { get; set; }
        public ICollection<RfcActivities> RfcActivitiesCustomers1 { get; set; }
        public ICollection<RfcActivities> RfcActivitiesCustomersNavigation { get; set; }
        public ICollection<RfcRecipients> RfcRecipients { get; set; }
        public ICollection<Rfcs> RfcsCustomers { get; set; }
        public ICollection<Rfcs> RfcsCustomersNavigation { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesCustomers { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesCustomers1 { get; set; }
        public ICollection<RfiQuestionActivities> RfiQuestionActivitiesCustomersNavigation { get; set; }
        public ICollection<RfiRecipients> RfiRecipients { get; set; }
        public ICollection<Rfis> RfisCustomers { get; set; }
        public ICollection<Rfis> RfisCustomersNavigation { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesCustomers { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesCustomers1 { get; set; }
        public ICollection<RfpItemActivities> RfpItemActivitiesCustomersNavigation { get; set; }
        public ICollection<RfpRecipients> RfpRecipients { get; set; }
        public ICollection<Rfps> RfpsCustomers { get; set; }
        public ICollection<Rfps> RfpsCustomersNavigation { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesCustomers { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesCustomers1 { get; set; }
        public ICollection<SubmittalItemActivities> SubmittalItemActivitiesCustomersNavigation { get; set; }
        public ICollection<SubmittalRecipients> SubmittalRecipients { get; set; }
        public ICollection<Submittals> SubmittalsCustomers { get; set; }
        public ICollection<Submittals> SubmittalsCustomersNavigation { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmWorksheetH> TmWorksheetH { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesCustomers { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesCustomers1 { get; set; }
        public ICollection<TransmittalActivities> TransmittalActivitiesCustomersNavigation { get; set; }
        public ICollection<TransmittalRecipients> TransmittalRecipients { get; set; }
        public ICollection<Transmittals> TransmittalsCustomers { get; set; }
        public ICollection<Transmittals> TransmittalsCustomersNavigation { get; set; }
    }
}
