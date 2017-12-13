using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApInvoiceFuelD
    {
        public int CompanyNo { get; set; }
        public int VoucherNo { get; set; }
        public int LineNo { get; set; }
        public string StorageTankNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public string EquipmentNo { get; set; }
        public string FuelTypeNo { get; set; }
        public string PostedFlag { get; set; }
        public string VoucherSource { get; set; }
        public string AdjustmentFlag { get; set; }
        public string DistributeTo { get; set; }
        public string TaxFlag { get; set; }
        public string DefaultFuelTypeFlag { get; set; }
        public string DefaultGlFlag { get; set; }
        public string DefaultDivFlag { get; set; }
        public string PrevAllocateFlag { get; set; }
        public string FuelAllocateReversedFlag { get; set; }
        public int? AdjustmentNo { get; set; }
        public decimal HoursMeter { get; set; }
        public decimal OdometerMeter { get; set; }
        public decimal OtherMeter { get; set; }
        public decimal InvoicedGallons { get; set; }
        public decimal InvoicedUnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public decimal? FuelReceiptGlExpense { get; set; }
        public int? FuelAllocateAuditNo { get; set; }
        public int? FuelAllocateRevAuditNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public decimal? FuelReceiptDivLevel1 { get; set; }
        public decimal? FuelReceiptDivLevel2 { get; set; }
        public decimal? FuelReceiptDivLevel3 { get; set; }
        public decimal? FuelReceiptDivLevel4 { get; set; }
        public decimal? FuelReceiptGlExpFull { get; set; }
        public DateTime? FuelAllocatePostDate { get; set; }
        public DateTime? FuelAllocateRevPostDate { get; set; }
        public decimal? Units { get; set; }
        public decimal HoursUnits { get; set; }
        public decimal OtherUnits { get; set; }
        public string AdjustmentId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EquipmentId { get; set; }
        public string FuelAllocateAuditId { get; set; }
        public string FuelAllocateRevAuditId { get; set; }
        public string FuelTypeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string StorageTankId { get; set; }
        public string VoucherId { get; set; }
        public string FuelEqCategoryNo { get; set; }
        public string ReversedFlag { get; set; }
        public string FuelEqCategoryId { get; set; }

        public ApInvoiceH ApInvoiceH { get; set; }
    }
}
