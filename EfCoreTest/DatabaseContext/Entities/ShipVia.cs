using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ShipVia
    {
        public ShipVia()
        {
            Customers = new HashSet<Customers>();
            Jobs = new HashSet<Jobs>();
            PoSubChangeH = new HashSet<PoSubChangeH>();
            PoSubH = new HashSet<PoSubH>();
            ShipTo = new HashSet<ShipTo>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
        }

        public int CompanyNo { get; set; }
        public string ShipViaNo { get; set; }
        public string Description { get; set; }
        public string CustomerPaysFreight { get; set; }
        public decimal? GlFreight { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ShipViaId { get; set; }
        public string CompanyId { get; set; }

        public Accounts Accounts { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<PoSubChangeH> PoSubChangeH { get; set; }
        public ICollection<PoSubH> PoSubH { get; set; }
        public ICollection<ShipTo> ShipTo { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
    }
}
