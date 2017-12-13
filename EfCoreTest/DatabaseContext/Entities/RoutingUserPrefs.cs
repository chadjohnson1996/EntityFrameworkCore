using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingUserPrefs
    {
        public RoutingUserPrefs()
        {
            RoutingUserPrefsApInvoice = new HashSet<RoutingUserPrefsApInvoice>();
            RoutingUserPrefsDocSearchCriteria = new HashSet<RoutingUserPrefsDocSearchCriteria>();
            RoutingUserPrefsLayout = new HashSet<RoutingUserPrefsLayout>();
        }

        public int Id { get; set; }
        public string UserNo { get; set; }
        public string PdfViewer { get; set; }
        public int? SavedCriteriaId { get; set; }
        public string EmailHost { get; set; }
        public int? EmailPort { get; set; }
        public string EmailReplyToAddress { get; set; }
        public string EmailLoginName { get; set; }
        public string EmailPassword { get; set; }
        public string EmailAuthentication { get; set; }
        public string EmailEncryption { get; set; }

        public RoutingUserPrefsDocSearchCriteria SavedCriteria { get; set; }
        public Users UserNoNavigation { get; set; }
        public ICollection<RoutingUserPrefsApInvoice> RoutingUserPrefsApInvoice { get; set; }
        public ICollection<RoutingUserPrefsDocSearchCriteria> RoutingUserPrefsDocSearchCriteria { get; set; }
        public ICollection<RoutingUserPrefsLayout> RoutingUserPrefsLayout { get; set; }
    }
}
