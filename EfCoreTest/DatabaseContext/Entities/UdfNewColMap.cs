using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UdfNewColMap
    {
        public UdfNewColMap()
        {
            UdfPicklistItems = new HashSet<UdfPicklistItems>();
        }

        public int TableNumber { get; set; }
        public decimal NewColSeq { get; set; }
        public string NewColName { get; set; }
        public short NewColSize { get; set; }
        public string NewColType { get; set; }
        public int? NewColDecimals { get; set; }
        public int OrdinalPosition { get; set; }

        public UdfDatatypes NewColTypeNavigation { get; set; }
        public UdfTableMaster TableNumberNavigation { get; set; }
        public ICollection<UdfPicklistItems> UdfPicklistItems { get; set; }
    }
}
