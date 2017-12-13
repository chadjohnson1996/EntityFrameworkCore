﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Status
    {
        public string StatusNo { get; set; }
        public string Description { get; set; }
        public int CompanyNo { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public string RecordStatus { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string StatusId { get; set; }
    }
}