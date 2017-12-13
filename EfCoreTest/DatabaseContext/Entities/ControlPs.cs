using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlPs
    {
        public int CompanyNo { get; set; }
        public string DefaultRetainagePercent { get; set; }
        public string RequirePsOnInvoice { get; set; }
        public string VerifyInvoiceAmount { get; set; }
        public string VerifyDistributions { get; set; }
        public string InvoiceChgOrdAgainst { get; set; }
        public string DefaultVendorToInvoice { get; set; }
        public string DefaultJobToInvoice { get; set; }
        public string DefaultAmountToInvoice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DefaultUnitCost1 { get; set; }
        public string DefaultUnitCost2 { get; set; }
        public string DefaultUnitCost3 { get; set; }
        public string DefaultUnitCost4 { get; set; }
        public string DefaultUnitCost5 { get; set; }
        public string DefaultUnitCost6 { get; set; }
        public string CompanyId { get; set; }
        public string DefaultPoPrintable { get; set; }
        public string DefaultPoHeaderFormat { get; set; }
        public string DefaultSubHeaderFormat { get; set; }
        public string DefaultPoBodyFormat { get; set; }
        public string DefaultSubBodyFormat { get; set; }
        public string DefaultType { get; set; }
        public string EnablePoVerifyChoice { get; set; }
        public string PoFormat { get; set; }
        public int? PoDetailDesignNo { get; set; }
        public int? PoBasicDesignNo { get; set; }
        public string SubFormat { get; set; }
        public int? SubDetailDesignNo { get; set; }
        public int? SubBasicDesignNo { get; set; }
        public string DefaultItemDistFromPrev { get; set; }
        public string ConcatJobWithPo { get; set; }
        public string VerifyVendorOnBuyOut { get; set; }
        public string VerifyItemOnBuyOut { get; set; }
        public string BuyOutUnitCostOverride { get; set; }
        public string PoBasicDesignId { get; set; }
        public string PoDetailDesignId { get; set; }
        public string SubBasicDesignId { get; set; }
        public string SubDetailDesignId { get; set; }
        public string EnableFixedFormatPoImport { get; set; }
        public string ManPo { get; set; }
        public string DefaultDistToInvoice { get; set; }
        public string DefaultVendorItemDesc { get; set; }
        public decimal AllowPoExceedInvoicePercent { get; set; }
        public string VerifyDistVsJobBudget { get; set; }
        public string CloseFullyInvoiceDetail { get; set; }
        public string DefaultShippingAddr { get; set; }
        public string DefaultSeqGlExpense { get; set; }
        public string PoImportFormatType { get; set; }
        public string PrintPoTitleFlag { get; set; }
        public string PreviewFloatSummary { get; set; }
        public string PreviewHeaderFirstpg { get; set; }
        public string DefaultCoDate { get; set; }
        public string PoSubDropdownFilter { get; set; }
        public string OpenPoAsPending { get; set; }
        public DateTime? PsFilterDate { get; set; }
        public int? DefaultPoBasicWpDesignNo { get; set; }
        public int? DefaultPoDetailWpDesignNo { get; set; }
        public int? DefaultSubBasicWpDesignNo { get; set; }
        public int? DefaultSubDetailWpDesignNo { get; set; }
        public string DefaultPoBasicWpDesignId { get; set; }
        public string DefaultPoDetailWpDesignId { get; set; }
        public string DefaultSubBasicWpDesignId { get; set; }
        public string DefaultSubDetailWpDesignId { get; set; }
        public string DefaultPoDate { get; set; }
        public string ChangeOrderPendingFlag { get; set; }
    }
}
