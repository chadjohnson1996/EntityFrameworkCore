using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BidD
    {
        public BidD()
        {
            EstimatD = new HashSet<EstimatD>();
            QtyPaidJournalD = new HashSet<QtyPaidJournalD>();
            QuantityUpdateD = new HashSet<QuantityUpdateD>();
        }

        public int CompanyNo { get; set; }
        public string BidNo { get; set; }
        public int SequenceNo { get; set; }
        public int OrdinalPosition { get; set; }
        public int NestingLevel { get; set; }
        public string RowType { get; set; }
        public string ItemType { get; set; }
        public DateTime? ChangeOrderDate { get; set; }
        public string AgencyLineNo { get; set; }
        public string ItemReference { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice { get; set; }
        public decimal RetainagePercent { get; set; }
        public string VendorNo { get; set; }
        public decimal UnitCost { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DisableFlag { get; set; }
        public string AgencyLineId { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string SequenceId { get; set; }
        public string UnitId { get; set; }
        public string VendorId { get; set; }
        public decimal MatUnitPrice { get; set; }
        public decimal LabEqpUnitPrice { get; set; }
        public decimal? GlIncome { get; set; }
        public int? GlIncomeDiv1 { get; set; }
        public int? GlIncomeDiv2 { get; set; }
        public int? GlIncomeDiv3 { get; set; }
        public int? GlIncomeDiv4 { get; set; }
        public string UseRetainage { get; set; }

        public BidH BidH { get; set; }
        public CostCodes Co { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public Units Units { get; set; }
        public Vendors Vendors { get; set; }
        public ICollection<EstimatD> EstimatD { get; set; }
        public ICollection<QtyPaidJournalD> QtyPaidJournalD { get; set; }
        public ICollection<QuantityUpdateD> QuantityUpdateD { get; set; }
    }
}
