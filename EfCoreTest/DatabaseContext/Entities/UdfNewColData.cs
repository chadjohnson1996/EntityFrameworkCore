using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UdfNewColData
    {
        public int CompanyNo { get; set; }
        public int TableNumber { get; set; }
        public int NewColSeq { get; set; }
        public int RowUniqueId { get; set; }
        public string NewColValue { get; set; }
        public string CompanyId { get; set; }

        public UdfTableMaster TableNumberNavigation { get; set; }
    }
}
