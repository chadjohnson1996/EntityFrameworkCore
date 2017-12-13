using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Equipment
    {
        public Equipment()
        {
            ArInvoiceEq = new HashSet<ArInvoiceEq>();
            AssetBooks = new HashSet<AssetBooks>();
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            DeprJournalD = new HashSet<DeprJournalD>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqExpenseJournalH = new HashSet<EqExpenseJournalH>();
            EqJobUsageRatesDetail = new HashSet<EqJobUsageRatesDetail>();
            EqLocationTransferD = new HashSet<EqLocationTransferD>();
            EqLocationTransferH = new HashSet<EqLocationTransferH>();
            EqMeterJournalD = new HashSet<EqMeterJournalD>();
            EqUsage = new HashSet<EqUsage>();
            EqWo = new HashSet<EqWo>();
            EquipmentAttachments = new HashSet<EquipmentAttachments>();
            EquipmentDivisions = new HashSet<EquipmentDivisions>();
            EquipmentFuelDivisions = new HashSet<EquipmentFuelDivisions>();
            EquipmentLocations = new HashSet<EquipmentLocations>();
            EquipmentMeterLogD = new HashSet<EquipmentMeterLogD>();
            EquipmentService = new HashSet<EquipmentService>();
            FieldLogEquipment = new HashSet<FieldLogEquipment>();
            FuelUsage = new HashSet<FuelUsage>();
            JobHistory = new HashSet<JobHistory>();
            JobScheduleTaskEquipmentResources = new HashSet<JobScheduleTaskEquipmentResources>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmInvoiceEq = new HashSet<TmInvoiceEq>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
        }

        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string EqCategoryNo { get; set; }
        public string SecondaryEqCategoryNo { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlCredit { get; set; }
        public string LicensePlateNo { get; set; }
        public decimal LicenseFee { get; set; }
        public DateTime? LicenseExpiration { get; set; }
        public string Manufacturer { get; set; }
        public string Distributor { get; set; }
        public string SerialNumber { get; set; }
        public string MakeModel { get; set; }
        public decimal? ModelYear { get; set; }
        public string Ownership { get; set; }
        public string NewOrUsed { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal SalePrice { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal InsuredValue { get; set; }
        public decimal MarketValue { get; set; }
        public string Axles { get; set; }
        public string CommercialOrPrivate { get; set; }
        public decimal GrossWeight { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public string WarrantyCoverage { get; set; }
        public string WarrantyLimitations { get; set; }
        public string WarrantyCompany { get; set; }
        public string WarrantyAddress1 { get; set; }
        public string WarrantyAddress2 { get; set; }
        public string WarrantyCity { get; set; }
        public string WarrantyState { get; set; }
        public string WarrantyZip { get; set; }
        public string WarrantyContact1 { get; set; }
        public string WarrantyContact2 { get; set; }
        public decimal DefaultHourlyRate { get; set; }
        public decimal DefaultDailyRate { get; set; }
        public decimal DefaultWeeklyRate { get; set; }
        public decimal DefaultMonthlyRate { get; set; }
        public decimal DefaultIdleRate { get; set; }
        public decimal DefaultDownRate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EqCategoryId { get; set; }
        public string EquipmentId { get; set; }
        public string LicensePlateId { get; set; }
        public string SecondaryEqCategoryId { get; set; }
        public string MeterType { get; set; }
        public string ServiceCodeNo { get; set; }
        public decimal DefaultBillingRate { get; set; }
        public string ServiceCodeId { get; set; }
        public string DefaultLocationJobNo { get; set; }
        public string DefaultWoJobNo { get; set; }
        public string DefaultLocationJobId { get; set; }
        public string DefaultWoJobId { get; set; }
        public string TrackAssetIn { get; set; }
        public string AssetCategoryNo { get; set; }
        public decimal SalvageValue { get; set; }
        public string PptAssetCategory { get; set; }
        public string PptPercentCode { get; set; }
        public decimal? GlAccumDepr { get; set; }
        public decimal? GlDeprExpense { get; set; }
        public string AssetCategoryId { get; set; }
        public string CrewNo { get; set; }
        public string CrewId { get; set; }
        public string FuelTypeNo { get; set; }
        public decimal FuelCapacity { get; set; }
        public decimal? GlFuelExpense { get; set; }
        public decimal? GlFuelCredit { get; set; }
        public string ConsumptionType { get; set; }
        public string EnableFuelTrackingFlag { get; set; }
        public string FuelJobNo { get; set; }
        public string FuelPhaseNo { get; set; }
        public string FuelCostCodeNo { get; set; }
        public string FuelCostClassNo { get; set; }
        public string FuelCostClassId { get; set; }
        public string FuelCostCodeId { get; set; }
        public string FuelJobId { get; set; }
        public string FuelPhaseId { get; set; }
        public string FuelTypeId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts Accounts2 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public AssetCategories AssetCategories { get; set; }
        public DeprMethods DeprMethods { get; set; }
        public EqCategories EqCategories { get; set; }
        public EqCategories EqCategoriesNavigation { get; set; }
        public FuelTypes FuelTypes { get; set; }
        public Jobs Jobs { get; set; }
        public Jobs JobsNavigation { get; set; }
        public EquipmentMeterLogH EquipmentMeterLogH { get; set; }
        public ICollection<ArInvoiceEq> ArInvoiceEq { get; set; }
        public ICollection<AssetBooks> AssetBooks { get; set; }
        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<DeprJournalD> DeprJournalD { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqExpenseJournalH> EqExpenseJournalH { get; set; }
        public ICollection<EqJobUsageRatesDetail> EqJobUsageRatesDetail { get; set; }
        public ICollection<EqLocationTransferD> EqLocationTransferD { get; set; }
        public ICollection<EqLocationTransferH> EqLocationTransferH { get; set; }
        public ICollection<EqMeterJournalD> EqMeterJournalD { get; set; }
        public ICollection<EqUsage> EqUsage { get; set; }
        public ICollection<EqWo> EqWo { get; set; }
        public ICollection<EquipmentAttachments> EquipmentAttachments { get; set; }
        public ICollection<EquipmentDivisions> EquipmentDivisions { get; set; }
        public ICollection<EquipmentFuelDivisions> EquipmentFuelDivisions { get; set; }
        public ICollection<EquipmentLocations> EquipmentLocations { get; set; }
        public ICollection<EquipmentMeterLogD> EquipmentMeterLogD { get; set; }
        public ICollection<EquipmentService> EquipmentService { get; set; }
        public ICollection<FieldLogEquipment> FieldLogEquipment { get; set; }
        public ICollection<FuelUsage> FuelUsage { get; set; }
        public ICollection<JobHistory> JobHistory { get; set; }
        public ICollection<JobScheduleTaskEquipmentResources> JobScheduleTaskEquipmentResources { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmInvoiceEq> TmInvoiceEq { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
    }
}
