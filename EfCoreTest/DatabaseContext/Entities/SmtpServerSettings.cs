using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SmtpServerSettings
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string Parm { get; set; }
        public string Value { get; set; }
        public string Advanced { get; set; }

        public SmtpServers Server { get; set; }
    }
}
