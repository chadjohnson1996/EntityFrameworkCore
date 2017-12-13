﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcPriorities
    {
        public DcPriorities()
        {
            DcRfis = new HashSet<DcRfis>();
        }

        public int CompanyNo { get; set; }
        public string DcPriorityNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcPriorityId { get; set; }

        public ICollection<DcRfis> DcRfis { get; set; }
    }
}