using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdUserSpecifiedDispatchPrBillings
    {
        public int CompanyNo { get; set; }
        public string SpecifiedNo { get; set; }
        public int SequenceNumber { get; set; }
        public string PayrollImported { get; set; }
        public decimal PrHours { get; set; }
        public DateTime? PrDate { get; set; }
        public string EmployeeNo { get; set; }
        public string EarnCode { get; set; }
        public string AdditionalEarnCode { get; set; }
        public int? TechnicianNo { get; set; }
        public decimal? BilledHours { get; set; }
        public string PrPhaseNo { get; set; }
        public string PrCostCodeNo { get; set; }
        public decimal PrAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int? RowUniqueId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int? TimeCardsRowUniqueId { get; set; }
        public string ShiftNo { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string PrCostCodeId { get; set; }
        public string PrPhaseId { get; set; }
        public string ShiftId { get; set; }
        public string SpecifiedId { get; set; }
        public string TechnicianId { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public CostCodes CostCodes { get; set; }
        public EarnTypes EarnTypes { get; set; }
        public Employees Employees { get; set; }
        public Phases Phases { get; set; }
        public SdUserSpecifiedDispatch SdUserSpecifiedDispatch { get; set; }
        public Shifts Shifts { get; set; }
        public SdTechnicians TechnicianNoNavigation { get; set; }
    }
}
