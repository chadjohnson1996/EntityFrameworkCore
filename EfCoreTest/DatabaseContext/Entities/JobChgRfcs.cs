﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobChgRfcs
    {
        public int CompanyNo { get; set; }
        public string ChangeOrderNo { get; set; }
        public int ChangeOrderSeq { get; set; }
        public string JobNo { get; set; }
        public string RfcNo { get; set; }
        public int LineNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string ChangeOrderId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string RfcId { get; set; }

        public JobChg JobChg { get; set; }
        public Rfcs Rfcs { get; set; }
    }
}