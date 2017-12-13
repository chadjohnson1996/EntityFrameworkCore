using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobTrx
    {
        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string JobTrxType { get; set; }
        public string TradeNo { get; set; }
        public string EarnTypeNo { get; set; }
        public DateTime? DateBooked { get; set; }
        public decimal? AccountWip { get; set; }
        public decimal? AccountCr { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Units { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? JtdUnits { get; set; }
        public decimal? JtdQuantity { get; set; }
        public decimal? JtdPercent { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? UnitCost { get; set; }
        public string ItemNo { get; set; }
        public string WarehouseNo { get; set; }
        public int? VoucherNo { get; set; }
        public string Comments { get; set; }
        public string OverheadPost { get; set; }
        public string MultiType { get; set; }
        public string PtdOrJtd { get; set; }
        public string SingleMulti { get; set; }
        public string CostCodeMethod { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public string VendorNo { get; set; }
        public string ModuleFrom { get; set; }
        public string EquipmentNo { get; set; }
        public string UsageType { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string EmployeeNo { get; set; }
        public string ArInvoiceNo { get; set; }
        public string OpInvoiceNo { get; set; }
        public string TmInvoiceNo { get; set; }
        public int? CashTrxNo { get; set; }
        public int? JobTrxNo { get; set; }
        public int? EqpTrxNo { get; set; }
        public string PostFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UnitNo { get; set; }
        public decimal InventoryQuantity { get; set; }
        public string ArInvoiceId { get; set; }
        public string CashTrxId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EarnTypeId { get; set; }
        public string EmployeeId { get; set; }
        public string EqpTrxId { get; set; }
        public string EquipmentId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string JobTrxId { get; set; }
        public string LineId { get; set; }
        public string OpInvoiceId { get; set; }
        public string PhaseId { get; set; }
        public string TmInvoiceId { get; set; }
        public string TradeId { get; set; }
        public string TransactionId { get; set; }
        public string UnitId { get; set; }
        public string VendorId { get; set; }
        public string VoucherId { get; set; }
        public string WarehouseId { get; set; }
        public int? QtyUpdTrxNo { get; set; }
        public int? QtyUpdSeqNo { get; set; }
        public string QtyUpdSeqId { get; set; }
        public string QtyUpdTrxId { get; set; }

        public Items Items { get; set; }
        public JobTrxHdr JobTrxHdr { get; set; }
        public Jobs Jobs { get; set; }
        public Units UnitsNavigation { get; set; }
    }
}
