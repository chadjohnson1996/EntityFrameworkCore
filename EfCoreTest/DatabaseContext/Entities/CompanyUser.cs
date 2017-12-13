using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUser
    {
        public CompanyUser()
        {
            CompanyUserProjMgr = new HashSet<CompanyUserProjMgr>();
            CompanyUserQuickLinkCategories = new HashSet<CompanyUserQuickLinkCategories>();
            CompanyUserQuickLinks = new HashSet<CompanyUserQuickLinks>();
            CompanyUserRows = new HashSet<CompanyUserRows>();
            CompanyUserSecurity = new HashSet<CompanyUserSecurity>();
            CustomItemCompanyUserRestrictions = new HashSet<CustomItemCompanyUserRestrictions>();
            DropdownSettings = new HashSet<DropdownSettings>();
            MobileDeviceEmployees = new HashSet<MobileDeviceEmployees>();
            MobileDeviceEquipment = new HashSet<MobileDeviceEquipment>();
            MobileDeviceJobs = new HashSet<MobileDeviceJobs>();
            UserAccessPeriods = new HashSet<UserAccessPeriods>();
            WindowSettings = new HashSet<WindowSettings>();
        }

        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string Secured { get; set; }
        public string JobAccess { get; set; }
        public string PayrollAccess { get; set; }
        public string PayPeriod { get; set; }
        public string PayPeriodNo { get; set; }
        public string ProjectManagerSecurity { get; set; }
        public string PayRateSecurity { get; set; }
        public string ReportPhaseSecurity { get; set; }
        public string DefaultFileFolder { get; set; }
        public string ApFileFolder { get; set; }
        public string ArFileFolder { get; set; }
        public string GlFileFolder { get; set; }
        public string JcFileFolder { get; set; }
        public string PrFileFolder { get; set; }
        public string PsFileFolder { get; set; }
        public string EqFileFolder { get; set; }
        public string FaFileFolder { get; set; }
        public string InFileFolder { get; set; }
        public string TmFileFolder { get; set; }
        public string UpFileFolder { get; set; }
        public string ReportViewOption { get; set; }
        public string AllowNameOverride { get; set; }
        public string AllowDateOverride { get; set; }
        public string CreateModuleSubfolders { get; set; }
        public int RowUniqueId { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public string RecordStatus { get; set; }
        public string CompanyId { get; set; }
        public string PayPeriodId { get; set; }
        public string UserId { get; set; }
        public int? DefaultQuickLinksCategoryId { get; set; }
        public string SelectFileType { get; set; }
        public string SdFileFolder { get; set; }
        public string PrintPostedPrompt { get; set; }
        public string MobileDevice { get; set; }
        public string MobileDeviceStatus { get; set; }
        public string MobileDeviceId { get; set; }
        public string MdAllowAllJobs { get; set; }
        public string MdAllowAllEmployees { get; set; }
        public string PrCorrectInstruct { get; set; }
        public string EnforceRoutingRules { get; set; }
        public string MdAllowAllEquipment { get; set; }
        public string AllowCustomLayouts { get; set; }
        public string MdPmApproval { get; set; }
        public string PdfPrintOption { get; set; }
        public string AllowPostEqUsage { get; set; }
        public string AllowPostInReceipts { get; set; }
        public string ProtectPoStatus { get; set; }
        public string SdDispatchboardSave { get; set; }
        public string AccessToken { get; set; }
        public long? BoardLineColor { get; set; }
        public string ShowEncryptionAddUserDialog { get; set; }
        public string AllowMicr { get; set; }
        public string AccessTokenPending { get; set; }
        public string UseProcessorDefaults { get; set; }
        public string AllowPostAp { get; set; }
        public string AllowPostAr { get; set; }
        public string LastUsedFolder { get; set; }

        public Companies CompanyNoNavigation { get; set; }
        public CompanyUserQuickLinkCategories DefaultQuickLinksCategory { get; set; }
        public Users UserNoNavigation { get; set; }
        public CompanyUserLytSettings CompanyUserLytSettings { get; set; }
        public ControlNotesUser ControlNotesUser { get; set; }
        public ControlPmUser ControlPmUser { get; set; }
        public ICollection<CompanyUserProjMgr> CompanyUserProjMgr { get; set; }
        public ICollection<CompanyUserQuickLinkCategories> CompanyUserQuickLinkCategories { get; set; }
        public ICollection<CompanyUserQuickLinks> CompanyUserQuickLinks { get; set; }
        public ICollection<CompanyUserRows> CompanyUserRows { get; set; }
        public ICollection<CompanyUserSecurity> CompanyUserSecurity { get; set; }
        public ICollection<CustomItemCompanyUserRestrictions> CustomItemCompanyUserRestrictions { get; set; }
        public ICollection<DropdownSettings> DropdownSettings { get; set; }
        public ICollection<MobileDeviceEmployees> MobileDeviceEmployees { get; set; }
        public ICollection<MobileDeviceEquipment> MobileDeviceEquipment { get; set; }
        public ICollection<MobileDeviceJobs> MobileDeviceJobs { get; set; }
        public ICollection<UserAccessPeriods> UserAccessPeriods { get; set; }
        public ICollection<WindowSettings> WindowSettings { get; set; }
    }
}
