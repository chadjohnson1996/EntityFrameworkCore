using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlUp
    {
        public int CompanyNo { get; set; }
        public string AutoPostToAr { get; set; }
        public string EnableAutoPostBid { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal? GlAr { get; set; }
        public decimal? GlRetainage { get; set; }
        public string UpdateJcQuantity { get; set; }
        public string UnpostedQtyJrnlFlag { get; set; }
        public string SubReportBasis { get; set; }
        public int? DefaultDiv1 { get; set; }
        public int? DefaultDiv2 { get; set; }
        public int? DefaultDiv3 { get; set; }
        public int? DefaultDiv4 { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string UseArRetainage { get; set; }
        public string QtyExceedsBidFlag { get; set; }
        public string CompanyId { get; set; }
        public string QtyPaidExceedsBilled { get; set; }
        public string DefaultTrackQtyPaid { get; set; }
        public string DefaultMethodPayToQty { get; set; }
        public string PreventUnbalancedQtyPaid { get; set; }
        public string EnterMatLabUnitPrice { get; set; }
        public string TrackStoredMaterial { get; set; }
        public string DefaultSubmitToFrom { get; set; }
        public string DefaultReleaseRetFrom { get; set; }
        public string TermsNo { get; set; }
        public string TermsId { get; set; }
        public string ProtectQtyAndSub { get; set; }
        public string EnableAgencyDefaultUnitPrice { get; set; }

        public Accounts Accounts { get; set; }
        public Accounts Accounts1 { get; set; }
        public Accounts AccountsNavigation { get; set; }
        public Terms Terms { get; set; }
    }
}
