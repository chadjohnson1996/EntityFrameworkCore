using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ApShipTo
    {
        public ApShipTo()
        {
            PoSubChangeH = new HashSet<PoSubChangeH>();
            PoSubH = new HashSet<PoSubH>();
            Vendors = new HashSet<Vendors>();
        }

        public int CompanyNo { get; set; }
        public string VendorNo { get; set; }
        public string ShipToNo { get; set; }
        public string Name { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TaxNo { get; set; }
        public string ShipViaNo { get; set; }
        public string WarehouseNo { get; set; }
        public string Phone { get; set; }
        public string TaxPrNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TermsNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ShipToId { get; set; }
        public string CompanyId { get; set; }
        public string VendorId { get; set; }
        public string TermsId { get; set; }
        public string TaxPrId { get; set; }
        public string TaxId { get; set; }
        public string ShipViaId { get; set; }
        public string WarehouseId { get; set; }
        public string PostalCodeFlag { get; set; }
        public string ForeignPostalCode { get; set; }
        public string Country { get; set; }

        public SalesTaxes SalesTaxes { get; set; }
        public Warehouses Warehouses { get; set; }
        public ICollection<PoSubChangeH> PoSubChangeH { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<Vendors> Vendors { get; set; }
    }
}
