using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWo
    {
        public EqWo()
        {
            ApInvoiceD = new HashSet<ApInvoiceD>();
            EqWoItems = new HashSet<EqWoItems>();
            EqWoItemsD = new HashSet<EqWoItemsD>();
            EqWoItemsUsed = new HashSet<EqWoItemsUsed>();
            EqWoJournal = new HashSet<EqWoJournal>();
            EqWoLabor = new HashSet<EqWoLabor>();
            EqWoLaborD = new HashSet<EqWoLaborD>();
            EqWoNonInv = new HashSet<EqWoNonInv>();
            EqWoService = new HashSet<EqWoService>();
            InventoryActivityH = new HashSet<InventoryActivityH>();
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public string EquipmentNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime WoDate { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Comments { get; set; }
        public decimal EstLaborHours { get; set; }
        public string PrintStatus { get; set; }
        public string EmployeeNo { get; set; }
        public decimal HoursMeterBalance { get; set; }
        public decimal OdometerMeterBalance { get; set; }
        public decimal OtherMeterBalance { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string EqWoId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public int? ApVoucherNo { get; set; }
        public string PrAutoGen { get; set; }
        public string ApVoucherId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? DeliveryTime { get; set; }
        public string DeliveryTimeType { get; set; }
        public DateTime? DeliveryTimeMilitary { get; set; }
        public int? ReceiptTransactionNo { get; set; }
        public string ReceiptTransactionId { get; set; }
        public int? PrAuditNo { get; set; }
        public int? ApAuditNo { get; set; }
        public int? InAuditNo { get; set; }
        public string ApAuditId { get; set; }
        public string InAuditId { get; set; }
        public string PrAuditId { get; set; }

        public Employees Employees { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public Equipment Equipment { get; set; }
        public ICollection<ApInvoiceD> ApInvoiceD { get; set; }
        public ICollection<EqWoItems> EqWoItems { get; set; }
        public ICollection<EqWoItemsD> EqWoItemsD { get; set; }
        public ICollection<EqWoItemsUsed> EqWoItemsUsed { get; set; }
        public ICollection<EqWoJournal> EqWoJournal { get; set; }
        public ICollection<EqWoLabor> EqWoLabor { get; set; }
        public ICollection<EqWoLaborD> EqWoLaborD { get; set; }
        public ICollection<EqWoNonInv> EqWoNonInv { get; set; }
        public ICollection<EqWoService> EqWoService { get; set; }
        public ICollection<InventoryActivityH> InventoryActivityH { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
