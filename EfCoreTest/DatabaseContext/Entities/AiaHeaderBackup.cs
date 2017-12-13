using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AiaHeaderBackup
    {
        public AiaHeaderBackup()
        {
            AiaItemBackup = new HashSet<AiaItemBackup>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SectionNo { get; set; }
        public string ApplicationNo { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? BillingStartDate { get; set; }
        public DateTime? BillingEndDate { get; set; }
        public decimal PreviousCertificate { get; set; }
        public decimal PreviousRetainage { get; set; }
        public string InvoiceNo { get; set; }
        public int RowUniqueId { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RecordStatus { get; set; }
        public string CostCodeNo { get; set; }
        public string PhaseNo { get; set; }
        public DateTime PostDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal RetainagePercent { get; set; }
        public string TermsNo { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public string ArchProjectNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public string ContractDescription { get; set; }
        public string CountyOf { get; set; }
        public string CustomerNo { get; set; }
        public string G702Type { get; set; }
        public string IncomeTypeNo { get; set; }
        public string OwnerAddress1 { get; set; }
        public string OwnerAddress2 { get; set; }
        public string OwnerCity { get; set; }
        public string OwnerName { get; set; }
        public string OwnerState { get; set; }
        public string OwnerZipCode { get; set; }
        public string SignatureName { get; set; }
        public string SignatureTitle { get; set; }
        public string StateOf { get; set; }
        public string Status { get; set; }
        public string UseSections { get; set; }
        public string ViaArchitect { get; set; }
        public string ViaArchitectAddress1 { get; set; }
        public string ViaArchitectAddress2 { get; set; }
        public string ViaArchitectCity { get; set; }
        public string ViaArchitectState { get; set; }
        public string ViaArchitectZipCode { get; set; }
        public string ViaContructionManager { get; set; }
        public string AutoPostToAr { get; set; }
        public string ApplicationId { get; set; }
        public string ArchProjectId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string CustomerId { get; set; }
        public string IncomeTypeId { get; set; }
        public string InvoiceId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string SectionId { get; set; }
        public string TermsId { get; set; }
        public decimal RetainagePaidToEscrow { get; set; }
        public decimal RetainageDueToEscrow { get; set; }
        public string ProjectAddress1 { get; set; }
        public string ProjectAddress2 { get; set; }
        public string ProjectCity { get; set; }
        public string ProjectState { get; set; }
        public string ProjectZipCode { get; set; }

        public AiaHeader AiaHeader { get; set; }
        public ICollection<AiaItemBackup> AiaItemBackup { get; set; }
    }
}
