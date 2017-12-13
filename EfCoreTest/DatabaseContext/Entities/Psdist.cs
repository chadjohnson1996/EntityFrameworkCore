using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Psdist
    {
        public int PsDistId { get; set; }
        public string Guid { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyName { get; set; }
        public string SetType { get; set; }
        public string PoSubNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public string PsCoDescription { get; set; }
        public string VendorNo { get; set; }
        public string VendorName { get; set; }
        public string PoJobNo { get; set; }
        public string PoJobDescription { get; set; }
        public string PoPhaseNo { get; set; }
        public string PoPhaseDescription { get; set; }
        public string PoCostCodeNo { get; set; }
        public string PoCostCodeDescription { get; set; }
        public string PoCostClassNo { get; set; }
        public string PoCostClassDescription { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Invoiced { get; set; }
        public decimal? Paid { get; set; }
        public decimal? Retained { get; set; }
        public decimal? Remaining { get; set; }
    }
}
