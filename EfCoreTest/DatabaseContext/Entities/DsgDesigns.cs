using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DsgDesigns
    {
        public DsgDesigns()
        {
            ArInvoice = new HashSet<ArInvoice>();
            ControlTm = new HashSet<ControlTm>();
            Customers = new HashSet<Customers>();
            DsgDesigners = new HashSet<DsgDesigners>();
            Jobs = new HashSet<Jobs>();
            TmInvoiceH = new HashSet<TmInvoiceH>();
            TmWorksheetH = new HashSet<TmWorksheetH>();
        }

        public int DesignNo { get; set; }
        public string DesignType { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public string DefaultDesign { get; set; }
        public string Flag1 { get; set; }
        public string Flag2 { get; set; }
        public string Flag3 { get; set; }
        public int Version { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DesignId { get; set; }
        public string DispatchFlag { get; set; }
        public int ApwvrPtlPg { get; set; }
        public int ApwvrFnlPg { get; set; }
        public string ApwvrAddPgType { get; set; }

        public ICollection<ArInvoice> ArInvoice { get; set; }
        public ICollection<ControlTm> ControlTm { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<DsgDesigners> DsgDesigners { get; set; }
        public ICollection<Jobs> Jobs { get; set; }
        public ICollection<TmInvoiceH> TmInvoiceH { get; set; }
        public ICollection<TmWorksheetH> TmWorksheetH { get; set; }
    }
}
