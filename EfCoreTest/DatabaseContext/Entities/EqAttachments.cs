using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqAttachments
    {
        public EqAttachments()
        {
            Employees = new HashSet<Employees>();
            EqAttachmentUsage = new HashSet<EqAttachmentUsage>();
            EqAttachmentsDivisions = new HashSet<EqAttachmentsDivisions>();
            EquipmentAttachments = new HashSet<EquipmentAttachments>();
        }

        public int CompanyNo { get; set; }
        public string AttachmentNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string EqCategoryNo { get; set; }
        public decimal? GlExpense { get; set; }
        public decimal? GlCredit { get; set; }
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
        public string AttachmentId { get; set; }
        public string CompanyId { get; set; }
        public string EqCategoryId { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public EqCategories EqCategories { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<EqAttachmentUsage> EqAttachmentUsage { get; set; }
        public ICollection<EqAttachmentsDivisions> EqAttachmentsDivisions { get; set; }
        public ICollection<EquipmentAttachments> EquipmentAttachments { get; set; }
    }
}
