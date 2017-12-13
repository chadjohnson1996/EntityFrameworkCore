using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlPm
    {
        public int CompanyNo { get; set; }
        public string DefaultContactMethod { get; set; }
        public string DefaultMiscDocTypeNo { get; set; }
        public string DefaultMeetingTypeNo { get; set; }
        public DateTime? DefaultMeetingStartTime { get; set; }
        public DateTime? DefaultMeetingEndTime { get; set; }
        public string DefaultPrintDetailFlag { get; set; }
        public string VerifyJcAmtsWithRfcAmts { get; set; }
        public string AddVendorContact { get; set; }
        public string AddCustomerContact { get; set; }
        public string DefaultTransPrintSendingLbl1 { get; set; }
        public string DefaultTransPrintSendingLbl2 { get; set; }
        public string DefaultTransPrintSendingLbl3 { get; set; }
        public string DefaultTransPrintSendingLbl4 { get; set; }
        public string DefaultTransPrintSendingLbl5 { get; set; }
        public string DefaultTransPrintSendingLbl6 { get; set; }
        public string DefaultTransPrintSendingLbl7 { get; set; }
        public string DefaultTransPrintSendingLbl8 { get; set; }
        public string DefaultTransPrintSendingLbl9 { get; set; }
        public string DefaultTransPrintSendingLbl10 { get; set; }
        public string DefaultTransPrintSendingLbl11 { get; set; }
        public string DefaultTransPrintSendingLbl12 { get; set; }
        public string DefaultTransPrintSendingLbl13 { get; set; }
        public string DefaultTransPrintSendingLbl14 { get; set; }
        public string DefaultTransPrintSendingLbl15 { get; set; }
        public string DefaultTransPrintSendingLbl16 { get; set; }
        public string DefaultTransSubmittedForLbl1 { get; set; }
        public string DefaultTransSubmittedForLbl2 { get; set; }
        public string DefaultTransActionRequiredLbl1 { get; set; }
        public string DefaultTransActionRequiredLbl2 { get; set; }
        public int? DefaultRfcWpDesignNo { get; set; }
        public int? DefaultRfiWpDesignNo { get; set; }
        public int? DefaultRfpWpDesignNo { get; set; }
        public int? DefaultSubmittalWpDesignNo { get; set; }
        public int? DefaultTransmittalWpDesignNo { get; set; }
        public int? DefaultMiscDocWpDesignNo { get; set; }
        public string WarnEmptyDesignNoFlag { get; set; }
        public string GeneratedPdfAttachmentsFolder { get; set; }
        public string FromAddress { get; set; }
        public string SmtpHostname { get; set; }
        public int? SmtpPort { get; set; }
        public string DefaultEmailRecipients { get; set; }
        public string SmtpAuthentication { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpConnectionVerified { get; set; }
        public string SenderAsRecipientFlag { get; set; }
        public string SenderAsRecipientType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DefaultMeetingTypeId { get; set; }
        public string DefaultMiscDocTypeId { get; set; }
        public string DefaultMiscDocWpDesignId { get; set; }
        public string DefaultRfcWpDesignId { get; set; }
        public string DefaultRfiWpDesignId { get; set; }
        public string DefaultRfpWpDesignId { get; set; }
        public string DefaultSubmittalWpDesignId { get; set; }
        public string DefaultTransmittalWpDesignId { get; set; }
        public string DefaultCmContactNo { get; set; }
        public string EnableFldLogEqSavePost { get; set; }
        public string EnableFldLogInSavePost { get; set; }
        public string RptImageTopLeft { get; set; }
        public string RptImageBannerPort { get; set; }
        public string RptImageBannerLand { get; set; }
        public string RptImageFitWidth { get; set; }
        public int RptImageScale { get; set; }
        public string EnableFldLogLaborToTimecard { get; set; }
        public string DefaultJobCenterJobInfoExpanded { get; set; }
        public string RptImageToggleDefault { get; set; }
        public string RptImagePosition { get; set; }
        public string DefaultCmContactId { get; set; }
        public string JobContactsDropdownFilter { get; set; }
        public string PromptRfcCreateLinkJcCo { get; set; }
        public string DefaultShowRecentMeetingMinutes { get; set; }
        public string SeqCmContactLocation { get; set; }
        public string DefaultPoCoStatusOpen { get; set; }
        public string DefaultPoCoStatusClosed { get; set; }
        public string DefaultPoCoStatusPending { get; set; }
        public string DefaultPoCoStatusCanceled { get; set; }
        public string AllowBidTracking { get; set; }
        public string BidPrefix { get; set; }
        public string DefaultJobNoOption { get; set; }
        public string DefaultBidStatusNo { get; set; }
        public string DefaultBidStatusId { get; set; }

        public BidStatuses BidStatuses { get; set; }
        public CmContacts DefaultCmContactNoNavigation { get; set; }
        public DocTypes DocTypes { get; set; }
        public MeetingTypes MeetingTypes { get; set; }
    }
}
