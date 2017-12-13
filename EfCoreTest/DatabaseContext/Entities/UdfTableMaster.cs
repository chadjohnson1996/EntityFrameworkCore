using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UdfTableMaster
    {
        public UdfTableMaster()
        {
            UdfNewColData = new HashSet<UdfNewColData>();
            UdfNewColMap = new HashSet<UdfNewColMap>();
        }

        public int TableNumber { get; set; }
        public string TableName { get; set; }
        public string TableDescription { get; set; }

        public ICollection<UdfNewColData> UdfNewColData { get; set; }
        public ICollection<UdfNewColMap> UdfNewColMap { get; set; }
    }
}
