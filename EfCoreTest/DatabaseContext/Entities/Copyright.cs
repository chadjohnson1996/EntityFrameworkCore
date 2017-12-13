using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Copyright
    {
        public int CopyrightId { get; set; }
        public string IsvName { get; set; }
        public string Message { get; set; }
    }
}
