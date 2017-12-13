using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoutingNotification
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public int RouteGroupId { get; set; }
        public int ReDocumentTypeId { get; set; }
        public int? ReDocumentRowId { get; set; }
        public int? RevisionId { get; set; }
        public DateTime DateCreated { get; set; }
        public string FromUserNo { get; set; }
        public string ToUserNo { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Outcome { get; set; }

        public Users FromUserNoNavigation { get; set; }
        public RecordType ReDocumentType { get; set; }
        public Users ToUserNoNavigation { get; set; }
    }
}
