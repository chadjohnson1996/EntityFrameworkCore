using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingRecipientSettings
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string MainEmailAddress { get; set; }
        public string AlternateEmailAddress1 { get; set; }
        public string AlternateEmailAddress2 { get; set; }

        public Users UserNoNavigation { get; set; }
    }
}
