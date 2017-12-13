using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ShipTo
    {
        public ShipTo()
        {
            Customers = new HashSet<Customers>();
        }

        public int CompanyNo { get; set; }
        public string CustomerNo { get; set; }
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
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CompanyId { get; set; }
        public string CustomerId { get; set; }
        public string ShipToId { get; set; }
        public string ShipViaId { get; set; }
        public string TaxId { get; set; }
        public string TaxPrId { get; set; }
        public string WarehouseId { get; set; }
        public string Country { get; set; }
        public string ShipToForeignFlag { get; set; }

        public SalesTaxes SalesTaxes { get; set; }
        public ShipVia ShipVia { get; set; }
        public TaxGroups TaxGroups { get; set; }
        public Warehouses Warehouses { get; set; }
        public ICollection<Customers> Customers { get; set; }
    }
}
