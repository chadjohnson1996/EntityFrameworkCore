using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Trades
    {
        public Trades()
        {
            DcFieldLogOnSiteLabor = new HashSet<DcFieldLogOnSiteLabor>();
            Employees = new HashSet<Employees>();
            JobHistoryPrBrdDtl = new HashSet<JobHistoryPrBrdDtl>();
            JobScheduleTaskTradeResources = new HashSet<JobScheduleTaskTradeResources>();
            JobTrades = new HashSet<JobTrades>();
            TimeCards = new HashSet<TimeCards>();
            TmInvoiceD = new HashSet<TmInvoiceD>();
            TmMarkupCompanyD = new HashSet<TmMarkupCompanyD>();
            TmMarkupCustomerD = new HashSet<TmMarkupCustomerD>();
            TmMarkupJobD = new HashSet<TmMarkupJobD>();
            TmWorksheetD = new HashSet<TmWorksheetD>();
            TradeBurdens = new HashSet<TradeBurdens>();
            TradesCrl = new HashSet<TradesCrl>();
            WcTrades = new HashSet<WcTrades>();
        }

        public int CompanyNo { get; set; }
        public string TradeNo { get; set; }
        public string Description { get; set; }
        public string MinorityGroupNo { get; set; }
        public string ApprenticeTrainee { get; set; }
        public string WcClassNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MinorityGroupId { get; set; }
        public string TradeId { get; set; }
        public string WcClassId { get; set; }
        public decimal? ApprenticeRatePerc { get; set; }
        public string WorkClassification { get; set; }
        public int? JobClassification { get; set; }
        public string WageDecisionNo { get; set; }
        public string WageDecisionId { get; set; }
        public string Category { get; set; }
        public string ConstructionType { get; set; }

        public ICollection<DcFieldLogOnSiteLabor> DcFieldLogOnSiteLabor { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<JobHistoryPrBrdDtl> JobHistoryPrBrdDtl { get; set; }
        public ICollection<JobScheduleTaskTradeResources> JobScheduleTaskTradeResources { get; set; }
        public ICollection<JobTrades> JobTrades { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TmInvoiceD> TmInvoiceD { get; set; }
        public ICollection<TmMarkupCompanyD> TmMarkupCompanyD { get; set; }
        public ICollection<TmMarkupCustomerD> TmMarkupCustomerD { get; set; }
        public ICollection<TmMarkupJobD> TmMarkupJobD { get; set; }
        public ICollection<TmWorksheetD> TmWorksheetD { get; set; }
        public ICollection<TradeBurdens> TradeBurdens { get; set; }
        public ICollection<TradesCrl> TradesCrl { get; set; }
        public ICollection<WcTrades> WcTrades { get; set; }
    }
}
