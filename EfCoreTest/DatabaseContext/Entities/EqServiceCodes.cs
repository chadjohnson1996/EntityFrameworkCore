using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqServiceCodes
    {
        public EqServiceCodes()
        {
            ApInvoiceD = new HashSet<ApInvoiceD>();
            EqCategoriesSrv = new HashSet<EqCategoriesSrv>();
            EqExpenseHistory = new HashSet<EqExpenseHistory>();
            EqExpenseJournalD = new HashSet<EqExpenseJournalD>();
            EqExpenseJournalH = new HashSet<EqExpenseJournalH>();
            EqServiceCodesItems = new HashSet<EqServiceCodesItems>();
            EqServiceCodesNonInv = new HashSet<EqServiceCodesNonInv>();
            EqServiceCodesSupercede = new HashSet<EqServiceCodesSupercede>();
            EqSrvCodesDivExpJrnl = new HashSet<EqSrvCodesDivExpJrnl>();
            EqWo = new HashSet<EqWo>();
            EqWoLabor = new HashSet<EqWoLabor>();
            EqWoLaborD = new HashSet<EqWoLaborD>();
            EqWoService = new HashSet<EqWoService>();
            EquipmentService = new HashSet<EquipmentService>();
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string Description { get; set; }
        public string ExpenseGroupNo { get; set; }
        public string PrintStatus { get; set; }
        public decimal EstLaborHours { get; set; }
        public string AutoClose { get; set; }
        public string Comments { get; set; }
        public decimal MeterHours { get; set; }
        public decimal MeterMiles { get; set; }
        public decimal MeterOther { get; set; }
        public decimal UsageHours { get; set; }
        public string Daily { get; set; }
        public string Weekly { get; set; }
        public string Monthly { get; set; }
        public string Annual { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfWeeks { get; set; }
        public int NoOfMonths { get; set; }
        public int NoOfYears { get; set; }
        public string CompanyId { get; set; }
        public string ServiceCodeId { get; set; }
        public string ExpenseGroupId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ExpenseType { get; set; }
        public decimal? GlExpJrnlDebit { get; set; }
        public decimal? GlExpJrnlCredit { get; set; }
        public string ActivityToCreate { get; set; }
        public string DefaultAutoGrouping { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public EqExpenseGroups EqExpenseGroups { get; set; }
        public ICollection<ApInvoiceD> ApInvoiceD { get; set; }
        public ICollection<EqCategoriesSrv> EqCategoriesSrv { get; set; }
        public ICollection<EqExpenseHistory> EqExpenseHistory { get; set; }
        public ICollection<EqExpenseJournalD> EqExpenseJournalD { get; set; }
        public ICollection<EqExpenseJournalH> EqExpenseJournalH { get; set; }
        public ICollection<EqServiceCodesItems> EqServiceCodesItems { get; set; }
        public ICollection<EqServiceCodesNonInv> EqServiceCodesNonInv { get; set; }
        public ICollection<EqServiceCodesSupercede> EqServiceCodesSupercede { get; set; }
        public ICollection<EqSrvCodesDivExpJrnl> EqSrvCodesDivExpJrnl { get; set; }
        public ICollection<EqWo> EqWo { get; set; }
        public ICollection<EqWoLabor> EqWoLabor { get; set; }
        public ICollection<EqWoLaborD> EqWoLaborD { get; set; }
        public ICollection<EqWoService> EqWoService { get; set; }
        public ICollection<EquipmentService> EquipmentService { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
