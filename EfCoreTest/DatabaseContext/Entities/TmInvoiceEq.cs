﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TmInvoiceEq
    {
        public int CompanyNo { get; set; }
        public string InvoiceNo { get; set; }
        public int LineNo { get; set; }
        public string PostedFlag { get; set; }
        public string EquipmentNo { get; set; }
        public decimal InvoiceAmount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string InvoiceId { get; set; }
        public string LineId { get; set; }
        public string EquipmentId { get; set; }

        public Equipment Equipment { get; set; }
        public TmInvoiceH TmInvoiceH { get; set; }
    }
}
