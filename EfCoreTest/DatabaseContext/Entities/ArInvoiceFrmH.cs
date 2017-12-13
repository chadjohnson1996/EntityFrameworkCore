using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArInvoiceFrmH
    {
        public ArInvoiceFrmH()
        {
            ArInvoiceFrmD = new HashSet<ArInvoiceFrmD>();
            ArInvoiceFrmHUdf = new HashSet<ArInvoiceFrmHUdf>();
        }

        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public string CustomerOrderNo { get; set; }
        public string CustomerJobNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AttentionOf { get; set; }
        public string TermsNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public string Comment { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerContact { get; set; }
        public string ShipVia { get; set; }
        public string PrintedFlag { get; set; }
        public decimal? OriginalContract { get; set; }
        public decimal? ChangeOrders { get; set; }
        public decimal? ContractAmount { get; set; }
        public decimal? PercentComplete { get; set; }
        public decimal? IncomeEarned { get; set; }
        public decimal? RetainageEarned { get; set; }
        public decimal? PreviousInvoice { get; set; }
        public decimal? PreviousRetainage { get; set; }
        public decimal? CurrentInvoiceDue { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string TermsDescription { get; set; }
        public string CustomerJobContact { get; set; }
        public string CompanyId { get; set; }
        public string CustomerJobId { get; set; }
        public string CustomerOrderId { get; set; }
        public string InvoiceId { get; set; }
        public string TermsId { get; set; }
        public string JobCountry { get; set; }
        public string SdDescriptionOfRepair { get; set; }
        public string SdNotes { get; set; }
        public string SdWorkRequested { get; set; }

        public ArInvoice ArInvoice { get; set; }
        public ICollection<ArInvoiceFrmD> ArInvoiceFrmD { get; set; }
        public ICollection<ArInvoiceFrmHUdf> ArInvoiceFrmHUdf { get; set; }
    }
}
