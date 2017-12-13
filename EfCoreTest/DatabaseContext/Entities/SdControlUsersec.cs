using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdControlUsersec
    {
        public string Company { get; set; }
        public string UserNo { get; set; }
        public string SecFlag { get; set; }
        public string InvoiceFlag { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string TmBillFlag { get; set; }
        public string PostPayments { get; set; }
        public string CreateCustomer { get; set; }
        public string UpdateInventory { get; set; }
        public string DeleteAuth { get; set; }
        public string EditAuth { get; set; }
    }
}
