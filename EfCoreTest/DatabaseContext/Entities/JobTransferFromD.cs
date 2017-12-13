using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobTransferFromD
    {
        public JobTransferFromD()
        {
            JobTransferToD = new HashSet<JobTransferToD>();
        }

        public int CompanyNo { get; set; }
        public int TransactionNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public decimal Amount { get; set; }
        public decimal Units { get; set; }
        public string JobNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string TaxNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string TaxId { get; set; }
        public string TransactionId { get; set; }
        public string TaxByEffdateFlag { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? StateTaxPercent { get; set; }
        public decimal? LocalTaxPercent { get; set; }
        public decimal? OtherTaxPercent { get; set; }

        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public JobTransferH JobTransferH { get; set; }
        public Jobs Jobs { get; set; }
        public Phases Phases { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public ICollection<JobTransferToD> JobTransferToD { get; set; }
    }
}
