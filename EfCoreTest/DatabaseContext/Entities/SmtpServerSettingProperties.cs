using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SmtpServerSettingProperties
    {
        public int Id { get; set; }
        public string Parm { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Domain { get; set; }
    }
}
