using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlDi
    {
        public int CompanyNo { get; set; }
        public string BatchUserSpecific { get; set; }
        public string AutoDeleteBatch { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string ApplyApInvoiceMntSecurity { get; set; }
        public string ApplyJobMntSecurity { get; set; }
        public string ApplyVendorMntSecurity { get; set; }
        public string ApplyPoSubMntSecurity { get; set; }
        public string ApplyEquipmentMntSecurity { get; set; }
        public string ApplyJcCoMntSecurity { get; set; }
        public string ApplyCustomerMntSecurity { get; set; }
        public string ApplyEmployeeMntSecurity { get; set; }
        public string ApplyDcRfcMntSecurity { get; set; }
        public string ApplyDcRfiMntSecurity { get; set; }
        public string ApplyDcRfpMntSecurity { get; set; }
        public string ApplyDcSubmittalMntSecurity { get; set; }
        public string ApplyDcTransmittalMntSecurity { get; set; }
        public string ApplyDcMiscDocMntSecurity { get; set; }
        public string ApplyDcFieldLogMntSecurity { get; set; }
        public string ApplyDcMeetingAgendaMntSecurity { get; set; }
        public string ApplyDcPunchListMntSecurity { get; set; }
        public string ApplyDcDailySecurity { get; set; }
        public string ApplyDcJobCenterSecurity { get; set; }
        public string ApplyPmSecurity { get; set; }
        public string AlwaysRouteToOrigUserOnReviseReject { get; set; }
        public int DefaultPendingEmailTemplateId { get; set; }
        public int DefaultApprovedEmailTemplateId { get; set; }
        public int DefaultRevisedEmailTemplateId { get; set; }
        public int DefaultRejectedEmailTemplateId { get; set; }
        public string ApplyArInvoiceSecurity { get; set; }
        public string ApplySdDispatchSecurity { get; set; }
        public string ApplySdSiteSecurity { get; set; }
        public string ApplyInventoryReceiptSecurity { get; set; }
        public string AutoApproveRevisedRoute { get; set; }

        public RoutingEmailTemplates DefaultApprovedEmailTemplate { get; set; }
        public RoutingEmailTemplates DefaultPendingEmailTemplate { get; set; }
        public RoutingEmailTemplates DefaultRejectedEmailTemplate { get; set; }
        public RoutingEmailTemplates DefaultRevisedEmailTemplate { get; set; }
    }
}
