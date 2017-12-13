﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BinLocations
    {
        public BinLocations()
        {
            Items = new HashSet<Items>();
        }

        public int CompanyNo { get; set; }
        public string BinLocationNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BinLocationId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<Items> Items { get; set; }
    }
}