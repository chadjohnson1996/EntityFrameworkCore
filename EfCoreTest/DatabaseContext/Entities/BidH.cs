using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BidH
    {
        public BidH()
        {
            BidD = new HashSet<BidD>();
            BidDivisions = new HashSet<BidDivisions>();
            EstimatD = new HashSet<EstimatD>();
            EstimatH = new HashSet<EstimatH>();
            QtyPaidJournalD = new HashSet<QtyPaidJournalD>();
            QtyPaidJournalH = new HashSet<QtyPaidJournalH>();
            QuantityUpdateD = new HashSet<QuantityUpdateD>();
            QuantityUpdateH = new HashSet<QuantityUpdateH>();
        }

        public int CompanyNo { get; set; }
        public string BidNo { get; set; }
        public string JobNo { get; set; }
        public string AgencyNo { get; set; }
        public string CustomerNo { get; set; }
        public string BidderReference { get; set; }
        public string ProjectReference { get; set; }
        public string ContractReference { get; set; }
        public string FederalId { get; set; }
        public string CountyPrNo { get; set; }
        public string BidStatus { get; set; }
        public DateTime? BidDueDate { get; set; }
        public DateTime? AwardDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string AutoPostToAr { get; set; }
        public string ProjectDescription { get; set; }
        public decimal? GlIncome { get; set; }
        public decimal RetainagePercent { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AgencyId { get; set; }
        public string BidId { get; set; }
        public string CompanyId { get; set; }
        public string CountyPrId { get; set; }
        public string CustomerId { get; set; }
        public string JobId { get; set; }
        public string TrackQtyPaid { get; set; }
        public string TrackStoredMaterial { get; set; }
        public string AiaContractDescription { get; set; }
        public DateTime? AiaContractDate { get; set; }
        public string AiaViaArchitect { get; set; }
        public string ViaArchitectAddress1 { get; set; }
        public string ViaArchitectAddress2 { get; set; }
        public string ViaArchitectCity { get; set; }
        public string ViaArchitectState { get; set; }
        public string ViaArchitectZipCode { get; set; }
        public string ViaContructionManager { get; set; }
        public string StateOf { get; set; }
        public string CountyOf { get; set; }
        public string SignatureName { get; set; }
        public string SignatureTitle { get; set; }
        public string ReleaseRetFromUp { get; set; }

        public Agencies Agencies { get; set; }
        public Customers C { get; set; }
        public Counties Co { get; set; }
        public Jobs Jobs { get; set; }
        public ICollection<BidD> BidD { get; set; }
        public ICollection<BidDivisions> BidDivisions { get; set; }
        public ICollection<EstimatD> EstimatD { get; set; }
        public ICollection<EstimatH> EstimatH { get; set; }
        public ICollection<QtyPaidJournalD> QtyPaidJournalD { get; set; }
        public ICollection<QtyPaidJournalH> QtyPaidJournalH { get; set; }
        public ICollection<QuantityUpdateD> QuantityUpdateD { get; set; }
        public ICollection<QuantityUpdateH> QuantityUpdateH { get; set; }
    }
}
