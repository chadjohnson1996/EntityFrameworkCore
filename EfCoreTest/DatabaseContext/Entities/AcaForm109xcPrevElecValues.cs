using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaForm109xcPrevElecValues
    {
        public int CompanyNo { get; set; }
        public int ElecTransNum { get; set; }
        public int AcaFormYear { get; set; }
        public string Print1095c { get; set; }
        public string Corrected1095c { get; set; }
        public string Void1095c { get; set; }
        public string Print1094c { get; set; }
        public string Corrected1094c { get; set; }
        public string AuthoritativeTrans1094c { get; set; }
        public string CreateElectronicFile { get; set; }
        public string NameControl { get; set; }
        public string TransmitterControlCode { get; set; }
        public string FileLocation { get; set; }
        public string CompanyName { get; set; }
        public string CompanyName2 { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddress2 { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyState { get; set; }
        public string CompanyZipCode { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyFein { get; set; }
        public string SsnShowOnlyLastFour { get; set; }
        public int? TotalNum1095cSubmitted { get; set; }
        public int? TotalNum1095cFiled { get; set; }
        public string MemberAggregatedAleGroup { get; set; }
        public string CertQualOfferMethod { get; set; }
        public string CertQualOfferTransRelief { get; set; }
        public string Cert4980hTransRelief { get; set; }
        public string Cert98PctOfferMethod { get; set; }
        public string PlanStartMonth { get; set; }
        public string CompanyContactFirstName { get; set; }
        public string CompanyContactMiddleInitial { get; set; }
        public string CompanyContactLastName { get; set; }
        public string CompanyContactSuffix { get; set; }
        public string CompanyContact1094cFirstName { get; set; }
        public string CompanyContact1094cMiddleInitial { get; set; }
        public string CompanyContact1094cLastName { get; set; }
        public string CompanyContact1094cSuffix { get; set; }
        public string CompanyPhoneNumber1094c { get; set; }
        public string TestScenarioInd { get; set; }
        public string TestScenarioCode { get; set; }
        public string TransmissionType { get; set; }
        public int? OrigElecTransNum { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string SortOption { get; set; }
        public string PrintAddrPage { get; set; }
        public decimal AdjCmpAddrLeftRight { get; set; }
        public decimal AdjCmpAddrUpDown { get; set; }
        public decimal AdjEmpAddrLeftRight { get; set; }
        public decimal AdjEmpAddrUpDown { get; set; }
        public string CollatePages { get; set; }

        public AcaForm109xcPrevElecTrans AcaForm109xcPrevElecTrans { get; set; }
    }
}
