using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class NextNumber
    {
        public int CompanyNo { get; set; }
        public string TableNameNo { get; set; }
        public int NextTrx { get; set; }
        public string Modified { get; set; }
        public string Description { get; set; }
        public string Enabled { get; set; }
        public string NumberType { get; set; }
    }
}
