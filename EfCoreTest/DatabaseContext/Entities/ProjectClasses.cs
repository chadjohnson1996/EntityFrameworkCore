﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ProjectClasses
    {
        public ProjectClasses()
        {
            Jobs = new HashSet<Jobs>();
        }

        public int CompanyNo { get; set; }
        public string ProjectClassNo { get; set; }
        public string Description { get; set; }
        public string PcForceAmounts { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ProjectClassId { get; set; }

        public ICollection<Jobs> Jobs { get; set; }
    }
}