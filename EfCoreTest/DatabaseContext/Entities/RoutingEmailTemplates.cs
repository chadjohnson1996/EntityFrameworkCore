using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingEmailTemplates
    {
        public RoutingEmailTemplates()
        {
            ControlDiDefaultApprovedEmailTemplate = new HashSet<ControlDi>();
            ControlDiDefaultPendingEmailTemplate = new HashSet<ControlDi>();
            ControlDiDefaultRejectedEmailTemplate = new HashSet<ControlDi>();
            ControlDiDefaultRevisedEmailTemplate = new HashSet<ControlDi>();
        }

        public int Id { get; set; }
        public string TemplateType { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string IncludeAttachments { get; set; }

        public ICollection<ControlDi> ControlDiDefaultApprovedEmailTemplate { get; set; }
        public ICollection<ControlDi> ControlDiDefaultPendingEmailTemplate { get; set; }
        public ICollection<ControlDi> ControlDiDefaultRejectedEmailTemplate { get; set; }
        public ICollection<ControlDi> ControlDiDefaultRevisedEmailTemplate { get; set; }
    }
}
