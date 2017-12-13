using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AccountsMicr
    {
        public int CompanyNo { get; set; }
        public decimal AccountNo { get; set; }
        public string MicrRoutingNo { get; set; }
        public int? MicrRoutingNoEid { get; set; }
        public string MicrField1 { get; set; }
        public string MicrField2 { get; set; }
        public string MicrField3 { get; set; }
        public string RoutingA { get; set; }
        public string RoutingB { get; set; }
        public string RoutingC { get; set; }
        public int? RoutingAEid { get; set; }
        public int? RoutingBEid { get; set; }
        public int? RoutingCEid { get; set; }
        public byte[] Signature1 { get; set; }
        public byte[] Signature2 { get; set; }
        public string Signature1Filetype { get; set; }
        public string Signature2Filetype { get; set; }
        public byte[] CompanyLogo { get; set; }
        public string CompanyLogoFiletype { get; set; }
        public string MicrPrint1 { get; set; }
        public string MicrPrint2 { get; set; }
        public string MicrPrint3 { get; set; }
        public int? MicrPrint1Eid { get; set; }
        public int? MicrPrint2Eid { get; set; }
        public int? MicrPrint3Eid { get; set; }
        public string MicrCompany1 { get; set; }
        public string MicrCompany2 { get; set; }
        public string MicrCompany3 { get; set; }
        public string MicrCompany4 { get; set; }
        public string MicrCompany5 { get; set; }
        public string MicrBank1 { get; set; }
        public string MicrBank2 { get; set; }
        public string MicrCheckInfo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string MicrBank3 { get; set; }
        public string MicrBank4 { get; set; }
        public string MicrCheckInfo2 { get; set; }
        public string AccountId { get; set; }
        public string CompanyId { get; set; }
        public string MicrRoutingId { get; set; }
        public string OversizedLogo { get; set; }

        public Accounts Accounts { get; set; }
        public Edata MicrPrint1E { get; set; }
        public Edata MicrPrint2E { get; set; }
        public Edata MicrPrint3E { get; set; }
        public Edata MicrRoutingNoE { get; set; }
        public Edata RoutingAE { get; set; }
        public Edata RoutingBE { get; set; }
        public Edata RoutingCE { get; set; }
    }
}
