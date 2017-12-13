using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class PendingJobQuantity
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public DateTime Date { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public string Notes { get; set; }
        public string MdUser { get; set; }
        public string JobQtyCreated { get; set; }
        public int? JobTrxRowUniqueId { get; set; }
        public string RecordStatus { get; set; }
        public string RowCreatedBy { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string PhaseId { get; set; }
        public string UnitId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
    }
}
