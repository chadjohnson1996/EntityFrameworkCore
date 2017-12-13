using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArBankDeposit
    {
        public ArBankDeposit()
        {
            GlDepositHistory = new HashSet<GlDepositHistory>();
            GlHistory = new HashSet<GlHistory>();
        }

        public int CompanyNo { get; set; }
        public int DepositNo { get; set; }
        public DateTime? DepositDate { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal GlCash { get; set; }
        public string PostedFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DepositId { get; set; }
        public string PrintStatus { get; set; }
        public decimal? DivLevel1 { get; set; }
        public decimal? DivLevel2 { get; set; }
        public decimal? DivLevel3 { get; set; }
        public decimal? DivLevel4 { get; set; }

        public Accounts Accounts { get; set; }
        public ICollection<GlDepositHistory> GlDepositHistory { get; set; }
        public ICollection<GlHistory> GlHistory { get; set; }
    }
}
