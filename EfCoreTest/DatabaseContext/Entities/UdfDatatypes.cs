using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UdfDatatypes
    {
        public UdfDatatypes()
        {
            UdfNewColMap = new HashSet<UdfNewColMap>();
        }

        public string DataType { get; set; }
        public string Description { get; set; }
        public string FormatString { get; set; }
        public string ValidationMssg { get; set; }

        public ICollection<UdfNewColMap> UdfNewColMap { get; set; }
    }
}
