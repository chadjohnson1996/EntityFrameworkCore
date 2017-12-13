using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ArInvoiceFrmDUdf
    {
        public int CompanyNo { get; set; }
        public string InvoiceSource { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string UdfNo { get; set; }
        public string Datatype { get; set; }
        public string Value { get; set; }

        public ArInvoiceFrmD ArInvoiceFrmD { get; set; }
    }
}
